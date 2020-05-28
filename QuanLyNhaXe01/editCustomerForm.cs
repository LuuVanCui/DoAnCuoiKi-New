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
    public partial class editCustomerForm : Form
    {
        public editCustomerForm()
        {
            InitializeComponent();
        }

        Customer customer = new Customer();
        private void buttonAdd_Click(object sender, EventArgs e)
        {

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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

            string maKH = textBoxCustomerID.Text;
            string tenKH = textBoxCustomerName.Text;
            string cmnd = textBoxIdentityCard.Text;
            string diachi = textBoxAddress.Text;
            string sdt = textBoxPhone.Text;

            if (verify())
            {
                
                if (customer.updateCustomer(maKH, tenKH, cmnd, diachi, sdt))
                {
                    MessageBox.Show("New Customer Updated", "Edit Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Edit Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Empty Field, please enter the data! ", "Edit Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void editCustomerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
