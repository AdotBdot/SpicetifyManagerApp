using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpicetifySettingsApp.Source
{
    public partial class ManageForm : Form
    {
        public ManageForm()
        {
            InitializeComponent();

            LoadFonts();
            LoadColors();
        }

        private void LoadFonts()
        {
            Title.Font = new Font(Fonts.Pfc.Families[0], 18, FontStyle.Bold);
            RestartBtn.Font = new Font(Fonts.Pfc.Families[1], 11.25f);
            UpgradeBtn.Font = new Font(Fonts.Pfc.Families[1], 11.25f);
            BackupBtn.Font = new Font(Fonts.Pfc.Families[1], 11.25f);
            ClearBackupBtn.Font = new Font(Fonts.Pfc.Families[1], 11.25f);
        }
        private void LoadColors()
        {
            this.BackColor = Colors.GetBg(0);
            Title.ForeColor = Colors.TxtLight;
            RestartBtn.BackColor = Colors.Primary;
            RestartBtn.ForeColor = Colors.TxtDark;
            UpgradeBtn.BackColor = Colors.Primary;
            UpgradeBtn.ForeColor = Colors.TxtDark;
            BackupBtn.BackColor = Colors.Primary;
            BackupBtn.ForeColor = Colors.TxtDark;
            ClearBackupBtn.BackColor = Colors.Primary;
            ClearBackupBtn.ForeColor = Colors.TxtDark;
            RestoreBtn.BackColor = Colors.Primary;
            RestoreBtn.ForeColor = Colors.TxtDark;
        }

        private void ManageForm_Load(object sender, EventArgs e)
        {
        }

        private void RestartBtn_Click(object sender, EventArgs e)
        {
            if(!StaticData.Spicetify.Detected)
                return;

            Task.Run(() => StaticData.Spicetify.Restart());
        }
        private void UpgradeBtn_Click(object sender, EventArgs e)
        {
            if(!StaticData.Spicetify.Detected)
                return;

            Task.Run(() => StaticData.Spicetify.Upgrade());
        }
        private void BackupBtn_Click(object sender, EventArgs e)
        {
            if(!StaticData.Spicetify.Detected)
                return;

            Task.Run(() => StaticData.Spicetify.Backup());
        }
        private void ClearBackupBtn_Click(object sender, EventArgs e)
        {
            if(!StaticData.Spicetify.Detected)
                return;

            DialogResult confirmResult = MessageBox.Show("Are you sure to clear backup?", "Confirmation", MessageBoxButtons.YesNo);

            if(confirmResult == DialogResult.Yes)
            {
                Task.Run(() => StaticData.Spicetify.Clear());
            }
        }
        private void RestoreBtn_Click(object sender, EventArgs e)
        {
            if(!StaticData.Spicetify.Detected)
                return;

            DialogResult confirmResult = MessageBox.Show("Are you sure to restore Spotify?", "Confirmation", MessageBoxButtons.YesNo);

            if(confirmResult == DialogResult.Yes)
            {
                Task.Run(() => StaticData.Spicetify.Restore());
            }
        }

        private void UpgradeBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Show("Upgrade Spicetify.", UpgradeBtn);
        }
        private void RestartBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Show("Restart Spotify.", RestartBtn);
        }
        private void BackupBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Show("Backup Spotify files.", BackupBtn);
        }
        private void ClearBackupBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Show("Clear backup.", ClearBackupBtn);
        }
        private void RestoreBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Show("Restore Spotify to it's original state.", RestoreBtn);
        }
    }
}