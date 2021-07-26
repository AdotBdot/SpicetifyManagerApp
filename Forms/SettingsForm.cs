using System;
using System.Windows.Forms;

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
            InitControls();
        }

        private Settings _Settings;
        private Spicetify _Spicetify;

        public void Reload()
        {
            _Settings.LoadConfig();
            InitControls();
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

        private void InitControls()
        {
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


        private void SettingsForm_Load(object sender, EventArgs e)
        {
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            ReadUserInput();
            _Settings.SaveSettings();
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            ReadUserInput();
            _Settings.SaveSettings();
            _Spicetify.Apply();
        }

        private void ConfigFileBtn_Click(object sender, EventArgs e)
        {
            _Spicetify.OpenConfigFile();
        }
    }
}