﻿using System;
using System.Windows.Forms;

namespace SpicetifyManager
{
    public partial class ManageForm : Form
    {
        public ManageForm(Spicetify spicetify)
        {
            _Spicetify = spicetify;
            InitializeComponent();
            LoadColors();
        }

        private Spicetify _Spicetify;

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
        }

        private void ManageForm_Load(object sender, EventArgs e)
        {
        }

        private void RestartBtn_Click(object sender, EventArgs e)
        {
            _Spicetify.Restart();
        }

        private void UpgradeBtn_Click(object sender, EventArgs e)
        {
            _Spicetify.Upgrade();
        }

        private void BackupBtn_Click(object sender, EventArgs e)
        {
            _Spicetify.Backup();
        }

        private void ClearBackupBtn_Click(object sender, EventArgs e)
        {
            _Spicetify.Clear();
        }

        //TODO: Restore Confirmation popup
        private void RestoreBtn_Click(object sender, EventArgs e)
        {
            _Spicetify.Restore();
        }
    }
}