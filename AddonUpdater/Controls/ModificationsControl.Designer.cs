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
            this.buttonPatchLoad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.panel1.Controls.Add(this.pictureBoxLogo);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonPatchLoad);
            this.panel1.Location = new System.Drawing.Point(30, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 350);
            this.panel1.TabIndex = 0;
            // 
            // buttonPatchLoad
            // 
            this.buttonPatchLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.buttonPatchLoad.FlatAppearance.BorderSize = 0;
            this.buttonPatchLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPatchLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPatchLoad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPatchLoad.Location = new System.Drawing.Point(45, 275);
            this.buttonPatchLoad.Name = "buttonPatchLoad";
            this.buttonPatchLoad.Size = new System.Drawing.Size(197, 56);
            this.buttonPatchLoad.TabIndex = 4;
            this.buttonPatchLoad.TabStop = false;
            this.buttonPatchLoad.Text = "Установить патч";
            this.buttonPatchLoad.UseVisualStyleBackColor = false;
            this.buttonPatchLoad.Click += new System.EventHandler(this.buttonPatchLoad_Click);
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
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(45, 255);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(200, 10);
            this.progressBar1.TabIndex = 32;
            this.progressBar1.Visible = false;
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
            // ModificationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.panel1);
            this.Name = "ModificationsControl";
            this.Size = new System.Drawing.Size(1070, 640);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPatchLoad;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}
