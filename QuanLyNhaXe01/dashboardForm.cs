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
    public partial class dashboardForm : Form
    {
        public dashboardForm()
        {
            InitializeComponent();
        }

        private void buttonAddVehicle_Click(object sender, EventArgs e)
        {
            addVehicleForm addVehicle = new addVehicleForm();
            addVehicle.Show(this);
        }

        private void buttonEditVehicle_Click(object sender, EventArgs e)
        {
            editVehiclesForm editVehicle = new editVehiclesForm();
            editVehicle.Show(this);
        }

        private void buttonRemoveVehicle_Click(object sender, EventArgs e)
        {
            deleteVehicleByID deleteVehicle = new deleteVehicleByID();
            deleteVehicle.Show(this);
        }

        private void buttonShowAllVehicle_Click(object sender, EventArgs e)
        {
            manageVehiclesForm manageVehicle = new manageVehiclesForm();
            manageVehicle.Show(this);
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            paymentForm payment = new paymentForm();
            payment.Show(this); 
        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            staticsForm statics = new staticsForm();
            statics.Show(this);
        }

        private void buttonSlot_Click(object sender, EventArgs e)
        {

        }

        

        private void tabPageVehicles_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddWorker_Click(object sender, EventArgs e)
        {

        }
    }
}
