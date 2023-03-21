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
            this.PanelDescription = new System.Windows.Forms.Panel();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.panelAddonsViewTitle = new System.Windows.Forms.Panel();
            this.labelDelete = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.ContextMenuStripPaths = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelBottomButtons = new System.Windows.Forms.Panel();
            this.panelRightLauncher = new System.Windows.Forms.Panel();
            this.panelRightUpdate = new System.Windows.Forms.Panel();
            this.dowloadButton = new System.Windows.Forms.Button();
            this.pathsShowDowload = new System.Windows.Forms.Button();
            this.panelRightDowload = new System.Windows.Forms.Panel();
            this.panelBottomButtonsUp = new System.Windows.Forms.Panel();
            this.panelAddonsView = new System.Windows.Forms.Panel();
            this.launcherButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.pictureBoxFollowUpdate = new System.Windows.Forms.PictureBox();
            this.PanelDescription.SuspendLayout();
            this.panelAddonsViewTitle.SuspendLayout();
            this.panelBottomButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFollowUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelDescription
            // 
            this.PanelDescription.Controls.Add(this.LabelDescription);
            this.PanelDescription.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PanelDescription.Location = new System.Drawing.Point(19, 378);
            this.PanelDescription.MaximumSize = new System.Drawing.Size(940, 300);
            this.PanelDescription.Name = "PanelDescription";
            this.PanelDescription.Size = new System.Drawing.Size(940, 15);
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
            this.LabelDescription.Size = new System.Drawing.Size(940, 15);
            this.LabelDescription.TabIndex = 1;
            // 
            // panelAddonsViewTitle
            // 
            this.panelAddonsViewTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(130)))), ((int)(((byte)(159)))));
            this.panelAddonsViewTitle.Controls.Add(this.labelDelete);
            this.panelAddonsViewTitle.Controls.Add(this.labelAuthor);
            this.panelAddonsViewTitle.Controls.Add(this.labelCategory);
            this.panelAddonsViewTitle.Controls.Add(this.labelVersion);
            this.panelAddonsViewTitle.Controls.Add(this.pictureBoxFollowUpdate);
            this.panelAddonsViewTitle.Controls.Add(this.labelName);
            this.panelAddonsViewTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddonsViewTitle.Location = new System.Drawing.Point(0, 0);
            this.panelAddonsViewTitle.Name = "panelAddonsViewTitle";
            this.panelAddonsViewTitle.Size = new System.Drawing.Size(1070, 40);
            this.panelAddonsViewTitle.TabIndex = 32;
            // 
            // labelDelete
            // 
            this.labelDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDelete.ForeColor = System.Drawing.Color.White;
            this.labelDelete.Location = new System.Drawing.Point(990, 0);
            this.labelDelete.Margin = new System.Windows.Forms.Padding(0);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(50, 40);
            this.labelDelete.TabIndex = 11;
            this.labelDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAuthor
            // 
            this.labelAuthor.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuthor.ForeColor = System.Drawing.Color.White;
            this.labelAuthor.Location = new System.Drawing.Point(810, 0);
            this.labelAuthor.Margin = new System.Windows.Forms.Padding(0);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(180, 40);
            this.labelAuthor.TabIndex = 10;
            this.labelAuthor.Text = "Автор";
            this.labelAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCategory
            // 
            this.labelCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCategory.ForeColor = System.Drawing.Color.White;
            this.labelCategory.Location = new System.Drawing.Point(630, 0);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(180, 40);
            this.labelCategory.TabIndex = 9;
            this.labelCategory.Text = "Категория";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVersion
            // 
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVersion.ForeColor = System.Drawing.Color.White;
            this.labelVersion.Location = new System.Drawing.Point(450, 0);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(180, 40);
            this.labelVersion.TabIndex = 7;
            this.labelVersion.Text = "Версия";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(0, 0);
            this.labelName.Margin = new System.Windows.Forms.Padding(0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(400, 40);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Название";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // panelBottom
            // 
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 600);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1070, 10);
            this.panelBottom.TabIndex = 38;
            // 
            // panelBottomButtons
            // 
            this.panelBottomButtons.Controls.Add(this.launcherButton);
            this.panelBottomButtons.Controls.Add(this.panelRightLauncher);
            this.panelBottomButtons.Controls.Add(this.updateButton);
            this.panelBottomButtons.Controls.Add(this.panelRightUpdate);
            this.panelBottomButtons.Controls.Add(this.dowloadButton);
            this.panelBottomButtons.Controls.Add(this.pathsShowDowload);
            this.panelBottomButtons.Controls.Add(this.panelRightDowload);
            this.panelBottomButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomButtons.Location = new System.Drawing.Point(0, 550);
            this.panelBottomButtons.Name = "panelBottomButtons";
            this.panelBottomButtons.Size = new System.Drawing.Size(1070, 50);
            this.panelBottomButtons.TabIndex = 39;
            // 
            // panelRightLauncher
            // 
            this.panelRightLauncher.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRightLauncher.Location = new System.Drawing.Point(815, 0);
            this.panelRightLauncher.Name = "panelRightLauncher";
            this.panelRightLauncher.Size = new System.Drawing.Size(10, 50);
            this.panelRightLauncher.TabIndex = 48;
            // 
            // panelRightUpdate
            // 
            this.panelRightUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRightUpdate.Location = new System.Drawing.Point(875, 0);
            this.panelRightUpdate.Name = "panelRightUpdate";
            this.panelRightUpdate.Size = new System.Drawing.Size(10, 50);
            this.panelRightUpdate.TabIndex = 46;
            // 
            // dowloadButton
            // 
            this.dowloadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(128)))));
            this.dowloadButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.dowloadButton.FlatAppearance.BorderSize = 0;
            this.dowloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dowloadButton.ForeColor = System.Drawing.Color.White;
            this.dowloadButton.Location = new System.Drawing.Point(885, 0);
            this.dowloadButton.Name = "dowloadButton";
            this.dowloadButton.Size = new System.Drawing.Size(150, 50);
            this.dowloadButton.TabIndex = 43;
            this.dowloadButton.TabStop = false;
            this.dowloadButton.Text = "Обновить все";
            this.dowloadButton.UseVisualStyleBackColor = false;
            this.dowloadButton.Click += new System.EventHandler(this.DowloadButton_Click);
            // 
            // pathsShowDowload
            // 
            this.pathsShowDowload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(128)))));
            this.pathsShowDowload.Dock = System.Windows.Forms.DockStyle.Right;
            this.pathsShowDowload.FlatAppearance.BorderSize = 0;
            this.pathsShowDowload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pathsShowDowload.ForeColor = System.Drawing.Color.White;
            this.pathsShowDowload.Location = new System.Drawing.Point(1035, 0);
            this.pathsShowDowload.Name = "pathsShowDowload";
            this.pathsShowDowload.Size = new System.Drawing.Size(25, 50);
            this.pathsShowDowload.TabIndex = 42;
            this.pathsShowDowload.TabStop = false;
            this.pathsShowDowload.Text = "▼";
            this.pathsShowDowload.UseVisualStyleBackColor = false;
            this.pathsShowDowload.Click += new System.EventHandler(this.PathsShowButton_Click);
            // 
            // panelRightDowload
            // 
            this.panelRightDowload.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRightDowload.Location = new System.Drawing.Point(1060, 0);
            this.panelRightDowload.Name = "panelRightDowload";
            this.panelRightDowload.Size = new System.Drawing.Size(10, 50);
            this.panelRightDowload.TabIndex = 41;
            // 
            // panelBottomButtonsUp
            // 
            this.panelBottomButtonsUp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomButtonsUp.Location = new System.Drawing.Point(0, 540);
            this.panelBottomButtonsUp.Name = "panelBottomButtonsUp";
            this.panelBottomButtonsUp.Size = new System.Drawing.Size(1070, 10);
            this.panelBottomButtonsUp.TabIndex = 40;
            // 
            // panelAddonsView
            // 
            this.panelAddonsView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.panelAddonsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddonsView.Location = new System.Drawing.Point(0, 40);
            this.panelAddonsView.Margin = new System.Windows.Forms.Padding(0);
            this.panelAddonsView.Name = "panelAddonsView";
            this.panelAddonsView.Size = new System.Drawing.Size(1070, 500);
            this.panelAddonsView.TabIndex = 41;
            // 
            // launcherButton
            // 
            this.launcherButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.launcherButton.BackgroundImage = global::AddonUpdater.Properties.Resources.sirusLauncher;
            this.launcherButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.launcherButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.launcherButton.FlatAppearance.BorderSize = 0;
            this.launcherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.launcherButton.ForeColor = System.Drawing.Color.White;
            this.launcherButton.Location = new System.Drawing.Point(765, 0);
            this.launcherButton.Name = "launcherButton";
            this.launcherButton.Size = new System.Drawing.Size(50, 50);
            this.launcherButton.TabIndex = 49;
            this.launcherButton.TabStop = false;
            this.launcherButton.UseVisualStyleBackColor = false;
            this.launcherButton.Click += new System.EventHandler(this.LauncherButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.updateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateButton.BackgroundImage")));
            this.updateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.updateButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(825, 0);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(50, 50);
            this.updateButton.TabIndex = 47;
            this.updateButton.TabStop = false;
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // pictureBoxFollowUpdate
            // 
            this.pictureBoxFollowUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxFollowUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFollowUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxFollowUpdate.Location = new System.Drawing.Point(400, 0);
            this.pictureBoxFollowUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxFollowUpdate.Name = "pictureBoxFollowUpdate";
            this.pictureBoxFollowUpdate.Size = new System.Drawing.Size(50, 40);
            this.pictureBoxFollowUpdate.TabIndex = 5;
            this.pictureBoxFollowUpdate.TabStop = false;
            this.pictureBoxFollowUpdate.Click += new System.EventHandler(this.PictureBoxFollowUpdate_Click);
            // 
            // AddonFormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.panelAddonsView);
            this.Controls.Add(this.panelBottomButtonsUp);
            this.Controls.Add(this.panelBottomButtons);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.PanelDescription);
            this.Controls.Add(this.panelAddonsViewTitle);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AddonFormControl";
            this.Size = new System.Drawing.Size(1070, 610);
            this.Load += new System.EventHandler(this.AddonFormControls_Load);
            this.PanelDescription.ResumeLayout(false);
            this.panelAddonsViewTitle.ResumeLayout(false);
            this.panelBottomButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFollowUpdate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelDescription;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.Panel panelAddonsViewTitle;
        private System.Windows.Forms.PictureBox pictureBoxFollowUpdate;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripPaths;
        public System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelBottomButtons;
        private System.Windows.Forms.Panel panelBottomButtonsUp;
        private System.Windows.Forms.Panel panelAddonsView;
        private System.Windows.Forms.Button dowloadButton;
        private System.Windows.Forms.Button pathsShowDowload;
        private System.Windows.Forms.Panel panelRightDowload;
        private System.Windows.Forms.Panel panelRightLauncher;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Panel panelRightUpdate;
        private System.Windows.Forms.Button launcherButton;
    }
}
