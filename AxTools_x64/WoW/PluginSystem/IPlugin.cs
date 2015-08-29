﻿using System;
using System.Drawing;

namespace AxTools.WoW.PluginSystem
{
    public interface IPlugin
    {
        /// <summary>
        ///     The name of the plugin
        /// </summary>
        string Name { get; }

        /// <summary>
        ///     Current version of this plugin
        /// </summary>
        Version Version { get; }

        /// <summary>
        ///     Description to display on the plugin interface
        /// </summary>
        string Description { get; }

        /// <summary>
        ///     Icon for tray context menu
        /// </summary>
        Image TrayIcon { get; }

        /// <summary>
        ///     Icon in format "Interface\\\\Icons\\\\trade_fishing"
        /// </summary>
        string WowIcon { get; }

        /// <summary>
        ///     
        /// </summary>
        bool ConfigAvailable { get; }

        /// <summary>
        ///     Work or configuration windows to display when the user presses the "config" button
        /// </summary>
        void OnConfig();

        /// <summary>
        ///     Work to be done when the plugin is loaded by the bot on startup
        /// </summary>
        void OnStart();

        /// <summary>
        ///     Work to be done when the bot is shutdown/closed
        /// </summary>
        void OnStop();

    }
}
