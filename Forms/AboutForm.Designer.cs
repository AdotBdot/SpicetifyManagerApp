
namespace SpicetifyManager
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.ManagerVer = new System.Windows.Forms.Label();
            this.SpicetifyVer = new System.Windows.Forms.Label();
            this.SpotifyVer = new System.Windows.Forms.Label();
            this.Image = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 22);
            this.label1.TabIndex = 41;
            this.label1.Text = "Manager Version";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 22);
            this.label2.TabIndex = 42;
            this.label2.Text = "Spicetify Version";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 22);
            this.label3.TabIndex = 43;
            this.label3.Text = "Spotify Version";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Title.Location = new System.Drawing.Point(17, 14);
            this.Title.Margin = new System.Windows.Forms.Padding(14);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(88, 33);
            this.Title.TabIndex = 44;
            this.Title.Text = "About";
            // 
            // ManagerVer
            // 
            this.ManagerVer.AutoSize = true;
            this.ManagerVer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ManagerVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManagerVer.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerVer.Location = new System.Drawing.Point(208, 61);
            this.ManagerVer.Name = "ManagerVer";
            this.ManagerVer.Size = new System.Drawing.Size(47, 24);
            this.ManagerVer.TabIndex = 45;
            this.ManagerVer.Text = "0.0.0";
            // 
            // SpicetifyVer
            // 
            this.SpicetifyVer.AutoSize = true;
            this.SpicetifyVer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpicetifyVer.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpicetifyVer.Location = new System.Drawing.Point(208, 87);
            this.SpicetifyVer.Name = "SpicetifyVer";
            this.SpicetifyVer.Size = new System.Drawing.Size(47, 24);
            this.SpicetifyVer.TabIndex = 46;
            this.SpicetifyVer.Text = "0.0.0";
            // 
            // SpotifyVer
            // 
            this.SpotifyVer.AutoSize = true;
            this.SpotifyVer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpotifyVer.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpotifyVer.Location = new System.Drawing.Point(208, 113);
            this.SpotifyVer.Name = "SpotifyVer";
            this.SpotifyVer.Size = new System.Drawing.Size(47, 24);
            this.SpotifyVer.TabIndex = 47;
            this.SpotifyVer.Text = "0.0.0";
            // 
            // Image
            // 
            this.Image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Image.BackgroundImage")));
            this.Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Image.Location = new System.Drawing.Point(607, 17);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(80, 80);
            this.Image.TabIndex = 55;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 461);
            this.Controls.Add(this.Image);
            this.Controls.Add(this.SpotifyVer);
            this.Controls.Add(this.SpicetifyVer);
            this.Controls.Add(this.ManagerVer);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AboutForm";
            this.Padding = new System.Windows.Forms.Padding(14);
            this.Text = "AboutForm";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label ManagerVer;
        private System.Windows.Forms.Label SpicetifyVer;
        private System.Windows.Forms.Label SpotifyVer;
        private System.Windows.Forms.Panel Image;
    }
}