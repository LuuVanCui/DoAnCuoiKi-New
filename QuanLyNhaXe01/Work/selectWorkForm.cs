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

namespace QuanLyNhaXe01
{
    public partial class selectWorkForm : Form
    {
        public selectWorkForm()
        {
            InitializeComponent();
        }

        private void selectWorkForm_Load(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            dataGridViewSelectWork.ReadOnly = true;
            string query = "select distinct * from CongViec";
            dataGridViewSelectWork.DataSource = vehicle.getVehicle(new SqlCommand(query));
            dataGridViewSelectWork.AllowUserToAddRows = false;
        }

        private void dataGridViewSelectWork_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
