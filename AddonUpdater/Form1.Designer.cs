
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            buttonAllAddons = new System.Windows.Forms.Button();
            buttonAddons = new System.Windows.Forms.Button();
            panelTitleBar = new System.Windows.Forms.Panel();
            titleOnlinePanel = new System.Windows.Forms.Panel();
            panelTitleRight = new System.Windows.Forms.Panel();
            panelTitleRightUp = new System.Windows.Forms.Panel();
            buttonResize = new System.Windows.Forms.Button();
            buttonClose = new System.Windows.Forms.Button();
            labelTitleName = new System.Windows.Forms.Label();
            timerGithub = new System.Windows.Forms.Timer(components);
            notifyIcon1 = new System.Windows.Forms.NotifyIcon(components);
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            panelMenu = new System.Windows.Forms.Panel();
            buttonAbout = new System.Windows.Forms.Button();
            buttonSettings = new System.Windows.Forms.Button();
            buttonModifications = new System.Windows.Forms.Button();
            labelNeedUpdateMyAddon = new System.Windows.Forms.Label();
            LabelVersion = new System.Windows.Forms.Label();
            labelInfo = new System.Windows.Forms.Label();
            timerKill = new System.Windows.Forms.Timer(components);
            ToolTip = new System.Windows.Forms.ToolTip(components);
            timerSirus = new System.Windows.Forms.Timer(components);
            progressBar1 = new System.Windows.Forms.ProgressBar();
            panelBottom = new System.Windows.Forms.Panel();
            panelDesktopPane = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            timerLocal = new System.Windows.Forms.Timer(components);
            timerUpdate = new System.Windows.Forms.Timer(components);
            panelTitleBar.SuspendLayout();
            panelTitleRight.SuspendLayout();
            panelTitleRightUp.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            panelMenu.SuspendLayout();
            panelBottom.SuspendLayout();
            panelDesktopPane.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAllAddons
            // 
            buttonAllAddons.BackColor = System.Drawing.Color.FromArgb(37, 35, 47);
            buttonAllAddons.Dock = System.Windows.Forms.DockStyle.Top;
            buttonAllAddons.FlatAppearance.BorderSize = 0;
            buttonAllAddons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonAllAddons.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonAllAddons.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            buttonAllAddons.Location = new System.Drawing.Point(0, 80);
            buttonAllAddons.Margin = new System.Windows.Forms.Padding(0);
            buttonAllAddons.Name = "buttonAllAddons";
            buttonAllAddons.Size = new System.Drawing.Size(230, 80);
            buttonAllAddons.TabIndex = 3;
            buttonAllAddons.TabStop = false;
            buttonAllAddons.Text = "           Все аддоны";
            buttonAllAddons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAllAddons.UseVisualStyleBackColor = false;
            buttonAllAddons.Visible = false;
            buttonAllAddons.Click += ButtonAllAddons_Click;
            // 
            // buttonAddons
            // 
            buttonAddons.BackColor = System.Drawing.Color.FromArgb(37, 35, 47);
            buttonAddons.Dock = System.Windows.Forms.DockStyle.Top;
            buttonAddons.FlatAppearance.BorderSize = 0;
            buttonAddons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonAddons.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonAddons.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            buttonAddons.Location = new System.Drawing.Point(0, 0);
            buttonAddons.Margin = new System.Windows.Forms.Padding(0);
            buttonAddons.Name = "buttonAddons";
            buttonAddons.Size = new System.Drawing.Size(230, 80);
            buttonAddons.TabIndex = 1;
            buttonAddons.TabStop = false;
            buttonAddons.Text = "           Установленные аддоны";
            buttonAddons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAddons.UseVisualStyleBackColor = false;
            buttonAddons.Visible = false;
            buttonAddons.Click += ButtonAddons_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = System.Drawing.Color.FromArgb(44, 42, 63);
            panelTitleBar.Controls.Add(titleOnlinePanel);
            panelTitleBar.Controls.Add(panelTitleRight);
            panelTitleBar.Controls.Add(labelTitleName);
            panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            panelTitleBar.Location = new System.Drawing.Point(0, 0);
            panelTitleBar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new System.Drawing.Size(1300, 50);
            panelTitleBar.TabIndex = 13;
            panelTitleBar.MouseDown += PanelTitleBar_MouseDown;
            // 
            // titleOnlinePanel
            // 
            titleOnlinePanel.BackColor = System.Drawing.Color.FromArgb(44, 42, 63);
            titleOnlinePanel.Dock = System.Windows.Forms.DockStyle.Left;
            titleOnlinePanel.Location = new System.Drawing.Point(230, 0);
            titleOnlinePanel.Name = "titleOnlinePanel";
            titleOnlinePanel.Size = new System.Drawing.Size(970, 50);
            titleOnlinePanel.TabIndex = 24;
            titleOnlinePanel.Visible = false;
            titleOnlinePanel.MouseDown += TitleOnlinePanel_MouseDown;
            // 
            // panelTitleRight
            // 
            panelTitleRight.Controls.Add(panelTitleRightUp);
            panelTitleRight.Dock = System.Windows.Forms.DockStyle.Right;
            panelTitleRight.Location = new System.Drawing.Point(1200, 0);
            panelTitleRight.Name = "panelTitleRight";
            panelTitleRight.Size = new System.Drawing.Size(100, 50);
            panelTitleRight.TabIndex = 26;
            panelTitleRight.MouseDown += PanelTitleRight_MouseDown;
            // 
            // panelTitleRightUp
            // 
            panelTitleRightUp.Controls.Add(buttonResize);
            panelTitleRightUp.Controls.Add(buttonClose);
            panelTitleRightUp.Dock = System.Windows.Forms.DockStyle.Top;
            panelTitleRightUp.Location = new System.Drawing.Point(0, 0);
            panelTitleRightUp.Name = "panelTitleRightUp";
            panelTitleRightUp.Size = new System.Drawing.Size(100, 50);
            panelTitleRightUp.TabIndex = 0;
            // 
            // buttonResize
            // 
            buttonResize.BackColor = System.Drawing.Color.FromArgb(44, 42, 63);
            buttonResize.BackgroundImage = (System.Drawing.Image)resources.GetObject("buttonResize.BackgroundImage");
            buttonResize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            buttonResize.Dock = System.Windows.Forms.DockStyle.Right;
            buttonResize.FlatAppearance.BorderSize = 0;
            buttonResize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonResize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonResize.ForeColor = System.Drawing.Color.WhiteSmoke;
            buttonResize.Location = new System.Drawing.Point(0, 0);
            buttonResize.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            buttonResize.Name = "buttonResize";
            buttonResize.Size = new System.Drawing.Size(50, 50);
            buttonResize.TabIndex = 23;
            buttonResize.TabStop = false;
            buttonResize.UseVisualStyleBackColor = false;
            buttonResize.Visible = false;
            buttonResize.Click += ButtonResize_Click;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = System.Drawing.Color.FromArgb(44, 42, 63);
            buttonClose.BackgroundImage = (System.Drawing.Image)resources.GetObject("buttonClose.BackgroundImage");
            buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            buttonClose.Location = new System.Drawing.Point(50, 0);
            buttonClose.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new System.Drawing.Size(50, 50);
            buttonClose.TabIndex = 20;
            buttonClose.TabStop = false;
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Visible = false;
            buttonClose.Click += ButtonClose_Click;
            buttonClose.MouseLeave += ButtonClose_MouseLeave;
            buttonClose.MouseMove += ButtonClose_MouseMove;
            // 
            // labelTitleName
            // 
            labelTitleName.Dock = System.Windows.Forms.DockStyle.Left;
            labelTitleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelTitleName.ForeColor = System.Drawing.Color.White;
            labelTitleName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            labelTitleName.Location = new System.Drawing.Point(0, 0);
            labelTitleName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelTitleName.Name = "labelTitleName";
            labelTitleName.Size = new System.Drawing.Size(230, 50);
            labelTitleName.TabIndex = 24;
            labelTitleName.Text = "Addon Updater";
            labelTitleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelTitleName.Visible = false;
            labelTitleName.MouseDown += LabelTitleName_MouseDown;
            // 
            // timerGithub
            // 
            timerGithub.Interval = 300000;
            timerGithub.Tick += TimerGithub_Tick;
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (System.Drawing.Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "AddonUpdater";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseClick += NotifyIcon1_MouseClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { OpenToolStripMenuItem, CloseToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(157, 52);
            // 
            // OpenToolStripMenuItem
            // 
            OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            OpenToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            OpenToolStripMenuItem.Text = "Развернуть";
            OpenToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            // 
            // CloseToolStripMenuItem
            // 
            CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            CloseToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            CloseToolStripMenuItem.Text = "Выйти";
            CloseToolStripMenuItem.Click += CloseToolStripMenuItem_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = System.Drawing.Color.FromArgb(44, 42, 63);
            panelMenu.Controls.Add(buttonAbout);
            panelMenu.Controls.Add(buttonSettings);
            panelMenu.Controls.Add(buttonModifications);
            panelMenu.Controls.Add(labelNeedUpdateMyAddon);
            panelMenu.Controls.Add(LabelVersion);
            panelMenu.Controls.Add(buttonAllAddons);
            panelMenu.Controls.Add(buttonAddons);
            panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            panelMenu.Location = new System.Drawing.Point(0, 50);
            panelMenu.Margin = new System.Windows.Forms.Padding(0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new System.Drawing.Size(230, 680);
            panelMenu.TabIndex = 15;
            // 
            // buttonAbout
            // 
            buttonAbout.BackColor = System.Drawing.Color.FromArgb(37, 35, 47);
            buttonAbout.Dock = System.Windows.Forms.DockStyle.Top;
            buttonAbout.FlatAppearance.BorderSize = 0;
            buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonAbout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            buttonAbout.Location = new System.Drawing.Point(0, 320);
            buttonAbout.Margin = new System.Windows.Forms.Padding(0);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new System.Drawing.Size(230, 80);
            buttonAbout.TabIndex = 27;
            buttonAbout.TabStop = false;
            buttonAbout.Text = "           О программе";
            buttonAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAbout.UseVisualStyleBackColor = false;
            buttonAbout.Visible = false;
            buttonAbout.Click += ButtonAbout_Click;
            // 
            // buttonSettings
            // 
            buttonSettings.BackColor = System.Drawing.Color.FromArgb(37, 35, 47);
            buttonSettings.Dock = System.Windows.Forms.DockStyle.Top;
            buttonSettings.FlatAppearance.BorderSize = 0;
            buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            buttonSettings.Location = new System.Drawing.Point(0, 240);
            buttonSettings.Margin = new System.Windows.Forms.Padding(0);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new System.Drawing.Size(230, 80);
            buttonSettings.TabIndex = 26;
            buttonSettings.TabStop = false;
            buttonSettings.Text = "           Настройки";
            buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSettings.UseVisualStyleBackColor = false;
            buttonSettings.Visible = false;
            buttonSettings.Click += ButtonSettings_Click;
            // 
            // buttonModifications
            // 
            buttonModifications.BackColor = System.Drawing.Color.FromArgb(37, 35, 47);
            buttonModifications.Dock = System.Windows.Forms.DockStyle.Top;
            buttonModifications.FlatAppearance.BorderSize = 0;
            buttonModifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonModifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonModifications.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            buttonModifications.Location = new System.Drawing.Point(0, 160);
            buttonModifications.Margin = new System.Windows.Forms.Padding(0);
            buttonModifications.Name = "buttonModifications";
            buttonModifications.Size = new System.Drawing.Size(230, 80);
            buttonModifications.TabIndex = 25;
            buttonModifications.TabStop = false;
            buttonModifications.Text = "           Доп. возможности";
            buttonModifications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonModifications.UseVisualStyleBackColor = false;
            buttonModifications.Visible = false;
            buttonModifications.Click += ButtonModifications_Click;
            // 
            // labelNeedUpdateMyAddon
            // 
            labelNeedUpdateMyAddon.BackColor = System.Drawing.Color.FromArgb(37, 35, 47);
            labelNeedUpdateMyAddon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            labelNeedUpdateMyAddon.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelNeedUpdateMyAddon.ForeColor = System.Drawing.Color.White;
            labelNeedUpdateMyAddon.Image = Properties.Resources.notifications;
            labelNeedUpdateMyAddon.Location = new System.Drawing.Point(0, 18);
            labelNeedUpdateMyAddon.Margin = new System.Windows.Forms.Padding(0);
            labelNeedUpdateMyAddon.Name = "labelNeedUpdateMyAddon";
            labelNeedUpdateMyAddon.Size = new System.Drawing.Size(50, 50);
            labelNeedUpdateMyAddon.TabIndex = 24;
            labelNeedUpdateMyAddon.Text = "1";
            labelNeedUpdateMyAddon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelNeedUpdateMyAddon.Visible = false;
            // 
            // LabelVersion
            // 
            LabelVersion.Cursor = System.Windows.Forms.Cursors.Hand;
            LabelVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
            LabelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LabelVersion.ForeColor = System.Drawing.Color.White;
            LabelVersion.Location = new System.Drawing.Point(0, 630);
            LabelVersion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            LabelVersion.Name = "LabelVersion";
            LabelVersion.Size = new System.Drawing.Size(230, 50);
            LabelVersion.TabIndex = 22;
            LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            LabelVersion.Visible = false;
            LabelVersion.Click += LabelVersion_Click;
            LabelVersion.MouseHover += LabelVersion_MouseHover;
            // 
            // labelInfo
            // 
            labelInfo.BackColor = System.Drawing.Color.FromArgb(44, 42, 63);
            labelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            labelInfo.ForeColor = System.Drawing.Color.White;
            labelInfo.Location = new System.Drawing.Point(0, 30);
            labelInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new System.Drawing.Size(1070, 30);
            labelInfo.TabIndex = 18;
            labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelInfo.Visible = false;
            // 
            // timerKill
            // 
            timerKill.Tick += TimerKill_Tick;
            // 
            // ToolTip
            // 
            ToolTip.AutoPopDelay = 5000;
            ToolTip.InitialDelay = 100;
            ToolTip.ReshowDelay = 100;
            // 
            // timerSirus
            // 
            timerSirus.Interval = 180000;
            timerSirus.Tick += TimerSirus_Tick;
            // 
            // progressBar1
            // 
            progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            progressBar1.Location = new System.Drawing.Point(0, 0);
            progressBar1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(1070, 30);
            progressBar1.TabIndex = 20;
            progressBar1.Visible = false;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(progressBar1);
            panelBottom.Controls.Add(labelInfo);
            panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelBottom.Location = new System.Drawing.Point(230, 670);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new System.Drawing.Size(1070, 60);
            panelBottom.TabIndex = 21;
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.BackColor = System.Drawing.Color.FromArgb(44, 42, 63);
            panelDesktopPane.Controls.Add(label2);
            panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            panelDesktopPane.Location = new System.Drawing.Point(230, 50);
            panelDesktopPane.Margin = new System.Windows.Forms.Padding(0);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new System.Drawing.Size(1070, 620);
            panelDesktopPane.TabIndex = 22;
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(-230, 255);
            label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(1300, 75);
            label2.TabIndex = 0;
            label2.Text = "Addon Updater";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerLocal
            // 
            timerLocal.Interval = 20000;
            timerLocal.Tick += TimerLocal_Tick;
            // 
            // timerUpdate
            // 
            timerUpdate.Interval = 30000;
            timerUpdate.Tick += TimerUpdate_Tick;
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            BackColor = System.Drawing.Color.FromArgb(44, 42, 63);
            ClientSize = new System.Drawing.Size(1300, 730);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelBottom);
            Controls.Add(panelMenu);
            Controls.Add(panelTitleBar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(1390, 730);
            MinimumSize = new System.Drawing.Size(1200, 730);
            Name = "FormMainMenu";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "AddonUpdater";
            Load += Form1_Load;
            panelTitleBar.ResumeLayout(false);
            panelTitleRight.ResumeLayout(false);
            panelTitleRightUp.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            panelDesktopPane.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Timer timerGithub;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.Label LabelVersion;
        private System.Windows.Forms.Timer timerKill;
        public System.Windows.Forms.Label labelInfo;
        public System.Windows.Forms.Button buttonAddons;
        public System.Windows.Forms.Button buttonAllAddons;
        public System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ToolTip ToolTip;
        public System.Windows.Forms.Label labelNeedUpdateMyAddon;
        private System.Windows.Forms.Timer timerSirus;
        private System.Windows.Forms.Panel titleOnlinePanel;
        private System.Windows.Forms.Panel panelTitleRight;
        private System.Windows.Forms.Panel panelTitleRightUp;
        private System.Windows.Forms.Label labelTitleName;
        private System.Windows.Forms.Button buttonResize;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerLocal;
        private System.Windows.Forms.Timer timerUpdate;
        public System.Windows.Forms.Button buttonAbout;
        public System.Windows.Forms.Button buttonSettings;
        public System.Windows.Forms.Button buttonModifications;
    }
}

