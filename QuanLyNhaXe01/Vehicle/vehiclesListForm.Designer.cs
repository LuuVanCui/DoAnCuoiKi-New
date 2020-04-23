namespace QuanLyNhaXe01
{
    partial class vehiclesListForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBoxTypeVehicle = new System.Windows.Forms.ComboBox();
            this.xeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetQuanLyNhaXe = new QuanLyNhaXe01.DataSetQuanLyNhaXe();
            this.label1 = new System.Windows.Forms.Label();
            this.xeTableAdapter = new QuanLyNhaXe01.DataSetQuanLyNhaXeTableAdapters.XeTableAdapter();
            this.labelTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuanLyNhaXe)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1238, 362);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(449, 499);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(113, 52);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(720, 499);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(109, 52);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // comboBoxTypeVehicle
            // 
            this.comboBoxTypeVehicle.FormattingEnabled = true;
            this.comboBoxTypeVehicle.Location = new System.Drawing.Point(271, 20);
            this.comboBoxTypeVehicle.Name = "comboBoxTypeVehicle";
            this.comboBoxTypeVehicle.Size = new System.Drawing.Size(223, 28);
            this.comboBoxTypeVehicle.TabIndex = 3;
            // 
            // xeBindingSource
            // 
            this.xeBindingSource.DataMember = "Xe";
            this.xeBindingSource.DataSource = this.dataSetQuanLyNhaXe;
            // 
            // dataSetQuanLyNhaXe
            // 
            this.dataSetQuanLyNhaXe.DataSetName = "DataSetQuanLyNhaXe";
            this.dataSetQuanLyNhaXe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type Of Vehicle:";
            // 
            // xeTableAdapter
            // 
            this.xeTableAdapter.ClearBeforeFill = true;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(878, 46);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(52, 20);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Total: ";
            // 
            // vehiclesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 604);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTypeVehicle);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Name = "vehiclesListForm";
            this.Text = "formVehicleList";
            this.Load += new System.EventHandler(this.vehiclesListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuanLyNhaXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBoxTypeVehicle;
        private System.Windows.Forms.Label label1;
        private DataSetQuanLyNhaXe dataSetQuanLyNhaXe;
        private System.Windows.Forms.BindingSource xeBindingSource;
        private DataSetQuanLyNhaXeTableAdapters.XeTableAdapter xeTableAdapter;
        private System.Windows.Forms.Label labelTotal;
    }
}