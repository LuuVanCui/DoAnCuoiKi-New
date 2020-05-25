namespace QuanLyNhaXe01
{
    partial class selectWorkForm
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
            this.dataGridViewSelectWork = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectWork)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSelectWork
            // 
            this.dataGridViewSelectWork.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSelectWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelectWork.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewSelectWork.Name = "dataGridViewSelectWork";
            this.dataGridViewSelectWork.RowHeadersWidth = 62;
            this.dataGridViewSelectWork.RowTemplate.Height = 28;
            this.dataGridViewSelectWork.Size = new System.Drawing.Size(679, 537);
            this.dataGridViewSelectWork.TabIndex = 0;
            this.dataGridViewSelectWork.Click += new System.EventHandler(this.dataGridViewSelectWork_Click);
            // 
            // selectWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 561);
            this.Controls.Add(this.dataGridViewSelectWork);
            this.Name = "selectWorkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Work";
            this.Load += new System.EventHandler(this.selectWorkForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectWork)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewSelectWork;
    }
}