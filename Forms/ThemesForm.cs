using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
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
            if(!_Spicetify.Detected)
                return;

            ThemesDropdown.Items.Clear();
            foreach(string theme in _Spicetify.GetThemes())
            {
                ThemesDropdown.Items.Add(theme);
            }

            if(_Settings.CurrentTheme == string.Empty)
                ThemesDropdown.SelectedItem = ThemesDropdown.Items[ThemesDropdown.Items.IndexOf("(none)")];
            else
                ThemesDropdown.SelectedItem =
                    ThemesDropdown.Items[ThemesDropdown.Items.IndexOf(_Settings.CurrentTheme)];

            ColorsDropdown.Items.Clear();
            foreach(string color in _Spicetify.GetColors(_Settings.CurrentTheme))
            {
                ColorsDropdown.Items.Add(color);
            }

            if(_Settings.ColorScheme != string.Empty)
                ColorsDropdown.SelectedItem = ColorsDropdown.Items[ColorsDropdown.Items.IndexOf(_Settings.ColorScheme)];
            else
                ColorsDropdown.SelectedItem = null;
        }

        private void ReadUserInput()
        {
            if(ThemesDropdown.SelectedItem.ToString() == "(none)")
                _Settings.CurrentTheme = "";
            else
                _Settings.CurrentTheme = ThemesDropdown.SelectedItem.ToString();

            if(ColorsDropdown.SelectedItem == null)
                _Settings.ColorScheme = "";
            else
                _Settings.ColorScheme = ColorsDropdown.SelectedItem.ToString();
        }


        private void ThemesForm_Load(object sender, EventArgs e)
        {
        }

        private void CurrentThemeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColorsDropdown.Items.Clear();
            List<string> colors = _Spicetify.GetColors(ThemesDropdown.SelectedItem.ToString());
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
            if(!_Spicetify.Detected)
                return;

            ReadUserInput();
            _Settings.SaveThemes();
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            if(!_Spicetify.Detected)
                return;

            ReadUserInput();
            _Settings.SaveThemes();
            Task.Run(() => _Spicetify.Apply());
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if(!_Spicetify.Detected)
                return;

            ReadUserInput();
            _Settings.SaveThemes();
            Task.Run(() => _Spicetify.Update());
        }

        private void ThemeFolderBtn_Click(object sender, EventArgs e)
        {
            if(!_Spicetify.Detected)
                return;

            _Spicetify.OpenThemeFolder();
        }
    }
}