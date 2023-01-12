namespace AddonUpdater.Controls
{
    partial class AddonUpdaterSettingsControl
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
            this.components = new System.ComponentModel.Container();
            this.DeletePathGame = new System.Windows.Forms.Button();
            this.ButtonPathsShow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxLauncher = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxDescription = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SavePathGame = new System.Windows.Forms.Button();
            this.checkBoxAutoUpdate = new System.Windows.Forms.CheckBox();
            this.labelPathGame = new System.Windows.Forms.Label();
            this.ContextMenuStripPaths = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // DeletePathGame
            // 
            this.DeletePathGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.DeletePathGame.FlatAppearance.BorderSize = 0;
            this.DeletePathGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletePathGame.ForeColor = System.Drawing.Color.White;
            this.DeletePathGame.Location = new System.Drawing.Point(1015, 58);
            this.DeletePathGame.Margin = new System.Windows.Forms.Padding(4);
            this.DeletePathGame.Name = "DeletePathGame";
            this.DeletePathGame.Size = new System.Drawing.Size(160, 49);
            this.DeletePathGame.TabIndex = 40;
            this.DeletePathGame.TabStop = false;
            this.DeletePathGame.Text = "Удалить данный путь к игре";
            this.DeletePathGame.UseVisualStyleBackColor = false;
            this.DeletePathGame.Click += new System.EventHandler(this.DeletePathGame_Click);
            // 
            // ButtonPathsShow
            // 
            this.ButtonPathsShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(128)))));
            this.ButtonPathsShow.FlatAppearance.BorderSize = 0;
            this.ButtonPathsShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPathsShow.ForeColor = System.Drawing.Color.White;
            this.ButtonPathsShow.Location = new System.Drawing.Point(1142, 14);
            this.ButtonPathsShow.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonPathsShow.Name = "ButtonPathsShow";
            this.ButtonPathsShow.Size = new System.Drawing.Size(33, 37);
            this.ButtonPathsShow.TabIndex = 39;
            this.ButtonPathsShow.TabStop = false;
            this.ButtonPathsShow.Text = "▼";
            this.ButtonPathsShow.UseVisualStyleBackColor = false;
            this.ButtonPathsShow.Click += new System.EventHandler(this.ButtonPathsShow_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(785, 31);
            this.label3.TabIndex = 38;
            this.label3.Text = "Открывать лаунчер. Если открыт, открывать игру.\r\n";
            // 
            // checkBoxLauncher
            // 
            this.checkBoxLauncher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBoxLauncher.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxLauncher.ForeColor = System.Drawing.Color.White;
            this.checkBoxLauncher.Location = new System.Drawing.Point(14, 218);
            this.checkBoxLauncher.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxLauncher.Name = "checkBoxLauncher";
            this.checkBoxLauncher.Size = new System.Drawing.Size(20, 37);
            this.checkBoxLauncher.TabIndex = 37;
            this.checkBoxLauncher.TabStop = false;
            this.checkBoxLauncher.UseVisualStyleBackColor = true;
            this.checkBoxLauncher.CheckedChanged += new System.EventHandler(this.CheckBoxLauncher_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(445, 31);
            this.label2.TabIndex = 36;
            this.label2.Text = "Показывать описание аддона";
            // 
            // checkBoxDescription
            // 
            this.checkBoxDescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDescription.ForeColor = System.Drawing.Color.White;
            this.checkBoxDescription.Location = new System.Drawing.Point(14, 174);
            this.checkBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxDescription.Name = "checkBoxDescription";
            this.checkBoxDescription.Size = new System.Drawing.Size(20, 37);
            this.checkBoxDescription.TabIndex = 35;
            this.checkBoxDescription.TabStop = false;
            this.checkBoxDescription.UseVisualStyleBackColor = true;
            this.checkBoxDescription.CheckedChanged += new System.EventHandler(this.CheckBoxDescription_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 31);
            this.label1.TabIndex = 34;
            this.label1.Text = "Автообновление аддонов";
            // 
            // SavePathGame
            // 
            this.SavePathGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(128)))));
            this.SavePathGame.FlatAppearance.BorderSize = 0;
            this.SavePathGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SavePathGame.ForeColor = System.Drawing.Color.White;
            this.SavePathGame.Location = new System.Drawing.Point(1015, 14);
            this.SavePathGame.Margin = new System.Windows.Forms.Padding(4);
            this.SavePathGame.Name = "SavePathGame";
            this.SavePathGame.Size = new System.Drawing.Size(160, 37);
            this.SavePathGame.TabIndex = 33;
            this.SavePathGame.TabStop = false;
            this.SavePathGame.Text = "Изменить";
            this.SavePathGame.UseVisualStyleBackColor = false;
            this.SavePathGame.Click += new System.EventHandler(this.SavePathGame_Click);
            // 
            // checkBoxAutoUpdate
            // 
            this.checkBoxAutoUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBoxAutoUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxAutoUpdate.ForeColor = System.Drawing.Color.White;
            this.checkBoxAutoUpdate.Location = new System.Drawing.Point(14, 123);
            this.checkBoxAutoUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxAutoUpdate.Name = "checkBoxAutoUpdate";
            this.checkBoxAutoUpdate.Size = new System.Drawing.Size(20, 37);
            this.checkBoxAutoUpdate.TabIndex = 31;
            this.checkBoxAutoUpdate.TabStop = false;
            this.checkBoxAutoUpdate.UseVisualStyleBackColor = true;
            this.checkBoxAutoUpdate.CheckedChanged += new System.EventHandler(this.CheckBoxAutoUpdate_CheckedChanged);
            // 
            // labelPathGame
            // 
            this.labelPathGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPathGame.ForeColor = System.Drawing.Color.White;
            this.labelPathGame.Location = new System.Drawing.Point(14, 14);
            this.labelPathGame.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPathGame.Name = "labelPathGame";
            this.labelPathGame.Size = new System.Drawing.Size(993, 94);
            this.labelPathGame.TabIndex = 32;
            this.labelPathGame.Text = "Папка с игрой:\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // ContextMenuStripPaths
            // 
            this.ContextMenuStripPaths.BackColor = System.Drawing.Color.LightGray;
            this.ContextMenuStripPaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ContextMenuStripPaths.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStripPaths.Name = "ContextMenuStripPaths";
            this.ContextMenuStripPaths.ShowImageMargin = false;
            this.ContextMenuStripPaths.Size = new System.Drawing.Size(36, 4);
            this.ContextMenuStripPaths.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ContextMenuStripPaths_ItemClicked);
            this.ContextMenuStripPaths.MouseLeave += new System.EventHandler(this.ContextMenuStripPaths_MouseLeave);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddonUpdaterSettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
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
            this.Name = "AddonUpdaterSettingsControl";
            this.Size = new System.Drawing.Size(1217, 325);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeletePathGame;
        private System.Windows.Forms.Button ButtonPathsShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxLauncher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SavePathGame;
        private System.Windows.Forms.CheckBox checkBoxAutoUpdate;
        private System.Windows.Forms.Label labelPathGame;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripPaths;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
