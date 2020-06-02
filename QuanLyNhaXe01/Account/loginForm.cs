using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNhaXe01
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            MyDB db = new MyDB();
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();
            string query = "SELECT * FROM Login WHERE username=@User AND password=@Pass";
            if (radioButtonParking.Checked == true)
            {
                query = "SELECT * FROM Tho WHERE Username=@User AND Password=@Pass AND LoaiNguoiDung = 'Parking'";
            }
            else if (radioButtonWorker.Checked)
            {
                query = "SELECT * FROM Tho WHERE Username=@User AND Password=@Pass AND (LoaiNguoiDung = 'Worker')";
            }    
            SqlCommand cmd = new SqlCommand(query, db.getConnection);
            cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = textBoxUser.Text;
            cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBoxPassword.Text;

            adapter.SelectCommand = cmd;
            adapter.Fill(table);


            if ((table.Rows.Count > 0))
            {
                Checkin_out check_time = new Checkin_out();
                Globals.GlobalUserID = Convert.ToInt32(table.Rows[0][0].ToString());
                Globals.time_in = DateTime.Now;
                this.Close();
                if (radioButtonHumanResourse.Checked)
                {
                    dashboardForm dashboard = new dashboardForm();
                    dashboard.ShowDialog(this);
                }    
                else if (radioButtonParking.Checked)
                {
                    if (check_time.insert_Checkin(Globals.GlobalUserID, Globals.time_in))
                    {
                        MessageBox.Show("Check in Sucessfully!", "Check in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        manageVehiclesForm manageVehicles = new manageVehiclesForm();
                        manageVehicles.ShowDialog(this);
                    }
                }
                else
                {
                    if (check_time.insert_Checkin(Globals.GlobalUserID, Globals.time_in))
                    {
                        MessageBox.Show("Check in Sucessfully!", "Check in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        wokerDashBoardForm woker = new wokerDashBoardForm();
                        woker.ShowDialog(this);
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            radioButtonHumanResourse.Checked = true;
        }
    }
}
