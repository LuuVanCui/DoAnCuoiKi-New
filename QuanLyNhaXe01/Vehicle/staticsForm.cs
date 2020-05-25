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
    public partial class staticsForm : Form
    {
        public staticsForm()
        {
            InitializeComponent();
        }

        Vehicle vehicle = new Vehicle();

        private void staticsForm_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("Select LoaiXe, COUNT(LoaiXe) as tong from Xe where TrangThaiGui='Dang Gui' group by LoaiXe");
                DataTable tb = getTable(command);
                chart1.DataSource = tb;
            }
            catch
            {

            }
            chart1.Series["Number Of Vehicles"].XValueMember = "LoaiXe";
            chart1.Series["Number Of Vehicles"].YValueMembers = "tong";

            Title title = new Title();
            title.Font = new Font("Arial", 16, FontStyle.Bold);
            title.Text = "Statistics By Vehicle Type";
            chart1.Titles.Add(title);

        }

        DataTable getTable(SqlCommand command)//lay ra tb cong viec va so nguoi lam cong viec do
        {
                return vehicle.getVehicle(command);
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
