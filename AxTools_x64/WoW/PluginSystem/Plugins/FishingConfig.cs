﻿using System;
using System.Windows.Forms;
using AxTools.Forms;

namespace AxTools.WoW.PluginSystem.Plugins
{
    internal partial class FishingConfig : Form
    {
        public FishingConfig(FishingSettings fishingSettings)
        {
            InitializeComponent();
            FishingSettings thisSettings = fishingSettings;
            checkBoxUseAnySpecialBaitIfPreferredIsNotAvailable.Checked = thisSettings.UseAnySpecialBaitIfPreferredIsNotAvailable;
            checkBoxGetSpecialBaitFromNatPagle.Checked = thisSettings.GetSpecialBaitFromNatPagle;
        }

        internal static void Open(FishingSettings fishingSettings)
        {
            FishingConfig fishingConfig = new FishingConfig(fishingSettings)
            {
                checkBoxUseBestBait = {Checked = fishingSettings.UseBestBait},
                checkBoxUseSpecialBait = {Checked = fishingSettings.UseSpecialBait},
                comboBoxSpecialBait = {Text = fishingSettings.SpecialBait}
            };
            fishingConfig.ShowDialog(MainForm.Instance);
            fishingSettings.UseBestBait = fishingConfig.checkBoxUseBestBait.Checked;
            fishingSettings.UseSpecialBait = fishingConfig.checkBoxUseSpecialBait.Checked;
            fishingSettings.SpecialBait = fishingConfig.comboBoxSpecialBait.Text;
            fishingSettings.UseAnySpecialBaitIfPreferredIsNotAvailable = fishingConfig.checkBoxUseAnySpecialBaitIfPreferredIsNotAvailable.Checked;
            fishingSettings.GetSpecialBaitFromNatPagle = fishingConfig.checkBoxGetSpecialBaitFromNatPagle.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ReSharper disable once InconsistentNaming
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
    }
}
