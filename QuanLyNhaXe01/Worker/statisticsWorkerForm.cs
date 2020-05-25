using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyNhaXe01
{
    public partial class statisticsWorkerForm : Form
    {
        public statisticsWorkerForm()
        {
            InitializeComponent();
        }

        MyDB mydb = new MyDB();

        private void statisticsWorkerForm_Load(object sender, EventArgs e)
        {
            DataTable tb = getTable();
           
            chart1.DataSource = tb;
            chart1.Series["Amount of people"].XValueMember = "TenCV";
            chart1.Series["Amount of people"].YValueMembers = "tong";
            

            Title title = new Title();
            title.Font = new Font("Arial", 16, FontStyle.Bold);
            title.Text = "Employee Statistics For Each Job";
            chart1.Titles.Add(title);

        }

        
         DataTable getTable()//lay ra tb cong viec va so nguoi lam cong viec do
        {
            Worker worker = new Worker();
            SqlCommand command = new SqlCommand("select Tho.MaCV,count(Tho.MaCV) as tong, CongViec.TenCV from Tho  inner join CongViec on CongViec.MaCV=Tho.MaCV group by Tho.MaCV,CongViec.TenCV", mydb.getConnection);
            return worker.getWorker(command);
        }

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
    }
}
