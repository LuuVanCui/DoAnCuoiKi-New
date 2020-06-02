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
    public partial class statisticsSalaryForm : Form
    {
        public statisticsSalaryForm()
        {
            InitializeComponent();
        }
        MyDB mydb = new MyDB();
        private void buttonColumn_Click(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = SeriesChartType.Column;
        }

        private void buttonPie_Click(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = SeriesChartType.Pie;
        }

        private void buttonBar_Click(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = SeriesChartType.Bar;
        }

        private void statisticsSalaryForm_Load(object sender, EventArgs e)
        {
            DataTable tb = getTable();
            chart1.DataSource = tb;
            chart1.Series["VNĐ"].XValueMember = "LoaiNguoiDung";
            chart1.Series["VNĐ"].YValueMembers = "TongLuong";
            Title title = new Title();
            title.Font = new Font("Arial", 16, FontStyle.Bold);
            title.Text = "Statistics Salary";
            chart1.Titles.Add(title);
        }
        DataTable getTable()//lay ra tb cong viec va so nguoi lam cong viec do
        {

            Worker worker = new Worker();
            SqlCommand command = new SqlCommand("select Tho.LoaiNguoiDung, sum((DATEDIFF(hour, checkin_time, checkout_time) * MucLuong.Luong)) as 'TongLuong'  from Tho" +
                " inner join Luong on Tho.MaTho = Luong.MaTho inner join " +
                "MucLuong on MucLuong.LoaiTho = Tho.LoaiNguoiDung group by Tho.LoaiNguoiDung, MucLuong.Luong", mydb.getConnection);
            return worker.getWorker(command);
        }

    }
}
