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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddonFormControl));
            PanelDescription = new System.Windows.Forms.Panel();
            LabelDescription = new System.Windows.Forms.Label();
            panelAddonsViewTitle = new System.Windows.Forms.Panel();
            labelDelete = new System.Windows.Forms.Label();
            labelAuthor = new System.Windows.Forms.Label();
            labelCategory = new System.Windows.Forms.Label();
            labelVersion = new System.Windows.Forms.Label();
            pictureBoxFollowUpdate = new System.Windows.Forms.PictureBox();
            labelName = new System.Windows.Forms.Label();
            ContextMenuStripPaths = new System.Windows.Forms.ContextMenuStrip(components);
            ToolTip = new System.Windows.Forms.ToolTip(components);
            panelBottom = new System.Windows.Forms.Panel();
            panelBottomButtons = new System.Windows.Forms.Panel();
            launcherButton = new System.Windows.Forms.Button();
            panelRightLauncher = new System.Windows.Forms.Panel();
            updateButton = new System.Windows.Forms.Button();
            panelRightUpdate = new System.Windows.Forms.Panel();
            dowloadButton = new System.Windows.Forms.Button();
            pathsShowDowload = new System.Windows.Forms.Button();
            panelRightDowload = new System.Windows.Forms.Panel();
            panelBottomButtonsUp = new System.Windows.Forms.Panel();
            panelAddonsView = new System.Windows.Forms.Panel();
            PanelDescription.SuspendLayout();
            panelAddonsViewTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFollowUpdate).BeginInit();
            panelBottomButtons.SuspendLayout();
            SuspendLayout();
            // 
            // PanelDescription
            // 
            PanelDescription.Controls.Add(LabelDescription);
            PanelDescription.ForeColor = System.Drawing.SystemColors.ButtonFace;
            PanelDescription.Location = new System.Drawing.Point(19, 378);
            PanelDescription.MaximumSize = new System.Drawing.Size(940, 300);
            PanelDescription.Name = "PanelDescription";
            PanelDescription.Size = new System.Drawing.Size(940, 15);
            PanelDescription.TabIndex = 31;
            PanelDescription.Visible = false;
            // 
            // LabelDescription
            // 
            LabelDescription.AutoEllipsis = true;
            LabelDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            LabelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LabelDescription.ForeColor = System.Drawing.SystemColors.ButtonFace;
            LabelDescription.Location = new System.Drawing.Point(0, 0);
            LabelDescription.Name = "LabelDescription";
            LabelDescription.Size = new System.Drawing.Size(940, 15);
            LabelDescription.TabIndex = 1;
            // 
            // panelAddonsViewTitle
            // 
            panelAddonsViewTitle.BackColor = System.Drawing.Color.FromArgb(132, 130, 159);
            panelAddonsViewTitle.Controls.Add(labelDelete);
            panelAddonsViewTitle.Controls.Add(labelAuthor);
            panelAddonsViewTitle.Controls.Add(labelCategory);
            panelAddonsViewTitle.Controls.Add(labelVersion);
            panelAddonsViewTitle.Controls.Add(pictureBoxFollowUpdate);
            panelAddonsViewTitle.Controls.Add(labelName);
            panelAddonsViewTitle.Dock = System.Windows.Forms.DockStyle.Top;
            panelAddonsViewTitle.Location = new System.Drawing.Point(0, 0);
            panelAddonsViewTitle.Name = "panelAddonsViewTitle";
            panelAddonsViewTitle.Size = new System.Drawing.Size(1070, 40);
            panelAddonsViewTitle.TabIndex = 32;
            // 
            // labelDelete
            // 
            labelDelete.Dock = System.Windows.Forms.DockStyle.Left;
            labelDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelDelete.ForeColor = System.Drawing.Color.White;
            labelDelete.Location = new System.Drawing.Point(990, 0);
            labelDelete.Margin = new System.Windows.Forms.Padding(0);
            labelDelete.Name = "labelDelete";
            labelDelete.Size = new System.Drawing.Size(50, 40);
            labelDelete.TabIndex = 11;
            labelDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAuthor
            // 
            labelAuthor.Dock = System.Windows.Forms.DockStyle.Left;
            labelAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelAuthor.ForeColor = System.Drawing.Color.White;
            labelAuthor.Location = new System.Drawing.Point(810, 0);
            labelAuthor.Margin = new System.Windows.Forms.Padding(0);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new System.Drawing.Size(180, 40);
            labelAuthor.TabIndex = 10;
            labelAuthor.Text = "Автор";
            labelAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCategory
            // 
            labelCategory.Dock = System.Windows.Forms.DockStyle.Left;
            labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelCategory.ForeColor = System.Drawing.Color.White;
            labelCategory.Location = new System.Drawing.Point(630, 0);
            labelCategory.Margin = new System.Windows.Forms.Padding(0);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new System.Drawing.Size(180, 40);
            labelCategory.TabIndex = 9;
            labelCategory.Text = "Категория";
            labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVersion
            // 
            labelVersion.Dock = System.Windows.Forms.DockStyle.Left;
            labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelVersion.ForeColor = System.Drawing.Color.White;
            labelVersion.Location = new System.Drawing.Point(450, 0);
            labelVersion.Margin = new System.Windows.Forms.Padding(0);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new System.Drawing.Size(180, 40);
            labelVersion.TabIndex = 7;
            labelVersion.Text = "Версия";
            labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxFollowUpdate
            // 
            pictureBoxFollowUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBoxFollowUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBoxFollowUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            pictureBoxFollowUpdate.Location = new System.Drawing.Point(400, 0);
            pictureBoxFollowUpdate.Margin = new System.Windows.Forms.Padding(0);
            pictureBoxFollowUpdate.Name = "pictureBoxFollowUpdate";
            pictureBoxFollowUpdate.Size = new System.Drawing.Size(50, 40);
            pictureBoxFollowUpdate.TabIndex = 5;
            pictureBoxFollowUpdate.TabStop = false;
            pictureBoxFollowUpdate.Click += PictureBoxFollowUpdate_Click;
            // 
            // labelName
            // 
            labelName.Dock = System.Windows.Forms.DockStyle.Left;
            labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelName.ForeColor = System.Drawing.Color.White;
            labelName.Location = new System.Drawing.Point(0, 0);
            labelName.Margin = new System.Windows.Forms.Padding(0);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(400, 40);
            labelName.TabIndex = 1;
            labelName.Text = "Название";
            labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ContextMenuStripPaths
            // 
            ContextMenuStripPaths.BackColor = System.Drawing.Color.LightGray;
            ContextMenuStripPaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ContextMenuStripPaths.ImageScalingSize = new System.Drawing.Size(20, 20);
            ContextMenuStripPaths.Name = "ContextMenuStripPaths";
            ContextMenuStripPaths.ShowImageMargin = false;
            ContextMenuStripPaths.Size = new System.Drawing.Size(36, 4);
            ContextMenuStripPaths.ItemClicked += ContextMenuStripPaths_ItemClicked;
            ContextMenuStripPaths.MouseLeave += ContextMenuStripPaths_MouseLeave;
            // 
            // ToolTip
            // 
            ToolTip.AutoPopDelay = 5000;
            ToolTip.InitialDelay = 200;
            ToolTip.ReshowDelay = 100;
            // 
            // panelBottom
            // 
            panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelBottom.Location = new System.Drawing.Point(0, 605);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new System.Drawing.Size(1070, 15);
            panelBottom.TabIndex = 38;
            // 
            // panelBottomButtons
            // 
            panelBottomButtons.Controls.Add(launcherButton);
            panelBottomButtons.Controls.Add(panelRightLauncher);
            panelBottomButtons.Controls.Add(updateButton);
            panelBottomButtons.Controls.Add(panelRightUpdate);
            panelBottomButtons.Controls.Add(dowloadButton);
            panelBottomButtons.Controls.Add(pathsShowDowload);
            panelBottomButtons.Controls.Add(panelRightDowload);
            panelBottomButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelBottomButtons.Location = new System.Drawing.Point(0, 555);
            panelBottomButtons.Name = "panelBottomButtons";
            panelBottomButtons.Size = new System.Drawing.Size(1070, 50);
            panelBottomButtons.TabIndex = 39;
            // 
            // launcherButton
            // 
            launcherButton.BackColor = System.Drawing.Color.FromArgb(44, 42, 63);
            launcherButton.BackgroundImage = Properties.Resources.sirusLauncher;
            launcherButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            launcherButton.Dock = System.Windows.Forms.DockStyle.Right;
            launcherButton.FlatAppearance.BorderSize = 0;
            launcherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            launcherButton.ForeColor = System.Drawing.Color.White;
            launcherButton.Location = new System.Drawing.Point(765, 0);
            launcherButton.Name = "launcherButton";
            launcherButton.Size = new System.Drawing.Size(50, 50);
            launcherButton.TabIndex = 49;
            launcherButton.TabStop = false;
            launcherButton.UseVisualStyleBackColor = false;
            launcherButton.Click += LauncherButton_Click;
            // 
            // panelRightLauncher
            // 
            panelRightLauncher.Dock = System.Windows.Forms.DockStyle.Right;
            panelRightLauncher.Location = new System.Drawing.Point(815, 0);
            panelRightLauncher.Name = "panelRightLauncher";
            panelRightLauncher.Size = new System.Drawing.Size(10, 50);
            panelRightLauncher.TabIndex = 48;
            // 
            // updateButton
            // 
            updateButton.BackColor = System.Drawing.Color.FromArgb(44, 42, 63);
            updateButton.BackgroundImage = (System.Drawing.Image)resources.GetObject("updateButton.BackgroundImage");
            updateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            updateButton.Dock = System.Windows.Forms.DockStyle.Right;
            updateButton.FlatAppearance.BorderSize = 0;
            updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            updateButton.ForeColor = System.Drawing.Color.White;
            updateButton.Location = new System.Drawing.Point(825, 0);
            updateButton.Name = "updateButton";
            updateButton.Size = new System.Drawing.Size(50, 50);
            updateButton.TabIndex = 47;
            updateButton.TabStop = false;
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += UpdateButton_Click;
            // 
            // panelRightUpdate
            // 
            panelRightUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            panelRightUpdate.Location = new System.Drawing.Point(875, 0);
            panelRightUpdate.Name = "panelRightUpdate";
            panelRightUpdate.Size = new System.Drawing.Size(10, 50);
            panelRightUpdate.TabIndex = 46;
            // 
            // dowloadButton
            // 
            dowloadButton.BackColor = System.Drawing.Color.FromArgb(44, 177, 128);
            dowloadButton.Dock = System.Windows.Forms.DockStyle.Right;
            dowloadButton.FlatAppearance.BorderSize = 0;
            dowloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            dowloadButton.ForeColor = System.Drawing.Color.White;
            dowloadButton.Location = new System.Drawing.Point(885, 0);
            dowloadButton.Name = "dowloadButton";
            dowloadButton.Size = new System.Drawing.Size(150, 50);
            dowloadButton.TabIndex = 43;
            dowloadButton.TabStop = false;
            dowloadButton.Text = "Обновить все";
            dowloadButton.UseVisualStyleBackColor = false;
            dowloadButton.Click += DowloadButton_Click;
            // 
            // pathsShowDowload
            // 
            pathsShowDowload.BackColor = System.Drawing.Color.FromArgb(44, 177, 128);
            pathsShowDowload.Dock = System.Windows.Forms.DockStyle.Right;
            pathsShowDowload.FlatAppearance.BorderSize = 0;
            pathsShowDowload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            pathsShowDowload.ForeColor = System.Drawing.Color.White;
            pathsShowDowload.Location = new System.Drawing.Point(1035, 0);
            pathsShowDowload.Name = "pathsShowDowload";
            pathsShowDowload.Size = new System.Drawing.Size(25, 50);
            pathsShowDowload.TabIndex = 42;
            pathsShowDowload.TabStop = false;
            pathsShowDowload.Text = "▼";
            pathsShowDowload.UseVisualStyleBackColor = false;
            pathsShowDowload.Click += PathsShowButton_Click;
            // 
            // panelRightDowload
            // 
            panelRightDowload.Dock = System.Windows.Forms.DockStyle.Right;
            panelRightDowload.Location = new System.Drawing.Point(1060, 0);
            panelRightDowload.Name = "panelRightDowload";
            panelRightDowload.Size = new System.Drawing.Size(10, 50);
            panelRightDowload.TabIndex = 41;
            // 
            // panelBottomButtonsUp
            // 
            panelBottomButtonsUp.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelBottomButtonsUp.Location = new System.Drawing.Point(0, 540);
            panelBottomButtonsUp.Name = "panelBottomButtonsUp";
            panelBottomButtonsUp.Size = new System.Drawing.Size(1070, 15);
            panelBottomButtonsUp.TabIndex = 40;
            // 
            // panelAddonsView
            // 
            panelAddonsView.BackColor = System.Drawing.Color.FromArgb(232, 232, 232);
            panelAddonsView.Dock = System.Windows.Forms.DockStyle.Fill;
            panelAddonsView.Location = new System.Drawing.Point(0, 40);
            panelAddonsView.Margin = new System.Windows.Forms.Padding(0);
            panelAddonsView.Name = "panelAddonsView";
            panelAddonsView.Size = new System.Drawing.Size(1070, 500);
            panelAddonsView.TabIndex = 41;
            // 
            // AddonFormControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            BackColor = System.Drawing.Color.FromArgb(44, 42, 63);
            Controls.Add(panelAddonsView);
            Controls.Add(panelBottomButtonsUp);
            Controls.Add(panelBottomButtons);
            Controls.Add(panelBottom);
            Controls.Add(PanelDescription);
            Controls.Add(panelAddonsViewTitle);
            Margin = new System.Windows.Forms.Padding(0);
            Name = "AddonFormControl";
            Size = new System.Drawing.Size(1070, 620);
            Load += AddonFormControls_Load;
            PanelDescription.ResumeLayout(false);
            panelAddonsViewTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxFollowUpdate).EndInit();
            panelBottomButtons.ResumeLayout(false);
            ResumeLayout(false);
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
