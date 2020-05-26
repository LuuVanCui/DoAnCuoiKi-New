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
    public partial class editContractForm : Form
    {
        public editContractForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Customer customer = new Customer();
        Contract contract = new Contract();

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string loaiHd = comboBoxContractType.Text;
            DateTime ngayKy = dateTimePickerSign.Value;
            string maKH = textBoxCustomerID.Text;
            string soXe = textBoxVehicleID.Text;
            string moTa = textBoxDescibe.Text;
            DateTime ngayNhiemThu = dateTimePicker_LeaseTerm.Value;

            try
            {
                if (verifyData())
                {
                    int soHD = int.Parse(textBoxContractID.Text);
                    float giaTriHD = float.Parse(textBoxContractValue.Text);
                    double thanhToan = double.Parse(textBoxPaid.Text);

                    // kiem tra ma hop dong co bi trung ko
                    /*if (contract.check_ID(soHD))
                    {*/
                        //kiem tra xem thong tin khach hang da co chua
                        if (customer.Check_Customer(maKH))
                        {
                            //them cai kiem tra xe co ton tai trong ds xe hop dong chua

                            if (contract.update_table_HopDong(soHD, loaiHd, ngayKy, maKH, soXe, moTa, giaTriHD, ngayNhiemThu,thanhToan))
                            {
                                MessageBox.Show("Update Successfully", "Update Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error", "Update Contract", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Customer does not exist, please add new customer", "Invalid Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                   /* }
                    else
                    {
                        MessageBox.Show("This Contract ID Already Exists, Try Another One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }*/

                }
                else
                {
                    MessageBox.Show("Empty Field, please enter the data! ", "Update Contract", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {

            }
        }

        bool verifyData()
        {
            if ((textBoxContractID.Text.Trim() == "")
                || (comboBoxContractType.Text.Trim() == "")
                || (textBoxCustomerID.Text.Trim() == "")
                || (textBoxVehicleID.Text.Trim() == "")
                || (textBoxDescibe.Text.Trim() == "")
                || (textBoxContractValue.Text.Trim() == ""))

            {
                return false;
            }
            else
                return true;
        }

        private void dateTimePickerSign_ValueChanged(object sender, EventArgs e)
        {

        }

        private void editContractForm_Load(object sender, EventArgs e)
        {
            fillComboBoxType_Contract();
        }

        void fillComboBoxType_Contract()
        {

            MyDB mydb = new MyDB();
            try
            {
                SqlCommand command = new SqlCommand("Select* from HopDong", mydb.getConnection);
                comboBoxContractType.DataSource = contract.getTable(command);
                comboBoxContractType.DisplayMember = "LoaiHD";
                comboBoxContractType.ValueMember = "SoHD";
            }
            catch
            {

            }
        }

    }
}
