namespace AddonUpdater.Controls
{
    partial class AddonDeleteSettingsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddonDeleteSettingsControl));
            this.addonNameLabel = new System.Windows.Forms.Label();
            this.realmComboBox = new System.Windows.Forms.ComboBox();
            this.personsComboBox = new System.Windows.Forms.ComboBox();
            this.settingsComboBox = new System.Windows.Forms.ComboBox();
            this.accountComboBox = new System.Windows.Forms.ComboBox();
            this.deleteSettingsButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addonNameLabel
            // 
            this.addonNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addonNameLabel.ForeColor = System.Drawing.Color.White;
            this.addonNameLabel.Location = new System.Drawing.Point(0, 0);
            this.addonNameLabel.Name = "addonNameLabel";
            this.addonNameLabel.Size = new System.Drawing.Size(400, 40);
            this.addonNameLabel.TabIndex = 32;
            this.addonNameLabel.Text = "Название";
            this.addonNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // realmComboBox
            // 
            this.realmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.realmComboBox.FormattingEnabled = true;
            this.realmComboBox.Location = new System.Drawing.Point(205, 55);
            this.realmComboBox.Name = "realmComboBox";
            this.realmComboBox.Size = new System.Drawing.Size(180, 24);
            this.realmComboBox.TabIndex = 31;
            this.realmComboBox.TextChanged += new System.EventHandler(this.RealmComboBox_TextChanged);
            // 
            // personsComboBox
            // 
            this.personsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.personsComboBox.FormattingEnabled = true;
            this.personsComboBox.Location = new System.Drawing.Point(15, 90);
            this.personsComboBox.Name = "personsComboBox";
            this.personsComboBox.Size = new System.Drawing.Size(180, 24);
            this.personsComboBox.TabIndex = 30;
            this.personsComboBox.TextChanged += new System.EventHandler(this.PersonsComboBox_TextChanged);
            // 
            // settingsComboBox
            // 
            this.settingsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.settingsComboBox.FormattingEnabled = true;
            this.settingsComboBox.Location = new System.Drawing.Point(205, 90);
            this.settingsComboBox.Name = "settingsComboBox";
            this.settingsComboBox.Size = new System.Drawing.Size(180, 24);
            this.settingsComboBox.TabIndex = 29;
            // 
            // accountComboBox
            // 
            this.accountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountComboBox.FormattingEnabled = true;
            this.accountComboBox.Location = new System.Drawing.Point(15, 55);
            this.accountComboBox.Name = "accountComboBox";
            this.accountComboBox.Size = new System.Drawing.Size(180, 24);
            this.accountComboBox.TabIndex = 28;
            this.accountComboBox.TextChanged += new System.EventHandler(this.AccountComboBox_TextChanged);
            // 
            // deleteSettingsButton
            // 
            this.deleteSettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.deleteSettingsButton.FlatAppearance.BorderSize = 0;
            this.deleteSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSettingsButton.ForeColor = System.Drawing.Color.White;
            this.deleteSettingsButton.Location = new System.Drawing.Point(100, 130);
            this.deleteSettingsButton.Name = "deleteSettingsButton";
            this.deleteSettingsButton.Size = new System.Drawing.Size(200, 35);
            this.deleteSettingsButton.TabIndex = 27;
            this.deleteSettingsButton.TabStop = false;
            this.deleteSettingsButton.Text = "Удалить";
            this.deleteSettingsButton.UseVisualStyleBackColor = false;
            this.deleteSettingsButton.Click += new System.EventHandler(this.DeleteSettingsButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.closeButton.Location = new System.Drawing.Point(370, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 30);
            this.closeButton.TabIndex = 33;
            this.closeButton.TabStop = false;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AddonDeleteSettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addonNameLabel);
            this.Controls.Add(this.realmComboBox);
            this.Controls.Add(this.personsComboBox);
            this.Controls.Add(this.settingsComboBox);
            this.Controls.Add(this.accountComboBox);
            this.Controls.Add(this.deleteSettingsButton);
            this.Name = "AddonDeleteSettingsControl";
            this.Size = new System.Drawing.Size(400, 180);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button closeButton;
        public System.Windows.Forms.Label addonNameLabel;
        private System.Windows.Forms.ComboBox realmComboBox;
        private System.Windows.Forms.ComboBox personsComboBox;
        private System.Windows.Forms.ComboBox settingsComboBox;
        public System.Windows.Forms.ComboBox accountComboBox;
        private System.Windows.Forms.Button deleteSettingsButton;
    }
}
