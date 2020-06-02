using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyNhaXe01
{
    public partial class statisticsRevenueForm : Form
    {
        public statisticsRevenueForm()
        {
            InitializeComponent();
        }

        private void statisticsRevenueForm_Load(object sender, EventArgs e)
        {

            DataTable tb = getTable();
            chart1.DataSource = tb;
            chart1.Series["VNĐ"].XValueMember = "LoaiXe";
            chart1.Series["VNĐ"].YValueMembers = "Phi";
            chart1.BackColor = Color.Chocolate;
            Title title = new Title();
            title.Font = new Font("Arial", 16, FontStyle.Bold);
            title.Text = "Statistics of parking costs of each vehicle type";
            chart1.Titles.Add(title);

            DataTable tb2 = getTableHD();
            chart2.DataSource = tb2;
            chart2.Series["VNĐ"].XValueMember = "LoaiHD";
            chart2.Series["VNĐ"].YValueMembers = "ThanhToan";
            Title title2 = new Title();
            title2.Font = new Font("Arial", 16, FontStyle.Bold);
            title2.Text = "Contract revenue";
            chart2.Titles.Add(title2);
            chart2.BackColor = Color.BurlyWood;

        }

        DataTable getTable()//lay ra tb cong viec va so nguoi lam cong viec do
        {
            MyDB mydb = new MyDB();
            Worker worker = new Worker();
            SqlCommand command = new SqlCommand(" select  LoaiXe, DoanhThu.Total as 'Phi' from Xe inner join DoanhThu on" +
                " DoanhThu.MaTheXe = Xe.MaTheXe where ThoiGianRa is not null group by Xe.LoaiXe, DoanhThu.Total", mydb.getConnection);
            return worker.getWorker(command);
        }
        DataTable getTableHD()//lay ra tb cong viec va so nguoi lam cong viec do
        {
            MyDB mydb = new MyDB();
            Worker worker = new Worker();
            SqlCommand command = new SqlCommand(" select LoaiHD,sum(ThanhToan) as 'ThanhToan' From HopDong group by LoaiHD ", mydb.getConnection);
            return worker.getWorker(command);
        }
        //select LoaiHD,sum(ThanhToan) as 'ThanhToan' From HopDong group by LoaiHD
        private void buttonColumn_Click(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = SeriesChartType.Column;
            chart2.Series[0].ChartType = SeriesChartType.Column;
        }

        private void buttonPie_Click(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = SeriesChartType.Pie;
            chart2.Series[0].ChartType = SeriesChartType.Pie;
        }

        private void buttonBar_Click(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = SeriesChartType.Bar;
        }
    }
}
