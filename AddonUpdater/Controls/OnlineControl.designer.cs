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
            realmNameLabel = new System.Windows.Forms.Label();
            isOnlinePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)isOnlinePictureBox).BeginInit();
            SuspendLayout();
            // 
            // realmNameLabel
            // 
            realmNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            realmNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            realmNameLabel.ForeColor = System.Drawing.Color.White;
            realmNameLabel.Location = new System.Drawing.Point(20, 0);
            realmNameLabel.Margin = new System.Windows.Forms.Padding(0);
            realmNameLabel.Name = "realmNameLabel";
            realmNameLabel.Size = new System.Drawing.Size(210, 50);
            realmNameLabel.TabIndex = 1;
            realmNameLabel.Text = "Scourge x2 - 3.3.5a+";
            realmNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            realmNameLabel.MouseDown += RealmNameLabel_MouseDown;
            // 
            // isOnlinePictureBox
            // 
            isOnlinePictureBox.BackgroundImage = Properties.Resources.ofline;
            isOnlinePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            isOnlinePictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            isOnlinePictureBox.Location = new System.Drawing.Point(0, 0);
            isOnlinePictureBox.Margin = new System.Windows.Forms.Padding(0);
            isOnlinePictureBox.Name = "isOnlinePictureBox";
            isOnlinePictureBox.Size = new System.Drawing.Size(20, 50);
            isOnlinePictureBox.TabIndex = 0;
            isOnlinePictureBox.TabStop = false;
            isOnlinePictureBox.MouseDown += IsOnlinePictureBox_MouseDown;
            // 
            // OnlineControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(44, 42, 63);
            Controls.Add(realmNameLabel);
            Controls.Add(isOnlinePictureBox);
            Margin = new System.Windows.Forms.Padding(0);
            Name = "OnlineControl";
            Size = new System.Drawing.Size(230, 50);
            MouseDown += OnlineControl_MouseDown;
            ((System.ComponentModel.ISupportInitialize)isOnlinePictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox isOnlinePictureBox;
        private System.Windows.Forms.Label realmNameLabel;
    }
}
