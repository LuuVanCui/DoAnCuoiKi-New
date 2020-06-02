namespace QuanLyNhaXe01
{
    partial class statisticsSalaryForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonBar = new System.Windows.Forms.Button();
            this.buttonColumn = new System.Windows.Forms.Button();
            this.buttonPie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonBar);
            this.groupBox1.Controls.Add(this.buttonColumn);
            this.groupBox1.Controls.Add(this.buttonPie);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(765, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 417);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chart Type";
            // 
            // buttonBar
            // 
            this.buttonBar.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonBar.Location = new System.Drawing.Point(25, 282);
            this.buttonBar.Name = "buttonBar";
            this.buttonBar.Size = new System.Drawing.Size(159, 71);
            this.buttonBar.TabIndex = 4;
            this.buttonBar.Text = "Bar";
            this.buttonBar.UseVisualStyleBackColor = false;
            this.buttonBar.Click += new System.EventHandler(this.buttonBar_Click);
            // 
            // buttonColumn
            // 
            this.buttonColumn.BackColor = System.Drawing.Color.Cyan;
            this.buttonColumn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonColumn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonColumn.Location = new System.Drawing.Point(25, 78);
            this.buttonColumn.Name = "buttonColumn";
            this.buttonColumn.Size = new System.Drawing.Size(159, 71);
            this.buttonColumn.TabIndex = 2;
            this.buttonColumn.Text = "Columun";
            this.buttonColumn.UseVisualStyleBackColor = false;
            this.buttonColumn.Click += new System.EventHandler(this.buttonColumn_Click);
            // 
            // buttonPie
            // 
            this.buttonPie.BackColor = System.Drawing.Color.Purple;
            this.buttonPie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonPie.Location = new System.Drawing.Point(25, 179);
            this.buttonPie.Name = "buttonPie";
            this.buttonPie.Size = new System.Drawing.Size(159, 71);
            this.buttonPie.TabIndex = 3;
            this.buttonPie.Text = "Pie";
            this.buttonPie.UseVisualStyleBackColor = false;
            this.buttonPie.Click += new System.EventHandler(this.buttonPie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(278, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 57);
            this.label1.TabIndex = 8;
            this.label1.Text = "Statistics ";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.DimGray;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(74, 109);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "VNĐ";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(664, 507);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            title1.Name = "Employee Statistics For Each Job";
            this.chart1.Titles.Add(title1);
            // 
            // statisticsSalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1051, 646);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "statisticsSalaryForm";
            this.Text = "Statistics Salary";
            this.Load += new System.EventHandler(this.statisticsSalaryForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonBar;
        private System.Windows.Forms.Button buttonColumn;
        private System.Windows.Forms.Button buttonPie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}