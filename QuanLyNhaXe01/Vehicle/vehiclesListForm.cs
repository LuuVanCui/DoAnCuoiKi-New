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
    public partial class vehiclesListForm : Form
    {
        public vehiclesListForm()
        {
            InitializeComponent();
        }

        Vehicle vehicle = new Vehicle();
        private void vehiclesListForm_Load(object sender, EventArgs e)
        {
            DataTable dt = vehicle.getTypeVehicle();
            dt.Rows.Add(new Object[]{
                "Tat Ca"
            });
            comboBoxTypeVehicle.DataSource = dt;
            comboBoxTypeVehicle.ValueMember = "LoaiXe";
            comboBoxTypeVehicle.DisplayMember = "LoaiXe";
            fillGrid();

        }

        void makeUpGridForAllVehicle()
        {
            dataGridView1.ReadOnly = true;

            DataGridViewImageColumn picCol2 = new DataGridViewImageColumn();
            DataGridViewImageColumn picCol3 = new DataGridViewImageColumn();
            DataGridViewImageColumn picCol6 = new DataGridViewImageColumn();
            DataGridViewImageColumn picCol7 = new DataGridViewImageColumn();

            dataGridView1.RowTemplate.Height = 80;

            //     dataGridView1.DataSource = student.getStudents(command);

            picCol2 = (DataGridViewImageColumn)dataGridView1.Columns[2];

            picCol3 = (DataGridViewImageColumn)dataGridView1.Columns[3];

            picCol6 = (DataGridViewImageColumn)dataGridView1.Columns[6];

            picCol7 = (DataGridViewImageColumn)dataGridView1.Columns[7];

            picCol2.ImageLayout = DataGridViewImageCellLayout.Stretch;

            picCol3.ImageLayout = DataGridViewImageCellLayout.Stretch;

            picCol6.ImageLayout = DataGridViewImageCellLayout.Stretch;

            picCol7.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AllowUserToAddRows = false;
        }


        void fillGrid()
        {
            if (comboBoxTypeVehicle.Text == "Xe May")
            {
                dataGridView1.DataSource = vehicle.getVehicle(new SqlCommand("SELECT MaTheXe, LoaiXe, NguoiGui, AnhXe, ThoiGianVao, Slot FROM dbo.Xe WHERE LoaiXe = 'Xe May'"));
            }
            else if (comboBoxTypeVehicle.Text == "Xe Dap")
            {
                dataGridView1.DataSource = vehicle.getVehicle(new SqlCommand("SELECT MaTheXe, LoaiXe, NguoiGui, AnhXe, ThoiGianVao, Slot FROM dbo.Xe WHERE LoaiXe = 'Xe Dap'"));
            }
            else if (comboBoxTypeVehicle.Text == "Xe Hoi")
            {
                dataGridView1.DataSource = vehicle.getVehicle(new SqlCommand("SELECT *FROM Xe  WHERE LoaiXe = 'Xe Hoi'"));
            }
            else
            {
                dataGridView1.DataSource = vehicle.getVehicle(new SqlCommand("SELECT *FROM Xe"));
            }
        }
    }
}
