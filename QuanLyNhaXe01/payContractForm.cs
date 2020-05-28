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
    public partial class payContractForm : Form
    {
        public payContractForm()
        {
            InitializeComponent();
        }
        Contract contract = new Contract();
        Vehicle vehicle = new Vehicle();
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void payContractForm_Load(object sender, EventArgs e)
        {
            DateTime leaseterm = Convert.ToDateTime(labelLeaseTearm.Text);
            TimeSpan late = DateTime.Now - leaseterm;
            labelLatetime.Text = late.Days.ToString() + " Days " + late.Hours.ToString() + " Hours";
    
            double valueCT = double.Parse(labelContractValue.Text);
            double penalty = 0;
            double paid = double.Parse(labelPaid.Text);
            if (late.Days > 0)
            {
                penalty = valueCT * 10 * late.Days / 100 + valueCT / 100 * late.Hours;
            }
            else if (late.Hours > 0)
            {
                penalty = valueCT * 0.05 * late.Hours;
            }
            labelPenalty.Text = penalty.ToString();
            labelPayment.Text = (penalty + valueCT - paid).ToString();
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            int contracID = int.Parse(labelContractID.Text);
            string maKh = labelCustomerID.Text;
            string soxe = labelVehicleID.Text;
            string loaiHD = labelContractTypeID.Text;
            string moTa = labelDescibe.Text;
            DateTime sign = Convert.ToDateTime(labelSignID.Text);
            DateTime ngayNhiemThu = Convert.ToDateTime(labelLeaseTearm.Text);
            double giaTriHD = Convert.ToDouble(labelContractValue.Text);
            double thanhtoan = Convert.ToDouble(labelPayment.Text);
            if (contract.update_table_HopDong(contracID, loaiHD, sign, maKh, soxe, moTa, giaTriHD, ngayNhiemThu, thanhtoan, "Ket Thuc") )
            {
                vehicle.updateTrangThai(soxe, "Dang Gui");
                MessageBox.Show("Pay Successfully", "Pay Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Pay Contract", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
