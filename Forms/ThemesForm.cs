using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SpicetifyManager.My;

namespace SpicetifyManager
{
    public partial class ThemesForm : Form
    {
        public ThemesForm(Settings settings, Spicetify spicetify)
        {
            _Settings = settings;
            _Spicetify = spicetify;
            InitializeComponent();

            LoadFonts();
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
            if(!_Spicetify.DetectSpicetify())
                return;

            ThemesDropdown.Items.Clear();
            foreach(string Theme in _Spicetify.GetThemes())
            {
                ThemesDropdown.Items.Add(Theme);
            }

            ThemesDropdown.SelectedItem = ThemesDropdown.Items[ThemesDropdown.Items.IndexOf(_Settings.CurrentTheme)];

            ColorsDropdown.Items.Clear();
            foreach(string Color in _Spicetify.GetColors(_Settings.CurrentTheme))
            {
                ColorsDropdown.Items.Add(Color);
            }

            ColorsDropdown.SelectedItem = ColorsDropdown.Items[ColorsDropdown.Items.IndexOf(_Settings.ColorScheme)];
        }

        private void ReadUserInput()
        {
            if(ThemesDropdown.SelectedItem.ToString() == "(none)")
                _Settings.CurrentTheme = "";
            else
                _Settings.CurrentTheme = ThemesDropdown.SelectedItem.ToString();

            if(ColorsDropdown.SelectedItem != null)
                _Settings.ColorScheme = ColorsDropdown.SelectedItem.ToString();
            else
                _Settings.ColorScheme = "";
        }


        private void ThemesForm_Load(object sender, EventArgs e)
        {
        }

        private void CurrentThemeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColorsDropdown.Items.Clear();
            List<string> Colors = _Spicetify.GetColors(ThemesDropdown.SelectedItem.ToString());
            if(Colors.Count != 0)
            {
                foreach(string Color in Colors)
                {
                    ColorsDropdown.Items.Add(Color);
                }
            }
            else //Colors.Count == 0
            {
                ColorsDropdown.SelectedItem = null;
                ColorsDropdown.Text = "";
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(!_Spicetify.DetectSpicetify())
                return;

            ReadUserInput();
            _Settings.SaveThemes();
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            if(!_Spicetify.DetectSpicetify())
                return;

            ReadUserInput();
            _Settings.SaveThemes();
            _Spicetify.Apply();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if(!_Spicetify.DetectSpicetify())
                return;

            ReadUserInput();
            _Settings.SaveThemes();
            _Spicetify.Update();
        }

        private void ThemeFolderBtn_Click(object sender, EventArgs e)
        {
            if(!_Spicetify.DetectSpicetify())
                return;

            _Spicetify.OpenThemeFolder();
        }
    }
}