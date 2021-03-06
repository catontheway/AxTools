﻿using AxTools.WoW.Helpers;
using AxTools.WoW.Internals;
using AxTools.WoW.PluginSystem;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;

namespace WoWPlugin_AttackFirst
{
    public class AttackFirst : IPlugin3
    {
        #region Info

        public string Name => nameof(AttackFirst);

        public Version Version => new Version(1, 0);

        public string Description => "Select mob name and this plugin will try to hit it first";

        public Image TrayIcon => null;

        public bool ConfigAvailable => false;

        public string[] Dependencies => null;

        public bool DontCloseOnWowShutdown => false;

        #endregion Info

        #region Events

        public void OnConfig()
        {
        }

        public void OnStart(GameInterface game)
        {
            this.game = game;
            timer = this.CreateTimer(50, game, OnPulse);
            timer.Start();
        }

        public void OnStop()
        {
            timer.Dispose();
        }

        private void OnPulse()
        {
            WoWPlayerMe me = game.GetGameObjects(null, null, npcs);
            if (me != null)
            {
                WowNpc npc = npcs.FirstOrDefault(l => l.Name == mobName && l.Location.Distance(me.Location) < 40);
                if (npc != null)
                {
                    this.LogPrint("Found mob -->> " + npc.GUID);
                    stopwatch.Restart();
                    //npc.Location.Face();
                    npc.Target();
                    game.CastSpellByName(spell);
                    this.LogPrint("It took " + stopwatch.ElapsedMilliseconds + "ms to hit mob");
                    //SendMessage(Utilities.WoWWindowHandle, WM_KEYDOWN, (IntPtr)keyCode, IntPtr.Zero);
                    //SendMessage(Utilities.WoWWindowHandle, WM_KEYUP, (IntPtr)keyCode, IntPtr.Zero);
                }
            }
        }

        #endregion Events

        #region Fields, propeties

        private readonly Stopwatch stopwatch = new Stopwatch();
        private readonly List<WowNpc> npcs = new List<WowNpc>();
        private SafeTimer timer;
        private readonly string mobName = "Тренировочный манекен рейдера";
        private readonly string spell = "Огненный шок";
        private readonly int keyCode = 0x73; // F4
        private GameInterface game;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

        internal const uint WM_KEYDOWN = 0x100;
        internal const uint WM_KEYUP = 0x101;

        #endregion Fields, propeties
    }
}