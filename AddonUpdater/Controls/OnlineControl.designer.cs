namespace AddonUpdater.Controls
{
    partial class OnlineControl
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
            this.realmNameLabel = new System.Windows.Forms.Label();
            this.isOnlinePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.isOnlinePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // realmNameLabel
            // 
            this.realmNameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.realmNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.realmNameLabel.ForeColor = System.Drawing.Color.White;
            this.realmNameLabel.Location = new System.Drawing.Point(20, 0);
            this.realmNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.realmNameLabel.Name = "realmNameLabel";
            this.realmNameLabel.Size = new System.Drawing.Size(220, 25);
            this.realmNameLabel.TabIndex = 1;
            this.realmNameLabel.Text = "Scourge x2 - 3.3.5a+";
            this.realmNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.realmNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RealmNameLabel_MouseDown);
            // 
            // isOnlinePictureBox
            // 
            this.isOnlinePictureBox.BackgroundImage = global::AddonUpdater.Properties.Resources.ofline;
            this.isOnlinePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.isOnlinePictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.isOnlinePictureBox.Location = new System.Drawing.Point(0, 0);
            this.isOnlinePictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.isOnlinePictureBox.Name = "isOnlinePictureBox";
            this.isOnlinePictureBox.Size = new System.Drawing.Size(20, 25);
            this.isOnlinePictureBox.TabIndex = 0;
            this.isOnlinePictureBox.TabStop = false;
            this.isOnlinePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IsOnlinePictureBox_MouseDown);
            // 
            // OnlineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.realmNameLabel);
            this.Controls.Add(this.isOnlinePictureBox);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "OnlineControl";
            this.Size = new System.Drawing.Size(240, 25);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnlineControl_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.isOnlinePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox isOnlinePictureBox;
        private System.Windows.Forms.Label realmNameLabel;
    }
}
