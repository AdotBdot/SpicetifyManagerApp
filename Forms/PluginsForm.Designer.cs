
namespace SpicetifyManager
{
    partial class PluginsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginsForm));
            this.CustomAppsFolderBtn = new System.Windows.Forms.Button();
            this.ApplyBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ExtensionsList = new System.Windows.Forms.CheckedListBox();
            this.CustomAppsList = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExtsFolderBtn = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Image = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // CustomAppsFolderBtn
            // 
            this.CustomAppsFolderBtn.FlatAppearance.BorderSize = 0;
            this.CustomAppsFolderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomAppsFolderBtn.Font = new System.Drawing.Font("Open Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomAppsFolderBtn.Location = new System.Drawing.Point(527, 416);
            this.CustomAppsFolderBtn.Margin = new System.Windows.Forms.Padding(7);
            this.CustomAppsFolderBtn.Name = "CustomAppsFolderBtn";
            this.CustomAppsFolderBtn.Size = new System.Drawing.Size(163, 31);
            this.CustomAppsFolderBtn.TabIndex = 39;
            this.CustomAppsFolderBtn.Text = "Custom Apps Folder";
            this.CustomAppsFolderBtn.UseVisualStyleBackColor = true;
            this.CustomAppsFolderBtn.Click += new System.EventHandler(this.CustomAppsFolderBtn_Click);
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.FlatAppearance.BorderSize = 0;
            this.ApplyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyBtn.Font = new System.Drawing.Font("Open Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyBtn.Location = new System.Drawing.Point(135, 416);
            this.ApplyBtn.Margin = new System.Windows.Forms.Padding(7);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(107, 31);
            this.ApplyBtn.TabIndex = 37;
            this.ApplyBtn.Text = "Apply";
            this.ApplyBtn.UseVisualStyleBackColor = true;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Open Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(14, 416);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(7);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(107, 31);
            this.SaveBtn.TabIndex = 36;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 40;
            this.label1.Text = "Extensions";
            // 
            // ExtensionsList
            // 
            this.ExtensionsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExtensionsList.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExtensionsList.FormattingEnabled = true;
            this.ExtensionsList.Location = new System.Drawing.Point(20, 91);
            this.ExtensionsList.Name = "ExtensionsList";
            this.ExtensionsList.Size = new System.Drawing.Size(190, 230);
            this.ExtensionsList.Sorted = true;
            this.ExtensionsList.TabIndex = 41;
            this.ExtensionsList.UseCompatibleTextRendering = true;
            // 
            // CustomAppsList
            // 
            this.CustomAppsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomAppsList.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomAppsList.FormattingEnabled = true;
            this.CustomAppsList.Location = new System.Drawing.Point(236, 91);
            this.CustomAppsList.Name = "CustomAppsList";
            this.CustomAppsList.Size = new System.Drawing.Size(190, 230);
            this.CustomAppsList.Sorted = true;
            this.CustomAppsList.TabIndex = 42;
            this.CustomAppsList.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 26);
            this.label2.TabIndex = 43;
            this.label2.Text = "Custom Apps";
            // 
            // ExtsFolderBtn
            // 
            this.ExtsFolderBtn.FlatAppearance.BorderSize = 0;
            this.ExtsFolderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExtsFolderBtn.Font = new System.Drawing.Font("Open Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtsFolderBtn.Location = new System.Drawing.Point(365, 416);
            this.ExtsFolderBtn.Margin = new System.Windows.Forms.Padding(7);
            this.ExtsFolderBtn.Name = "ExtsFolderBtn";
            this.ExtsFolderBtn.Size = new System.Drawing.Size(148, 31);
            this.ExtsFolderBtn.TabIndex = 44;
            this.ExtsFolderBtn.Text = "Extensions Folder";
            this.ExtsFolderBtn.UseVisualStyleBackColor = true;
            this.ExtsFolderBtn.Click += new System.EventHandler(this.ExtsFolderBtn_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(17, 14);
            this.Title.Margin = new System.Windows.Forms.Padding(14);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(102, 33);
            this.Title.TabIndex = 45;
            this.Title.Text = "Plugins";
            // 
            // Image
            // 
            this.Image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Image.BackgroundImage")));
            this.Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Image.Location = new System.Drawing.Point(607, 17);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(80, 70);
            this.Image.TabIndex = 47;
            // 
            // PluginsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(704, 461);
            this.Controls.Add(this.Image);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ExtsFolderBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustomAppsList);
            this.Controls.Add(this.ExtensionsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomAppsFolderBtn);
            this.Controls.Add(this.ApplyBtn);
            this.Controls.Add(this.SaveBtn);
            this.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PluginsForm";
            this.Padding = new System.Windows.Forms.Padding(14);
            this.Text = "PluginsForm";
            this.Load += new System.EventHandler(this.PluginsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CustomAppsFolderBtn;
        private System.Windows.Forms.Button ApplyBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox ExtensionsList;
        private System.Windows.Forms.CheckedListBox CustomAppsList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExtsFolderBtn;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel Image;
    }
}