using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpicetifyManager.My;

namespace SpicetifyManager
{
    public partial class PluginsForm : Form
    {
        public PluginsForm()
        {
            InitializeComponent();

            LoadFonts();
            LoadColors();

            InitControls();
        }

        public void Reload()
        {
            StaticData.Settings.LoadConfig();
            InitControls();
        }

        private void LoadFonts()
        {
            Title.Font = new Font(Fonts.Pfc.Families[0], 18, FontStyle.Bold);
            label1.Font = new Font(Fonts.Pfc.Families[1], 14.25f);
            label2.Font = new Font(Fonts.Pfc.Families[1], 14.25f);
            ExtensionsList.Font = new Font(Fonts.Pfc.Families[0], 11.25f);
            CustomAppsList.Font = new Font(Fonts.Pfc.Families[0], 11.25f);
            SaveBtn.Font = new Font(Fonts.Pfc.Families[1], 11.25f);
            ApplyBtn.Font = new Font(Fonts.Pfc.Families[1], 11.25f);
            ExtsFolderBtn.Font = new Font(Fonts.Pfc.Families[1], 11.25f);
            CustomAppsFolderBtn.Font = new Font(Fonts.Pfc.Families[1], 11.25f);
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
        private void InitControls()
        {
            if(!StaticData.Spicetify.Detected)
                return;

            ExtensionsList.Items.Clear();
            foreach(string ext in StaticData.Spicetify.GetExtensions())
            {
                if(StaticData.Settings.ExtensionsList.Contains(ext))
                    ExtensionsList.Items.Add(ext, CheckState.Checked);
                else
                    ExtensionsList.Items.Add(ext, CheckState.Unchecked);
            }

            CustomAppsList.Items.Clear();
            foreach(string app in StaticData.Spicetify.GetCustomApps())
            {
                if(StaticData.Settings.CustomAppsList.Contains(app))
                    CustomAppsList.Items.Add(app, CheckState.Checked);
                else
                    CustomAppsList.Items.Add(app, CheckState.Unchecked);
            }
        }
        private void ReadUserInput()
        {
            var checkedExts = ExtensionsList.CheckedItems;
            List<string> newExtsList = new List<string>();
            foreach(var item in checkedExts)
            {
                newExtsList.Add(item.ToString());
            }

            StaticData.Settings.ExtensionsList = newExtsList;

            var checkedApps = CustomAppsList.CheckedItems;
            List<string> newAppsList = new List<string>();
            foreach(var item in checkedApps)
            {
                newAppsList.Add(item.ToString());
            }

            StaticData.Settings.CustomAppsList = newAppsList;
        }

        private void PluginsForm_Load(object sender, EventArgs e)
        {
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(!StaticData.Spicetify.Detected)
                return;

            ReadUserInput();
            StaticData.Settings.SavePlugins();
        }
        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            if(!StaticData.Spicetify.Detected)
                return;

            ReadUserInput();
            StaticData.Settings.SavePlugins();
            Task.Run(() => StaticData.Spicetify.Apply());
        }
        private void ExtsFolderBtn_Click(object sender, EventArgs e)
        {
            if(!StaticData.Spicetify.Detected)
                return;

            StaticData.Spicetify.OpenExtensionsFolder();
        }
        private void CustomAppsFolderBtn_Click(object sender, EventArgs e)
        {
            if(!StaticData.Spicetify.Detected)
                return;

            StaticData.Spicetify.OpenCustomAppsFolder();
        }

        private void ExtsFolderBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Show("Open extensions folder.", ExtsFolderBtn);
        }
        private void CustomAppsFolderBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Show("Open custom apps folder.", CustomAppsFolderBtn);
        }
        private void ApplyBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Show("Apply current config.", ApplyBtn);
        }
        private void SaveBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Show("Save plugins settings.", SaveBtn);
        }
        private void ExtensionsList_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Show("Select Extensions you want to use.", ExtensionsList);
        }
        private void CustomAppsList_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Show("Select Custom Apps you want to use.", CustomAppsList);
        }
    }
}