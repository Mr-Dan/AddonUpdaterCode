
namespace AddonUpdater
{
    partial class FormMainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.buttonAllAddons = new System.Windows.Forms.Button();
            this.buttonAddons = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitleName = new System.Windows.Forms.Label();
            this.button_Resize = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.labelVersion = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.labelMainName = new System.Windows.Forms.Label();
            this.timerKill = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelInfo = new System.Windows.Forms.Label();
            this.panelTitleBar.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelDesktopPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAllAddons
            // 
            this.buttonAllAddons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.buttonAllAddons.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAllAddons.FlatAppearance.BorderSize = 0;
            this.buttonAllAddons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAllAddons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAllAddons.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAllAddons.Location = new System.Drawing.Point(0, 60);
            this.buttonAllAddons.Name = "buttonAllAddons";
            this.buttonAllAddons.Size = new System.Drawing.Size(200, 60);
            this.buttonAllAddons.TabIndex = 3;
            this.buttonAllAddons.TabStop = false;
            this.buttonAllAddons.Text = "           Все аддоны";
            this.buttonAllAddons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAllAddons.UseVisualStyleBackColor = false;
            this.buttonAllAddons.Visible = false;
            this.buttonAllAddons.Click += new System.EventHandler(this.buttonAllAddons_Click);
            // 
            // buttonAddons
            // 
            this.buttonAddons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.buttonAddons.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddons.FlatAppearance.BorderSize = 0;
            this.buttonAddons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddons.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddons.Location = new System.Drawing.Point(0, 0);
            this.buttonAddons.Name = "buttonAddons";
            this.buttonAddons.Size = new System.Drawing.Size(200, 60);
            this.buttonAddons.TabIndex = 1;
            this.buttonAddons.TabStop = false;
            this.buttonAddons.Text = "           Установленные аддоны";
            this.buttonAddons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddons.UseVisualStyleBackColor = false;
            this.buttonAddons.Visible = false;
            this.buttonAddons.Click += new System.EventHandler(this.buttonAddons_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.panelTitleBar.Controls.Add(this.labelTitleName);
            this.panelTitleBar.Controls.Add(this.button_Resize);
            this.panelTitleBar.Controls.Add(this.button_Close);
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1000, 60);
            this.panelTitleBar.TabIndex = 13;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // labelTitleName
            // 
            this.labelTitleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitleName.ForeColor = System.Drawing.Color.White;
            this.labelTitleName.Location = new System.Drawing.Point(30, 15);
            this.labelTitleName.Name = "labelTitleName";
            this.labelTitleName.Size = new System.Drawing.Size(168, 30);
            this.labelTitleName.TabIndex = 0;
            this.labelTitleName.Text = "Addon Updater";
            this.labelTitleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitleName.Visible = false;
            this.labelTitleName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTitleName_MouseDown);
            // 
            // button_Resize
            // 
            this.button_Resize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.button_Resize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Resize.BackgroundImage")));
            this.button_Resize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Resize.FlatAppearance.BorderSize = 0;
            this.button_Resize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Resize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Resize.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_Resize.Location = new System.Drawing.Point(940, 0);
            this.button_Resize.Name = "button_Resize";
            this.button_Resize.Size = new System.Drawing.Size(30, 30);
            this.button_Resize.TabIndex = 22;
            this.button_Resize.TabStop = false;
            this.button_Resize.UseVisualStyleBackColor = false;
            this.button_Resize.Visible = false;
            this.button_Resize.Click += new System.EventHandler(this.button_Resize_Click);
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.button_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Close.BackgroundImage")));
            this.button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Close.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_Close.Location = new System.Drawing.Point(970, 0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(30, 30);
            this.button_Close.TabIndex = 20;
            this.button_Close.TabStop = false;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Visible = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(200, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(800, 30);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Установленные аддоны";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.Visible = false;
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTitle_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Interval = 300000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "AddonUpdater";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.CloseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 48);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.OpenToolStripMenuItem.Text = "Развернуть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.CloseToolStripMenuItem.Text = "Выйти";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.panelMenu.Controls.Add(this.buttonAbout);
            this.panelMenu.Controls.Add(this.buttonSettings);
            this.panelMenu.Controls.Add(this.labelVersion);
            this.panelMenu.Controls.Add(this.buttonAllAddons);
            this.panelMenu.Controls.Add(this.buttonAddons);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 60);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 540);
            this.panelMenu.TabIndex = 15;
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.buttonAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAbout.FlatAppearance.BorderSize = 0;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAbout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAbout.Location = new System.Drawing.Point(0, 180);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(200, 60);
            this.buttonAbout.TabIndex = 23;
            this.buttonAbout.TabStop = false;
            this.buttonAbout.Text = "           О программе";
            this.buttonAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbout.UseVisualStyleBackColor = false;
            this.buttonAbout.Visible = false;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSettings.Location = new System.Drawing.Point(0, 120);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(200, 60);
            this.buttonSettings.TabIndex = 5;
            this.buttonSettings.TabStop = false;
            this.buttonSettings.Text = "           Настройки";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Visible = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // labelVersion
            // 
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVersion.ForeColor = System.Drawing.Color.White;
            this.labelVersion.Location = new System.Drawing.Point(34, 501);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(160, 30);
            this.labelVersion.TabIndex = 22;
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelVersion.Visible = false;
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.panelDesktopPane.Controls.Add(this.labelMainName);
            this.panelDesktopPane.Location = new System.Drawing.Point(200, 60);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(800, 480);
            this.panelDesktopPane.TabIndex = 16;
            // 
            // labelMainName
            // 
            this.labelMainName.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMainName.ForeColor = System.Drawing.Color.White;
            this.labelMainName.Location = new System.Drawing.Point(125, 215);
            this.labelMainName.Name = "labelMainName";
            this.labelMainName.Size = new System.Drawing.Size(350, 50);
            this.labelMainName.TabIndex = 0;
            this.labelMainName.Text = "Addon Updater";
            // 
            // timerKill
            // 
            this.timerKill.Tick += new System.EventHandler(this.timerKill_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(200, 547);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(800, 25);
            this.progressBar1.TabIndex = 19;
            this.progressBar1.Visible = false;
            // 
            // labelInfo
            // 
            this.labelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.labelInfo.ForeColor = System.Drawing.Color.White;
            this.labelInfo.Location = new System.Drawing.Point(200, 575);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(800, 25);
            this.labelInfo.TabIndex = 18;
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelInfo.Visible = false;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddonUpdater";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelDesktopPane.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Label labelMainName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Button button_Resize;
        private System.Windows.Forms.Timer timerKill;
        private System.Windows.Forms.Label labelTitleName;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Label labelInfo;
        public System.Windows.Forms.Button buttonAddons;
        public System.Windows.Forms.Button buttonAllAddons;
        public System.Windows.Forms.Button buttonSettings;
        public System.Windows.Forms.Button buttonAbout;
        public System.Windows.Forms.Button button_Close;
    }
}

