﻿using AxTools.WoW.Helpers;
using AxTools.WoW.Internals;
using AxTools.WoW.PluginSystem;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AutoLoot
{
    internal class AutoLoot : IPlugin3
    {
        #region Info

        public string Name => nameof(AutoLoot);

        public Version Version => new Version(1, 0, 0, 0);

        public string Author => "Axioma";

        public string Description => "Loots mobs in 100 yd range";

        private Image trayIcon;

        public Image TrayIcon => trayIcon ?? (trayIcon = new Bitmap($"{this.GetPluginSourceFolder()}\\inv_misc_coin_01.jpg"));

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
            (timer = this.CreateTimer(250, game, OnPulse)).Start();
        }

        public void OnPulse()
        {
            WoWPlayerMe localPlayer = game.GetGameObjects(null, null, wowNpcs);
            if (localPlayer != null && localPlayer.CastingSpellID == 0 && localPlayer.ChannelSpellID == 0 && !game.IsLooting)
            {
                foreach (WowNpc npc in wowNpcs.Where(l => l.Health == 0 && l.Location.Distance2D(localPlayer.Location) < 40 && !unlootableNpcs.Contains(l.GUID)).OrderBy(l => l.Location.Distance(localPlayer.Location)))
                {
                    if (game.LuaIsTrue($"CanLootUnit('{npc.GetGameGUID()}')==true")) // game.LuaIsTrue($"select(2,CanLootUnit('{npc.GetGameGUID()}'))==true") &&
                    {
                        if (npc.Location.Distance(localPlayer.Location) > 3f)
                        {
                            game.Move2D(npc.Location, 2.5f, 1000, true, false);
                        }
                        else
                        {
                            npc.Interact();
                        }
                        break;
                    }
                    else
                    {
                        unlootableNpcs.Add(npc.GUID);
                    }
                }
            }
        }

        public void OnStop()
        {
            timer.Dispose();
        }

        #endregion Events

        private readonly List<WowNpc> wowNpcs = new List<WowNpc>();
        private readonly List<WoWGUID> unlootableNpcs = new List<WoWGUID>();
        private SafeTimer timer;
        private GameInterface game;
    }
}