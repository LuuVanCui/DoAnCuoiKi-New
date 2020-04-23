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

namespace QuanLyNhaXe01
{
    public partial class settingForm : Form
    {
        public settingForm()
        {
            InitializeComponent();
        }

        Calculate calculate = new Calculate();
        private void settingForm_Load(object sender, EventArgs e)
        {
            DataTable table = calculate.getData(new SqlCommand("SELECT * FROM PhiGuiXe"));

            // bike
            textBoxFeeByDayBike.Text = table.Rows[1][2].ToString();
            textBoxFeeByHourBike.Text = table.Rows[0][2].ToString();
            textBoxFeeByMonthBike.Text = table.Rows[3][2].ToString();
            textBoxFeeByWeekBike.Text = table.Rows[2][2].ToString();

            //moto
            textBoxFeeByHourMoto.Text = table.Rows[4][2].ToString();
            textBoxFeeByDayMoto.Text = table.Rows[5][2].ToString();
            textBoxFeeByWeekMoto.Text = table.Rows[6][2].ToString();
            textBoxFeeByMonthMoto.Text = table.Rows[7][2].ToString();

            //car
            textBoxFeeByWeekCar.Text = table.Rows[10][2].ToString();
            textBoxFeeByHourCar.Text = table.Rows[8][2].ToString();
            textBoxFeeByDayCar.Text = table.Rows[9][2].ToString();
            textBoxFeeByMonthCar.Text = table.Rows[11][2].ToString();
        }
    }
}
