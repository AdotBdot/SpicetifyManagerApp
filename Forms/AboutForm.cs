using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using SpicetifyManager.My;

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
            ManagerVer.Text = "1.0.0";

            if(!_Spicetify.DetectSpicetify())
                return;

            SpicetifyVer.Text = _Spicetify.Version;
            SpotifyVer.Text = _Settings.SpotifyVersion;
        }


        private void AboutForm_Load(object sender, EventArgs e)
        {
        }

        private void GithubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo SInfo = new ProcessStartInfo("https://github.com/AdotBdot/SpicetifyManagerApp");
            Process.Start(SInfo);
        }

        private void BugReportLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo SInfo = new ProcessStartInfo("https://github.com/AdotBdot/SpicetifyManagerApp/issues");
            Process.Start(SInfo);
        }

        private void IconsProviderLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo SInfo = new ProcessStartInfo("https://www.flaticon.com/");
            Process.Start(SInfo);
        }
    }
}