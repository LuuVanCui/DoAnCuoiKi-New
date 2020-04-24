using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaXe01
{
    public partial class paymentForm : Form
    {
        public paymentForm()
        {
            InitializeComponent();
        }
        Vehicle vehicle = new Vehicle();

        private string id;
        
        // Get ID by manageForm
        public paymentForm(string ID):this()
        {
            id = ID;
        }

        private void paymentForm_Load(object sender, EventArgs e)
        {

            paymentForm pay = new paymentForm();
            SqlCommand command = new SqlCommand("SELECT MaTheXe, LoaiXe, ThoiGianVao, AnhXe, BienSo, HinhThucGui FROM Xe WHERE MaTheXe = " + id);
            DataTable table = vehicle.getVehicle(command);

            if (table.Rows.Count > 0)
            {
                labelCardID.Text = table.Rows[0]["MaTheXe"].ToString();
                labelTypeOfVehicle.Text = table.Rows[0]["LoaiXe"].ToString();
                labelInTime.Text = table.Rows[0]["ThoiGianVao"].ToString();

                if (table.Rows[0][1].ToString() == "Xe Dap")
                {
                    labelPicture.Text = "Vehicle Picture:";
                    byte[] pic = (byte[])table.Rows[0]["AnhXe"];
                    MemoryStream AnhXe = new MemoryStream(pic);
                    pictureBoxVehiclePicture.Image = Image.FromStream(AnhXe);
                }
                else
                {
                    labelPicture.Text = "License Picture:";
                    byte[] pic = (byte[])table.Rows[0]["BienSo"];
                    MemoryStream BienSo = new MemoryStream(pic);
                    pictureBoxVehiclePicture.Image = Image.FromStream(BienSo);
                }    
            }

            labelShape.Text = table.Rows[0]["HinhThucGui"].ToString();
           
        }

       

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {

        }
    }
}
