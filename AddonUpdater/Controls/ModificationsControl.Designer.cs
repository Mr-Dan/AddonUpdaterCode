namespace AddonUpdater.Controls
{
    partial class ModificationsControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDeletePath = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPatchLoad = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CheckPatchProgressBar = new System.Windows.Forms.ProgressBar();
            this.CheckPatchLabel = new System.Windows.Forms.Label();
            this.CheckPatchButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.panel1.Controls.Add(this.buttonDeletePath);
            this.panel1.Controls.Add(this.pictureBoxLogo);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonPatchLoad);
            this.panel1.Location = new System.Drawing.Point(21, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 390);
            this.panel1.TabIndex = 0;
            // 
            // buttonDeletePath
            // 
            this.buttonDeletePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.buttonDeletePath.FlatAppearance.BorderSize = 0;
            this.buttonDeletePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeletePath.ForeColor = System.Drawing.Color.White;
            this.buttonDeletePath.Location = new System.Drawing.Point(45, 335);
            this.buttonDeletePath.Name = "buttonDeletePath";
            this.buttonDeletePath.Size = new System.Drawing.Size(200, 40);
            this.buttonDeletePath.TabIndex = 34;
            this.buttonDeletePath.TabStop = false;
            this.buttonDeletePath.Text = "Удалить";
            this.buttonDeletePath.UseVisualStyleBackColor = false;
            this.buttonDeletePath.Click += new System.EventHandler(this.buttonDeletePath_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::AddonUpdater.Properties.Resources.PatchX;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Location = new System.Drawing.Point(45, 10);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(200, 170);
            this.pictureBoxLogo.TabIndex = 33;
            this.pictureBoxLogo.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(45, 255);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(200, 10);
            this.progressBar1.TabIndex = 32;
            this.progressBar1.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 70);
            this.label2.TabIndex = 29;
            this.label2.Text = "Патч для повышения фпс путем удаления ненужных анимаций.";
            // 
            // buttonPatchLoad
            // 
            this.buttonPatchLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.buttonPatchLoad.FlatAppearance.BorderSize = 0;
            this.buttonPatchLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPatchLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPatchLoad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPatchLoad.Location = new System.Drawing.Point(45, 280);
            this.buttonPatchLoad.Name = "buttonPatchLoad";
            this.buttonPatchLoad.Size = new System.Drawing.Size(200, 40);
            this.buttonPatchLoad.TabIndex = 4;
            this.buttonPatchLoad.TabStop = false;
            this.buttonPatchLoad.Text = "Создать патч";
            this.buttonPatchLoad.UseVisualStyleBackColor = false;
            this.buttonPatchLoad.Click += new System.EventHandler(this.buttonPatchLoad_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.CheckPatchProgressBar);
            this.panel2.Controls.Add(this.CheckPatchLabel);
            this.panel2.Controls.Add(this.CheckPatchButton);
            this.panel2.Location = new System.Drawing.Point(340, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 390);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AddonUpdater.Properties.Resources.PatchX;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(45, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 170);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // CheckPatchProgressBar
            // 
            this.CheckPatchProgressBar.Location = new System.Drawing.Point(45, 255);
            this.CheckPatchProgressBar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CheckPatchProgressBar.Name = "CheckPatchProgressBar";
            this.CheckPatchProgressBar.Size = new System.Drawing.Size(200, 10);
            this.CheckPatchProgressBar.TabIndex = 32;
            this.CheckPatchProgressBar.Visible = false;
            // 
            // CheckPatchLabel
            // 
            this.CheckPatchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckPatchLabel.ForeColor = System.Drawing.Color.White;
            this.CheckPatchLabel.Location = new System.Drawing.Point(20, 180);
            this.CheckPatchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CheckPatchLabel.Name = "CheckPatchLabel";
            this.CheckPatchLabel.Size = new System.Drawing.Size(260, 70);
            this.CheckPatchLabel.TabIndex = 29;
            this.CheckPatchLabel.Text = "Проверка и скачивание клиента";
            // 
            // CheckPatchButton
            // 
            this.CheckPatchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.CheckPatchButton.FlatAppearance.BorderSize = 0;
            this.CheckPatchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckPatchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckPatchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CheckPatchButton.Location = new System.Drawing.Point(45, 280);
            this.CheckPatchButton.Name = "CheckPatchButton";
            this.CheckPatchButton.Size = new System.Drawing.Size(200, 40);
            this.CheckPatchButton.TabIndex = 4;
            this.CheckPatchButton.TabStop = false;
            this.CheckPatchButton.Text = "Запустить проверку";
            this.CheckPatchButton.UseVisualStyleBackColor = false;
            this.CheckPatchButton.Click += new System.EventHandler(this.CheckPatch_Click);
            // 
            // ModificationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ModificationsControl";
            this.Size = new System.Drawing.Size(1070, 640);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPatchLoad;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonDeletePath;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ProgressBar CheckPatchProgressBar;
        private System.Windows.Forms.Label CheckPatchLabel;
        private System.Windows.Forms.Button CheckPatchButton;
    }
}
