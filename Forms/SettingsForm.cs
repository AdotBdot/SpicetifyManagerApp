using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpicetifyManager.My;

namespace SpicetifyManager
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            LoadColors();
            LoadFonts();

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
            ExperimentalFeaturesChkBox.Font = new Font(Fonts.Pfc.Families[1], 12);
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
            ExperimentalFeaturesChkBox.ForeColor = Colors.TxtLight;
            SaveBtn.BackColor = Colors.Primary;
            SaveBtn.ForeColor = Colors.TxtDark;
            ApplyBtn.BackColor = Colors.Primary;
            ApplyBtn.ForeColor = Colors.TxtDark;
            ConfigFileBtn.BackColor = Colors.Primary;
            ConfigFileBtn.ForeColor = Colors.TxtDark;
        }
        private void InitControls()
        {
            if(!StaticData.Spicetify.Detected)
                return;

            PrefsPathInput.Text = StaticData.Settings.PrefsPath;
            OverwriteAssetsChkBox.Checked = StaticData.Settings.OverwriteAssets;
            SpotifyPathInput.Text = StaticData.Settings.SpotifyPath;
            InjectCssChkBox.Checked = StaticData.Settings.InjectCss;
            ReplaceColorsChkBox.Checked = StaticData.Settings.ReplaceColors;
            LaunchFlagsInput.Text = StaticData.Settings.SpotifyLaunchFlags;

            DisableSentryChkBox.Checked = StaticData.Settings.DisableSentry;
            DisableUiLoggingChkBox.Checked = StaticData.Settings.DisableUiLogging;
            RemoveRtlRuleChkBox.Checked = StaticData.Settings.RemoveRtlRule;
            ExposeApisChkBox.Checked = StaticData.Settings.ExposeApis;
            DisableUpgradeCheckChkBox.Checked = StaticData.Settings.DisableUpgradeCheck;

            HomeConfigChkBox.Checked = StaticData.Settings.HomeConfig;
            SidebarConfigChkBox.Checked = StaticData.Settings.SidebarConfig;
            ExperimentalFeaturesChkBox.Checked = StaticData.Settings.ExperimentalFeatures;
        }
        private void ReadUserInput()
        {
            StaticData.Settings.PrefsPath = PrefsPathInput.Text;
            StaticData.Settings.OverwriteAssets = OverwriteAssetsChkBox.Checked;
            StaticData.Settings.CheckSpicetifyUpgrade = OverwriteAssetsChkBox.Checked;
            StaticData.Settings.SpotifyPath = SpotifyPathInput.Text;
            StaticData.Settings.InjectCss = InjectCssChkBox.Checked;
            StaticData.Settings.ReplaceColors = ReplaceColorsChkBox.Checked;
            StaticData.Settings.SpotifyLaunchFlags = LaunchFlagsInput.Text;

            StaticData.Settings.DisableSentry = DisableSentryChkBox.Checked;
            StaticData.Settings.DisableUiLogging = DisableUiLoggingChkBox.Checked;
            StaticData.Settings.RemoveRtlRule = RemoveRtlRuleChkBox.Checked;
            StaticData.Settings.ExposeApis = ExposeApisChkBox.Checked;
            StaticData.Settings.DisableUpgradeCheck = DisableUpgradeCheckChkBox.Checked;

            StaticData.Settings.HomeConfig = HomeConfigChkBox.Checked;
            StaticData.Settings.SidebarConfig = SidebarConfigChkBox.Checked;
            StaticData.Settings.ExperimentalFeatures = ExperimentalFeaturesChkBox.Checked;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(!StaticData.Spicetify.Detected)
                return;

            ReadUserInput();
            StaticData.Settings.SaveSettings();
        }
        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            if(!StaticData.Spicetify.Detected)
                return;

            ReadUserInput();
            StaticData.Settings.SaveSettings();
            Task.Run(() => StaticData.Spicetify.Apply());
        }
        private void ConfigFileBtn_Click(object sender, EventArgs e)
        {
            if(!StaticData.Spicetify.Detected)
                return;

            StaticData.Spicetify.OpenConfigFile();
        }

        private void LaunchFlagsInput_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Show("Spotify launch flags.", LaunchFlagsInput);
        }
        private void label3_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Show("Spotify launch flags", label3);
        }
        private void ConfigFileBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Show("Open config file in text editor.", ConfigFileBtn);
        }
        private void SpotifyPathInput_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Show("Path to spotify executable.", SpotifyPathInput);
        }
        private void label2_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Show("Path to spotify executable.", label2);
        }
        private void label1_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Show("Path to spotify prefs.", label1);
        }
        private void PrefsPathInput_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Show("Path to spotify prefs.", PrefsPathInput);
        }
        private void SaveBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Show("Save settings.", SaveBtn);
        }
        private void ApplyBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Show("Apply current config.", ApplyBtn);
        }
        private void ExperimentalFeaturesChkBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Show("Enable ability to activate unfinished or work-in-progress features that would eventually be released in future Spotify updates.",ExperimentalFeaturesChkBox);
        }
    }
}