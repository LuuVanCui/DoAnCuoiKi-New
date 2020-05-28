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
    public partial class addContractForm: Form
    {
        public addContractForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Contract contract = new Contract();
        Customer customer = new Customer();
        Vehicle vehicle = new Vehicle();
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string loaiHd = comboBoxContractType.Text;
            DateTime ngayKy = dateTimePickerSign.Value;
            string maKH = textBoxCustomerID.Text;
            string soXe = textBoxVehicleID.Text;
            string moTa = textBoxDescibe.Text;
            DateTime ngayNhiemThu = dateTimePicker_LeaseTerm.Value;
            string trangthaixe = "DangHD";

            /* try
             {*/
            if (verifyData())
            {
                int soHD = int.Parse(textBoxContractID.Text);
                double giaTriHD = double.Parse(textBoxContractValue.Text);
                double thanhtoan = double.Parse(textBoxPaid.Text);

                if (loaiHd == "Ky Gui")
                {
                    trangthaixe = "Dang Gui";
                }

                // kiem tra ma hop dong co bi trung ko
                if (contract.check_ID(soHD))
                {
                    //kiem tra xem thong tin khach hang da co chua
                    if (customer.Check_Customer(maKH))
                    {
                        if (vehicle.checkXe_Contract(soXe) == false)
                        {

                            MessageBox.Show("This vehicle is not on the list of contract vehicles, Please add or edit it before you add contract", "Add Contract", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (vehicle.checkTrangThai(soXe) == false)

                            {
                                MessageBox.Show("This Vehicle Was Busy, Try Another One", "Add Contract", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            //them cai kiem tra xe co ton tai trong ds xe hop dong chua
                            else if (contract.insert_table_HopDong(soHD, loaiHd, ngayKy, maKH, soXe, moTa, giaTriHD, ngayNhiemThu, thanhtoan, "DangHD") && vehicle.updateTrangThai(soXe, trangthaixe))
                            {
                                MessageBox.Show("New Contract Added", "Add Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error", "Add Contract", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Customer does not exist, please add new customer", "Invalid Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("This Contract ID Already Exists, Try Another One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Empty Field, please enter the data! ", "Add Contract", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            /* }
             catch
             {

             }*/
        }

        bool verifyData()
        {
            if ((textBoxContractID.Text.Trim() == "")
                || (comboBoxContractType.Text.Trim() == "")
                || (textBoxCustomerID.Text.Trim() == "")
                || (textBoxVehicleID.Text.Trim() == "")
                || (textBoxDescibe.Text.Trim() == "")
                || (textBoxContractValue.Text.Trim() == "")
                || (textBoxPaid.Text.Trim() == "")
                || (textBoxUnpaid.Text.Trim() == ""))
            {
                return false;
            }
            else
                return true;
        }

        private void buttonFindCustomer_Click(object sender, EventArgs e)
        {
            showCustomerForm show = new showCustomerForm();
            show.ShowDialog();
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            addCustomerForm add = new addCustomerForm();
            add.ShowDialog();
        }

        private void buttonAddVehicle_Click(object sender, EventArgs e)
        {
            addVehicleForm addvhc = new addVehicleForm();
            addvhc.Show(this);
        }

        private void buttonFindVehicle_Click(object sender, EventArgs e)
        {
            showVehicleForm vhc = new showVehicleForm();
            vhc.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addContractForm_Load(object sender, EventArgs e)
        {

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
        private void textBoxPaid_TextChanged_1(object sender, EventArgs e)
        {
            if (textBoxContractValue.Text.Trim() != "")
            {
                try
                {
                    double tien = double.Parse(textBoxContractValue.Text) - double.Parse(textBoxPaid.Text);
                    textBoxUnpaid.Text = tien.ToString();
                }
                catch
                {

                }
            }
        }
    }
}
