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
    public partial class showCustomerForm : Form
    {
        public showCustomerForm()
        {
            InitializeComponent();
        }

        private void showCustomerForm_Load(object sender, EventArgs e)
        {
            MyDB mydb = new MyDB();
            Worker worker = new Worker();

            SqlCommand command = new SqlCommand("Select * from KhachHang");
            System.Data.DataTable tb = new System.Data.DataTable();
            tb = worker.getWorker(command);
            dataGridViewCustomer.DataSource = tb;
            dataGridViewCustomer.ReadOnly = true;
        }

        private void textBoxSearchCustomer_TextChanged_1(object sender, EventArgs e)
        {
            Contract contract = new Contract();
            SqlCommand command = new SqlCommand("select* from KhachHang Where Concat(MaKH,TenKH,CMND,DiaChi,SDT)  LIKE '%" + textBoxSearchCustomer.Text + "%' ");

            dataGridViewCustomer.DataSource = contract.getTable(command);
        }
    }
}
