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
    public partial class editContractForm : Form
    {
        public editContractForm()
        {
            InitializeComponent();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        // chức năng kiểm tra dữ liệu input
        bool verif()
        {
            if (textBoxContractID.Text.Trim() == ""
                || textBoxCustomerID.Text.Trim() == ""
                || comboBoxVehicleType.Text.Trim() == ""
                || textBoxContractValue.Text.Trim() == ""
                || textBoxDescibe.Text.Trim() == ""
                || textBoxContractValue.Text.Trim() == ""
                || comboBoxContractType.Text.Trim() == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
