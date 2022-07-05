
namespace AddonUpdater.Forms
{
    partial class FormSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxAutoUpdate = new System.Windows.Forms.CheckBox();
            this.SavePathGame = new System.Windows.Forms.Button();
            this.labelPathGame = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxDescription = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxLauncher = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxAutoUpdate
            // 
            this.checkBoxAutoUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBoxAutoUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxAutoUpdate.ForeColor = System.Drawing.Color.White;
            this.checkBoxAutoUpdate.Location = new System.Drawing.Point(9, 95);
            this.checkBoxAutoUpdate.Name = "checkBoxAutoUpdate";
            this.checkBoxAutoUpdate.Size = new System.Drawing.Size(15, 30);
            this.checkBoxAutoUpdate.TabIndex = 3;
            this.checkBoxAutoUpdate.TabStop = false;
            this.checkBoxAutoUpdate.UseVisualStyleBackColor = true;
            this.checkBoxAutoUpdate.CheckedChanged += new System.EventHandler(this.CheckBoxAutoUpdate_CheckedChanged);
            // 
            // SavePathGame
            // 
            this.SavePathGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(128)))));
            this.SavePathGame.FlatAppearance.BorderSize = 0;
            this.SavePathGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SavePathGame.ForeColor = System.Drawing.Color.White;
            this.SavePathGame.Location = new System.Drawing.Point(788, 25);
            this.SavePathGame.Name = "SavePathGame";
            this.SavePathGame.Size = new System.Drawing.Size(100, 30);
            this.SavePathGame.TabIndex = 4;
            this.SavePathGame.TabStop = false;
            this.SavePathGame.Text = "Изменить";
            this.SavePathGame.UseVisualStyleBackColor = false;
            this.SavePathGame.Click += new System.EventHandler(this.SavePathGame_Click);
            // 
            // labelPathGame
            // 
            this.labelPathGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPathGame.ForeColor = System.Drawing.Color.White;
            this.labelPathGame.Location = new System.Drawing.Point(9, 25);
            this.labelPathGame.Name = "labelPathGame";
            this.labelPathGame.Size = new System.Drawing.Size(773, 50);
            this.labelPathGame.TabIndex = 3;
            this.labelPathGame.Text = "Папка с игрой:\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Автообновление аддонов";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Показывать описание аддона";
            // 
            // checkBoxDescription
            // 
            this.checkBoxDescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDescription.ForeColor = System.Drawing.Color.White;
            this.checkBoxDescription.Location = new System.Drawing.Point(9, 136);
            this.checkBoxDescription.Name = "checkBoxDescription";
            this.checkBoxDescription.Size = new System.Drawing.Size(15, 30);
            this.checkBoxDescription.TabIndex = 6;
            this.checkBoxDescription.TabStop = false;
            this.checkBoxDescription.UseVisualStyleBackColor = true;
            this.checkBoxDescription.CheckedChanged += new System.EventHandler(this.CheckBoxDescription_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(589, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Открывать лаунчер. Если открыт, открывать игру.\r\n";
            // 
            // checkBoxLauncher
            // 
            this.checkBoxLauncher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBoxLauncher.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxLauncher.ForeColor = System.Drawing.Color.White;
            this.checkBoxLauncher.Location = new System.Drawing.Point(9, 172);
            this.checkBoxLauncher.Name = "checkBoxLauncher";
            this.checkBoxLauncher.Size = new System.Drawing.Size(15, 30);
            this.checkBoxLauncher.TabIndex = 8;
            this.checkBoxLauncher.TabStop = false;
            this.checkBoxLauncher.UseVisualStyleBackColor = true;
            this.checkBoxLauncher.CheckedChanged += new System.EventHandler(this.CheckBoxLauncher_CheckedChanged);
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxLauncher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SavePathGame);
            this.Controls.Add(this.checkBoxAutoUpdate);
            this.Controls.Add(this.labelPathGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSetting";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.FormSetting_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxAutoUpdate;
        private System.Windows.Forms.Button SavePathGame;
        private System.Windows.Forms.Label labelPathGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxLauncher;
    }
}