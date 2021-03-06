﻿using Components;
using MetroFramework.Components;
using MetroFramework.Controls;

namespace AxTools.Forms
{
    partial class AppSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.checkBox_AntiAFK = new MetroFramework.Controls.MetroCheckBox();
            this.CheckBoxStartAxToolsWithWindows = new MetroFramework.Controls.MetroCheckBox();
            this.CheckBox7 = new MetroFramework.Controls.MetroCheckBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.TextBox4 = new Components.MetroTextboxExt();
            this.TextBox5 = new Components.MetroTextboxExt();
            this.Label5 = new MetroFramework.Controls.MetroLabel();
            this.Label6 = new MetroFramework.Controls.MetroLabel();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.TextBox6 = new Components.MetroTextboxExt();
            this.TextBox7 = new Components.MetroTextboxExt();
            this.Label7 = new MetroFramework.Controls.MetroLabel();
            this.Label8 = new MetroFramework.Controls.MetroLabel();
            this.CheckBox6 = new MetroFramework.Controls.MetroCheckBox();
            this.numericUpDownBackupTimer = new System.Windows.Forms.NumericUpDown();
            this.Hours = new MetroFramework.Controls.MetroLabel();
            this.numericUpDownBackupCopiesToKeep = new System.Windows.Forms.NumericUpDown();
            this.label9 = new MetroFramework.Controls.MetroLabel();
            this.checkBoxAddonsBackup = new MetroFramework.Controls.MetroCheckBox();
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.checkBoxSendLogOnShutdown = new MetroFramework.Controls.MetroCheckBox();
            this.checkBoxMinimizeToTray = new MetroFramework.Controls.MetroCheckBox();
            this.linkSendLogToDev = new MetroFramework.Controls.MetroLink();
            this.linkShowLog = new MetroFramework.Controls.MetroLink();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxStyle = new MetroFramework.Controls.MetroComboBox();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.checkBoxClearWoWCache = new MetroFramework.Controls.MetroCheckBox();
            this.checkBoxSetAfkStatus = new MetroFramework.Controls.MetroCheckBox();
            this.buttonIngameKeyBinds = new MetroFramework.Controls.MetroButton();
            this.checkBoxPluginsUpdate = new MetroFramework.Controls.MetroCheckBox();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.checkBoxMakeBackupNotWhilePlaying = new MetroFramework.Controls.MetroCheckBox();
            this.metroComboBoxBackupCompressionLevel = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.buttonBackupPath = new MetroFramework.Controls.MetroButton();
            this.textBoxBackupPath = new Components.MetroTextboxExt();
            this.metroTabPage7 = new MetroFramework.Controls.MetroTabPage();
            this.ComboBox_server_ip = new MetroFramework.Controls.MetroComboBox();
            this.Label3 = new MetroFramework.Controls.MetroLabel();
            this.toolTip = new MetroFramework.Components.MetroToolTip();
            this.linkTitle = new MetroFramework.Controls.MetroLink();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBackupTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBackupCopiesToKeep)).BeginInit();
            this.tabControl.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.metroTabPage4.SuspendLayout();
            this.metroTabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_AntiAFK
            // 
            this.checkBox_AntiAFK.AutoSize = true;
            this.checkBox_AntiAFK.CustomBackground = false;
            this.checkBox_AntiAFK.CustomForeColor = false;
            this.checkBox_AntiAFK.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.checkBox_AntiAFK.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.checkBox_AntiAFK.Location = new System.Drawing.Point(3, 15);
            this.checkBox_AntiAFK.Name = "checkBox_AntiAFK";
            this.checkBox_AntiAFK.Size = new System.Drawing.Size(74, 19);
            this.checkBox_AntiAFK.Style = MetroFramework.MetroColorStyle.Blue;
            this.checkBox_AntiAFK.StyleManager = null;
            this.checkBox_AntiAFK.TabIndex = 16;
            this.checkBox_AntiAFK.Text = "AntiAFK";
            this.checkBox_AntiAFK.Theme = MetroFramework.MetroThemeStyle.Light;
            this.checkBox_AntiAFK.UseStyleColors = true;
            this.checkBox_AntiAFK.UseVisualStyleBackColor = true;
            // 
            // CheckBoxStartAxToolsWithWindows
            // 
            this.CheckBoxStartAxToolsWithWindows.AutoSize = true;
            this.CheckBoxStartAxToolsWithWindows.CustomBackground = false;
            this.CheckBoxStartAxToolsWithWindows.CustomForeColor = false;
            this.CheckBoxStartAxToolsWithWindows.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.CheckBoxStartAxToolsWithWindows.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.CheckBoxStartAxToolsWithWindows.Location = new System.Drawing.Point(3, 15);
            this.CheckBoxStartAxToolsWithWindows.Name = "CheckBoxStartAxToolsWithWindows";
            this.CheckBoxStartAxToolsWithWindows.Size = new System.Drawing.Size(195, 19);
            this.CheckBoxStartAxToolsWithWindows.Style = MetroFramework.MetroColorStyle.Blue;
            this.CheckBoxStartAxToolsWithWindows.StyleManager = null;
            this.CheckBoxStartAxToolsWithWindows.TabIndex = 29;
            this.CheckBoxStartAxToolsWithWindows.Text = "Start AxTools with Windows";
            this.CheckBoxStartAxToolsWithWindows.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CheckBoxStartAxToolsWithWindows.UseStyleColors = true;
            this.CheckBoxStartAxToolsWithWindows.UseVisualStyleBackColor = true;
            // 
            // CheckBox7
            // 
            this.CheckBox7.AutoSize = true;
            this.CheckBox7.CustomBackground = false;
            this.CheckBox7.CustomForeColor = false;
            this.CheckBox7.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.CheckBox7.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.CheckBox7.Location = new System.Drawing.Point(3, 182);
            this.CheckBox7.Name = "CheckBox7";
            this.CheckBox7.Size = new System.Drawing.Size(155, 19);
            this.CheckBox7.Style = MetroFramework.MetroColorStyle.Blue;
            this.CheckBox7.StyleManager = null;
            this.CheckBox7.TabIndex = 15;
            this.CheckBox7.Text = "Hide window borders";
            this.CheckBox7.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CheckBox7.UseStyleColors = true;
            this.CheckBox7.UseVisualStyleBackColor = true;
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox2.Controls.Add(this.TextBox4);
            this.GroupBox2.Controls.Add(this.TextBox5);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Location = new System.Drawing.Point(292, 157);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(120, 80);
            this.GroupBox2.TabIndex = 13;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Window position";
            // 
            // TextBox4
            // 
            this.TextBox4.CustomBackground = false;
            this.TextBox4.CustomForeColor = false;
            this.TextBox4.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.TextBox4.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.TextBox4.Location = new System.Drawing.Point(31, 51);
            this.TextBox4.Multiline = false;
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.ReadOnly = false;
            this.TextBox4.SelectedText = "";
            this.TextBox4.Size = new System.Drawing.Size(58, 20);
            this.TextBox4.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox4.StyleManager = null;
            this.TextBox4.TabIndex = 5;
            this.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox4.UseStyleColors = true;
            // 
            // TextBox5
            // 
            this.TextBox5.CustomBackground = false;
            this.TextBox5.CustomForeColor = false;
            this.TextBox5.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.TextBox5.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.TextBox5.Location = new System.Drawing.Point(31, 25);
            this.TextBox5.Multiline = false;
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.ReadOnly = false;
            this.TextBox5.SelectedText = "";
            this.TextBox5.Size = new System.Drawing.Size(58, 20);
            this.TextBox5.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox5.StyleManager = null;
            this.TextBox5.TabIndex = 4;
            this.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox5.UseStyleColors = true;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.CustomBackground = false;
            this.Label5.CustomForeColor = false;
            this.Label5.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.Label5.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.Label5.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.Label5.Location = new System.Drawing.Point(8, 25);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(20, 19);
            this.Label5.Style = MetroFramework.MetroColorStyle.Blue;
            this.Label5.StyleManager = null;
            this.Label5.TabIndex = 2;
            this.Label5.Text = "X:";
            this.Label5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Label5.UseStyleColors = true;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.CustomBackground = false;
            this.Label6.CustomForeColor = false;
            this.Label6.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.Label6.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.Label6.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.Label6.Location = new System.Drawing.Point(8, 51);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(20, 19);
            this.Label6.Style = MetroFramework.MetroColorStyle.Blue;
            this.Label6.StyleManager = null;
            this.Label6.TabIndex = 3;
            this.Label6.Text = "Y:";
            this.Label6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Label6.UseStyleColors = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.TextBox6);
            this.GroupBox1.Controls.Add(this.TextBox7);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Location = new System.Drawing.Point(166, 157);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(120, 80);
            this.GroupBox1.TabIndex = 12;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Window size";
            // 
            // TextBox6
            // 
            this.TextBox6.CustomBackground = false;
            this.TextBox6.CustomForeColor = false;
            this.TextBox6.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.TextBox6.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.TextBox6.Location = new System.Drawing.Point(31, 51);
            this.TextBox6.Multiline = false;
            this.TextBox6.Name = "TextBox6";
            this.TextBox6.ReadOnly = false;
            this.TextBox6.SelectedText = "";
            this.TextBox6.Size = new System.Drawing.Size(58, 20);
            this.TextBox6.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox6.StyleManager = null;
            this.TextBox6.TabIndex = 5;
            this.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox6.UseStyleColors = true;
            // 
            // TextBox7
            // 
            this.TextBox7.CustomBackground = false;
            this.TextBox7.CustomForeColor = false;
            this.TextBox7.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.TextBox7.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.TextBox7.Location = new System.Drawing.Point(31, 25);
            this.TextBox7.Multiline = false;
            this.TextBox7.Name = "TextBox7";
            this.TextBox7.ReadOnly = false;
            this.TextBox7.SelectedText = "";
            this.TextBox7.Size = new System.Drawing.Size(58, 20);
            this.TextBox7.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox7.StyleManager = null;
            this.TextBox7.TabIndex = 4;
            this.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox7.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox7.UseStyleColors = true;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.CustomBackground = false;
            this.Label7.CustomForeColor = false;
            this.Label7.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.Label7.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.Label7.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.Label7.Location = new System.Drawing.Point(8, 25);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(20, 19);
            this.Label7.Style = MetroFramework.MetroColorStyle.Blue;
            this.Label7.StyleManager = null;
            this.Label7.TabIndex = 2;
            this.Label7.Text = "X:";
            this.Label7.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Label7.UseStyleColors = true;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.CustomBackground = false;
            this.Label8.CustomForeColor = false;
            this.Label8.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.Label8.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.Label8.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.Label8.Location = new System.Drawing.Point(8, 51);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(20, 19);
            this.Label8.Style = MetroFramework.MetroColorStyle.Blue;
            this.Label8.StyleManager = null;
            this.Label8.TabIndex = 3;
            this.Label8.Text = "Y:";
            this.Label8.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Label8.UseStyleColors = true;
            // 
            // CheckBox6
            // 
            this.CheckBox6.AutoSize = true;
            this.CheckBox6.CustomBackground = false;
            this.CheckBox6.CustomForeColor = false;
            this.CheckBox6.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.CheckBox6.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.CheckBox6.Location = new System.Drawing.Point(3, 157);
            this.CheckBox6.Name = "CheckBox6";
            this.CheckBox6.Size = new System.Drawing.Size(157, 19);
            this.CheckBox6.Style = MetroFramework.MetroColorStyle.Blue;
            this.CheckBox6.StyleManager = null;
            this.CheckBox6.TabIndex = 17;
            this.CheckBox6.Text = "Modify WoW window";
            this.CheckBox6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CheckBox6.UseStyleColors = true;
            this.CheckBox6.UseVisualStyleBackColor = true;
            // 
            // numericUpDownBackupTimer
            // 
            this.numericUpDownBackupTimer.Location = new System.Drawing.Point(258, 129);
            this.numericUpDownBackupTimer.Maximum = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.numericUpDownBackupTimer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBackupTimer.Name = "numericUpDownBackupTimer";
            this.numericUpDownBackupTimer.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownBackupTimer.TabIndex = 47;
            this.numericUpDownBackupTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip.SetToolTip(this.numericUpDownBackupTimer, "Interval between backup attempts");
            this.numericUpDownBackupTimer.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Hours
            // 
            this.Hours.AutoSize = true;
            this.Hours.CustomBackground = false;
            this.Hours.CustomForeColor = false;
            this.Hours.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.Hours.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.Hours.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.Hours.Location = new System.Drawing.Point(3, 128);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(253, 19);
            this.Hours.Style = MetroFramework.MetroColorStyle.Blue;
            this.Hours.StyleManager = null;
            this.Hours.TabIndex = 46;
            this.Hours.Text = "Minimal interval between backups (hours):";
            this.Hours.Theme = MetroFramework.MetroThemeStyle.Light;
            this.toolTip.SetToolTip(this.Hours, "Interval between backup attempts");
            this.Hours.UseStyleColors = true;
            // 
            // numericUpDownBackupCopiesToKeep
            // 
            this.numericUpDownBackupCopiesToKeep.Location = new System.Drawing.Point(128, 99);
            this.numericUpDownBackupCopiesToKeep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBackupCopiesToKeep.Name = "numericUpDownBackupCopiesToKeep";
            this.numericUpDownBackupCopiesToKeep.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownBackupCopiesToKeep.TabIndex = 44;
            this.numericUpDownBackupCopiesToKeep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip.SetToolTip(this.numericUpDownBackupCopiesToKeep, "How many archives keep on disk");
            this.numericUpDownBackupCopiesToKeep.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.CustomBackground = false;
            this.label9.CustomForeColor = false;
            this.label9.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.label9.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.label9.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.label9.Location = new System.Drawing.Point(3, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 19);
            this.label9.Style = MetroFramework.MetroColorStyle.Blue;
            this.label9.StyleManager = null;
            this.label9.TabIndex = 43;
            this.label9.Text = "Copies to keep:";
            this.label9.Theme = MetroFramework.MetroThemeStyle.Light;
            this.toolTip.SetToolTip(this.label9, "How many archives keep on disk");
            this.label9.UseStyleColors = true;
            // 
            // checkBoxAddonsBackup
            // 
            this.checkBoxAddonsBackup.AutoSize = true;
            this.checkBoxAddonsBackup.CustomBackground = false;
            this.checkBoxAddonsBackup.CustomForeColor = false;
            this.checkBoxAddonsBackup.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.checkBoxAddonsBackup.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.checkBoxAddonsBackup.Location = new System.Drawing.Point(3, 15);
            this.checkBoxAddonsBackup.Name = "checkBoxAddonsBackup";
            this.checkBoxAddonsBackup.Size = new System.Drawing.Size(162, 19);
            this.checkBoxAddonsBackup.Style = MetroFramework.MetroColorStyle.Blue;
            this.checkBoxAddonsBackup.StyleManager = null;
            this.checkBoxAddonsBackup.TabIndex = 42;
            this.checkBoxAddonsBackup.Text = "Enable addons backup";
            this.checkBoxAddonsBackup.Theme = MetroFramework.MetroThemeStyle.Light;
            this.checkBoxAddonsBackup.UseStyleColors = true;
            this.checkBoxAddonsBackup.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.metroTabPage1);
            this.tabControl.Controls.Add(this.metroTabPage3);
            this.tabControl.Controls.Add(this.metroTabPage4);
            this.tabControl.Controls.Add(this.metroTabPage7);
            this.tabControl.CustomBackground = false;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.FontSize = MetroFramework.MetroTabControlSize.Medium;
            this.tabControl.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.tabControl.Location = new System.Drawing.Point(20, 30);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 3;
            this.tabControl.Size = new System.Drawing.Size(565, 284);
            this.tabControl.Style = MetroFramework.MetroColorStyle.Blue;
            this.tabControl.TabIndex = 65;
            this.tabControl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabControl.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabControl.UseStyleColors = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.checkBoxSendLogOnShutdown);
            this.metroTabPage1.Controls.Add(this.checkBoxMinimizeToTray);
            this.metroTabPage1.Controls.Add(this.linkSendLogToDev);
            this.metroTabPage1.Controls.Add(this.linkShowLog);
            this.metroTabPage1.Controls.Add(this.metroLabel10);
            this.metroTabPage1.Controls.Add(this.metroComboBoxStyle);
            this.metroTabPage1.Controls.Add(this.CheckBoxStartAxToolsWithWindows);
            this.metroTabPage1.CustomBackground = false;
            this.metroTabPage1.HorizontalScrollbar = false;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(557, 245);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage1.StyleManager = null;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "    General  ";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage1.VerticalScrollbar = false;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // checkBoxSendLogOnShutdown
            // 
            this.checkBoxSendLogOnShutdown.AutoSize = true;
            this.checkBoxSendLogOnShutdown.CustomBackground = false;
            this.checkBoxSendLogOnShutdown.CustomForeColor = false;
            this.checkBoxSendLogOnShutdown.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.checkBoxSendLogOnShutdown.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.checkBoxSendLogOnShutdown.Location = new System.Drawing.Point(3, 65);
            this.checkBoxSendLogOnShutdown.Name = "checkBoxSendLogOnShutdown";
            this.checkBoxSendLogOnShutdown.Size = new System.Drawing.Size(441, 19);
            this.checkBoxSendLogOnShutdown.Style = MetroFramework.MetroColorStyle.Blue;
            this.checkBoxSendLogOnShutdown.StyleManager = null;
            this.checkBoxSendLogOnShutdown.TabIndex = 49;
            this.checkBoxSendLogOnShutdown.Text = "Send a report to the developer if errors occurred during the runtime";
            this.checkBoxSendLogOnShutdown.Theme = MetroFramework.MetroThemeStyle.Light;
            this.checkBoxSendLogOnShutdown.UseStyleColors = true;
            this.checkBoxSendLogOnShutdown.UseVisualStyleBackColor = true;
            // 
            // checkBoxMinimizeToTray
            // 
            this.checkBoxMinimizeToTray.AutoSize = true;
            this.checkBoxMinimizeToTray.CustomBackground = false;
            this.checkBoxMinimizeToTray.CustomForeColor = false;
            this.checkBoxMinimizeToTray.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.checkBoxMinimizeToTray.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.checkBoxMinimizeToTray.Location = new System.Drawing.Point(3, 40);
            this.checkBoxMinimizeToTray.Name = "checkBoxMinimizeToTray";
            this.checkBoxMinimizeToTray.Size = new System.Drawing.Size(125, 19);
            this.checkBoxMinimizeToTray.Style = MetroFramework.MetroColorStyle.Blue;
            this.checkBoxMinimizeToTray.StyleManager = null;
            this.checkBoxMinimizeToTray.TabIndex = 48;
            this.checkBoxMinimizeToTray.Text = "Minimize to tray";
            this.checkBoxMinimizeToTray.Theme = MetroFramework.MetroThemeStyle.Light;
            this.checkBoxMinimizeToTray.UseStyleColors = true;
            this.checkBoxMinimizeToTray.UseVisualStyleBackColor = true;
            // 
            // linkSendLogToDev
            // 
            this.linkSendLogToDev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkSendLogToDev.AutoSize = true;
            this.linkSendLogToDev.CustomBackground = false;
            this.linkSendLogToDev.CustomForeColor = false;
            this.linkSendLogToDev.FontSize = MetroFramework.MetroLinkSize.Small;
            this.linkSendLogToDev.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.linkSendLogToDev.Location = new System.Drawing.Point(424, 222);
            this.linkSendLogToDev.Name = "linkSendLogToDev";
            this.linkSendLogToDev.Size = new System.Drawing.Size(130, 23);
            this.linkSendLogToDev.Style = MetroFramework.MetroColorStyle.Blue;
            this.linkSendLogToDev.StyleManager = null;
            this.linkSendLogToDev.TabIndex = 47;
            this.linkSendLogToDev.Text = "Send log to developer";
            this.linkSendLogToDev.Theme = MetroFramework.MetroThemeStyle.Light;
            this.toolTip.SetToolTip(this.linkSendLogToDev, "Send AxTools\'s log file to developer");
            this.linkSendLogToDev.UseStyleColors = true;
            // 
            // linkShowLog
            // 
            this.linkShowLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkShowLog.CustomBackground = false;
            this.linkShowLog.CustomForeColor = false;
            this.linkShowLog.FontSize = MetroFramework.MetroLinkSize.Small;
            this.linkShowLog.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.linkShowLog.Location = new System.Drawing.Point(343, 222);
            this.linkShowLog.Name = "linkShowLog";
            this.linkShowLog.Size = new System.Drawing.Size(75, 23);
            this.linkShowLog.Style = MetroFramework.MetroColorStyle.Blue;
            this.linkShowLog.StyleManager = null;
            this.linkShowLog.TabIndex = 46;
            this.linkShowLog.Text = "Show log";
            this.linkShowLog.Theme = MetroFramework.MetroThemeStyle.Light;
            this.toolTip.SetToolTip(this.linkShowLog, "Open AxTools\'s log file");
            this.linkShowLog.UseStyleColors = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.CustomBackground = false;
            this.metroLabel10.CustomForeColor = false;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel10.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel10.Location = new System.Drawing.Point(3, 219);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(74, 19);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel10.StyleManager = null;
            this.metroLabel10.TabIndex = 45;
            this.metroLabel10.Text = "Color style:";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel10.UseStyleColors = true;
            // 
            // metroComboBoxStyle
            // 
            this.metroComboBoxStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroComboBoxStyle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroComboBoxStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroComboBoxStyle.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroComboBoxStyle.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroComboBoxStyle.FormattingEnabled = true;
            this.metroComboBoxStyle.ItemHeight = 19;
            this.metroComboBoxStyle.Items.AddRange(new object[] {
            "Black",
            "Silver",
            "Blue",
            "Green",
            "Lime",
            "Teal",
            "Orange",
            "Brown",
            "Pink",
            "Magenta",
            "Purple",
            "Red",
            "Yellow"});
            this.metroComboBoxStyle.Location = new System.Drawing.Point(83, 217);
            this.metroComboBoxStyle.Name = "metroComboBoxStyle";
            this.metroComboBoxStyle.Size = new System.Drawing.Size(145, 25);
            this.metroComboBoxStyle.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroComboBoxStyle.StyleManager = null;
            this.metroComboBoxStyle.TabIndex = 44;
            this.metroComboBoxStyle.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.checkBoxClearWoWCache);
            this.metroTabPage3.Controls.Add(this.checkBoxSetAfkStatus);
            this.metroTabPage3.Controls.Add(this.buttonIngameKeyBinds);
            this.metroTabPage3.Controls.Add(this.checkBoxPluginsUpdate);
            this.metroTabPage3.Controls.Add(this.GroupBox2);
            this.metroTabPage3.Controls.Add(this.CheckBox6);
            this.metroTabPage3.Controls.Add(this.CheckBox7);
            this.metroTabPage3.Controls.Add(this.GroupBox1);
            this.metroTabPage3.Controls.Add(this.checkBox_AntiAFK);
            this.metroTabPage3.CustomBackground = false;
            this.metroTabPage3.HorizontalScrollbar = false;
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(557, 245);
            this.metroTabPage3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage3.StyleManager = null;
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "     World of Warcraft ";
            this.metroTabPage3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage3.VerticalScrollbar = false;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // checkBoxClearWoWCache
            // 
            this.checkBoxClearWoWCache.AutoSize = true;
            this.checkBoxClearWoWCache.CustomBackground = false;
            this.checkBoxClearWoWCache.CustomForeColor = false;
            this.checkBoxClearWoWCache.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.checkBoxClearWoWCache.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.checkBoxClearWoWCache.Location = new System.Drawing.Point(3, 65);
            this.checkBoxClearWoWCache.Name = "checkBoxClearWoWCache";
            this.checkBoxClearWoWCache.Size = new System.Drawing.Size(244, 19);
            this.checkBoxClearWoWCache.Style = MetroFramework.MetroColorStyle.Blue;
            this.checkBoxClearWoWCache.StyleManager = null;
            this.checkBoxClearWoWCache.TabIndex = 58;
            this.checkBoxClearWoWCache.Text = "Clear WoW cache from time to time";
            this.checkBoxClearWoWCache.Theme = MetroFramework.MetroThemeStyle.Light;
            this.toolTip.SetToolTip(this.checkBoxClearWoWCache, "Show various plugins notifications in game\r\n(it appears on recordings/streams)");
            this.checkBoxClearWoWCache.UseStyleColors = true;
            this.checkBoxClearWoWCache.UseVisualStyleBackColor = true;
            // 
            // checkBoxSetAfkStatus
            // 
            this.checkBoxSetAfkStatus.AutoSize = true;
            this.checkBoxSetAfkStatus.CustomBackground = false;
            this.checkBoxSetAfkStatus.CustomForeColor = false;
            this.checkBoxSetAfkStatus.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.checkBoxSetAfkStatus.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.checkBoxSetAfkStatus.Location = new System.Drawing.Point(83, 15);
            this.checkBoxSetAfkStatus.Name = "checkBoxSetAfkStatus";
            this.checkBoxSetAfkStatus.Size = new System.Drawing.Size(253, 19);
            this.checkBoxSetAfkStatus.Style = MetroFramework.MetroColorStyle.Blue;
            this.checkBoxSetAfkStatus.StyleManager = null;
            this.checkBoxSetAfkStatus.TabIndex = 57;
            this.checkBoxSetAfkStatus.Text = "Set in-game /afk status when you afk";
            this.checkBoxSetAfkStatus.Theme = MetroFramework.MetroThemeStyle.Light;
            this.checkBoxSetAfkStatus.UseStyleColors = true;
            this.checkBoxSetAfkStatus.UseVisualStyleBackColor = true;
            // 
            // buttonIngameKeyBinds
            // 
            this.buttonIngameKeyBinds.Highlight = true;
            this.buttonIngameKeyBinds.Location = new System.Drawing.Point(0, 90);
            this.buttonIngameKeyBinds.Name = "buttonIngameKeyBinds";
            this.buttonIngameKeyBinds.Size = new System.Drawing.Size(137, 23);
            this.buttonIngameKeyBinds.Style = MetroFramework.MetroColorStyle.Blue;
            this.buttonIngameKeyBinds.StyleManager = null;
            this.buttonIngameKeyBinds.TabIndex = 56;
            this.buttonIngameKeyBinds.Text = "Ingame key binds...";
            this.buttonIngameKeyBinds.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // checkBoxPluginsUpdate
            // 
            this.checkBoxPluginsUpdate.AutoSize = true;
            this.checkBoxPluginsUpdate.CustomBackground = false;
            this.checkBoxPluginsUpdate.CustomForeColor = false;
            this.checkBoxPluginsUpdate.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.checkBoxPluginsUpdate.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.checkBoxPluginsUpdate.Location = new System.Drawing.Point(3, 40);
            this.checkBoxPluginsUpdate.Name = "checkBoxPluginsUpdate";
            this.checkBoxPluginsUpdate.Size = new System.Drawing.Size(509, 19);
            this.checkBoxPluginsUpdate.Style = MetroFramework.MetroColorStyle.Blue;
            this.checkBoxPluginsUpdate.StyleManager = null;
            this.checkBoxPluginsUpdate.TabIndex = 43;
            this.checkBoxPluginsUpdate.Text = "Update plug-ins along with AxTools update + notify about update once a week";
            this.checkBoxPluginsUpdate.Theme = MetroFramework.MetroThemeStyle.Light;
            this.toolTip.SetToolTip(this.checkBoxPluginsUpdate, "Show various plugins notifications in game\r\n(it appears on recordings/streams)");
            this.checkBoxPluginsUpdate.UseStyleColors = true;
            this.checkBoxPluginsUpdate.UseVisualStyleBackColor = true;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.checkBoxMakeBackupNotWhilePlaying);
            this.metroTabPage4.Controls.Add(this.metroComboBoxBackupCompressionLevel);
            this.metroTabPage4.Controls.Add(this.metroLabel9);
            this.metroTabPage4.Controls.Add(this.metroLabel6);
            this.metroTabPage4.Controls.Add(this.buttonBackupPath);
            this.metroTabPage4.Controls.Add(this.textBoxBackupPath);
            this.metroTabPage4.Controls.Add(this.numericUpDownBackupTimer);
            this.metroTabPage4.Controls.Add(this.Hours);
            this.metroTabPage4.Controls.Add(this.numericUpDownBackupCopiesToKeep);
            this.metroTabPage4.Controls.Add(this.checkBoxAddonsBackup);
            this.metroTabPage4.Controls.Add(this.label9);
            this.metroTabPage4.CustomBackground = false;
            this.metroTabPage4.HorizontalScrollbar = false;
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(557, 245);
            this.metroTabPage4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage4.StyleManager = null;
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "    Backup ";
            this.metroTabPage4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage4.VerticalScrollbar = false;
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // checkBoxMakeBackupNotWhilePlaying
            // 
            this.checkBoxMakeBackupNotWhilePlaying.AutoSize = true;
            this.checkBoxMakeBackupNotWhilePlaying.CustomBackground = false;
            this.checkBoxMakeBackupNotWhilePlaying.CustomForeColor = false;
            this.checkBoxMakeBackupNotWhilePlaying.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.checkBoxMakeBackupNotWhilePlaying.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.checkBoxMakeBackupNotWhilePlaying.Location = new System.Drawing.Point(3, 40);
            this.checkBoxMakeBackupNotWhilePlaying.Name = "checkBoxMakeBackupNotWhilePlaying";
            this.checkBoxMakeBackupNotWhilePlaying.Size = new System.Drawing.Size(342, 19);
            this.checkBoxMakeBackupNotWhilePlaying.Style = MetroFramework.MetroColorStyle.Blue;
            this.checkBoxMakeBackupNotWhilePlaying.StyleManager = null;
            this.checkBoxMakeBackupNotWhilePlaying.TabIndex = 56;
            this.checkBoxMakeBackupNotWhilePlaying.Text = "Do not create a backup while WoW client is running";
            this.checkBoxMakeBackupNotWhilePlaying.Theme = MetroFramework.MetroThemeStyle.Light;
            this.checkBoxMakeBackupNotWhilePlaying.UseStyleColors = true;
            this.checkBoxMakeBackupNotWhilePlaying.UseVisualStyleBackColor = true;
            // 
            // metroComboBoxBackupCompressionLevel
            // 
            this.metroComboBoxBackupCompressionLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroComboBoxBackupCompressionLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroComboBoxBackupCompressionLevel.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroComboBoxBackupCompressionLevel.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroComboBoxBackupCompressionLevel.FormattingEnabled = true;
            this.metroComboBoxBackupCompressionLevel.ItemHeight = 19;
            this.metroComboBoxBackupCompressionLevel.Items.AddRange(new object[] {
            "None",
            "Superfast",
            "Veryfast",
            "Faster",
            "Fast",
            "Medium",
            "Slow",
            "Slower",
            "Veryslow",
            "Superslow"});
            this.metroComboBoxBackupCompressionLevel.Location = new System.Drawing.Point(128, 155);
            this.metroComboBoxBackupCompressionLevel.Name = "metroComboBoxBackupCompressionLevel";
            this.metroComboBoxBackupCompressionLevel.Size = new System.Drawing.Size(152, 25);
            this.metroComboBoxBackupCompressionLevel.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroComboBoxBackupCompressionLevel.StyleManager = null;
            this.metroComboBoxBackupCompressionLevel.TabIndex = 55;
            this.metroComboBoxBackupCompressionLevel.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.CustomBackground = false;
            this.metroLabel9.CustomForeColor = false;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel9.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel9.Location = new System.Drawing.Point(3, 158);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(119, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel9.StyleManager = null;
            this.metroLabel9.TabIndex = 51;
            this.metroLabel9.Text = "Compression level:";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel9.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.CustomBackground = false;
            this.metroLabel6.CustomForeColor = false;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel6.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel6.Location = new System.Drawing.Point(3, 68);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(84, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel6.StyleManager = null;
            this.metroLabel6.TabIndex = 50;
            this.metroLabel6.Text = "Backup path:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel6.UseStyleColors = true;
            // 
            // buttonBackupPath
            // 
            this.buttonBackupPath.Highlight = true;
            this.buttonBackupPath.Location = new System.Drawing.Point(518, 69);
            this.buttonBackupPath.Name = "buttonBackupPath";
            this.buttonBackupPath.Size = new System.Drawing.Size(36, 20);
            this.buttonBackupPath.Style = MetroFramework.MetroColorStyle.Blue;
            this.buttonBackupPath.StyleManager = null;
            this.buttonBackupPath.TabIndex = 49;
            this.buttonBackupPath.Text = "...";
            this.buttonBackupPath.Theme = MetroFramework.MetroThemeStyle.Light;
            this.toolTip.SetToolTip(this.buttonBackupPath, "Click to select path...");
            // 
            // textBoxBackupPath
            // 
            this.textBoxBackupPath.CustomBackground = false;
            this.textBoxBackupPath.CustomForeColor = false;
            this.textBoxBackupPath.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.textBoxBackupPath.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.textBoxBackupPath.Location = new System.Drawing.Point(128, 69);
            this.textBoxBackupPath.Multiline = false;
            this.textBoxBackupPath.Name = "textBoxBackupPath";
            this.textBoxBackupPath.ReadOnly = true;
            this.textBoxBackupPath.SelectedText = "";
            this.textBoxBackupPath.Size = new System.Drawing.Size(384, 20);
            this.textBoxBackupPath.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxBackupPath.StyleManager = null;
            this.textBoxBackupPath.TabIndex = 48;
            this.textBoxBackupPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxBackupPath.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxBackupPath.UseStyleColors = true;
            // 
            // metroTabPage7
            // 
            this.metroTabPage7.Controls.Add(this.ComboBox_server_ip);
            this.metroTabPage7.Controls.Add(this.Label3);
            this.metroTabPage7.CustomBackground = false;
            this.metroTabPage7.HorizontalScrollbar = false;
            this.metroTabPage7.HorizontalScrollbarBarColor = true;
            this.metroTabPage7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage7.HorizontalScrollbarSize = 10;
            this.metroTabPage7.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage7.Name = "metroTabPage7";
            this.metroTabPage7.Size = new System.Drawing.Size(557, 245);
            this.metroTabPage7.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage7.StyleManager = null;
            this.metroTabPage7.TabIndex = 6;
            this.metroTabPage7.Text = "    Pinger ";
            this.metroTabPage7.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage7.VerticalScrollbar = false;
            this.metroTabPage7.VerticalScrollbarBarColor = true;
            this.metroTabPage7.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage7.VerticalScrollbarSize = 10;
            // 
            // ComboBox_server_ip
            // 
            this.ComboBox_server_ip.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_server_ip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_server_ip.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.ComboBox_server_ip.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.ComboBox_server_ip.FormattingEnabled = true;
            this.ComboBox_server_ip.ItemHeight = 23;
            this.ComboBox_server_ip.Location = new System.Drawing.Point(104, 15);
            this.ComboBox_server_ip.Name = "ComboBox_server_ip";
            this.ComboBox_server_ip.Size = new System.Drawing.Size(293, 29);
            this.ComboBox_server_ip.Style = MetroFramework.MetroColorStyle.Blue;
            this.ComboBox_server_ip.StyleManager = null;
            this.ComboBox_server_ip.TabIndex = 41;
            this.ComboBox_server_ip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.CustomBackground = false;
            this.Label3.CustomForeColor = false;
            this.Label3.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.Label3.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.Label3.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.Label3.Location = new System.Drawing.Point(3, 20);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(95, 19);
            this.Label3.Style = MetroFramework.MetroColorStyle.Blue;
            this.Label3.StyleManager = null;
            this.Label3.TabIndex = 42;
            this.Label3.Text = "Server to ping:";
            this.Label3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Label3.UseStyleColors = true;
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 10000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 100;
            this.toolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.toolTip.StyleManager = null;
            this.toolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // linkTitle
            // 
            this.linkTitle.AutoSize = true;
            this.linkTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.linkTitle.CustomBackground = false;
            this.linkTitle.CustomForeColor = false;
            this.linkTitle.FontSize = MetroFramework.MetroLinkSize.Small;
            this.linkTitle.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.linkTitle.Location = new System.Drawing.Point(13, 5);
            this.linkTitle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.linkTitle.Name = "linkTitle";
            this.linkTitle.Size = new System.Drawing.Size(55, 23);
            this.linkTitle.Style = MetroFramework.MetroColorStyle.Blue;
            this.linkTitle.TabIndex = 70;
            this.linkTitle.Text = "Settings";
            this.linkTitle.Theme = MetroFramework.MetroThemeStyle.Light;
            this.linkTitle.UseStyleColors = true;
            // 
            // AppSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 324);
            this.Controls.Add(this.linkTitle);
            this.Controls.Add(this.tabControl);
            this.DisplayHeader = false;
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.Name = "AppSettings";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 10);
            this.Resizable = false;
            this.Text = "Settings";
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBackupTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBackupCopiesToKeep)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.metroTabPage4.ResumeLayout(false);
            this.metroTabPage4.PerformLayout();
            this.metroTabPage7.ResumeLayout(false);
            this.metroTabPage7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private MetroCheckBox checkBox_AntiAFK;
        private MetroCheckBox CheckBoxStartAxToolsWithWindows;
        private MetroCheckBox CheckBox7;
        private System.Windows.Forms.GroupBox GroupBox2;
        private MetroTextboxExt TextBox4;
        private MetroTextboxExt TextBox5;
        private MetroLabel Label5;
        private MetroLabel Label6;
        private System.Windows.Forms.GroupBox GroupBox1;
        private MetroTextboxExt TextBox6;
        private MetroTextboxExt TextBox7;
        private MetroLabel Label7;
        private MetroLabel Label8;
        private MetroCheckBox CheckBox6;


        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDownBackupCopiesToKeep;
        private MetroLabel label9;
        private MetroCheckBox checkBoxAddonsBackup;
        private System.Windows.Forms.NumericUpDown numericUpDownBackupTimer;
        private MetroLabel Hours;
        private MetroTabControl tabControl;
        private MetroTabPage metroTabPage1;
        private MetroTabPage metroTabPage3;
        private MetroTabPage metroTabPage4;
        private MetroLabel metroLabel6;
        private MetroButton buttonBackupPath;
        private MetroTextboxExt textBoxBackupPath;
        private MetroToolTip toolTip;
        private MetroComboBox metroComboBoxBackupCompressionLevel;
        private MetroLabel metroLabel9;
        private MetroLabel metroLabel10;
        private MetroComboBox metroComboBoxStyle;
        private MetroLink linkShowLog;
        private MetroLink linkSendLogToDev;
        private MetroTabPage metroTabPage7;
        private MetroComboBox ComboBox_server_ip;
        private MetroLabel Label3;
        private MetroCheckBox checkBoxMinimizeToTray;
        private MetroLink linkTitle;
        private MetroCheckBox checkBoxPluginsUpdate;
        private MetroButton buttonIngameKeyBinds;
        private MetroCheckBox checkBoxMakeBackupNotWhilePlaying;
        private MetroCheckBox checkBoxSetAfkStatus;
        private MetroCheckBox checkBoxClearWoWCache;
        private MetroCheckBox checkBoxSendLogOnShutdown;
    }
}