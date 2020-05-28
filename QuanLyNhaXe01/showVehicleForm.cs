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
    public partial class showVehicleForm : Form
    {
        public showVehicleForm()
        {
            InitializeComponent();
        }

        Vehicle vehicle = new Vehicle();

        void fillGrid()
        {
            if (comboBoxTypeVehicle.Text == "Xe May")
            {
                dataGridViewVehicle.DataSource = vehicle.getVehicle(new SqlCommand("SELECT MaTheXe, LoaiXe, NguoiGui, BienSo, ThoiGianVao,HinhThucGui,TrangThaiGui  FROM dbo.Xe WHERE LoaiXe = 'Xe May'"));
                makeUpGridForXeMayAndXeDap();
            }
            else if (comboBoxTypeVehicle.Text == "Xe Dap")
            {
                dataGridViewVehicle.DataSource = vehicle.getVehicle(new SqlCommand("SELECT MaTheXe, LoaiXe, NguoiGui, AnhXe, ThoiGianVao, HinhThucGui,TrangThaiGui  FROM dbo.Xe WHERE LoaiXe = 'Xe Dap'"));
                makeUpGridForXeMayAndXeDap();
            }
            else if (comboBoxTypeVehicle.Text == "Xe Hoi")
            {
                dataGridViewVehicle.DataSource = vehicle.getVehicle(new SqlCommand("SELECT MaTheXe, LoaiXe, BienSo, HieuXe, ThoiGianVao, HinhThucGui, TrangThaiGui FROM Xe  WHERE LoaiXe = 'Xe Hoi' "));
                makeUpGridForXeMayAndXeDap();
            }
            else if (comboBoxTypeVehicle.Text == "Tat Ca")
            {
                dataGridViewVehicle.DataSource = vehicle.getVehicle(new SqlCommand("SELECT * FROM Xe"));
                makeUpGridForAllAndXeHoi();
            }

        }

        void makeUpGridForAllAndXeHoi()
        {
            try
            {
                dataGridViewVehicle.ReadOnly = true;

                DataGridViewImageColumn picCol2 = new DataGridViewImageColumn();
                DataGridViewImageColumn picCol3 = new DataGridViewImageColumn();
                DataGridViewImageColumn picCol4 = new DataGridViewImageColumn();
                DataGridViewImageColumn picCol5 = new DataGridViewImageColumn();


                dataGridViewVehicle.RowTemplate.Height = 80;

                picCol2 = (DataGridViewImageColumn)dataGridViewVehicle.Columns[2];
                picCol3 = (DataGridViewImageColumn)dataGridViewVehicle.Columns[3];
                picCol4 = (DataGridViewImageColumn)dataGridViewVehicle.Columns[4];
                picCol5 = (DataGridViewImageColumn)dataGridViewVehicle.Columns[5];

                picCol2.ImageLayout = DataGridViewImageCellLayout.Stretch;
                picCol3.ImageLayout = DataGridViewImageCellLayout.Stretch;
                picCol4.ImageLayout = DataGridViewImageCellLayout.Stretch;
                picCol5.ImageLayout = DataGridViewImageCellLayout.Stretch;

                dataGridViewVehicle.AllowUserToAddRows = false;
            }
            catch
            {

            }
        }

        void makeUpGridForXeMayAndXeDap()
        {
            try
            {
                dataGridViewVehicle.ReadOnly = true;

                DataGridViewImageColumn picCol2 = new DataGridViewImageColumn();
                DataGridViewImageColumn picCol3 = new DataGridViewImageColumn();

                dataGridViewVehicle.RowTemplate.Height = 80;

                picCol2 = (DataGridViewImageColumn)dataGridViewVehicle.Columns[2];
                picCol3 = (DataGridViewImageColumn)dataGridViewVehicle.Columns[3];

                picCol2.ImageLayout = DataGridViewImageCellLayout.Stretch;
                picCol3.ImageLayout = DataGridViewImageCellLayout.Stretch;

                dataGridViewVehicle.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void showVehicleForm_Load(object sender, EventArgs e)
        {
            comboBoxTypeVehicle.Text = "Tat Ca";
            fillGrid();
        }

        private void comboBoxTypeVehicle_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void dataGridViewVehicle_DoubleClick(object sender, EventArgs e)
        {

        }




        private void buttonEdit_Click(object sender, EventArgs e)
        {
            editVehiclesForm edit = new editVehiclesForm();
            edit.comboBoxCardID.Text = dataGridViewVehicle.CurrentRow.Cells[0].Value.ToString();
            edit.dateTimePickerInTime.Value = Convert.ToDateTime( dataGridViewVehicle.CurrentRow.Cells[6].Value.ToString());
            edit.comboBoxShape.Text = dataGridViewVehicle.CurrentRow.Cells[8].Value.ToString();
            string loaixe = dataGridViewVehicle.CurrentRow.Cells[1].Value.ToString();
            if(loaixe=="Xe May")
            {
                edit.radioButtonMoto.Checked = true;
            }
            else if(loaixe=="Xe Dap")
            {
                edit.radioButtonBike.Checked = true;
            }
            else
            {
                edit.radioButtonCar.Checked = true;
            }
            if (dataGridViewVehicle.CurrentRow.Cells[2].Value.ToString() != "")
            {
                byte[] bytes = (byte[])(dataGridViewVehicle.CurrentRow.Cells[2].Value);
                MemoryStream ms = new MemoryStream(bytes);
                edit.pictureBoxLicensePlate.Image = Image.FromStream(ms);
            }
            if (dataGridViewVehicle.CurrentRow.Cells[3].Value.ToString() != "")
            {
                byte[] bytes = (byte[])(dataGridViewVehicle.CurrentRow.Cells[3].Value);
                MemoryStream ms = new MemoryStream(bytes);
                edit.pictureBoxUser.Image = Image.FromStream(ms);
            }
            if (dataGridViewVehicle.CurrentRow.Cells[4].Value.ToString() != "")
            {
                byte[] bytes = (byte[])(dataGridViewVehicle.CurrentRow.Cells[4].Value);
                MemoryStream ms = new MemoryStream(bytes);
                edit.pictureBoxModel.Image = Image.FromStream(ms);
            }
            if (dataGridViewVehicle.CurrentRow.Cells[5].Value.ToString() != "")
            {
                byte[] bytes = (byte[])(dataGridViewVehicle.CurrentRow.Cells[5].Value);
                MemoryStream ms = new MemoryStream(bytes);
                edit.pictureBoxVehiclePicture.Image = Image.FromStream(ms);
            }

            edit.Show(this);
        }
    }
}
