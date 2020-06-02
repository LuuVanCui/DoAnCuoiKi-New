namespace QuanLyNhaXe01
{
    partial class statisticsRevenueForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonColumn = new System.Windows.Forms.Button();
            this.buttonPie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonColumn);
            this.groupBox1.Controls.Add(this.buttonPie);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(1102, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 397);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chart Type";
            // 
            // buttonColumn
            // 
            this.buttonColumn.BackColor = System.Drawing.Color.Cyan;
            this.buttonColumn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonColumn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonColumn.Location = new System.Drawing.Point(15, 82);
            this.buttonColumn.Name = "buttonColumn";
            this.buttonColumn.Size = new System.Drawing.Size(139, 71);
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
            this.buttonPie.Location = new System.Drawing.Point(15, 268);
            this.buttonPie.Name = "buttonPie";
            this.buttonPie.Size = new System.Drawing.Size(139, 71);
            this.buttonPie.TabIndex = 3;
            this.buttonPie.Text = "Pie";
            this.buttonPie.UseVisualStyleBackColor = false;
            this.buttonPie.Click += new System.EventHandler(this.buttonPie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(463, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 57);
            this.label1.TabIndex = 8;
            this.label1.Text = "Statistics ";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(36, 156);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "VNĐ";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(501, 465);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            title3.Name = "Employee Statistics For Each Job";
            this.chart1.Titles.Add(title3);
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            this.chart2.Cursor = System.Windows.Forms.Cursors.Default;
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(584, 156);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "VNĐ";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(501, 465);
            this.chart2.TabIndex = 10;
            this.chart2.Text = "chart2";
            title4.Name = "Employee Statistics For Each Job";
            this.chart2.Titles.Add(title4);
            // 
            // statisticsRevenueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1297, 644);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "statisticsRevenueForm";
            this.Text = "Statistics Revenue";
            this.Load += new System.EventHandler(this.statisticsRevenueForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonColumn;
        private System.Windows.Forms.Button buttonPie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}