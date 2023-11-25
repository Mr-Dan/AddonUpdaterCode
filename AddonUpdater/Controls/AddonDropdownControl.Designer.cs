namespace AddonUpdater.Controls
{
    partial class AddonDropdownControl
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
            reinstallButton = new System.Windows.Forms.Button();
            trackButton = new System.Windows.Forms.Button();
            bugReportButton = new System.Windows.Forms.Button();
            forumButton = new System.Windows.Forms.Button();
            gitHubButton = new System.Windows.Forms.Button();
            deleteSettingsButton = new System.Windows.Forms.Button();
            deleteButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // reinstallButton
            // 
            reinstallButton.BackColor = System.Drawing.Color.FromArgb(37, 35, 47);
            reinstallButton.Dock = System.Windows.Forms.DockStyle.Top;
            reinstallButton.FlatAppearance.BorderSize = 0;
            reinstallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            reinstallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            reinstallButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            reinstallButton.Location = new System.Drawing.Point(0, 0);
            reinstallButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            reinstallButton.Name = "reinstallButton";
            reinstallButton.Size = new System.Drawing.Size(160, 60);
            reinstallButton.TabIndex = 3;
            reinstallButton.TabStop = false;
            reinstallButton.Text = "Переустановить";
            reinstallButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            reinstallButton.UseVisualStyleBackColor = false;
            reinstallButton.Click += ReinstallButton_Click;
            // 
            // trackButton
            // 
            trackButton.BackColor = System.Drawing.Color.FromArgb(37, 35, 47);
            trackButton.Dock = System.Windows.Forms.DockStyle.Top;
            trackButton.FlatAppearance.BorderSize = 0;
            trackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            trackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            trackButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            trackButton.Location = new System.Drawing.Point(0, 60);
            trackButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            trackButton.Name = "trackButton";
            trackButton.Size = new System.Drawing.Size(160, 60);
            trackButton.TabIndex = 4;
            trackButton.TabStop = false;
            trackButton.Text = "Cледить за обновлением";
            trackButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            trackButton.UseVisualStyleBackColor = false;
            trackButton.Click += TrackButton_Click;
            // 
            // bugReportButton
            // 
            bugReportButton.BackColor = System.Drawing.Color.FromArgb(37, 35, 47);
            bugReportButton.Dock = System.Windows.Forms.DockStyle.Top;
            bugReportButton.FlatAppearance.BorderSize = 0;
            bugReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bugReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            bugReportButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            bugReportButton.Location = new System.Drawing.Point(0, 120);
            bugReportButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            bugReportButton.Name = "bugReportButton";
            bugReportButton.Size = new System.Drawing.Size(160, 60);
            bugReportButton.TabIndex = 5;
            bugReportButton.TabStop = false;
            bugReportButton.Text = "Сообщить о баге";
            bugReportButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            bugReportButton.UseVisualStyleBackColor = false;
            bugReportButton.Click += BugReportButton_Click;
            // 
            // forumButton
            // 
            forumButton.BackColor = System.Drawing.Color.FromArgb(37, 35, 47);
            forumButton.Dock = System.Windows.Forms.DockStyle.Top;
            forumButton.FlatAppearance.BorderSize = 0;
            forumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            forumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            forumButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            forumButton.Location = new System.Drawing.Point(0, 180);
            forumButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            forumButton.Name = "forumButton";
            forumButton.Size = new System.Drawing.Size(160, 60);
            forumButton.TabIndex = 6;
            forumButton.TabStop = false;
            forumButton.Text = "Форум";
            forumButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            forumButton.UseVisualStyleBackColor = false;
            forumButton.Click += ForumButton_Click;
            // 
            // gitHubButton
            // 
            gitHubButton.BackColor = System.Drawing.Color.FromArgb(37, 35, 47);
            gitHubButton.Dock = System.Windows.Forms.DockStyle.Top;
            gitHubButton.FlatAppearance.BorderSize = 0;
            gitHubButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            gitHubButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            gitHubButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            gitHubButton.Location = new System.Drawing.Point(0, 240);
            gitHubButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gitHubButton.Name = "gitHubButton";
            gitHubButton.Size = new System.Drawing.Size(160, 60);
            gitHubButton.TabIndex = 7;
            gitHubButton.TabStop = false;
            gitHubButton.Text = "GitHub";
            gitHubButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            gitHubButton.UseVisualStyleBackColor = false;
            gitHubButton.Click += GitHubButton_Click;
            // 
            // deleteSettingsButton
            // 
            deleteSettingsButton.BackColor = System.Drawing.Color.FromArgb(37, 35, 47);
            deleteSettingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            deleteSettingsButton.FlatAppearance.BorderSize = 0;
            deleteSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            deleteSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            deleteSettingsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            deleteSettingsButton.Location = new System.Drawing.Point(0, 300);
            deleteSettingsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            deleteSettingsButton.Name = "deleteSettingsButton";
            deleteSettingsButton.Size = new System.Drawing.Size(160, 60);
            deleteSettingsButton.TabIndex = 8;
            deleteSettingsButton.TabStop = false;
            deleteSettingsButton.Text = "Удалить настройки";
            deleteSettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            deleteSettingsButton.UseVisualStyleBackColor = false;
            deleteSettingsButton.Click += DeleteSettingsButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = System.Drawing.Color.FromArgb(37, 35, 47);
            deleteButton.Dock = System.Windows.Forms.DockStyle.Top;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            deleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            deleteButton.Location = new System.Drawing.Point(0, 360);
            deleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new System.Drawing.Size(160, 60);
            deleteButton.TabIndex = 9;
            deleteButton.TabStop = false;
            deleteButton.Text = "Удалить";
            deleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += DeleteButton_Click;
            // 
            // AddonDropdownControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(deleteButton);
            Controls.Add(deleteSettingsButton);
            Controls.Add(gitHubButton);
            Controls.Add(forumButton);
            Controls.Add(bugReportButton);
            Controls.Add(trackButton);
            Controls.Add(reinstallButton);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "AddonDropdownControl";
            Size = new System.Drawing.Size(160, 420);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button reinstallButton;
        private System.Windows.Forms.Button trackButton;
        private System.Windows.Forms.Button bugReportButton;
        private System.Windows.Forms.Button forumButton;
        private System.Windows.Forms.Button gitHubButton;
        private System.Windows.Forms.Button deleteSettingsButton;
        private System.Windows.Forms.Button deleteButton;
    }
}
