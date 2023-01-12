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
            this.reinstallButton = new System.Windows.Forms.Button();
            this.trackButton = new System.Windows.Forms.Button();
            this.bugReportButton = new System.Windows.Forms.Button();
            this.forumButton = new System.Windows.Forms.Button();
            this.gitHubButton = new System.Windows.Forms.Button();
            this.deleteSettingsButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reinstallButton
            // 
            this.reinstallButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.reinstallButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.reinstallButton.FlatAppearance.BorderSize = 0;
            this.reinstallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reinstallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reinstallButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reinstallButton.Location = new System.Drawing.Point(0, 0);
            this.reinstallButton.Name = "reinstallButton";
            this.reinstallButton.Size = new System.Drawing.Size(160, 50);
            this.reinstallButton.TabIndex = 3;
            this.reinstallButton.TabStop = false;
            this.reinstallButton.Text = "Переустановить";
            this.reinstallButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reinstallButton.UseVisualStyleBackColor = false;
            this.reinstallButton.Click += new System.EventHandler(this.ReinstallButton_Click);
            // 
            // trackButton
            // 
            this.trackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.trackButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackButton.FlatAppearance.BorderSize = 0;
            this.trackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trackButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trackButton.Location = new System.Drawing.Point(0, 50);
            this.trackButton.Name = "trackButton";
            this.trackButton.Size = new System.Drawing.Size(160, 60);
            this.trackButton.TabIndex = 4;
            this.trackButton.TabStop = false;
            this.trackButton.Text = "Cледить за обновлением";
            this.trackButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trackButton.UseVisualStyleBackColor = false;
            this.trackButton.Click += new System.EventHandler(this.TrackButton_Click);
            // 
            // bugReportButton
            // 
            this.bugReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.bugReportButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.bugReportButton.FlatAppearance.BorderSize = 0;
            this.bugReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bugReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bugReportButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bugReportButton.Location = new System.Drawing.Point(0, 110);
            this.bugReportButton.Name = "bugReportButton";
            this.bugReportButton.Size = new System.Drawing.Size(160, 50);
            this.bugReportButton.TabIndex = 5;
            this.bugReportButton.TabStop = false;
            this.bugReportButton.Text = "Сообщить о баге";
            this.bugReportButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bugReportButton.UseVisualStyleBackColor = false;
            this.bugReportButton.Click += new System.EventHandler(this.BugReportButton_Click);
            // 
            // forumButton
            // 
            this.forumButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.forumButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.forumButton.FlatAppearance.BorderSize = 0;
            this.forumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forumButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.forumButton.Location = new System.Drawing.Point(0, 160);
            this.forumButton.Name = "forumButton";
            this.forumButton.Size = new System.Drawing.Size(160, 50);
            this.forumButton.TabIndex = 6;
            this.forumButton.TabStop = false;
            this.forumButton.Text = "Форум";
            this.forumButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.forumButton.UseVisualStyleBackColor = false;
            this.forumButton.Click += new System.EventHandler(this.ForumButton_Click);
            // 
            // gitHubButton
            // 
            this.gitHubButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.gitHubButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.gitHubButton.FlatAppearance.BorderSize = 0;
            this.gitHubButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gitHubButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gitHubButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gitHubButton.Location = new System.Drawing.Point(0, 210);
            this.gitHubButton.Name = "gitHubButton";
            this.gitHubButton.Size = new System.Drawing.Size(160, 50);
            this.gitHubButton.TabIndex = 7;
            this.gitHubButton.TabStop = false;
            this.gitHubButton.Text = "GitHub";
            this.gitHubButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gitHubButton.UseVisualStyleBackColor = false;
            this.gitHubButton.Click += new System.EventHandler(this.GitHubButton_Click);
            // 
            // deleteSettingsButton
            // 
            this.deleteSettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.deleteSettingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteSettingsButton.FlatAppearance.BorderSize = 0;
            this.deleteSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteSettingsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteSettingsButton.Location = new System.Drawing.Point(0, 260);
            this.deleteSettingsButton.Name = "deleteSettingsButton";
            this.deleteSettingsButton.Size = new System.Drawing.Size(160, 60);
            this.deleteSettingsButton.TabIndex = 8;
            this.deleteSettingsButton.TabStop = false;
            this.deleteSettingsButton.Text = "Удалить настройки";
            this.deleteSettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteSettingsButton.UseVisualStyleBackColor = false;
            this.deleteSettingsButton.Click += new System.EventHandler(this.DeleteSettingsButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteButton.Location = new System.Drawing.Point(0, 320);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(160, 50);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.TabStop = false;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddonDropdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.deleteSettingsButton);
            this.Controls.Add(this.gitHubButton);
            this.Controls.Add(this.forumButton);
            this.Controls.Add(this.bugReportButton);
            this.Controls.Add(this.trackButton);
            this.Controls.Add(this.reinstallButton);
            this.Name = "AddonDropdown";
            this.Size = new System.Drawing.Size(160, 370);
            this.ResumeLayout(false);

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
