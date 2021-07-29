using System;
using System.Drawing;
using System.Windows.Forms;
using SpicetifyManager.My;

namespace SpicetifyManager
{
    public partial class SettingsForm : Form
    {
        public SettingsForm(Settings settings, Spicetify spicetify)
        {
            _Settings = settings;
            _Spicetify = spicetify;
            InitializeComponent();

            LoadColors();
            LoadFonts();

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
            label1.Font = new Font(Fonts.Pfc.Families[1], 12);
            label2.Font = new Font(Fonts.Pfc.Families[1], 12);
            label3.Font = new Font(Fonts.Pfc.Families[1], 12);
            PrefsPathInput.Font = new Font(Fonts.Pfc.Families[0], 10);
            SpotifyPathInput.Font = new Font(Fonts.Pfc.Families[0], 10);
            LaunchFlagsInput.Font = new Font(Fonts.Pfc.Families[0], 10);
            OverwriteAssetsChkBox.Font = new Font(Fonts.Pfc.Families[1], 12);
            CheckSpicetifyUpgradeChkBox.Font = new Font(Fonts.Pfc.Families[1], 12);
            InjectCssChkBox.Font = new Font(Fonts.Pfc.Families[1], 12);
            ReplaceColorsChkBox.Font = new Font(Fonts.Pfc.Families[1], 12);
            HomeConfigChkBox.Font = new Font(Fonts.Pfc.Families[1], 12);
            SidebarConfigChkBox.Font = new Font(Fonts.Pfc.Families[1], 12);
            DisableSentryChkBox.Font = new Font(Fonts.Pfc.Families[1], 12);
            DisableUiLoggingChkBox.Font = new Font(Fonts.Pfc.Families[1], 12);
            RemoveRtlRuleChkBox.Font = new Font(Fonts.Pfc.Families[1], 12);
            ExposeApisChkBox.Font = new Font(Fonts.Pfc.Families[1], 12);
            DisableUpgradeCheckChkBox.Font = new Font(Fonts.Pfc.Families[1], 12);
            SaveBtn.Font = new Font(Fonts.Pfc.Families[1], 11.25f);
            ApplyBtn.Font = new Font(Fonts.Pfc.Families[1], 11.25f);
            ConfigFileBtn.Font = new Font(Fonts.Pfc.Families[1], 11.25f);
        }

        private void LoadColors()
        {
            this.BackColor = Colors.GetBg(0);
            Title.ForeColor = Colors.TxtLight;
            label1.ForeColor = Colors.TxtLight;
            label2.ForeColor = Colors.TxtLight;
            label3.ForeColor = Colors.TxtLight;
            PrefsPathInput.BackColor = Colors.GetBg(2);
            PrefsPathInput.ForeColor = Colors.TxtLight;
            SpotifyPathInput.BackColor = Colors.GetBg(2);
            SpotifyPathInput.ForeColor = Colors.TxtLight;
            LaunchFlagsInput.BackColor = Colors.GetBg(2);
            LaunchFlagsInput.ForeColor = Colors.TxtLight;
            OverwriteAssetsChkBox.ForeColor = Colors.TxtLight;
            CheckSpicetifyUpgradeChkBox.ForeColor = Colors.TxtLight;
            InjectCssChkBox.ForeColor = Colors.TxtLight;
            ReplaceColorsChkBox.ForeColor = Colors.TxtLight;
            HomeConfigChkBox.ForeColor = Colors.TxtLight;
            SidebarConfigChkBox.ForeColor = Colors.TxtLight;
            DisableSentryChkBox.ForeColor = Colors.TxtLight;
            DisableUiLoggingChkBox.ForeColor = Colors.TxtLight;
            RemoveRtlRuleChkBox.ForeColor = Colors.TxtLight;
            ExposeApisChkBox.ForeColor = Colors.TxtLight;
            DisableUpgradeCheckChkBox.ForeColor = Colors.TxtLight;
            SaveBtn.BackColor = Colors.Primary;
            SaveBtn.ForeColor = Colors.TxtDark;
            ApplyBtn.BackColor = Colors.Primary;
            ApplyBtn.ForeColor = Colors.TxtDark;
            ConfigFileBtn.BackColor = Colors.Primary;
            ConfigFileBtn.ForeColor = Colors.TxtDark;
        }

        private void InitControls()
        {
            if(!_Spicetify.Detected)
                return;

            PrefsPathInput.Text = _Settings.PrefsPath;
            OverwriteAssetsChkBox.Checked = _Settings.OverwriteAssets;
            SpotifyPathInput.Text = _Settings.SpotifyPath;
            InjectCssChkBox.Checked = _Settings.InjectCss;
            ReplaceColorsChkBox.Checked = _Settings.ReplaceColors;
            LaunchFlagsInput.Text = _Settings.SpotifyLaunchFlags;

            DisableSentryChkBox.Checked = _Settings.DisableSentry;
            DisableUiLoggingChkBox.Checked = _Settings.DisableUiLogging;
            RemoveRtlRuleChkBox.Checked = _Settings.RemoveRtlRule;
            ExposeApisChkBox.Checked = _Settings.ExposeApis;
            DisableUpgradeCheckChkBox.Checked = _Settings.DisableUpgradeCheck;

            HomeConfigChkBox.Checked = _Settings.HomeConfig;
            SidebarConfigChkBox.Checked = _Settings.SidebarConfig;
        }

        private void ReadUserInput()
        {
            _Settings.PrefsPath = PrefsPathInput.Text;
            _Settings.OverwriteAssets = OverwriteAssetsChkBox.Checked;
            _Settings.CheckSpicetifyUpgrade = OverwriteAssetsChkBox.Checked;
            _Settings.SpotifyPath = SpotifyPathInput.Text;
            _Settings.InjectCss = InjectCssChkBox.Checked;
            _Settings.ReplaceColors = ReplaceColorsChkBox.Checked;
            _Settings.SpotifyLaunchFlags = LaunchFlagsInput.Text;

            _Settings.DisableSentry = DisableSentryChkBox.Checked;
            _Settings.DisableUiLogging = DisableUiLoggingChkBox.Checked;
            _Settings.RemoveRtlRule = RemoveRtlRuleChkBox.Checked;
            _Settings.ExposeApis = ExposeApisChkBox.Checked;
            _Settings.DisableUpgradeCheck = DisableUpgradeCheckChkBox.Checked;

            _Settings.HomeConfig = HomeConfigChkBox.Checked;
            _Settings.SidebarConfig = SidebarConfigChkBox.Checked;
        }


        private void SettingsForm_Load(object sender, EventArgs e)
        {
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(!_Spicetify.Detected)
                return;

            ReadUserInput();
            _Settings.SaveSettings();
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            if(!_Spicetify.Detected)
                return;

            ReadUserInput();
            _Settings.SaveSettings();
            _Spicetify.Apply();
        }

        private void ConfigFileBtn_Click(object sender, EventArgs e)
        {
            if(!_Spicetify.Detected)
                return;

            _Spicetify.OpenConfigFile();
        }
    }
}