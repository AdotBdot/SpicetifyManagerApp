﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SpicetifyManager
{
    public partial class PluginsForm : Form
    {
        public PluginsForm(Settings settings, Spicetify spicetify)
        {
            _Settings = settings;
            _Spicetify = spicetify;
            InitializeComponent();
            LoadColors();
            InitControls();
        }

        private Settings _Settings;
        private Spicetify _Spicetify;


        public void Reload()
        {
            _Settings.LoadConfig();
            InitControls();
        }


        private void InitControls()
        {
            ExtensionsList.Items.Clear();
            foreach(string Ext in _Spicetify.GetExtensions())
            {
                if(_Settings.ExtensionsList.Contains(Ext))
                    ExtensionsList.Items.Add(Ext, CheckState.Checked);
                else
                    ExtensionsList.Items.Add(Ext, CheckState.Unchecked);
            }

            CustomAppsList.Items.Clear();
            foreach(string App in _Spicetify.GetCustomApps())
            {
                if(_Settings.CustomAppsList.Contains(App))
                    CustomAppsList.Items.Add(App, CheckState.Checked);
                else
                    CustomAppsList.Items.Add(App, CheckState.Unchecked);
            }
        }

        private void ReadUserInput()
        {
            var CheckedExts = ExtensionsList.CheckedItems;
            List<string> NewExtsList = new List<string>();
            foreach(var Item in CheckedExts)
            {
                NewExtsList.Add(Item.ToString());
            }

            _Settings.ExtensionsList = NewExtsList;

            var CheckedApps = CustomAppsList.CheckedItems;
            List<string> NewAppsList = new List<string>();
            foreach(var Item in CheckedApps)
            {
                NewAppsList.Add(Item.ToString());
            }

            _Settings.CustomAppsList = NewAppsList;
        }

        private void LoadColors()
        {
            this.BackColor = Colors.GetBg(0);
            Title.ForeColor = Colors.TxtLight;
            label1.ForeColor = Colors.TxtLight;
            label2.ForeColor = Colors.TxtLight;
            ExtensionsList.BackColor = Colors.GetBg(2);
            ExtensionsList.ForeColor = Colors.TxtLight;
            CustomAppsList.BackColor = Colors.GetBg(2);
            CustomAppsList.ForeColor = Colors.TxtLight;
            SaveBtn.BackColor = Colors.Primary;
            ApplyBtn.BackColor = Colors.Primary;
            ExtsFolderBtn.BackColor = Colors.Primary;
            CustomAppsFolderBtn.BackColor = Colors.Primary;
        }


        private void PluginsForm_Load(object sender, EventArgs e)
        {
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            ReadUserInput();
            _Settings.SavePlugins();
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            ReadUserInput();
            _Settings.SavePlugins();
            _Spicetify.Apply();
        }

        private void ExtsFolderBtn_Click(object sender, EventArgs e)
        {
            _Spicetify.OpenExtensionsFolder();
        }

        private void CustomAppsFolderBtn_Click(object sender, EventArgs e)
        {
            _Spicetify.OpenCustomAppsFolder();
        }
    }
}