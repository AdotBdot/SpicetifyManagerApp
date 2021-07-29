using System;
using System.Drawing;
using System.Windows.Forms;
using SpicetifyManager.My;

namespace SpicetifyManager
{
    public partial class MainForm : Form
    {
        public MainForm(Settings settings, Spicetify spicetify)
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
        private Form _ActiveForm = null;


        private void InitControls()
        {
            if(_Spicetify.Detected)
            {
                WarningIcon.Hide();
            }
            else
                WarningIcon.Show();
        }

        private void LoadFonts()
        {
            AboutButton.Font = new Font(Fonts.Pfc.Families[1], 14.25f);
            ManageButton.Font = new Font(Fonts.Pfc.Families[1], 14.25f);
            ReloadButton.Font = new Font(Fonts.Pfc.Families[1], 14.25f);
            SettingsButton.Font = new Font(Fonts.Pfc.Families[1], 14.25f);
            ThemesButton.Font = new Font(Fonts.Pfc.Families[1], 14.25f);
        }

        private void LoadColors()
        {
            this.BackColor = Colors.GetBg(0);
            NavBar.BackColor = Colors.GetBg(4);
            ChildFormPanel.BackColor = Colors.GetBg(0);
            ThemesButton.BackColor = Colors.GetBg(4);
            ThemesButton.ForeColor = Colors.TxtLight;
            PluginsButton.BackColor = Colors.GetBg(4);
            PluginsButton.ForeColor = Colors.TxtLight;
            SettingsButton.BackColor = Colors.GetBg(4);
            SettingsButton.ForeColor = Colors.TxtLight;
            AboutButton.BackColor = Colors.GetBg(4);
            AboutButton.ForeColor = Colors.TxtLight;
            ManageButton.BackColor = Colors.GetBg(4);
            ManageButton.ForeColor = Colors.TxtLight;
            ReloadButton.BackColor = Colors.GetBg(4);
            ReloadButton.ForeColor = Colors.TxtLight;
            WarningIcon.BackColor = Colors.GetBg(4);
        }

        private void ClearButtonColors()
        {
            ThemesButton.BackColor = Colors.GetBg(4);
            ThemesButton.ForeColor = Colors.TxtLight;
            PluginsButton.BackColor = Colors.GetBg(4);
            PluginsButton.ForeColor = Colors.TxtLight;
            SettingsButton.BackColor = Colors.GetBg(4);
            SettingsButton.ForeColor = Colors.TxtLight;
            AboutButton.BackColor = Colors.GetBg(4);
            AboutButton.ForeColor = Colors.TxtLight;
            ManageButton.BackColor = Colors.GetBg(4);
            ManageButton.ForeColor = Colors.TxtLight;
        }

        private void OpenChildForm(Form childForm)
        {
            if(_ActiveForm != null)
                _ActiveForm.Close();

            _ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ChildFormPanel.Controls.Add(childForm);
            childForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void SetActiveButton(Button button)
        {
            ClearButtonColors();
            button.BackColor = Colors.Primary;
            button.ForeColor = Colors.TxtDark;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            if(!_Spicetify.Detected)
                return;

            OpenChildForm(new SettingsForm(_Settings, _Spicetify));
            SetActiveButton(SettingsButton);
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            if(!_Spicetify.Detected)
                return;

            OpenChildForm(new AboutForm(_Settings, _Spicetify));
            SetActiveButton(AboutButton);
        }

        private void ManageButton_Click(object sender, EventArgs e)
        {
            if(!_Spicetify.Detected)
                return;

            OpenChildForm(new ManageForm(_Spicetify));
            SetActiveButton(ManageButton);
        }

        private void PluginsButton_Click(object sender, EventArgs e)
        {
            if(!_Spicetify.Detected)
                return;

            OpenChildForm(new PluginsForm(_Settings, _Spicetify));
            SetActiveButton(PluginsButton);
        }

        private void ThemesButton_Click(object sender, EventArgs e)
        {
            if(!_Spicetify.Detected)
                return;

            OpenChildForm(new ThemesForm(_Settings, _Spicetify));
            SetActiveButton(ThemesButton);
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            if(!_Spicetify.Detected)
                return;

            string S = _ActiveForm.Name;
            switch(S)
            {
            case "ThemesForm":
            {
                ThemesForm F = (ThemesForm) _ActiveForm;
                F.Reload();
                break;
            }
            case "PluginsForm":
            {
                PluginsForm F = (PluginsForm) _ActiveForm;
                F.Reload();
                break;
            }
            case "SettingsForm":
            {
                SettingsForm F = (SettingsForm) _ActiveForm;
                F.Reload();
                break;
            }
            }
        }

        private void WarningIcon_MouseHover(object sender, EventArgs e)
        {
            WarningToolTip.Show("spicetify.exe not found, install spicetify and restart application", WarningIcon);
        }
    }
}