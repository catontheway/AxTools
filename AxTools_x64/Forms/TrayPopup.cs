﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Timers;
using System.Windows.Forms;
using AxTools.Helpers;
using AxTools.WinAPI;
using Components;

namespace AxTools.Forms
{
    public partial class TrayPopup : BorderedMetroForm
    {
        private readonly System.Timers.Timer timer;
        private int startPosX;
        private int startPosY;
        private DateTime loadTime;

        public TrayPopup(string title, string message, Image image)
        {
            InitializeComponent();
            StyleManager.Style = Settings.Instance.StyleColor;
            Title = title;
            Message = message;
            Icon = image;
            timer = new System.Timers.Timer(50);
            timer.Elapsed += timer_Tick;
        }

        public string Title
        {
            get { return metroLabel1.Text; }
            set { metroLabel1.Text = value; }
        }

        public string Message
        {
            get { return metroLabel2.Text; }
            set
            {
                metroLabel2.Text = Utils.WordWrap(value, 55);
                Size = new Size(Width, Math.Max(68, metroLabel2.Location.Y + metroLabel2.Size.Height + 10)); // 68 - standart heigth
            }
        }

        public new Image Icon
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        public int Timeout { get; private set; }

        public void Show(int timeout)
        {
            Timeout = timeout;
            Show();
        }

        public new event EventHandler Click
        {
            add
            {
                base.Click += value;
                foreach (Control control in Controls)
                {
                    control.Click += value;
                }
            }
            remove
            {
                base.Click -= value;
                foreach (Control control in Controls)
                {
                    control.Click -= value;
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            IntPtr taskbarHandle = NativeMethods.FindWindow("Shell_TrayWnd", null);
            APPBARDATA data = new APPBARDATA
            {
                cbSize = (uint)Marshal.SizeOf(typeof(APPBARDATA)),
                hWnd = taskbarHandle
            };
            IntPtr result = NativeMethods.SHAppBarMessage((uint)APPBARMESSAGE.GetTaskbarPos, ref data);
            if (result == IntPtr.Zero)
            {
                throw new InvalidOperationException();
            }
            if (data.uEdge == ABE.Top)
            {
                startPosX = Screen.PrimaryScreen.WorkingArea.Width - Width;
                startPosY = 0;
            }
            else
            {
                startPosX = Screen.PrimaryScreen.WorkingArea.Width - Width;
                startPosY = Screen.PrimaryScreen.WorkingArea.Height - Height;
            }
            base.OnLoad(e);
            SetDesktopLocation(startPosX, startPosY);
            loadTime = DateTime.UtcNow;
            timer.Start();
            Timeout = Timeout == 0 ? 30 : Timeout;
            foreach (Control control in Controls)
            {
                control.MouseEnter += ALL_MouseEnter;
            }
        }

        private void timer_Tick(object sender, ElapsedEventArgs e)
        {
            if (Opacity > 0.01f)
            {
                if (DateTime.UtcNow - loadTime > TimeSpan.FromSeconds(Timeout))
                {
                    Opacity = Opacity - 0.01f;
                }
            }
            else
            {
                Close();
            }
        }

        private void ALL_MouseEnter(object sender, EventArgs e)
        {
            loadTime = DateTime.UtcNow;
            Opacity = 1.0d;
        }

    }
}
