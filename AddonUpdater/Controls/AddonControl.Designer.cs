namespace AddonUpdater.Controls
{
    partial class AddonControl
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
            this.nameAddon = new System.Windows.Forms.Label();
            this.trackImage = new System.Windows.Forms.PictureBox();
            this.versionButton = new System.Windows.Forms.Button();
            this.categoryAddon = new System.Windows.Forms.Label();
            this.authorAddon = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addonProgressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackImage)).BeginInit();
            this.SuspendLayout();
            // 
            // nameAddon
            // 
            this.nameAddon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nameAddon.Dock = System.Windows.Forms.DockStyle.Left;
            this.nameAddon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameAddon.Location = new System.Drawing.Point(0, 0);
            this.nameAddon.Margin = new System.Windows.Forms.Padding(0);
            this.nameAddon.Name = "nameAddon";
            this.nameAddon.Size = new System.Drawing.Size(320, 50);
            this.nameAddon.TabIndex = 1;
            this.nameAddon.Text = "Addon имя";
            this.nameAddon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nameAddon.Click += new System.EventHandler(this.NameAddon_Click);
            this.nameAddon.MouseLeave += new System.EventHandler(this.NameAddon_MouseLeave);
            this.nameAddon.MouseHover += new System.EventHandler(this.NameAddon_MouseHover);
            // 
            // trackImage
            // 
            this.trackImage.BackColor = System.Drawing.SystemColors.Control;
            this.trackImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.trackImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.trackImage.Location = new System.Drawing.Point(320, 0);
            this.trackImage.Margin = new System.Windows.Forms.Padding(0);
            this.trackImage.Name = "trackImage";
            this.trackImage.Size = new System.Drawing.Size(50, 50);
            this.trackImage.TabIndex = 2;
            this.trackImage.TabStop = false;
            this.trackImage.Click += new System.EventHandler(this.TrackImage_Click);
            this.trackImage.MouseHover += new System.EventHandler(this.TrackImage_MouseHover);
            // 
            // versionButton
            // 
            this.versionButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.versionButton.FlatAppearance.BorderSize = 0;
            this.versionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.versionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.versionButton.Location = new System.Drawing.Point(370, 0);
            this.versionButton.Margin = new System.Windows.Forms.Padding(0);
            this.versionButton.Name = "versionButton";
            this.versionButton.Size = new System.Drawing.Size(160, 50);
            this.versionButton.TabIndex = 3;
            this.versionButton.TabStop = false;
            this.versionButton.Text = "Версия";
            this.versionButton.UseVisualStyleBackColor = true;
            this.versionButton.Click += new System.EventHandler(this.VersionButton_Click);
            this.versionButton.MouseHover += new System.EventHandler(this.VersionButton_MouseHover);
            // 
            // categoryAddon
            // 
            this.categoryAddon.Cursor = System.Windows.Forms.Cursors.Default;
            this.categoryAddon.Dock = System.Windows.Forms.DockStyle.Left;
            this.categoryAddon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryAddon.Location = new System.Drawing.Point(530, 0);
            this.categoryAddon.Margin = new System.Windows.Forms.Padding(0);
            this.categoryAddon.Name = "categoryAddon";
            this.categoryAddon.Size = new System.Drawing.Size(170, 50);
            this.categoryAddon.TabIndex = 4;
            this.categoryAddon.Text = "Тип";
            this.categoryAddon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // authorAddon
            // 
            this.authorAddon.Cursor = System.Windows.Forms.Cursors.Default;
            this.authorAddon.Dock = System.Windows.Forms.DockStyle.Left;
            this.authorAddon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorAddon.Location = new System.Drawing.Point(700, 0);
            this.authorAddon.Margin = new System.Windows.Forms.Padding(0);
            this.authorAddon.Name = "authorAddon";
            this.authorAddon.Size = new System.Drawing.Size(170, 50);
            this.authorAddon.TabIndex = 5;
            this.authorAddon.Text = "Автор";
            this.authorAddon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteButton
            // 
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Image = global::AddonUpdater.Properties.Resources.delete;
            this.deleteButton.Location = new System.Drawing.Point(870, 0);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(40, 50);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.TabStop = false;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            this.deleteButton.MouseHover += new System.EventHandler(this.DeleteButton_MouseHover);
            // 
            // addonProgressBar
            // 
            this.addonProgressBar.Location = new System.Drawing.Point(0, 35);
            this.addonProgressBar.Margin = new System.Windows.Forms.Padding(0);
            this.addonProgressBar.Name = "addonProgressBar";
            this.addonProgressBar.Size = new System.Drawing.Size(320, 15);
            this.addonProgressBar.TabIndex = 7;
            this.addonProgressBar.Visible = false;
            // 
            // AddonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.addonProgressBar);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.authorAddon);
            this.Controls.Add(this.categoryAddon);
            this.Controls.Add(this.versionButton);
            this.Controls.Add(this.trackImage);
            this.Controls.Add(this.nameAddon);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AddonControl";
            this.Size = new System.Drawing.Size(1070, 50);
            ((System.ComponentModel.ISupportInitialize)(this.trackImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label nameAddon;
        private System.Windows.Forms.PictureBox trackImage;
        private System.Windows.Forms.Button versionButton;
        private System.Windows.Forms.Label categoryAddon;
        private System.Windows.Forms.Label authorAddon;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ProgressBar addonProgressBar;
    }
}
