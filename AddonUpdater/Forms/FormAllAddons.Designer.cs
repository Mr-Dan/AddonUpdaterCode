
namespace AddonUpdater.Forms
{
    partial class FormAllAddons
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
            if (disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAllAddons));
            this.button_update = new System.Windows.Forms.Button();
            this.buttonLauncher = new System.Windows.Forms.Button();
            this.PanelDescription = new System.Windows.Forms.Panel();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.panelAddon = new System.Windows.Forms.Panel();
            this.buttonGitHub = new System.Windows.Forms.Button();
            this.buttonForum = new System.Windows.Forms.Button();
            this.buttonReportBug = new System.Windows.Forms.Button();
            this.buttonInstall = new System.Windows.Forms.Button();
            this.panelAddonsViewTitle = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTitleName = new System.Windows.Forms.Label();
            this.panelAddonsView = new System.Windows.Forms.Panel();
            this.PanelDescription.SuspendLayout();
            this.panelAddon.SuspendLayout();
            this.panelAddonsViewTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.button_update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_update.BackgroundImage")));
            this.button_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_update.FlatAppearance.BorderSize = 0;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Location = new System.Drawing.Point(730, 430);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(50, 40);
            this.button_update.TabIndex = 23;
            this.button_update.TabStop = false;
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // buttonLauncher
            // 
            this.buttonLauncher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.buttonLauncher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLauncher.BackgroundImage")));
            this.buttonLauncher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLauncher.FlatAppearance.BorderSize = 0;
            this.buttonLauncher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLauncher.ForeColor = System.Drawing.Color.White;
            this.buttonLauncher.Location = new System.Drawing.Point(670, 430);
            this.buttonLauncher.Name = "buttonLauncher";
            this.buttonLauncher.Size = new System.Drawing.Size(50, 40);
            this.buttonLauncher.TabIndex = 24;
            this.buttonLauncher.TabStop = false;
            this.buttonLauncher.UseVisualStyleBackColor = false;
            this.buttonLauncher.Click += new System.EventHandler(this.buttonLauncher_Click);
            // 
            // PanelDescription
            // 
            this.PanelDescription.Controls.Add(this.LabelDescription);
            this.PanelDescription.ForeColor = System.Drawing.Color.White;
            this.PanelDescription.Location = new System.Drawing.Point(5, 469);
            this.PanelDescription.MaximumSize = new System.Drawing.Size(800, 200);
            this.PanelDescription.Name = "PanelDescription";
            this.PanelDescription.Size = new System.Drawing.Size(800, 15);
            this.PanelDescription.TabIndex = 25;
            this.PanelDescription.Visible = false;
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoEllipsis = true;
            this.LabelDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDescription.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelDescription.Location = new System.Drawing.Point(0, 0);
            this.LabelDescription.MaximumSize = new System.Drawing.Size(800, 500);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(800, 15);
            this.LabelDescription.TabIndex = 1;
            // 
            // panelAddon
            // 
            this.panelAddon.Controls.Add(this.buttonGitHub);
            this.panelAddon.Controls.Add(this.buttonForum);
            this.panelAddon.Controls.Add(this.buttonReportBug);
            this.panelAddon.Controls.Add(this.buttonInstall);
            this.panelAddon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panelAddon.Location = new System.Drawing.Point(236, 431);
            this.panelAddon.MaximumSize = new System.Drawing.Size(140, 160);
            this.panelAddon.Name = "panelAddon";
            this.panelAddon.Size = new System.Drawing.Size(140, 160);
            this.panelAddon.TabIndex = 24;
            this.panelAddon.Visible = false;
            // 
            // buttonGitHub
            // 
            this.buttonGitHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.buttonGitHub.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGitHub.FlatAppearance.BorderSize = 0;
            this.buttonGitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGitHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGitHub.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGitHub.Location = new System.Drawing.Point(0, 120);
            this.buttonGitHub.Name = "buttonGitHub";
            this.buttonGitHub.Size = new System.Drawing.Size(140, 40);
            this.buttonGitHub.TabIndex = 7;
            this.buttonGitHub.TabStop = false;
            this.buttonGitHub.Text = "GitHub";
            this.buttonGitHub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGitHub.UseVisualStyleBackColor = false;
            this.buttonGitHub.Click += new System.EventHandler(this.buttonGitHub_Click);
            // 
            // buttonForum
            // 
            this.buttonForum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.buttonForum.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonForum.FlatAppearance.BorderSize = 0;
            this.buttonForum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonForum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonForum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonForum.Location = new System.Drawing.Point(0, 80);
            this.buttonForum.Name = "buttonForum";
            this.buttonForum.Size = new System.Drawing.Size(140, 40);
            this.buttonForum.TabIndex = 6;
            this.buttonForum.TabStop = false;
            this.buttonForum.Text = "Форум";
            this.buttonForum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonForum.UseVisualStyleBackColor = false;
            this.buttonForum.Click += new System.EventHandler(this.buttonForum_Click);
            // 
            // buttonReportBug
            // 
            this.buttonReportBug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.buttonReportBug.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReportBug.FlatAppearance.BorderSize = 0;
            this.buttonReportBug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReportBug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReportBug.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonReportBug.Location = new System.Drawing.Point(0, 40);
            this.buttonReportBug.Name = "buttonReportBug";
            this.buttonReportBug.Size = new System.Drawing.Size(140, 40);
            this.buttonReportBug.TabIndex = 5;
            this.buttonReportBug.TabStop = false;
            this.buttonReportBug.Text = "Сообщить о баге";
            this.buttonReportBug.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReportBug.UseVisualStyleBackColor = false;
            this.buttonReportBug.Click += new System.EventHandler(this.buttonReportBug_Click);
            // 
            // buttonInstall
            // 
            this.buttonInstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.buttonInstall.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonInstall.FlatAppearance.BorderSize = 0;
            this.buttonInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInstall.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonInstall.Location = new System.Drawing.Point(0, 0);
            this.buttonInstall.Name = "buttonInstall";
            this.buttonInstall.Size = new System.Drawing.Size(140, 40);
            this.buttonInstall.TabIndex = 3;
            this.buttonInstall.TabStop = false;
            this.buttonInstall.Text = "Скачать";
            this.buttonInstall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInstall.UseVisualStyleBackColor = false;
            this.buttonInstall.Click += new System.EventHandler(this.buttonInstall_Click);
            // 
            // panelAddonsViewTitle
            // 
            this.panelAddonsViewTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(130)))), ((int)(((byte)(159)))));
            this.panelAddonsViewTitle.Controls.Add(this.label3);
            this.panelAddonsViewTitle.Controls.Add(this.label2);
            this.panelAddonsViewTitle.Controls.Add(this.label1);
            this.panelAddonsViewTitle.Controls.Add(this.labelTitleName);
            this.panelAddonsViewTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddonsViewTitle.Location = new System.Drawing.Point(0, 0);
            this.panelAddonsViewTitle.Name = "panelAddonsViewTitle";
            this.panelAddonsViewTitle.Size = new System.Drawing.Size(800, 40);
            this.panelAddonsViewTitle.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(600, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "Автор";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(420, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Категория";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(280, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Версия";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitleName
            // 
            this.labelTitleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitleName.ForeColor = System.Drawing.Color.White;
            this.labelTitleName.Location = new System.Drawing.Point(0, 0);
            this.labelTitleName.Name = "labelTitleName";
            this.labelTitleName.Size = new System.Drawing.Size(280, 40);
            this.labelTitleName.TabIndex = 1;
            this.labelTitleName.Text = "Название";
            this.labelTitleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAddonsView
            // 
            this.panelAddonsView.BackColor = System.Drawing.Color.LightGray;
            this.panelAddonsView.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddonsView.Location = new System.Drawing.Point(0, 40);
            this.panelAddonsView.Margin = new System.Windows.Forms.Padding(0);
            this.panelAddonsView.MaximumSize = new System.Drawing.Size(800, 380);
            this.panelAddonsView.Name = "panelAddonsView";
            this.panelAddonsView.Size = new System.Drawing.Size(800, 380);
            this.panelAddonsView.TabIndex = 27;
            // 
            // FormAllAddons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.panelAddon);
            this.Controls.Add(this.PanelDescription);
            this.Controls.Add(this.panelAddonsView);
            this.Controls.Add(this.panelAddonsViewTitle);
            this.Controls.Add(this.buttonLauncher);
            this.Controls.Add(this.button_update);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAllAddons";
            this.Text = "Все аддоны";
            this.Load += new System.EventHandler(this.FormAllAddons_Load);
            this.PanelDescription.ResumeLayout(false);
            this.panelAddon.ResumeLayout(false);
            this.panelAddonsViewTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button buttonLauncher;
        private System.Windows.Forms.Panel PanelDescription;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.Panel panelAddon;
        public System.Windows.Forms.Button buttonGitHub;
        public System.Windows.Forms.Button buttonForum;
        public System.Windows.Forms.Button buttonReportBug;
        public System.Windows.Forms.Button buttonInstall;
        private System.Windows.Forms.Panel panelAddonsViewTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTitleName;
        private System.Windows.Forms.Panel panelAddonsView;
    }
}