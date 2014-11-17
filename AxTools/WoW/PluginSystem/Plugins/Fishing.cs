﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using AxTools.Classes;
using AxTools.Properties;
using AxTools.WoW.Management;
using AxTools.WoW.Management.ObjectManager;

namespace AxTools.WoW.PluginSystem.Plugins
{
    internal class Fishing : IPlugin
    {

        #region Info

        public string Name
        {
            get { return "Fishing"; }
        }

        public Version Version
        {
            get { return new Version(1, 0); }
        }

        public string Author
        {
            get { return "CasualShammy"; }
        }

        public string Description
        {
            get { return "This is a very simple fish bot. It supports Nat's Hat and Weather-Beaten Fishing Hat if equipped"; }
        }

        public Image TrayIcon { get { return Resources.trade_fishing; } }

        public int Interval
        {
            get { return 100; }
        }

        public string WowIcon
        {
            get { return "Interface\\\\Icons\\\\trade_fishing"; }
        }

        #endregion

        #region Events

        public void OnStart()
        {
            state = 0;
            bobber = null;
            iterationStartTime = Environment.TickCount;
            FishingSettings.InitializeBait(out Bait, out SpecialBait);
            lureBait = "if (not GetWeaponEnchantInfo()) then " +
                       "if (GetItemCount(\"" + Bait + "\") > 0) then UseItemByName(\"" + Bait + "\") end end";
            lureSpecialBait = "if (not UnitBuff(\"player\", \"" + SpecialBait + "\")) then " +
                              "if (GetItemCount(\"" + SpecialBait + "\") > 0) then UseItemByName(\"" + SpecialBait + "\") end end";
        }

        public void OnPulse()
        {
            if (Environment.TickCount - iterationStartTime > 25000)
            {
                state = 0;
                Log.Print(String.Format("{0}:{1} :: [{2}] Timeout has expired", WoWManager.WoWProcess.ProcessName, WoWManager.WoWProcess.ProcessID, Name));
            }
            switch (state)
            {
                case 0:
                    Log.Print(String.Format("{0}:{1} :: [{2}] Cast fishing...", WoWManager.WoWProcess.ProcessName, WoWManager.WoWProcess.ProcessID, Name));
                    WoWDXInject.LuaDoString(castFishing);
                    Thread.Sleep(1500);
                    state = 1;
                    iterationStartTime = Environment.TickCount;
                    break;
                case 1:
                    WoWPlayerMe localPlayer;
                    try
                    {
                        localPlayer = ObjectMgr.Pulse(wowObjects);
                    }
                    catch (Exception ex)
                    {
                        Log.Print(String.Format("{0}:{1} :: [Fishing] Pulse error: {2}", WoWManager.WoWProcess.ProcessName, WoWManager.WoWProcess.ProcessID, ex.Message), true);
                        break;
                    }
                    if (localPlayer.ChannelSpellID == 0)
                    {
                        Log.Print(String.Format("{0}:{1} :: [{2}] Player isn't fishing, recast...", WoWManager.WoWProcess.ProcessName, WoWManager.WoWProcess.ProcessID, Name));
                        state = 0;
                        break;
                    }
                    bobber = wowObjects.FirstOrDefault(i => i.OwnerGUID == localPlayer.GUID);
                    if (bobber != null && bobber.Bobbing) //4456449
                    {
                        Log.Print(String.Format("{0}:{1} :: [{2}] Got bit!", WoWManager.WoWProcess.ProcessName, WoWManager.WoWProcess.ProcessID, Name));
                        Thread.Sleep(250);
                        state = 2;
                    }
                    break;
                case 2:
                    if (bobber != null)
                    {
                        Log.Print(String.Format("{0}:{1} :: [{2}] Interacting...", WoWManager.WoWProcess.ProcessName, WoWManager.WoWProcess.ProcessID, Name));
                        WoWDXInject.Interact(bobber.GUID);
                        bobber = null;
                        state = 3;
                    }
                    else
                    {
                        Log.Print(String.Format("{0}:{1} :: [{2}] Bobber isn't found, recast...", WoWManager.WoWProcess.ProcessName, WoWManager.WoWProcess.ProcessID, Name));
                        state = 0;
                    }
                    break;
                case 3:
                    if (WoWManager.WoWProcess.PlayerIsLooting)
                    {
                        state = 4;
                        Log.Print(String.Format("{0}:{1} :: [{2}] Looting...", WoWManager.WoWProcess.ProcessName, WoWManager.WoWProcess.ProcessID, Name));
                    }
                    break;
                case 4:
                    if (!WoWManager.WoWProcess.PlayerIsLooting)
                    {
                        Log.Print(String.Format("{0}:{1} :: [{2}] Looted, applying lure...", WoWManager.WoWProcess.ProcessName, WoWManager.WoWProcess.ProcessID, Name));
                        WoWDXInject.LuaDoString(lure);
                        WoWDXInject.LuaDoString(lureBait);
                        WoWDXInject.LuaDoString(lureSpecialBait);
                        Thread.Sleep(500);
                        state = 0;
                    }
                    break;
            }
        }

        public void OnStop()
        {
            
        }

        #endregion

        #region Variables

        private int state;

        private readonly string lure = "if (GetInventoryItemCooldown(\"player\", 1) == 0 and not GetWeaponEnchantInfo()) then " +
                                       "if (IsEquippedItem(33820)) then UseItemByName(33820) elseif (IsEquippedItem(88710)) then UseItemByName(88710) end end";

        private readonly string castFishing = "if (not UnitAffectingCombat(\"player\")) then CastSpellByName(\"Рыбная ловля\") end";

        private WowObject bobber;

        private readonly List<WowObject> wowObjects = new List<WowObject>();

        private int iterationStartTime;

        internal string Bait = string.Empty;

        internal string SpecialBait = string.Empty;

        private string lureBait;

        private string lureSpecialBait;

        #endregion

    }
}
