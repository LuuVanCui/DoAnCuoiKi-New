namespace QuanLyNhaXe01
{
    partial class showCustomerForm
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
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.textBoxSearchCustomer = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(3, 78);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.RowHeadersWidth = 62;
            this.dataGridViewCustomer.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewCustomer.RowTemplate.Height = 32;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(915, 461);
            this.dataGridViewCustomer.TabIndex = 4;
            // 
            // textBoxSearchCustomer
            // 
            this.textBoxSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxSearchCustomer.Location = new System.Drawing.Point(268, 33);
            this.textBoxSearchCustomer.Name = "textBoxSearchCustomer";
            this.textBoxSearchCustomer.Size = new System.Drawing.Size(504, 35);
            this.textBoxSearchCustomer.TabIndex = 14;
            this.textBoxSearchCustomer.TextChanged += new System.EventHandler(this.textBoxSearchCustomer_TextChanged_1);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label35.ForeColor = System.Drawing.Color.Brown;
            this.label35.Location = new System.Drawing.Point(146, 36);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(95, 29);
            this.label35.TabIndex = 13;
            this.label35.Text = "Search:";
            // 
            // showCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 551);
            this.Controls.Add(this.textBoxSearchCustomer);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.dataGridViewCustomer);
            this.Name = "showCustomerForm";
            this.Text = "Show Customer";
            this.Load += new System.EventHandler(this.showCustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.TextBox textBoxSearchCustomer;
        private System.Windows.Forms.Label label35;
    }
}