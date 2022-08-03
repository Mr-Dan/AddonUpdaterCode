
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
            this.components = new System.ComponentModel.Container();
            this.checkBoxAutoUpdate = new System.Windows.Forms.CheckBox();
            this.SavePathGame = new System.Windows.Forms.Button();
            this.labelPathGame = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxDescription = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxLauncher = new System.Windows.Forms.CheckBox();
            this.ButtonPathsShow = new System.Windows.Forms.Button();
            this.ContextMenuStripPaths = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeletePathGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxAutoUpdate
            // 
            this.checkBoxAutoUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBoxAutoUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxAutoUpdate.ForeColor = System.Drawing.Color.White;
            this.checkBoxAutoUpdate.Location = new System.Drawing.Point(9, 114);
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
            this.SavePathGame.Location = new System.Drawing.Point(760, 25);
            this.SavePathGame.Name = "SavePathGame";
            this.SavePathGame.Size = new System.Drawing.Size(120, 30);
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
            this.labelPathGame.Size = new System.Drawing.Size(745, 76);
            this.labelPathGame.TabIndex = 3;
            this.labelPathGame.Text = "Папка с игрой:\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 114);
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
            this.label2.Location = new System.Drawing.Point(32, 155);
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
            this.checkBoxDescription.Location = new System.Drawing.Point(9, 155);
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
            this.label3.Location = new System.Drawing.Point(32, 191);
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
            this.checkBoxLauncher.Location = new System.Drawing.Point(9, 191);
            this.checkBoxLauncher.Name = "checkBoxLauncher";
            this.checkBoxLauncher.Size = new System.Drawing.Size(15, 30);
            this.checkBoxLauncher.TabIndex = 8;
            this.checkBoxLauncher.TabStop = false;
            this.checkBoxLauncher.UseVisualStyleBackColor = true;
            this.checkBoxLauncher.CheckedChanged += new System.EventHandler(this.CheckBoxLauncher_CheckedChanged);
            // 
            // ButtonPathsShow
            // 
            this.ButtonPathsShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(128)))));
            this.ButtonPathsShow.FlatAppearance.BorderSize = 0;
            this.ButtonPathsShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPathsShow.ForeColor = System.Drawing.Color.White;
            this.ButtonPathsShow.Location = new System.Drawing.Point(855, 25);
            this.ButtonPathsShow.Name = "ButtonPathsShow";
            this.ButtonPathsShow.Size = new System.Drawing.Size(25, 30);
            this.ButtonPathsShow.TabIndex = 28;
            this.ButtonPathsShow.TabStop = false;
            this.ButtonPathsShow.Text = "▼";
            this.ButtonPathsShow.UseVisualStyleBackColor = false;
            this.ButtonPathsShow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonPathsShow_MouseClick);
            // 
            // ContextMenuStripPaths
            // 
            this.ContextMenuStripPaths.BackColor = System.Drawing.Color.LightGray;
            this.ContextMenuStripPaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ContextMenuStripPaths.Name = "ContextMenuStripPaths";
            this.ContextMenuStripPaths.ShowImageMargin = false;
            this.ContextMenuStripPaths.Size = new System.Drawing.Size(36, 4);
            this.ContextMenuStripPaths.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ContextMenuStripPaths_ItemClicked);
            this.ContextMenuStripPaths.MouseLeave += new System.EventHandler(this.ContextMenuStripPaths_MouseLeave);
            // 
            // DeletePathGame
            // 
            this.DeletePathGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.DeletePathGame.FlatAppearance.BorderSize = 0;
            this.DeletePathGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletePathGame.ForeColor = System.Drawing.Color.White;
            this.DeletePathGame.Location = new System.Drawing.Point(760, 61);
            this.DeletePathGame.Name = "DeletePathGame";
            this.DeletePathGame.Size = new System.Drawing.Size(120, 40);
            this.DeletePathGame.TabIndex = 30;
            this.DeletePathGame.TabStop = false;
            this.DeletePathGame.Text = "Удалить данный путь к игре";
            this.DeletePathGame.UseVisualStyleBackColor = false;
            this.DeletePathGame.Click += new System.EventHandler(this.DeletePathGame_Click);
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.DeletePathGame);
            this.Controls.Add(this.ButtonPathsShow);
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
        private System.Windows.Forms.Button ButtonPathsShow;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripPaths;
        private System.Windows.Forms.Button DeletePathGame;
    }
}