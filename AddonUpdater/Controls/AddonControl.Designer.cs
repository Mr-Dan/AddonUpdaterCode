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
            nameAddon = new System.Windows.Forms.Label();
            trackImage = new System.Windows.Forms.PictureBox();
            versionButton = new System.Windows.Forms.Button();
            categoryAddon = new System.Windows.Forms.Label();
            authorAddon = new System.Windows.Forms.Label();
            deleteButton = new System.Windows.Forms.Button();
            addonProgressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)trackImage).BeginInit();
            SuspendLayout();
            // 
            // nameAddon
            // 
            nameAddon.Cursor = System.Windows.Forms.Cursors.Hand;
            nameAddon.Dock = System.Windows.Forms.DockStyle.Left;
            nameAddon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            nameAddon.Location = new System.Drawing.Point(0, 0);
            nameAddon.Margin = new System.Windows.Forms.Padding(0);
            nameAddon.Name = "nameAddon";
            nameAddon.Size = new System.Drawing.Size(320, 60);
            nameAddon.TabIndex = 1;
            nameAddon.Text = "Addon имя";
            nameAddon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            nameAddon.Click += NameAddon_Click;
            nameAddon.MouseLeave += NameAddon_MouseLeave;
            nameAddon.MouseHover += NameAddon_MouseHover;
            // 
            // trackImage
            // 
            trackImage.BackColor = System.Drawing.SystemColors.Control;
            trackImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            trackImage.Dock = System.Windows.Forms.DockStyle.Left;
            trackImage.Location = new System.Drawing.Point(320, 0);
            trackImage.Margin = new System.Windows.Forms.Padding(0);
            trackImage.Name = "trackImage";
            trackImage.Size = new System.Drawing.Size(50, 62);
            trackImage.TabIndex = 2;
            trackImage.TabStop = false;
            trackImage.Click += TrackImage_Click;
            trackImage.MouseHover += TrackImage_MouseHover;
            // 
            // versionButton
            // 
            versionButton.Dock = System.Windows.Forms.DockStyle.Left;
            versionButton.FlatAppearance.BorderSize = 0;
            versionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            versionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            versionButton.Location = new System.Drawing.Point(370, 0);
            versionButton.Margin = new System.Windows.Forms.Padding(0);
            versionButton.Name = "versionButton";
            versionButton.Size = new System.Drawing.Size(160, 62);
            versionButton.TabIndex = 3;
            versionButton.TabStop = false;
            versionButton.Text = "Версия";
            versionButton.UseVisualStyleBackColor = true;
            versionButton.Click += VersionButton_Click;
            versionButton.MouseHover += VersionButton_MouseHover;
            // 
            // categoryAddon
            // 
            categoryAddon.Dock = System.Windows.Forms.DockStyle.Left;
            categoryAddon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            categoryAddon.Location = new System.Drawing.Point(530, 0);
            categoryAddon.Margin = new System.Windows.Forms.Padding(0);
            categoryAddon.Name = "categoryAddon";
            categoryAddon.Size = new System.Drawing.Size(170, 60);
            categoryAddon.TabIndex = 4;
            categoryAddon.Text = "Тип";
            categoryAddon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // authorAddon
            // 
            authorAddon.Dock = System.Windows.Forms.DockStyle.Left;
            authorAddon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            authorAddon.Location = new System.Drawing.Point(700, 0);
            authorAddon.Margin = new System.Windows.Forms.Padding(0);
            authorAddon.Name = "authorAddon";
            authorAddon.Size = new System.Drawing.Size(170, 60);
            authorAddon.TabIndex = 5;
            authorAddon.Text = "Автор";
            authorAddon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteButton
            // 
            deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            deleteButton.Dock = System.Windows.Forms.DockStyle.Left;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            deleteButton.Image = Properties.Resources.delete;
            deleteButton.Location = new System.Drawing.Point(870, 0);
            deleteButton.Margin = new System.Windows.Forms.Padding(0);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new System.Drawing.Size(40, 62);
            deleteButton.TabIndex = 6;
            deleteButton.TabStop = false;
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += DeleteButton_Click;
            deleteButton.MouseHover += DeleteButton_MouseHover;
            // 
            // addonProgressBar
            // 
            addonProgressBar.Location = new System.Drawing.Point(0, 45);
            addonProgressBar.Margin = new System.Windows.Forms.Padding(0);
            addonProgressBar.Name = "addonProgressBar";
            addonProgressBar.Size = new System.Drawing.Size(320, 15);
            addonProgressBar.TabIndex = 7;
            addonProgressBar.Visible = false;
            // 
            // AddonControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            Controls.Add(addonProgressBar);
            Controls.Add(deleteButton);
            Controls.Add(authorAddon);
            Controls.Add(categoryAddon);
            Controls.Add(versionButton);
            Controls.Add(trackImage);
            Controls.Add(nameAddon);
            Margin = new System.Windows.Forms.Padding(0);
            Name = "AddonControl";
            Size = new System.Drawing.Size(1070, 60);
            ((System.ComponentModel.ISupportInitialize)trackImage).EndInit();
            ResumeLayout(false);
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
