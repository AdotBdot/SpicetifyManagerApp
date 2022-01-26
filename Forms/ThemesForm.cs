using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpicetifySettingsApp.Source
{
    public partial class ThemesForm : Form
    {
        public ThemesForm()
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
            label3.Font = new Font(Fonts.Pfc.Families[1], 14.25f);
            label4.Font = new Font(Fonts.Pfc.Families[1], 14.25f);
            ThemesDropdown.Font = new Font(Fonts.Pfc.Families[0], 11.25f);
            ColorsDropdown.Font = new Font(Fonts.Pfc.Families[0], 11.25f);
            SaveBtn.Font = new Font(Fonts.Pfc.Families[1], 11.25f);
            ApplyBtn.Font = new Font(Fonts.Pfc.Families[1], 11.25f);
            UpdateBtn.Font = new Font(Fonts.Pfc.Families[1], 11.25f);
            ThemeFolderBtn.Font = new Font(Fonts.Pfc.Families[1], 11.25f);
        }
        private void LoadColors()
        {
            this.BackColor = Colors.GetBg(0);
            ThemesDropdown.BackColor = Colors.GetBg(2);
            ThemesDropdown.ForeColor = Colors.TxtLight;
            ColorsDropdown.BackColor = Colors.GetBg(2);
            ColorsDropdown.ForeColor = Colors.TxtLight;
            Title.ForeColor = Colors.TxtLight;
            label3.ForeColor = Colors.TxtLight;
            label4.ForeColor = Colors.TxtLight;
            SaveBtn.BackColor = Colors.Primary;
            ApplyBtn.BackColor = Colors.Primary;
            UpdateBtn.BackColor = Colors.Primary;
            ThemeFolderBtn.BackColor = Colors.Primary;
        }
        private void InitControls()
        {
            if(!StaticData.Spicetify.Detected)
                return;

            ThemesDropdown.Items.Clear();
            foreach(string theme in StaticData.Spicetify.GetThemes())
            {
                ThemesDropdown.Items.Add(theme);
            }

            if(StaticData.Settings.CurrentTheme == string.Empty)
                ThemesDropdown.SelectedItem = ThemesDropdown.Items[ThemesDropdown.Items.IndexOf("(none)")];
            else
                ThemesDropdown.SelectedItem = ThemesDropdown.Items[ThemesDropdown.Items.IndexOf(StaticData.Settings.CurrentTheme)];

            ColorsDropdown.Items.Clear();
            foreach(string color in StaticData.Spicetify.GetColors(StaticData.Settings.CurrentTheme))
            {
                ColorsDropdown.Items.Add(color);
            }

            if(StaticData.Settings.ColorScheme != string.Empty)
                ColorsDropdown.SelectedItem = ColorsDropdown.Items[ColorsDropdown.Items.IndexOf(StaticData.Settings.ColorScheme)];
            else
                ColorsDropdown.SelectedItem = null;
        }
        private void ReadUserInput()
        {
            if(ThemesDropdown.SelectedItem.ToString() == "(none)")
                StaticData.Settings.CurrentTheme = "";
            else
                StaticData.Settings.CurrentTheme = ThemesDropdown.SelectedItem.ToString();

            if(ColorsDropdown.SelectedItem == null)
                StaticData.Settings.ColorScheme = "";
            else
                StaticData.Settings.ColorScheme = ColorsDropdown.SelectedItem.ToString();
        }

        private void ThemesForm_Load(object sender, EventArgs e)
        {
        }

        private void CurrentThemeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColorsDropdown.Items.Clear();
            List<string> colors = StaticData.Spicetify.GetColors(ThemesDropdown.SelectedItem.ToString());
            if(colors.Count != 0)
            {
                foreach(string color in colors)
                {
                    ColorsDropdown.Items.Add(color);
                }

                ColorsDropdown.SelectedItem = ColorsDropdown.Items[0];
            }
            else //Colors.Count == 0
            {
                ColorsDropdown.Text = "";
                ColorsDropdown.SelectedItem = null;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(!StaticData.Spicetify.Detected)
                return;

            ReadUserInput();
            StaticData.Settings.SaveThemes();
        }
        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            if(!StaticData.Spicetify.Detected)
                return;

            ReadUserInput();
            StaticData.Settings.SaveThemes();
            Task.Run(() => StaticData.Spicetify.Apply());
        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if(!StaticData.Spicetify.Detected)
                return;

            ReadUserInput();
            StaticData.Settings.SaveThemes();
            Task.Run(() => StaticData.Spicetify.Update());
        }
        private void ThemeFolderBtn_Click(object sender, EventArgs e)
        {
            if(!StaticData.Spicetify.Detected)
                return;

            StaticData.Spicetify.OpenThemeFolder();
        }

        private void SaveBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Show("Save themes settings.", SaveBtn);
        }
        private void ApplyBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Show("Apply current config.", ApplyBtn);
        }
        private void UpdateBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Show("Update theme and color scheme.", UpdateBtn);
        }
        private void ThemeFolderBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Show("Open themes folder.", ThemeFolderBtn);
        }
        private void ThemesDropdown_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Show("Select the Theme you want to use.", ThemesDropdown);
        }
        private void ColorsDropdown_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Show("Select the Color Scheme of chosen theme you want to use.", ColorsDropdown);
        }
    }
}