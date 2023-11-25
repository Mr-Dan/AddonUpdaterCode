namespace AddonUpdater.Controls
{
    partial class SettingsControl
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
            this.checkBoxAutoUpdate = new System.Windows.Forms.CheckBox();
            this.ContextMenuStripPaths = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SavePathGame = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.labelPathGame = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeletePathGame
            // 
            this.DeletePathGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.DeletePathGame.Dock = System.Windows.Forms.DockStyle.Right;
            this.DeletePathGame.FlatAppearance.BorderSize = 0;
            this.DeletePathGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletePathGame.ForeColor = System.Drawing.Color.White;
            this.DeletePathGame.Location = new System.Drawing.Point(109, 0);
            this.DeletePathGame.Margin = new System.Windows.Forms.Padding(4);
            this.DeletePathGame.Name = "DeletePathGame";
            this.DeletePathGame.Size = new System.Drawing.Size(160, 44);
            this.DeletePathGame.TabIndex = 40;
            this.DeletePathGame.TabStop = false;
            this.DeletePathGame.Text = "Удалить данный путь к игре";
            this.DeletePathGame.UseVisualStyleBackColor = false;
            this.DeletePathGame.Click += new System.EventHandler(this.DeletePathGame_Click);
            // 
            // ButtonPathsShow
            // 
            this.ButtonPathsShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(128)))));
            this.ButtonPathsShow.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonPathsShow.FlatAppearance.BorderSize = 0;
            this.ButtonPathsShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPathsShow.ForeColor = System.Drawing.Color.White;
            this.ButtonPathsShow.Location = new System.Drawing.Point(239, 0);
            this.ButtonPathsShow.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonPathsShow.Name = "ButtonPathsShow";
            this.ButtonPathsShow.Size = new System.Drawing.Size(30, 44);
            this.ButtonPathsShow.TabIndex = 39;
            this.ButtonPathsShow.TabStop = false;
            this.ButtonPathsShow.Text = "▼";
            this.ButtonPathsShow.UseVisualStyleBackColor = false;
            this.ButtonPathsShow.Click += new System.EventHandler(this.ButtonPathsShow_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(645, 104);
            this.label3.TabIndex = 38;
            this.label3.Text = "Открывать лаунчер. Если открыт, открывать игру.\r\n";
            // 
            // checkBoxLauncher
            // 
            this.checkBoxLauncher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBoxLauncher.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxLauncher.ForeColor = System.Drawing.Color.White;
            this.checkBoxLauncher.Location = new System.Drawing.Point(20, 260);
            this.checkBoxLauncher.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxLauncher.Name = "checkBoxLauncher";
            this.checkBoxLauncher.Size = new System.Drawing.Size(20, 40);
            this.checkBoxLauncher.TabIndex = 37;
            this.checkBoxLauncher.TabStop = false;
            this.checkBoxLauncher.UseVisualStyleBackColor = true;
            this.checkBoxLauncher.CheckedChanged += new System.EventHandler(this.CheckBoxLauncher_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(732, 30);
            this.label2.TabIndex = 36;
            this.label2.Text = "Показывать описание аддона";
            // 
            // checkBoxDescription
            // 
            this.checkBoxDescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDescription.ForeColor = System.Drawing.Color.White;
            this.checkBoxDescription.Location = new System.Drawing.Point(20, 210);
            this.checkBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxDescription.Name = "checkBoxDescription";
            this.checkBoxDescription.Size = new System.Drawing.Size(20, 40);
            this.checkBoxDescription.TabIndex = 35;
            this.checkBoxDescription.TabStop = false;
            this.checkBoxDescription.UseVisualStyleBackColor = true;
            this.checkBoxDescription.CheckedChanged += new System.EventHandler(this.CheckBoxDescription_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(732, 30);
            this.label1.TabIndex = 34;
            this.label1.Text = "Автообновление аддонов";
            // 
            // checkBoxAutoUpdate
            // 
            this.checkBoxAutoUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBoxAutoUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxAutoUpdate.ForeColor = System.Drawing.Color.White;
            this.checkBoxAutoUpdate.Location = new System.Drawing.Point(20, 160);
            this.checkBoxAutoUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxAutoUpdate.Name = "checkBoxAutoUpdate";
            this.checkBoxAutoUpdate.Size = new System.Drawing.Size(20, 40);
            this.checkBoxAutoUpdate.TabIndex = 31;
            this.checkBoxAutoUpdate.TabStop = false;
            this.checkBoxAutoUpdate.UseVisualStyleBackColor = true;
            this.checkBoxAutoUpdate.CheckedChanged += new System.EventHandler(this.CheckBoxAutoUpdate_CheckedChanged);
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
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(761, 30);
            this.label4.TabIndex = 41;
            this.label4.Text = "Папка с игрой:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(781, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 640);
            this.panel1.TabIndex = 42;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.DeletePathGame);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 84);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(269, 44);
            this.panel6.TabIndex = 42;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 64);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(269, 20);
            this.panel5.TabIndex = 41;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.SavePathGame);
            this.panel4.Controls.Add(this.ButtonPathsShow);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(269, 44);
            this.panel4.TabIndex = 2;
            // 
            // SavePathGame
            // 
            this.SavePathGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(128)))));
            this.SavePathGame.Dock = System.Windows.Forms.DockStyle.Right;
            this.SavePathGame.FlatAppearance.BorderSize = 0;
            this.SavePathGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SavePathGame.ForeColor = System.Drawing.Color.White;
            this.SavePathGame.Location = new System.Drawing.Point(109, 0);
            this.SavePathGame.Margin = new System.Windows.Forms.Padding(4);
            this.SavePathGame.Name = "SavePathGame";
            this.SavePathGame.Size = new System.Drawing.Size(130, 44);
            this.SavePathGame.TabIndex = 40;
            this.SavePathGame.TabStop = false;
            this.SavePathGame.Text = "Изменить";
            this.SavePathGame.UseVisualStyleBackColor = false;
            this.SavePathGame.Click += new System.EventHandler(this.SavePathGame_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(269, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 620);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 20);
            this.panel2.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.labelPathGame);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.checkBoxLauncher);
            this.panel7.Controls.Add(this.checkBoxDescription);
            this.panel7.Controls.Add(this.checkBoxAutoUpdate);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(781, 640);
            this.panel7.TabIndex = 43;
            // 
            // labelPathGame
            // 
            this.labelPathGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPathGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPathGame.ForeColor = System.Drawing.Color.White;
            this.labelPathGame.Location = new System.Drawing.Point(20, 60);
            this.labelPathGame.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPathGame.Name = "labelPathGame";
            this.labelPathGame.Size = new System.Drawing.Size(761, 94);
            this.labelPathGame.TabIndex = 45;
            this.labelPathGame.Click += new System.EventHandler(this.LabelPathGame_Click);
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(1070, 640);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
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
        private System.Windows.Forms.CheckBox checkBoxAutoUpdate;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripPaths;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label labelPathGame;
        private System.Windows.Forms.Button SavePathGame;
    }
}
