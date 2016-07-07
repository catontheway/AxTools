﻿using AxTools.Forms;
using System;
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsAero.TaskDialog;
using AxTools.Forms.Helpers;
using AxTools.Helpers;
using AxTools.Properties;
using Newtonsoft.Json;

namespace AxTools
{
    internal static class Program
    {
        internal static event Action Exit;

        [STAThread]
        private static void Main()
        {
            bool newInstance;
            using (new Mutex(true, "AxToolsMainExecutable", out newInstance))
            {
                if (newInstance)
                {
                    if (Environment.OSVersion.Version >= new Version(6, 1))
                    {
                        using (WindowsIdentity p = WindowsIdentity.GetCurrent())
                        {
                            if (p != null)
                            {
                                WindowsPrincipal pricipal = new WindowsPrincipal(p);
                                if (!pricipal.IsInRole(WindowsBuiltInRole.Administrator))
                                {
                                    TaskDialog.Show("This program requires administrator privileges", "AxTools", "Make sure you have administrator privileges", TaskDialogButton.OK, TaskDialogIcon.SecurityError);
                                    return;
                                }
                            }
                        }
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        WebRequest.DefaultWebProxy = null;
                        DeleteTempFolder();
                        Legacy();
                        InstallRootCertificate();
                        Log.Info(string.Format("[AxTools] Starting application... ({0})", Globals.AppVersion));
                        Application.Run(MainForm.Instance = new MainForm());
                        Log.Info("[AxTools] Application is closed");
                        if (Exit != null)
                        {
                            Exit();
                        }
                    }
                    else
                    {
                        MessageBox.Show("This program works only on Windows 7 or higher", "AxTools", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    TaskDialog.Show("This program is already running", "AxTools", "", TaskDialogButton.OK, TaskDialogIcon.Warning);
                }
            }
        }

        private static void DeleteTempFolder()
        {
            if (Directory.Exists(AppFolders.TempDir))
            {
                try
                {
                    Directory.Delete(AppFolders.TempDir, true);
                }
                catch
                {
                    //
                }
            }
        }

        private static void Legacy()
        {
            try
            {
                // 08.10.2015
                string mySettingsDir = Globals.PluginsSettingsPath + "\\Fishing";
                string mySettingsFile = mySettingsDir + "\\FishingSettings.json";
                if (File.Exists(mySettingsFile))
                {
                    File.Move(mySettingsFile, mySettingsDir + "\\settings.json");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // 01.06.2016
            try
            {
                //"WoWRadarShowMode": 2199040098561,
                Regex regex = new Regex("\"WoWRadarShowMode\": (\\d+)");
                string cfg = File.ReadAllText(Globals.CfgPath + "\\settings.json", Encoding.UTF8);
                Match match = regex.Match(cfg);
                if (match.Success)
                {
                    ulong radarShowMode = ulong.Parse(match.Groups[1].Value);
                    byte[] p = BitConverter.GetBytes(radarShowMode);
                    RadarShowMode newRadarShowMode = new RadarShowMode
                    {
                        Friends = p[0] == 1,
                        Enemies = p[1] == 1,
                        Npcs = p[2] == 1,
                        Objects = p[3] == 1,
                        Corpses = p[4] == 1,
                        Zoom = p[5]*0.25F
                    };
                    if (newRadarShowMode.Zoom > 2F || newRadarShowMode.Zoom < 0.25F)
                    {
                        newRadarShowMode.Zoom = 0.5F;
                    }
                    string newCfg = cfg.Replace(match.Value, "\"WoWRadarShowMode\": " + JsonConvert.SerializeObject(newRadarShowMode));
                    File.WriteAllText(Globals.CfgPath + "\\settings.json", newCfg, Encoding.UTF8);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void InstallRootCertificate()
        {
            X509Certificate2 x509 = new X509Certificate2();
            x509.Import(Resources.Axio_Lab_CA);
            X509Store store = new X509Store(StoreName.Root, StoreLocation.LocalMachine);
            store.Open(OpenFlags.ReadWrite);
            if (x509.SerialNumber != null && store.Certificates.Find(X509FindType.FindBySerialNumber, x509.SerialNumber, true).Count == 0)
            {
                Log.Info("[AxTools] Certificate isn't found, installing...");
                store.Add(x509);
            }
            store.Close();
        }

    }
}
