using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaXe01
{
    public partial class addCustomerForm : Form
    {
        public addCustomerForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            string maKH = textBoxCustomerID.Text;
            string tenKH = textBoxCustomerName.Text;
            string cmnd = textBoxIdentityCard.Text;
            string diachi = textBoxAddress.Text;
            string sdt = textBoxPhone.Text;

            if (verify())
            {
                if (customer.Check_Customer(maKH))
                {
                    MessageBox.Show("Customer Already Exist, Try Another One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (customer.insertCustomer(maKH, tenKH, cmnd, diachi, sdt))
                    {
                        MessageBox.Show("New Customer Added", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Empty Field, please enter the data! ", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        bool verify()
        {
            if ((textBoxCustomerID.Text.Trim() == "")
                || (textBoxCustomerName.Text.Trim() == "")
                || (textBoxIdentityCard.Text.Trim() == "")
                || (textBoxAddress.Text.Trim() == "")
                || (textBoxPhone.Text.Trim() == ""))
            {
                return false;
            }
            else
                return true;
        }
    }
}
