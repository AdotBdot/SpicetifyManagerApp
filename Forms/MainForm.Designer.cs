
namespace SpicetifyManager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.NavBar = new System.Windows.Forms.Panel();
            this.ToogleConsoleBtn = new System.Windows.Forms.Button();
            this.ReloadButton = new System.Windows.Forms.Button();
            this.WarningIcon = new System.Windows.Forms.Panel();
            this.PluginsButton = new System.Windows.Forms.Button();
            this.ThemesButton = new System.Windows.Forms.Button();
            this.ManageButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ChildFormPanel = new System.Windows.Forms.Panel();
            this.WarningToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ToogleConsoleToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ReloadTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.NavBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavBar
            // 
            this.NavBar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NavBar.Controls.Add(this.ToogleConsoleBtn);
            this.NavBar.Controls.Add(this.ReloadButton);
            this.NavBar.Controls.Add(this.WarningIcon);
            this.NavBar.Controls.Add(this.PluginsButton);
            this.NavBar.Controls.Add(this.ThemesButton);
            this.NavBar.Controls.Add(this.ManageButton);
            this.NavBar.Controls.Add(this.AboutButton);
            this.NavBar.Controls.Add(this.SettingsButton);
            this.NavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavBar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.NavBar.Location = new System.Drawing.Point(0, 0);
            this.NavBar.Margin = new System.Windows.Forms.Padding(0);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(150, 461);
            this.NavBar.TabIndex = 0;
            // 
            // ToogleConsoleBtn
            // 
            this.ToogleConsoleBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ToogleConsoleBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ToogleConsoleBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ToogleConsoleBtn.BackgroundImage")));
            this.ToogleConsoleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ToogleConsoleBtn.FlatAppearance.BorderSize = 0;
            this.ToogleConsoleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToogleConsoleBtn.Location = new System.Drawing.Point(55, 420);
            this.ToogleConsoleBtn.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ToogleConsoleBtn.Name = "ToogleConsoleBtn";
            this.ToogleConsoleBtn.Size = new System.Drawing.Size(40, 40);
            this.ToogleConsoleBtn.TabIndex = 6;
            this.ToogleConsoleBtn.UseVisualStyleBackColor = false;
            this.ToogleConsoleBtn.Click += new System.EventHandler(this.ToogleConsoleBtn_Click);
            this.ToogleConsoleBtn.MouseHover += new System.EventHandler(this.ToogleConsoleBtn_MouseHover);
            // 
            // ReloadButton
            // 
            this.ReloadButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ReloadButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReloadButton.BackgroundImage")));
            this.ReloadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReloadButton.FlatAppearance.BorderSize = 0;
            this.ReloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReloadButton.Location = new System.Drawing.Point(107, 418);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(40, 40);
            this.ReloadButton.TabIndex = 5;
            this.ReloadButton.UseVisualStyleBackColor = false;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            this.ReloadButton.MouseHover += new System.EventHandler(this.ReloadButton_MouseHover);
            // 
            // WarningIcon
            // 
            this.WarningIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WarningIcon.BackgroundImage")));
            this.WarningIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WarningIcon.Location = new System.Drawing.Point(3, 418);
            this.WarningIcon.Name = "WarningIcon";
            this.WarningIcon.Size = new System.Drawing.Size(40, 40);
            this.WarningIcon.TabIndex = 0;
            this.WarningIcon.MouseHover += new System.EventHandler(this.WarningIcon_MouseHover);
            // 
            // PluginsButton
            // 
            this.PluginsButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PluginsButton.FlatAppearance.BorderSize = 0;
            this.PluginsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PluginsButton.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PluginsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PluginsButton.Location = new System.Drawing.Point(0, 50);
            this.PluginsButton.Name = "PluginsButton";
            this.PluginsButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.PluginsButton.Size = new System.Drawing.Size(150, 50);
            this.PluginsButton.TabIndex = 4;
            this.PluginsButton.Text = "Plugins";
            this.PluginsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PluginsButton.UseVisualStyleBackColor = false;
            this.PluginsButton.Click += new System.EventHandler(this.PluginsButton_Click);
            // 
            // ThemesButton
            // 
            this.ThemesButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ThemesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ThemesButton.FlatAppearance.BorderSize = 0;
            this.ThemesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThemesButton.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ThemesButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ThemesButton.Location = new System.Drawing.Point(0, 0);
            this.ThemesButton.Name = "ThemesButton";
            this.ThemesButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.ThemesButton.Size = new System.Drawing.Size(150, 50);
            this.ThemesButton.TabIndex = 3;
            this.ThemesButton.Text = "Themes";
            this.ThemesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThemesButton.UseVisualStyleBackColor = false;
            this.ThemesButton.Click += new System.EventHandler(this.ThemesButton_Click);
            // 
            // ManageButton
            // 
            this.ManageButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ManageButton.FlatAppearance.BorderSize = 0;
            this.ManageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageButton.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ManageButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ManageButton.Location = new System.Drawing.Point(0, 150);
            this.ManageButton.Name = "ManageButton";
            this.ManageButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.ManageButton.Size = new System.Drawing.Size(150, 50);
            this.ManageButton.TabIndex = 0;
            this.ManageButton.Text = "Manage";
            this.ManageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageButton.UseVisualStyleBackColor = false;
            this.ManageButton.Click += new System.EventHandler(this.ManageButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AboutButton.FlatAppearance.BorderSize = 0;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AboutButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AboutButton.Location = new System.Drawing.Point(0, 200);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.AboutButton.Size = new System.Drawing.Size(150, 50);
            this.AboutButton.TabIndex = 2;
            this.AboutButton.Text = "About";
            this.AboutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SettingsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SettingsButton.Location = new System.Drawing.Point(0, 100);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.SettingsButton.Size = new System.Drawing.Size(150, 50);
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ChildFormPanel
            // 
            this.ChildFormPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ChildFormPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChildFormPanel.BackgroundImage")));
            this.ChildFormPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChildFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildFormPanel.Location = new System.Drawing.Point(150, 0);
            this.ChildFormPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ChildFormPanel.Name = "ChildFormPanel";
            this.ChildFormPanel.Size = new System.Drawing.Size(704, 461);
            this.ChildFormPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(854, 461);
            this.Controls.Add(this.ChildFormPanel);
            this.Controls.Add(this.NavBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Spicetify Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.NavBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavBar;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Panel ChildFormPanel;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button ManageButton;
        private System.Windows.Forms.Button PluginsButton;
        private System.Windows.Forms.Button ThemesButton;
        private System.Windows.Forms.Button ReloadButton;
        private System.Windows.Forms.Panel WarningIcon;
        private System.Windows.Forms.ToolTip WarningToolTip;
        private System.Windows.Forms.Button ToogleConsoleBtn;
        private System.Windows.Forms.ToolTip ToogleConsoleToolTip;
        private System.Windows.Forms.ToolTip ReloadTooltip;
    }
}