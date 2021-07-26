using System;
using System.Windows.Forms;

namespace SpicetifyManager
{
    public partial class AboutForm : Form
    {
        public AboutForm(Settings settings, Spicetify spicetify)
        {
            _Settings = settings;
            _Spicetify = spicetify;
            InitializeComponent();
            LoadColors();
            InitControls();
        }

        private Settings _Settings;
        private Spicetify _Spicetify;


        private void InitControls()
        {
            ManagerVer.Text = "1.0";
            SpicetifyVer.Text = _Spicetify.Version;
            SpotifyVer.Text = _Settings.SpotifyVersion;
        }

        private void LoadColors()
        {
            this.BackColor = Colors.GetBg(0);
            Title.ForeColor = Colors.TxtLight;
            label1.ForeColor = Colors.TxtLight;
            label2.ForeColor = Colors.TxtLight;
            label3.ForeColor = Colors.TxtLight;
            ManagerVer.ForeColor = Colors.TxtLight;
            ManagerVer.BackColor = Colors.GetBg(1);
            SpicetifyVer.ForeColor = Colors.TxtLight;
            SpicetifyVer.BackColor = Colors.GetBg(1);
            SpotifyVer.ForeColor = Colors.TxtLight;
            SpotifyVer.BackColor = Colors.GetBg(1);
        }


        private void AboutForm_Load(object sender, EventArgs e)
        {
        }
    }
}