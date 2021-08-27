using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using static SpicetifyManager.My;
using Version = SpicetifyManager.My.Version;

namespace SpicetifyManager
{
    public partial class AboutForm : Form
    {
        public AboutForm(Settings settings, Spicetify spicetify)
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


        private void LoadFonts()
        {
            Title.Font = new Font(Fonts.Pfc.Families[0], 18, FontStyle.Bold);
            label1.Font = new Font(Fonts.Pfc.Families[1], 12);
            label2.Font = new Font(Fonts.Pfc.Families[1], 12);
            label3.Font = new Font(Fonts.Pfc.Families[1], 12);
            label4.Font = new Font(Fonts.Pfc.Families[1], 12);
            label5.Font = new Font(Fonts.Pfc.Families[1], 12);
            label6.Font = new Font(Fonts.Pfc.Families[1], 12);
            VersionCheckLabel.Font = new Font(Fonts.Pfc.Families[1], 11);
            VersionCheckBtn.Font = new Font(Fonts.Pfc.Families[1], 10);
            ManagerVer.Font = new Font(Fonts.Pfc.Families[1], 12);
            SpicetifyVer.Font = new Font(Fonts.Pfc.Families[1], 12);
            SpotifyVer.Font = new Font(Fonts.Pfc.Families[1], 12);
            GithubLink.Font = new Font(Fonts.Pfc.Families[1], 12);
            BugReportLink.Font = new Font(Fonts.Pfc.Families[1], 12);
            IconsProviderLink.Font = new Font(Fonts.Pfc.Families[1], 12);
        }

        private void LoadColors()
        {
            this.BackColor = Colors.GetBg(0);
            Title.ForeColor = Colors.TxtLight;
            label1.ForeColor = Colors.TxtLight;
            label2.ForeColor = Colors.TxtLight;
            label3.ForeColor = Colors.TxtLight;
            label4.ForeColor = Colors.TxtLight;
            label5.ForeColor = Colors.TxtLight;
            label6.ForeColor = Colors.TxtLight;
            VersionCheckLabel.ForeColor = Colors.TxtLight;
            VersionCheckBtn.ForeColor = Colors.TxtDark;
            VersionCheckBtn.BackColor = Colors.Primary;
            ManagerVer.ForeColor = Colors.TxtLight;
            ManagerVer.BackColor = Colors.GetBg(1);
            SpicetifyVer.ForeColor = Colors.TxtLight;
            SpicetifyVer.BackColor = Colors.GetBg(1);
            SpotifyVer.ForeColor = Colors.TxtLight;
            SpotifyVer.BackColor = Colors.GetBg(1);
            GithubLink.LinkColor = Colors.Primary;
            GithubLink.BackColor = Colors.GetBg(1);
            BugReportLink.LinkColor = Colors.Primary;
            BugReportLink.BackColor = Colors.GetBg(1);
            IconsProviderLink.LinkColor = Colors.Primary;
            IconsProviderLink.BackColor = Colors.GetBg(1);
        }

        private void InitControls()
        {
            ManagerVer.Text = Version.CurrentVersion;

            if(!_Spicetify.Detected)
                return;

            SpicetifyVer.Text = _Spicetify.Version;

            if(_Settings.SpotifyVersion != string.Empty)
                SpotifyVer.Text = _Settings.SpotifyVersion;
            else
                SpotifyVer.Text = "0.0.0";
        }


        private void AboutForm_Load(object sender, EventArgs e)
        {
        }

        private void GithubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/AdotBdot/SpicetifyManagerApp");
            Process.Start(sInfo);
        }

        private void BugReportLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/AdotBdot/SpicetifyManagerApp/issues");
            Process.Start(sInfo);
        }

        private void IconsProviderLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.flaticon.com/");
            Process.Start(sInfo);
        }

        private async void VersionCheckBtn_Click(object sender, EventArgs e)
        {
            var text = await Version.GetVerCheckString();
            VersionCheckLabel.Text = text;
        }
    }
}