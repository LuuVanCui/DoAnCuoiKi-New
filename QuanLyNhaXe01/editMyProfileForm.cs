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
    public partial class editMyProfileForm : Form
    {
        public editMyProfileForm()
        {
            InitializeComponent();
        }

        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg; *.png; *gif)|*.jpg; *.png; *gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxProfile.Image = Image.FromFile(opf.FileName);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                USER user = new USER();
                string fname = textBoxFName.Text;
                string lname = textBoxLName.Text;
                string uname = textBoxUName.Text;
                string pass = textBoxPass.Text;
                MemoryStream pic = new MemoryStream();

                if (verif())
                {

                    if (user.usernameExist(uname, "edit", Globals.GlobalUserID))
                    {
                        MessageBox.Show("User Name are already exist.", "Edit Profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        pictureBoxProfile.Image.Save(pic, pictureBoxProfile.Image.RawFormat);
                        if (user.updateUser(Globals.GlobalUserID, fname, lname, uname, pass, pic))
                        {
                            MessageBox.Show("Update Suceess!", "Edit Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error", "Edit Profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Profile", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void editMyProfileForm_Load(object sender, EventArgs e)
        {
            USER user = new USER();
            DataTable table = user.getUser(new SqlCommand("SELECT * FROM login WHERE id = " + Globals.GlobalUserID));
            textBoxFName.Text = table.Rows[0][1].ToString();
            textBoxLName.Text = table.Rows[0][2].ToString();
            textBoxUName.Text = table.Rows[0][3].ToString();
            textBoxPass.Text = table.Rows[0][4].ToString();

            if (table.Rows[0][5].ToString() != "")
            {
                byte[] bytes = (byte[])table.Rows[0][5];
                MemoryStream ms = new MemoryStream(bytes);
                pictureBoxProfile.Image = Image.FromStream(ms);
            }     
        }

        bool verif()
        {
            if (textBoxFName.Text == null
                || textBoxLName.Text == null
                || textBoxUName.Text == null
                || textBoxPass.Text == null
                || pictureBoxProfile.Image == null)
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
