
namespace SpicetifyManager
{
    partial class ThemesForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemesForm));
            this.label4 = new System.Windows.Forms.Label();
            this.ColorsDropdown = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ThemesDropdown = new System.Windows.Forms.ComboBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ApplyBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.ThemeFolderBtn = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Image = new System.Windows.Forms.Panel();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 26);
            this.label4.TabIndex = 31;
            this.label4.Text = "Color Scheme";
            // 
            // ColorsDropdown
            // 
            this.ColorsDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorsDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorsDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorsDropdown.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorsDropdown.FormattingEnabled = true;
            this.ColorsDropdown.Location = new System.Drawing.Point(23, 155);
            this.ColorsDropdown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ColorsDropdown.Name = "ColorsDropdown";
            this.ColorsDropdown.Size = new System.Drawing.Size(220, 28);
            this.ColorsDropdown.Sorted = true;
            this.ColorsDropdown.TabIndex = 30;
            this.ColorsDropdown.MouseHover += new System.EventHandler(this.ColorsDropdown_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 26);
            this.label3.TabIndex = 29;
            this.label3.Text = "Theme";
            // 
            // ThemesDropdown
            // 
            this.ThemesDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThemesDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ThemesDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThemesDropdown.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemesDropdown.FormattingEnabled = true;
            this.ThemesDropdown.Location = new System.Drawing.Point(22, 87);
            this.ThemesDropdown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ThemesDropdown.Name = "ThemesDropdown";
            this.ThemesDropdown.Size = new System.Drawing.Size(220, 28);
            this.ThemesDropdown.Sorted = true;
            this.ThemesDropdown.TabIndex = 28;
            this.ThemesDropdown.SelectedIndexChanged += new System.EventHandler(this.CurrentThemeBox_SelectedIndexChanged);
            this.ThemesDropdown.MouseHover += new System.EventHandler(this.ThemesDropdown_MouseHover);
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
            this.SaveBtn.TabIndex = 32;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            this.SaveBtn.MouseHover += new System.EventHandler(this.SaveBtn_MouseHover);
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
            this.ApplyBtn.TabIndex = 33;
            this.ApplyBtn.Text = "Apply";
            this.ApplyBtn.UseVisualStyleBackColor = true;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            this.ApplyBtn.MouseHover += new System.EventHandler(this.ApplyBtn_MouseHover);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Open Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(256, 416);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(7);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(107, 31);
            this.UpdateBtn.TabIndex = 34;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            this.UpdateBtn.MouseHover += new System.EventHandler(this.UpdateBtn_MouseHover);
            // 
            // ThemeFolderBtn
            // 
            this.ThemeFolderBtn.FlatAppearance.BorderSize = 0;
            this.ThemeFolderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThemeFolderBtn.Font = new System.Drawing.Font("Open Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemeFolderBtn.Location = new System.Drawing.Point(573, 416);
            this.ThemeFolderBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ThemeFolderBtn.Name = "ThemeFolderBtn";
            this.ThemeFolderBtn.Size = new System.Drawing.Size(117, 31);
            this.ThemeFolderBtn.TabIndex = 35;
            this.ThemeFolderBtn.Text = "Theme Folder";
            this.ThemeFolderBtn.UseVisualStyleBackColor = true;
            this.ThemeFolderBtn.Click += new System.EventHandler(this.ThemeFolderBtn_Click);
            this.ThemeFolderBtn.MouseHover += new System.EventHandler(this.ThemeFolderBtn_MouseHover);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(17, 14);
            this.Title.Margin = new System.Windows.Forms.Padding(14);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(109, 33);
            this.Title.TabIndex = 45;
            this.Title.Text = "Themes";
            // 
            // Image
            // 
            this.Image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Image.BackgroundImage")));
            this.Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Image.Location = new System.Drawing.Point(607, 17);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(80, 80);
            this.Image.TabIndex = 46;
            // 
            // ThemesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 461);
            this.Controls.Add(this.Image);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ThemeFolderBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.ColorsDropdown);
            this.Controls.Add(this.ThemesDropdown);
            this.Controls.Add(this.ApplyBtn);
            this.Controls.Add(this.SaveBtn);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ThemesForm";
            this.Padding = new System.Windows.Forms.Padding(14);
            this.Text = "ThemesForm";
            this.Load += new System.EventHandler(this.ThemesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ColorsDropdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ThemesDropdown;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button ApplyBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button ThemeFolderBtn;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel Image;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}