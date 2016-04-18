﻿using System;
using System.Drawing;
using System.Windows.Forms;
using AxTools.WoW.Helpers;
using AxTools.WoW.Internals;
using AxTools.WoW.PluginSystem;
using AxTools.WoW.PluginSystem.API;

namespace WoWPlugin_PathCreator
{
    public class PathCreator : IPlugin
    {

        #region Info

        public string Name { get { return "PathCreator"; } }

        public Version Version { get { return new Version(1, 0); } }

        public string Description { get { return "Creates profiles for PathPlayer"; } }

        private Image trayIcon;
        public Image TrayIcon { get { return trayIcon ?? (trayIcon = Image.FromFile(string.Format("{0}\\plugins\\{1}\\Achievement_faction_lorewalkers.png", Application.StartupPath, Name))); } }

        public string WowIcon { get { return string.Empty; } }

        public bool ConfigAvailable { get { return false; } }

        #endregion

        #region Methods

        public void OnConfig()
        {

        }

        public void OnStart()
        {
            (mainForm = new MainForm(this)).Show();
            (timer = this.CreateTimer(250, OnPulse)).Start();
        }

        private void OnPulse()
        {
            WoWPlayerMe me = ObjMgr.Pulse();
            if (me != null)
            {
                mainForm.labelLocation.Text = "[" + me.Location + "]";
            }
        }

        public void OnStop()
        {
            timer.Dispose();
            mainForm.Hide();
            mainForm.Dispose();
        }

        #endregion

        private SingleThreadTimer timer;
        private MainForm mainForm;

    }
}