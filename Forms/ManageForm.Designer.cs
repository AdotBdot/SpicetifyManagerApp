
namespace SpicetifyManager
{
    partial class ManageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageForm));
            this.Title = new System.Windows.Forms.Label();
            this.RestartBtn = new System.Windows.Forms.Button();
            this.UpgradeBtn = new System.Windows.Forms.Button();
            this.Image = new System.Windows.Forms.Panel();
            this.BackupBtn = new System.Windows.Forms.Button();
            this.ClearBackupBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Title.Location = new System.Drawing.Point(17, 14);
            this.Title.Margin = new System.Windows.Forms.Padding(14);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(110, 33);
            this.Title.TabIndex = 45;
            this.Title.Text = "Manage";
            // 
            // RestartBtn
            // 
            this.RestartBtn.FlatAppearance.BorderSize = 0;
            this.RestartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestartBtn.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RestartBtn.Location = new System.Drawing.Point(23, 64);
            this.RestartBtn.Margin = new System.Windows.Forms.Padding(7);
            this.RestartBtn.Name = "RestartBtn";
            this.RestartBtn.Size = new System.Drawing.Size(157, 38);
            this.RestartBtn.TabIndex = 47;
            this.RestartBtn.Text = "Restart Spotify";
            this.RestartBtn.UseVisualStyleBackColor = true;
            this.RestartBtn.Click += new System.EventHandler(this.RestartBtn_Click);
            // 
            // UpgradeBtn
            // 
            this.UpgradeBtn.FlatAppearance.BorderSize = 0;
            this.UpgradeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpgradeBtn.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpgradeBtn.Location = new System.Drawing.Point(23, 116);
            this.UpgradeBtn.Margin = new System.Windows.Forms.Padding(7);
            this.UpgradeBtn.Name = "UpgradeBtn";
            this.UpgradeBtn.Size = new System.Drawing.Size(157, 38);
            this.UpgradeBtn.TabIndex = 48;
            this.UpgradeBtn.Text = "Upgrade";
            this.UpgradeBtn.UseVisualStyleBackColor = true;
            this.UpgradeBtn.Click += new System.EventHandler(this.UpgradeBtn_Click);
            // 
            // Image
            // 
            this.Image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Image.BackgroundImage")));
            this.Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Image.Location = new System.Drawing.Point(607, 17);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(80, 80);
            this.Image.TabIndex = 49;
            // 
            // BackupBtn
            // 
            this.BackupBtn.FlatAppearance.BorderSize = 0;
            this.BackupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackupBtn.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BackupBtn.Location = new System.Drawing.Point(23, 168);
            this.BackupBtn.Margin = new System.Windows.Forms.Padding(7);
            this.BackupBtn.Name = "BackupBtn";
            this.BackupBtn.Size = new System.Drawing.Size(157, 38);
            this.BackupBtn.TabIndex = 50;
            this.BackupBtn.Text = "Backup";
            this.BackupBtn.UseVisualStyleBackColor = true;
            this.BackupBtn.Click += new System.EventHandler(this.BackupBtn_Click);
            // 
            // ClearBackupBtn
            // 
            this.ClearBackupBtn.FlatAppearance.BorderSize = 0;
            this.ClearBackupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBackupBtn.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClearBackupBtn.Location = new System.Drawing.Point(23, 220);
            this.ClearBackupBtn.Margin = new System.Windows.Forms.Padding(7);
            this.ClearBackupBtn.Name = "ClearBackupBtn";
            this.ClearBackupBtn.Size = new System.Drawing.Size(157, 38);
            this.ClearBackupBtn.TabIndex = 51;
            this.ClearBackupBtn.Text = "Clear Backup";
            this.ClearBackupBtn.UseVisualStyleBackColor = true;
            this.ClearBackupBtn.Click += new System.EventHandler(this.ClearBackupBtn_Click);
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 461);
            this.Controls.Add(this.ClearBackupBtn);
            this.Controls.Add(this.BackupBtn);
            this.Controls.Add(this.Image);
            this.Controls.Add(this.UpgradeBtn);
            this.Controls.Add(this.RestartBtn);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageForm";
            this.Padding = new System.Windows.Forms.Padding(14);
            this.Text = "Manage";
            this.Load += new System.EventHandler(this.ManageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button RestartBtn;
        private System.Windows.Forms.Button UpgradeBtn;
        private System.Windows.Forms.Panel Image;
        private System.Windows.Forms.Button BackupBtn;
        private System.Windows.Forms.Button ClearBackupBtn;
    }
}