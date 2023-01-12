namespace AddonUpdater.Controls
{
    partial class AddonFormControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddonFormControl));
            this.pathsShowButton = new System.Windows.Forms.Button();
            this.PanelDescription = new System.Windows.Forms.Panel();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.panelAddonsView = new System.Windows.Forms.Panel();
            this.panelAddonsViewTitle = new System.Windows.Forms.Panel();
            this.labelDelete = new System.Windows.Forms.Label();
            this.pictureBoxFollowUpdate = new System.Windows.Forms.PictureBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.dowloadButton = new System.Windows.Forms.Button();
            this.ContextMenuStripPaths = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.launcherButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.PanelDescription.SuspendLayout();
            this.panelAddonsViewTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFollowUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // pathsShowButton
            // 
            this.pathsShowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(128)))));
            this.pathsShowButton.FlatAppearance.BorderSize = 0;
            this.pathsShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pathsShowButton.ForeColor = System.Drawing.Color.White;
            this.pathsShowButton.Location = new System.Drawing.Point(870, 445);
            this.pathsShowButton.Name = "pathsShowButton";
            this.pathsShowButton.Size = new System.Drawing.Size(25, 40);
            this.pathsShowButton.TabIndex = 34;
            this.pathsShowButton.TabStop = false;
            this.pathsShowButton.Text = "▼";
            this.pathsShowButton.UseVisualStyleBackColor = false;
            this.pathsShowButton.Click += new System.EventHandler(this.PathsShowButton_Click);
            // 
            // PanelDescription
            // 
            this.PanelDescription.Controls.Add(this.LabelDescription);
            this.PanelDescription.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PanelDescription.Location = new System.Drawing.Point(19, 378);
            this.PanelDescription.MaximumSize = new System.Drawing.Size(800, 300);
            this.PanelDescription.Name = "PanelDescription";
            this.PanelDescription.Size = new System.Drawing.Size(800, 15);
            this.PanelDescription.TabIndex = 31;
            this.PanelDescription.Visible = false;
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoEllipsis = true;
            this.LabelDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDescription.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelDescription.Location = new System.Drawing.Point(0, 0);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(800, 15);
            this.LabelDescription.TabIndex = 1;
            // 
            // panelAddonsView
            // 
            this.panelAddonsView.AutoScroll = true;
            this.panelAddonsView.BackColor = System.Drawing.Color.LightGray;
            this.panelAddonsView.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddonsView.Location = new System.Drawing.Point(0, 40);
            this.panelAddonsView.Margin = new System.Windows.Forms.Padding(0);
            this.panelAddonsView.Name = "panelAddonsView";
            this.panelAddonsView.Size = new System.Drawing.Size(890, 400);
            this.panelAddonsView.TabIndex = 33;
            // 
            // panelAddonsViewTitle
            // 
            this.panelAddonsViewTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(130)))), ((int)(((byte)(159)))));
            this.panelAddonsViewTitle.Controls.Add(this.labelDelete);
            this.panelAddonsViewTitle.Controls.Add(this.pictureBoxFollowUpdate);
            this.panelAddonsViewTitle.Controls.Add(this.labelAuthor);
            this.panelAddonsViewTitle.Controls.Add(this.labelCategory);
            this.panelAddonsViewTitle.Controls.Add(this.labelVersion);
            this.panelAddonsViewTitle.Controls.Add(this.labelName);
            this.panelAddonsViewTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddonsViewTitle.Location = new System.Drawing.Point(0, 0);
            this.panelAddonsViewTitle.Name = "panelAddonsViewTitle";
            this.panelAddonsViewTitle.Size = new System.Drawing.Size(890, 40);
            this.panelAddonsViewTitle.TabIndex = 32;
            // 
            // labelDelete
            // 
            this.labelDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDelete.ForeColor = System.Drawing.Color.White;
            this.labelDelete.Location = new System.Drawing.Point(850, 0);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(40, 40);
            this.labelDelete.TabIndex = 6;
            this.labelDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxFollowUpdate
            // 
            this.pictureBoxFollowUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxFollowUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFollowUpdate.Location = new System.Drawing.Point(290, 0);
            this.pictureBoxFollowUpdate.Name = "pictureBoxFollowUpdate";
            this.pictureBoxFollowUpdate.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxFollowUpdate.TabIndex = 5;
            this.pictureBoxFollowUpdate.TabStop = false;
            this.pictureBoxFollowUpdate.Click += new System.EventHandler(this.PictureBoxFollowUpdate_Click);
            // 
            // labelAuthor
            // 
            this.labelAuthor.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuthor.ForeColor = System.Drawing.Color.White;
            this.labelAuthor.Location = new System.Drawing.Point(670, 0);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(180, 40);
            this.labelAuthor.TabIndex = 4;
            this.labelAuthor.Text = "Автор";
            this.labelAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCategory
            // 
            this.labelCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCategory.ForeColor = System.Drawing.Color.White;
            this.labelCategory.Location = new System.Drawing.Point(500, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(170, 40);
            this.labelCategory.TabIndex = 3;
            this.labelCategory.Text = "Категория";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVersion
            // 
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVersion.ForeColor = System.Drawing.Color.White;
            this.labelVersion.Location = new System.Drawing.Point(330, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(170, 40);
            this.labelVersion.TabIndex = 2;
            this.labelVersion.Text = "Версия";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(0, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(330, 40);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Название";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dowloadButton
            // 
            this.dowloadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(128)))));
            this.dowloadButton.FlatAppearance.BorderSize = 0;
            this.dowloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dowloadButton.ForeColor = System.Drawing.Color.White;
            this.dowloadButton.Location = new System.Drawing.Point(720, 445);
            this.dowloadButton.Name = "dowloadButton";
            this.dowloadButton.Size = new System.Drawing.Size(150, 40);
            this.dowloadButton.TabIndex = 28;
            this.dowloadButton.TabStop = false;
            this.dowloadButton.Text = "Обновить все";
            this.dowloadButton.UseVisualStyleBackColor = false;
            this.dowloadButton.Click += new System.EventHandler(this.DowloadButton_Click);
            // 
            // ContextMenuStripPaths
            // 
            this.ContextMenuStripPaths.BackColor = System.Drawing.Color.LightGray;
            this.ContextMenuStripPaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ContextMenuStripPaths.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStripPaths.Name = "ContextMenuStripPaths";
            this.ContextMenuStripPaths.ShowImageMargin = false;
            this.ContextMenuStripPaths.Size = new System.Drawing.Size(36, 4);
            this.ContextMenuStripPaths.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ContextMenuStripPaths_ItemClicked);
            this.ContextMenuStripPaths.MouseLeave += new System.EventHandler(this.ContextMenuStripPaths_MouseLeave);
            // 
            // ToolTip
            // 
            this.ToolTip.AutoPopDelay = 5000;
            this.ToolTip.InitialDelay = 200;
            this.ToolTip.ReshowDelay = 100;
            // 
            // launcherButton
            // 
            this.launcherButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.launcherButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("launcherButton.BackgroundImage")));
            this.launcherButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.launcherButton.FlatAppearance.BorderSize = 0;
            this.launcherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.launcherButton.ForeColor = System.Drawing.Color.White;
            this.launcherButton.Location = new System.Drawing.Point(620, 445);
            this.launcherButton.Name = "launcherButton";
            this.launcherButton.Size = new System.Drawing.Size(50, 40);
            this.launcherButton.TabIndex = 30;
            this.launcherButton.TabStop = false;
            this.launcherButton.UseVisualStyleBackColor = false;
            this.launcherButton.Click += new System.EventHandler(this.LauncherButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.updateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateButton.BackgroundImage")));
            this.updateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(670, 445);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(50, 40);
            this.updateButton.TabIndex = 29;
            this.updateButton.TabStop = false;
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // AddonFormControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.pathsShowButton);
            this.Controls.Add(this.PanelDescription);
            this.Controls.Add(this.panelAddonsView);
            this.Controls.Add(this.panelAddonsViewTitle);
            this.Controls.Add(this.launcherButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.dowloadButton);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AddonFormControl";
            this.Size = new System.Drawing.Size(890, 490);
            this.Load += new System.EventHandler(this.AddonFormControls_Load);
            this.PanelDescription.ResumeLayout(false);
            this.panelAddonsViewTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFollowUpdate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pathsShowButton;
        private System.Windows.Forms.Panel PanelDescription;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.Panel panelAddonsView;
        private System.Windows.Forms.Panel panelAddonsViewTitle;
        private System.Windows.Forms.PictureBox pictureBoxFollowUpdate;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button launcherButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button dowloadButton;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripPaths;
        public System.Windows.Forms.ToolTip ToolTip;
    }
}
