namespace QuanLyNhaXe01
{
    partial class showVehicleForm
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
            this.dataGridViewVehicle = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTypeVehicle = new System.Windows.Forms.ComboBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVehicle
            // 
            this.dataGridViewVehicle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehicle.Location = new System.Drawing.Point(21, 78);
            this.dataGridViewVehicle.Name = "dataGridViewVehicle";
            this.dataGridViewVehicle.RowHeadersWidth = 62;
            this.dataGridViewVehicle.RowTemplate.Height = 28;
            this.dataGridViewVehicle.Size = new System.Drawing.Size(1218, 432);
            this.dataGridViewVehicle.TabIndex = 1;
            this.dataGridViewVehicle.DoubleClick += new System.EventHandler(this.dataGridViewVehicle_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(293, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Type Of Vehicle:";
            // 
            // comboBoxTypeVehicle
            // 
            this.comboBoxTypeVehicle.FormattingEnabled = true;
            this.comboBoxTypeVehicle.Items.AddRange(new object[] {
            "",
            "Xe May",
            "Xe Dap",
            "Xe Hoi",
            "Tat Ca"});
            this.comboBoxTypeVehicle.Location = new System.Drawing.Point(517, 31);
            this.comboBoxTypeVehicle.Name = "comboBoxTypeVehicle";
            this.comboBoxTypeVehicle.Size = new System.Drawing.Size(270, 28);
            this.comboBoxTypeVehicle.TabIndex = 5;
            this.comboBoxTypeVehicle.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeVehicle_SelectedIndexChanged_1);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEdit.Location = new System.Drawing.Point(887, 524);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(173, 52);
            this.buttonEdit.TabIndex = 8;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRefresh.Location = new System.Drawing.Point(229, 524);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(181, 52);
            this.buttonRefresh.TabIndex = 7;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            // 
            // showVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1260, 588);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTypeVehicle);
            this.Controls.Add(this.dataGridViewVehicle);
            this.Name = "showVehicleForm";
            this.Text = "Show Vehicle";
            this.Load += new System.EventHandler(this.showVehicleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVehicle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTypeVehicle;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonRefresh;
    }
}