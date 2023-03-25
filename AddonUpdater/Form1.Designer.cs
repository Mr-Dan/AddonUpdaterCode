
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
            this.titleOnlinePanel = new System.Windows.Forms.Panel();
            this.panelTitleRight = new System.Windows.Forms.Panel();
            this.panelTitleRightUp = new System.Windows.Forms.Panel();
            this.buttonResize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelTitleName = new System.Windows.Forms.Label();
            this.timerGithub = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonModifications = new System.Windows.Forms.Button();
            this.labelNeedUpdateMyAddon = new System.Windows.Forms.Label();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.timerKill = new System.Windows.Forms.Timer(this.components);
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timerSirus = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.timerLocal = new System.Windows.Forms.Timer(this.components);
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.panelTitleBar.SuspendLayout();
            this.panelTitleRight.SuspendLayout();
            this.panelTitleRightUp.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelBottom.SuspendLayout();
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
            this.buttonAllAddons.Location = new System.Drawing.Point(0, 80);
            this.buttonAllAddons.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAllAddons.Name = "buttonAllAddons";
            this.buttonAllAddons.Size = new System.Drawing.Size(230, 80);
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
            this.buttonAddons.Size = new System.Drawing.Size(230, 80);
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
            this.panelTitleBar.Controls.Add(this.titleOnlinePanel);
            this.panelTitleBar.Controls.Add(this.panelTitleRight);
            this.panelTitleBar.Controls.Add(this.labelTitleName);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1300, 50);
            this.panelTitleBar.TabIndex = 13;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitleBar_MouseDown);
            // 
            // titleOnlinePanel
            // 
            this.titleOnlinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.titleOnlinePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleOnlinePanel.Location = new System.Drawing.Point(230, 0);
            this.titleOnlinePanel.Name = "titleOnlinePanel";
            this.titleOnlinePanel.Size = new System.Drawing.Size(970, 47);
            this.titleOnlinePanel.TabIndex = 24;
            this.titleOnlinePanel.Visible = false;
            this.titleOnlinePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleOnlinePanel_MouseDown);
            // 
            // panelTitleRight
            // 
            this.panelTitleRight.Controls.Add(this.panelTitleRightUp);
            this.panelTitleRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTitleRight.Location = new System.Drawing.Point(1200, 0);
            this.panelTitleRight.Name = "panelTitleRight";
            this.panelTitleRight.Size = new System.Drawing.Size(100, 50);
            this.panelTitleRight.TabIndex = 26;
            this.panelTitleRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitleRight_MouseDown);
            // 
            // panelTitleRightUp
            // 
            this.panelTitleRightUp.Controls.Add(this.buttonResize);
            this.panelTitleRightUp.Controls.Add(this.buttonClose);
            this.panelTitleRightUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleRightUp.Location = new System.Drawing.Point(0, 0);
            this.panelTitleRightUp.Name = "panelTitleRightUp";
            this.panelTitleRightUp.Size = new System.Drawing.Size(100, 50);
            this.panelTitleRightUp.TabIndex = 0;
            // 
            // buttonResize
            // 
            this.buttonResize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.buttonResize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonResize.BackgroundImage")));
            this.buttonResize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonResize.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonResize.FlatAppearance.BorderSize = 0;
            this.buttonResize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResize.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonResize.Location = new System.Drawing.Point(0, 0);
            this.buttonResize.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonResize.Name = "buttonResize";
            this.buttonResize.Size = new System.Drawing.Size(50, 50);
            this.buttonResize.TabIndex = 23;
            this.buttonResize.TabStop = false;
            this.buttonResize.UseVisualStyleBackColor = false;
            this.buttonResize.Visible = false;
            this.buttonResize.Click += new System.EventHandler(this.ButtonResize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.buttonClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClose.BackgroundImage")));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonClose.Location = new System.Drawing.Point(50, 0);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(50, 50);
            this.buttonClose.TabIndex = 20;
            this.buttonClose.TabStop = false;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Visible = false;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            this.buttonClose.MouseLeave += new System.EventHandler(this.ButtonClose_MouseLeave);
            this.buttonClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonClose_MouseMove);
            // 
            // labelTitleName
            // 
            this.labelTitleName.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTitleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitleName.ForeColor = System.Drawing.Color.White;
            this.labelTitleName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTitleName.Location = new System.Drawing.Point(0, 0);
            this.labelTitleName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTitleName.Name = "labelTitleName";
            this.labelTitleName.Size = new System.Drawing.Size(230, 50);
            this.labelTitleName.TabIndex = 24;
            this.labelTitleName.Text = "Addon Updater";
            this.labelTitleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitleName.Visible = false;
            this.labelTitleName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelTitleName_MouseDown);
            // 
            // timerGithub
            // 
            this.timerGithub.Interval = 300000;
            this.timerGithub.Tick += new System.EventHandler(this.TimerGithub_Tick);
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
            this.panelMenu.Controls.Add(this.buttonAbout);
            this.panelMenu.Controls.Add(this.buttonSettings);
            this.panelMenu.Controls.Add(this.buttonModifications);
            this.panelMenu.Controls.Add(this.labelNeedUpdateMyAddon);
            this.panelMenu.Controls.Add(this.LabelVersion);
            this.panelMenu.Controls.Add(this.buttonAllAddons);
            this.panelMenu.Controls.Add(this.buttonAddons);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 50);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 670);
            this.panelMenu.TabIndex = 15;
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.buttonAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAbout.FlatAppearance.BorderSize = 0;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAbout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAbout.Location = new System.Drawing.Point(0, 320);
            this.buttonAbout.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(230, 80);
            this.buttonAbout.TabIndex = 27;
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
            this.buttonSettings.Location = new System.Drawing.Point(0, 240);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(230, 80);
            this.buttonSettings.TabIndex = 26;
            this.buttonSettings.TabStop = false;
            this.buttonSettings.Text = "           Настройки";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Visible = false;
            this.buttonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // buttonModifications
            // 
            this.buttonModifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.buttonModifications.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonModifications.FlatAppearance.BorderSize = 0;
            this.buttonModifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonModifications.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonModifications.Location = new System.Drawing.Point(0, 160);
            this.buttonModifications.Margin = new System.Windows.Forms.Padding(0);
            this.buttonModifications.Name = "buttonModifications";
            this.buttonModifications.Size = new System.Drawing.Size(230, 80);
            this.buttonModifications.TabIndex = 25;
            this.buttonModifications.TabStop = false;
            this.buttonModifications.Text = "           Доп. возможности";
            this.buttonModifications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModifications.UseVisualStyleBackColor = false;
            this.buttonModifications.Visible = false;
            this.buttonModifications.Click += new System.EventHandler(this.buttonModifications_Click);
            // 
            // labelNeedUpdateMyAddon
            // 
            this.labelNeedUpdateMyAddon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.labelNeedUpdateMyAddon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNeedUpdateMyAddon.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNeedUpdateMyAddon.ForeColor = System.Drawing.Color.White;
            this.labelNeedUpdateMyAddon.Image = global::AddonUpdater.Properties.Resources.notifications;
            this.labelNeedUpdateMyAddon.Location = new System.Drawing.Point(0, 18);
            this.labelNeedUpdateMyAddon.Margin = new System.Windows.Forms.Padding(0);
            this.labelNeedUpdateMyAddon.Name = "labelNeedUpdateMyAddon";
            this.labelNeedUpdateMyAddon.Size = new System.Drawing.Size(50, 50);
            this.labelNeedUpdateMyAddon.TabIndex = 24;
            this.labelNeedUpdateMyAddon.Text = "1";
            this.labelNeedUpdateMyAddon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNeedUpdateMyAddon.Visible = false;
            // 
            // LabelVersion
            // 
            this.LabelVersion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LabelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelVersion.ForeColor = System.Drawing.Color.White;
            this.LabelVersion.Location = new System.Drawing.Point(0, 620);
            this.LabelVersion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(230, 50);
            this.LabelVersion.TabIndex = 22;
            this.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelVersion.Visible = false;
            this.LabelVersion.Click += new System.EventHandler(this.LabelVersion_Click);
            this.LabelVersion.MouseHover += new System.EventHandler(this.LabelVersion_MouseHover);
            // 
            // labelInfo
            // 
            this.labelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.labelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelInfo.ForeColor = System.Drawing.Color.White;
            this.labelInfo.Location = new System.Drawing.Point(0, 30);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(1070, 30);
            this.labelInfo.TabIndex = 18;
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelInfo.Visible = false;
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
            // timerSirus
            // 
            this.timerSirus.Interval = 180000;
            this.timerSirus.Tick += new System.EventHandler(this.TimerSirus_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1070, 30);
            this.progressBar1.TabIndex = 20;
            this.progressBar1.Visible = false;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.progressBar1);
            this.panelBottom.Controls.Add(this.labelInfo);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(230, 660);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1070, 60);
            this.panelBottom.TabIndex = 21;
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.panelDesktopPane.Controls.Add(this.label2);
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(230, 50);
            this.panelDesktopPane.Margin = new System.Windows.Forms.Padding(0);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(1070, 610);
            this.panelDesktopPane.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-230, 255);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1300, 75);
            this.label2.TabIndex = 0;
            this.label2.Text = "Addon Updater";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerLocal
            // 
            this.timerLocal.Interval = 20000;
            this.timerLocal.Tick += new System.EventHandler(this.TimerLocal_Tick);
            // 
            // timerUpdate
            // 
            this.timerUpdate.Interval = 30000;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1300, 720);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1390, 720);
            this.MinimumSize = new System.Drawing.Size(1200, 720);
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddonUpdater";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleRight.ResumeLayout(false);
            this.panelTitleRightUp.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelDesktopPane.ResumeLayout(false);
            this.ResumeLayout(false);

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

