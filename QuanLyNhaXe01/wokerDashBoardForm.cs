using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaXe01
{
    public partial class wokerDashBoardForm : Form
    {
        public wokerDashBoardForm()
        {
            InitializeComponent();
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            Checkin_out checkTime = new Checkin_out();
            if (MessageBox.Show("Do you want to Check-out?", "Check Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (checkTime.update_time_out(Globals.GlobalUserID, Globals.time_in, DateTime.Now))
                {
                    this.Close();
                }
            } 
        }

        private void wokerDashBoardForm_Load(object sender, EventArgs e)
        {
            try
            {
                Vehicle vehicle = new Vehicle();
                string query = "select * from Tho where MaTho = " + Globals.GlobalUserID;
                DataTable table = vehicle.getVehicle(new System.Data.SqlClient.SqlCommand(query));
                if (table.Rows[0][11].ToString() != "")
                {
                    byte[] bytes = (byte[])table.Rows[0][11];
                    MemoryStream ms = new MemoryStream(bytes);
                    pictureBoxProfile.Image = Image.FromStream(ms);
                }
                labelWelcome.Text = "Welcome " + table.Rows[0][1].ToString();
            }
            catch { }
        }

        int ss = 0; // giây
        int mm = 0; // phút
        int hh = 0; // giờ

        private void timerWorking_Tick(object sender, EventArgs e)
        {
            ss++;
            if (ss > 59)
            {
                ss = 0;
                labelSecond.Text = "00";
                mm++;
                if (mm > 59)
                {
                    mm = 0;
                    labelMinute.Text = "00";
                    hh++;
                    labelHour.Text = hh.ToString();
                }
                else
                {
                    if (mm < 10)
                        labelMinute.Text = "0" + mm.ToString();
                    else
                        labelMinute.Text = mm.ToString();
                }
            }
            else
            {
                if (ss < 10)
                    labelSecond.Text = "0" + ss.ToString();
                else
                    labelSecond.Text = ss.ToString();
            }
        }
    }
}
