
namespace AddonUpdater.Forms
{
    partial class FormAllAddons
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAllAddons));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewAddons = new System.Windows.Forms.DataGridView();
            this.button_Dowload = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.buttonLauncher = new System.Windows.Forms.Button();
            this.PanelDescription = new System.Windows.Forms.Panel();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddons)).BeginInit();
            this.PanelDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewAddons
            // 
            this.dataGridViewAddons.AllowUserToAddRows = false;
            this.dataGridViewAddons.AllowUserToDeleteRows = false;
            this.dataGridViewAddons.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.dataGridViewAddons.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAddons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAddons.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.dataGridViewAddons.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewAddons.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(130)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(130)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAddons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAddons.ColumnHeadersHeight = 30;
            this.dataGridViewAddons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewAddons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAddons.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewAddons.EnableHeadersVisualStyles = false;
            this.dataGridViewAddons.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewAddons.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAddons.Name = "dataGridViewAddons";
            this.dataGridViewAddons.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAddons.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewAddons.RowHeadersVisible = false;
            this.dataGridViewAddons.RowHeadersWidth = 50;
            this.dataGridViewAddons.RowTemplate.Height = 25;
            this.dataGridViewAddons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAddons.Size = new System.Drawing.Size(800, 450);
            this.dataGridViewAddons.TabIndex = 22;
            this.dataGridViewAddons.TabStop = false;
            this.dataGridViewAddons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAddons_CellContentClick);
            this.dataGridViewAddons.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAddons_CellMouseLeave);
            this.dataGridViewAddons.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewAddons_CellMouseMove);
            this.dataGridViewAddons.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGridViewAddons_MouseMove);
            // 
            // button_Dowload
            // 
            this.button_Dowload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(128)))));
            this.button_Dowload.FlatAppearance.BorderSize = 0;
            this.button_Dowload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Dowload.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_Dowload.Location = new System.Drawing.Point(645, 450);
            this.button_Dowload.Name = "button_Dowload";
            this.button_Dowload.Size = new System.Drawing.Size(150, 35);
            this.button_Dowload.TabIndex = 19;
            this.button_Dowload.TabStop = false;
            this.button_Dowload.Text = "Скачать";
            this.button_Dowload.UseVisualStyleBackColor = false;
            this.button_Dowload.Click += new System.EventHandler(this.button_Dowload_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.button_update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_update.BackgroundImage")));
            this.button_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_update.FlatAppearance.BorderSize = 0;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Location = new System.Drawing.Point(590, 450);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(50, 35);
            this.button_update.TabIndex = 23;
            this.button_update.TabStop = false;
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // buttonLauncher
            // 
            this.buttonLauncher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.buttonLauncher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLauncher.BackgroundImage")));
            this.buttonLauncher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLauncher.FlatAppearance.BorderSize = 0;
            this.buttonLauncher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLauncher.ForeColor = System.Drawing.Color.White;
            this.buttonLauncher.Location = new System.Drawing.Point(540, 450);
            this.buttonLauncher.Name = "buttonLauncher";
            this.buttonLauncher.Size = new System.Drawing.Size(50, 35);
            this.buttonLauncher.TabIndex = 24;
            this.buttonLauncher.TabStop = false;
            this.buttonLauncher.UseVisualStyleBackColor = false;
            this.buttonLauncher.Click += new System.EventHandler(this.buttonLauncher_Click);
            // 
            // PanelDescription
            // 
            this.PanelDescription.Controls.Add(this.LabelDescription);
            this.PanelDescription.ForeColor = System.Drawing.Color.White;
            this.PanelDescription.Location = new System.Drawing.Point(12, 410);
            this.PanelDescription.MaximumSize = new System.Drawing.Size(800, 200);
            this.PanelDescription.Name = "PanelDescription";
            this.PanelDescription.Size = new System.Drawing.Size(800, 15);
            this.PanelDescription.TabIndex = 25;
            this.PanelDescription.Visible = false;
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoEllipsis = true;
            this.LabelDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDescription.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelDescription.Location = new System.Drawing.Point(0, 0);
            this.LabelDescription.MaximumSize = new System.Drawing.Size(800, 500);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(800, 15);
            this.LabelDescription.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 400F;
            this.Column1.HeaderText = "Название";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 200F;
            this.Column2.HeaderText = "Версия";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.NullValue = false;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column4.FillWeight = 160F;
            this.Column4.HeaderText = "Скачать";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FormAllAddons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.PanelDescription);
            this.Controls.Add(this.buttonLauncher);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.dataGridViewAddons);
            this.Controls.Add(this.button_Dowload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAllAddons";
            this.Text = "Все аддоны";
            this.Load += new System.EventHandler(this.FormAllAddons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddons)).EndInit();
            this.PanelDescription.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAddons;
        private System.Windows.Forms.Button button_Dowload;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button buttonLauncher;
        private System.Windows.Forms.Panel PanelDescription;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
    }
}