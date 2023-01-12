
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
            this.labelNeedUpdateMyAddon = new System.Windows.Forms.Label();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.labelMainName = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timerKill = new System.Windows.Forms.Timer(this.components);
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
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
            this.buttonAllAddons.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAllAddons.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAllAddons.Location = new System.Drawing.Point(0, 88);
            this.buttonAllAddons.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAllAddons.Name = "buttonAllAddons";
            this.buttonAllAddons.Size = new System.Drawing.Size(250, 88);
            this.buttonAllAddons.TabIndex = 3;
            this.buttonAllAddons.TabStop = false;
            this.buttonAllAddons.Text = "           Все аддоны";
            this.buttonAllAddons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAllAddons.UseVisualStyleBackColor = false;
            this.buttonAllAddons.Visible = false;
            this.buttonAllAddons.Click += new System.EventHandler(this.ButtonAllAddons_Click);
            // 
            // buttonAddons
            // 
            this.buttonAddons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.buttonAddons.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddons.FlatAppearance.BorderSize = 0;
            this.buttonAddons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddons.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddons.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddons.Location = new System.Drawing.Point(0, 0);
            this.buttonAddons.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddons.Name = "buttonAddons";
            this.buttonAddons.Size = new System.Drawing.Size(250, 88);
            this.buttonAddons.TabIndex = 1;
            this.buttonAddons.TabStop = false;
            this.buttonAddons.Text = "           Установленные аддоны";
            this.buttonAddons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddons.UseVisualStyleBackColor = false;
            this.buttonAddons.Visible = false;
            this.buttonAddons.Click += new System.EventHandler(this.ButtonAddons_Click);
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
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1390, 75);
            this.panelTitleBar.TabIndex = 13;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitleBar_MouseDown);
            // 
            // labelTitleName
            // 
            this.labelTitleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitleName.ForeColor = System.Drawing.Color.White;
            this.labelTitleName.Location = new System.Drawing.Point(0, 0);
            this.labelTitleName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTitleName.Name = "labelTitleName";
            this.labelTitleName.Size = new System.Drawing.Size(250, 75);
            this.labelTitleName.TabIndex = 0;
            this.labelTitleName.Text = "Addon Updater";
            this.labelTitleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitleName.Visible = false;
            this.labelTitleName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelTitleName_MouseDown);
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
            this.button_Resize.Location = new System.Drawing.Point(1291, 0);
            this.button_Resize.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button_Resize.Name = "button_Resize";
            this.button_Resize.Size = new System.Drawing.Size(50, 50);
            this.button_Resize.TabIndex = 22;
            this.button_Resize.TabStop = false;
            this.button_Resize.UseVisualStyleBackColor = false;
            this.button_Resize.Visible = false;
            this.button_Resize.Click += new System.EventHandler(this.Button_Resize_Click);
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
            this.button_Close.Location = new System.Drawing.Point(1340, 0);
            this.button_Close.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(50, 50);
            this.button_Close.TabIndex = 20;
            this.button_Close.TabStop = false;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Visible = false;
            this.button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(250, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1140, 75);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Установленные аддоны";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.Visible = false;
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelTitle_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Interval = 12000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "AddonUpdater";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.CloseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 52);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.OpenToolStripMenuItem.Text = "Развернуть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.CloseToolStripMenuItem.Text = "Выйти";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.panelMenu.Controls.Add(this.labelNeedUpdateMyAddon);
            this.panelMenu.Controls.Add(this.buttonAbout);
            this.panelMenu.Controls.Add(this.buttonSettings);
            this.panelMenu.Controls.Add(this.LabelVersion);
            this.panelMenu.Controls.Add(this.buttonAllAddons);
            this.panelMenu.Controls.Add(this.buttonAddons);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 75);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 675);
            this.panelMenu.TabIndex = 15;
            // 
            // labelNeedUpdateMyAddon
            // 
            this.labelNeedUpdateMyAddon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.labelNeedUpdateMyAddon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNeedUpdateMyAddon.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNeedUpdateMyAddon.ForeColor = System.Drawing.Color.White;
            this.labelNeedUpdateMyAddon.Image = global::AddonUpdater.Properties.Resources.notifications;
            this.labelNeedUpdateMyAddon.Location = new System.Drawing.Point(0, 19);
            this.labelNeedUpdateMyAddon.Margin = new System.Windows.Forms.Padding(0);
            this.labelNeedUpdateMyAddon.Name = "labelNeedUpdateMyAddon";
            this.labelNeedUpdateMyAddon.Size = new System.Drawing.Size(50, 50);
            this.labelNeedUpdateMyAddon.TabIndex = 24;
            this.labelNeedUpdateMyAddon.Text = "1";
            this.labelNeedUpdateMyAddon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNeedUpdateMyAddon.Visible = false;
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.buttonAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAbout.FlatAppearance.BorderSize = 0;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAbout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAbout.Location = new System.Drawing.Point(0, 264);
            this.buttonAbout.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(250, 88);
            this.buttonAbout.TabIndex = 23;
            this.buttonAbout.TabStop = false;
            this.buttonAbout.Text = "           О программе";
            this.buttonAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbout.UseVisualStyleBackColor = false;
            this.buttonAbout.Visible = false;
            this.buttonAbout.Click += new System.EventHandler(this.ButtonAbout_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSettings.Location = new System.Drawing.Point(0, 176);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(250, 88);
            this.buttonSettings.TabIndex = 5;
            this.buttonSettings.TabStop = false;
            this.buttonSettings.Text = "           Настройки";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Visible = false;
            this.buttonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // LabelVersion
            // 
            this.LabelVersion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelVersion.ForeColor = System.Drawing.Color.White;
            this.LabelVersion.Location = new System.Drawing.Point(0, 625);
            this.LabelVersion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(250, 50);
            this.LabelVersion.TabIndex = 22;
            this.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelVersion.Visible = false;
            this.LabelVersion.Click += new System.EventHandler(this.LabelVersion_Click);
            this.LabelVersion.MouseHover += new System.EventHandler(this.LabelVersion_MouseHover);
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.panelDesktopPane.Controls.Add(this.labelMainName);
            this.panelDesktopPane.Location = new System.Drawing.Point(250, 75);
            this.panelDesktopPane.Margin = new System.Windows.Forms.Padding(0);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(1140, 610);
            this.panelDesktopPane.TabIndex = 16;
            // 
            // labelMainName
            // 
            this.labelMainName.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMainName.ForeColor = System.Drawing.Color.White;
            this.labelMainName.Location = new System.Drawing.Point(-250, 250);
            this.labelMainName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelMainName.Name = "labelMainName";
            this.labelMainName.Size = new System.Drawing.Size(1350, 75);
            this.labelMainName.TabIndex = 0;
            this.labelMainName.Text = "Addon Updater";
            this.labelMainName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInfo
            // 
            this.labelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.labelInfo.ForeColor = System.Drawing.Color.White;
            this.labelInfo.Location = new System.Drawing.Point(250, 719);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(1140, 31);
            this.labelInfo.TabIndex = 18;
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelInfo.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(250, 688);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1140, 31);
            this.progressBar1.TabIndex = 19;
            this.progressBar1.Visible = false;
            // 
            // timerKill
            // 
            this.timerKill.Tick += new System.EventHandler(this.TimerKill_Tick);
            // 
            // ToolTip
            // 
            this.ToolTip.AutoPopDelay = 5000;
            this.ToolTip.InitialDelay = 100;
            this.ToolTip.ReshowDelay = 100;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1390, 750);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximumSize = new System.Drawing.Size(1390, 750);
            this.MinimumSize = new System.Drawing.Size(1390, 750);
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
        private System.Windows.Forms.Label LabelVersion;
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
        private System.Windows.Forms.ToolTip ToolTip;
        public System.Windows.Forms.Label labelNeedUpdateMyAddon;
    }
}

