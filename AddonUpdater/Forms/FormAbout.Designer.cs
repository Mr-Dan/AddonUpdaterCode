
namespace AddonUpdater.Forms
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_GitHub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Addon Updater";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(60, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(630, 65);
            this.label2.TabIndex = 1;
            this.label2.Text = "Addon Updater - программа для обновлений аддонов для игры World Of Warcraft.";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(60, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Автор: Дан (Днюша)";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(60, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Версия программы:";
            // 
            // labelVersion
            // 
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVersion.ForeColor = System.Drawing.Color.White;
            this.labelVersion.Location = new System.Drawing.Point(300, 240);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(180, 35);
            this.labelVersion.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(60, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(350, 35);
            this.label6.TabIndex = 6;
            this.label6.Text = "Контакты: Discord(Дан#7156)";
            // 
            // button_GitHub
            // 
            this.button_GitHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.button_GitHub.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_GitHub.BackgroundImage")));
            this.button_GitHub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_GitHub.FlatAppearance.BorderSize = 0;
            this.button_GitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GitHub.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_GitHub.Location = new System.Drawing.Point(710, 471);
            this.button_GitHub.Name = "button_GitHub";
            this.button_GitHub.Size = new System.Drawing.Size(78, 57);
            this.button_GitHub.TabIndex = 20;
            this.button_GitHub.UseVisualStyleBackColor = false;
            this.button_GitHub.Click += new System.EventHandler(this.button_GitHub_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.button_GitHub);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAbout";
            this.Text = "О программе";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_GitHub;
    }
}