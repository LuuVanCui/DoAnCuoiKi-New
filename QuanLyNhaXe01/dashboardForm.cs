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
using System.Drawing.Printing;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using Microsoft.Office.Interop.Excel;

namespace QuanLyNhaXe01
{
    public partial class dashboardForm : Form
    {
        public dashboardForm()
        {
            InitializeComponent();
            this.dataGridViewVehicle.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewVehicle_DataError);
        }

        private void dashboardForm_Load(object sender, EventArgs e)
        {
            #region TABAR
            USER user = new USER();
            System.Data.DataTable hrTable = user.getUser(new SqlCommand("SELECT * FROM login WHERE id = " + Globals.GlobalUserID));
            /* byte[] bytes = (byte[])hrTable.Rows[0][5];
             MemoryStream ms = new MemoryStream(bytes);
             pictureBoxProfile.Image = Image.FromStream(ms);*/
            labelWelcome.Text = "Welcome " + hrTable.Rows[0]["fname"].ToString().Trim() + " " + hrTable.Rows[0]["lname"].ToString();
            #endregion

            #region VEHICLES
            vehicleControls();
            System.Data.DataTable table = vehicle.getVehicle(new SqlCommand("SELECT * FROM PhiGuiXeVaSlot"));

            // fill textbox
            textBoxTotalSlot_Bike.Text = table.Rows[0]["Slot"].ToString();
            textBoxTotalSlot_Car.Text = table.Rows[1]["Slot"].ToString();
            textBoxTotalSlot_Moto.Text = table.Rows[2]["Slot"].ToString();
            textBoxPrice_Bike.Text = table.Rows[0]["Phi"].ToString();
            textBoxPrice_Car.Text = table.Rows[1]["Phi"].ToString();
            textBoxPrice_Moto.Text = table.Rows[2]["Phi"].ToString();
            labelDangGui.Text = "Existing: " + vehicle.totalVehicle_in();
            labelDaRa.Text = "Leave: " + vehicle.totalVehicle_out();
            labelStatus.Text = "Total Vehicle: " + vehicle.totalVehicle();

            #endregion

            #region WORK

            comboBoxGroupName_work.DataSource = vehicle.getVehicle(new SqlCommand("SELECT * FROM Nhom"));
            comboBoxGroupName_work.DisplayMember = "TenNhom";
            comboBoxGroupName_work.ValueMember = "MaNhom";

            // edit
            comboBoxEditGroup_work.DataSource = vehicle.getVehicle(new SqlCommand("SELECT * FROM Nhom"));
            comboBoxEditGroup_work.DisplayMember = "TenNhom";
            comboBoxEditGroup_work.ValueMember = "MaNhom";

            // remove
            comboBoxRemoveGroup_work.DataSource = vehicle.getVehicle(new SqlCommand("SELECT * FROM Nhom"));
            comboBoxRemoveGroup_work.DisplayMember = "TenNhom";
            comboBoxRemoveGroup_work.ValueMember = "MaNhom";

            // listBox
            listBoxGroup_work.DataSource = vehicle.getVehicle(new SqlCommand("SELECT * FROM Nhom"));
            listBoxGroup_work.DisplayMember = "TenNhom";
            listBoxGroup_work.ValueMember = "MaNhom";
            listBoxGroup_work.SelectedItem = null;
            listBoxGroup_work.ClearSelected();

            // dataGid Show Data
            string query_grid_work = "select distinct Tho.MaTho, TenTho, GioiTinh, SDT, TenNhom, TenCV " +
                "from Tho inner join CongViec on Tho.MaCV = CongViec.MaCV" +
                " inner join Nhom on Tho.MaNhom = Nhom.MaNhom";
            dataGridViewWork.DataSource = vehicle.getVehicle(new SqlCommand(query_grid_work));
            #endregion

            #region WORKER

            fillDatagridWorker();
            fillComboboxGroup_Worker();
            fillComboBoxWork_Worker();

            #endregion

            #region CONTRACT
            fillDatagridContract();
            #endregion
        }

        #region Tabar----------------------------------------------------------
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabelEditInfo_Click(object sender, EventArgs e)
        {
            editMyProfileForm editInfo = new editMyProfileForm();
            editInfo.ShowDialog(this);
        }

        private void linkLabelRefresh_Click(object sender, EventArgs e)
        {
            dashboardForm_Load(sender, e);
        }
        #endregion

        #region Vehicles-------------------------------------------------------

        Vehicle vehicle = new Vehicle();

        void makeUpGridForAllAndXeHoi()
        {
            try
            {
                dataGridViewVehicle.ReadOnly = true;

                DataGridViewImageColumn picCol2 = new DataGridViewImageColumn();
                DataGridViewImageColumn picCol3 = new DataGridViewImageColumn();
                DataGridViewImageColumn picCol4 = new DataGridViewImageColumn();
                DataGridViewImageColumn picCol5 = new DataGridViewImageColumn();

                SqlCommand command = new SqlCommand(" Select distinct T.MaTho , T.TenTho , T.GioiTinh ,T.CMND, T.NgaySinh, T.SDT, T.DiaChi, N.TenNhom, CV.TenCV, T.NgayBatDau  from Tho T inner join Nhom N on T.MaNhom = N.MaNhom inner join CongViec CV on T.MaCV = CV.MaCV  ");

                dataGridViewWorker.DataSource = vehicle.getVehicle(command);

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

        private void textBoxSearchVehicle_TextChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT *FROM Xe WHERE CONCAT(MaTheXe, LoaiXe, ThoiGianVao, ThoiGianRa, HinhThucGui, TrangThaiGui) LIKE '%" + textBoxSearchVehicle.Text + "%'");
            dataGridViewVehicle.DataSource = vehicle.getVehicle(command);
        }

        private void radioButtonBike_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewVehicle.DataSource = vehicle.getVehicle(new SqlCommand("SELECT MaTheXe, LoaiXe, NguoiGui, AnhXe, ThoiGianVao, HinhThucGui,TrangThaiGui FROM dbo.Xe WHERE LoaiXe = 'Xe Dap'"));
            makeUpGridForXeMayAndXeDap();
        }

        private void radioButtonMoto_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewVehicle.DataSource = vehicle.getVehicle(new SqlCommand("SELECT MaTheXe, LoaiXe, NguoiGui, BienSo, ThoiGianVao, HinhThucGui, TrangThaiGui FROM dbo.Xe WHERE LoaiXe = 'Xe May'"));
            makeUpGridForXeMayAndXeDap();
        }

        private void radioButtonCar_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewVehicle.DataSource = vehicle.getVehicle(new SqlCommand("SELECT MaTheXe, LoaiXe, HieuXe, BienSo, ThoiGianVao, HinhThucGui,TrangThaiGui FROM Xe  WHERE LoaiXe = 'Xe Hoi'"));
            makeUpGridForXeMayAndXeDap();
        }

        private void radioButtonAllVehicle_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewVehicle.DataSource = vehicle.getVehicle(new SqlCommand("SELECT * FROM Xe"));
            makeUpGridForAllAndXeHoi();
        }

        void vehicleControls()
        {
            radioButtonAllVehicle.Checked = true;
            dataGridViewVehicle.DataSource = vehicle.getVehicle(new SqlCommand("SELECT * FROM Xe"));
        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            staticsForm statics = new staticsForm();
            statics.Show(this);
        }

        private void buttonSetBike_Click(object sender, EventArgs e)
        {
            PriceAndSlot setting = new PriceAndSlot();
            try
            {
                int slot = Convert.ToInt32(textBoxTotalSlot_Bike.Text);
                float price = float.Parse(textBoxPrice_Bike.Text);
                if (setting.updatePriceAndSlot("Xe Dap", price, slot))
                {
                    MessageBox.Show("Set successful!", "Set Bike", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Set fail", "Set Bike", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Set Bike", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSetMoto_Click(object sender, EventArgs e)
        {
            PriceAndSlot setting = new PriceAndSlot();
            try
            {
                int slot = Convert.ToInt32(textBoxTotalSlot_Moto.Text);
                float price = float.Parse(textBoxPrice_Moto.Text);
                if (setting.updatePriceAndSlot("Xe May", price, slot))
                {
                    MessageBox.Show("Set successful!", "Set Moto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Set fail", "Set Moto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Set Moto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSetCar_Click(object sender, EventArgs e)
        {
            PriceAndSlot setting = new PriceAndSlot();
            try
            {
                int slot = Convert.ToInt32(textBoxTotalSlot_Car.Text);
                float price = float.Parse(textBoxPrice_Car.Text);
                if (setting.updatePriceAndSlot("Xe Hoi", price, slot))
                {
                    MessageBox.Show("Set successful!", "Set Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Set fail", "Set Car", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Set Car", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExportVehicle_Click(object sender, EventArgs e)
        {
            // Tham khảo link: https://stackoverflow.com/questions/18182029/how-to-export-datagridview-data-instantly-to-excel-on-button-click

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "Inventory_Adjustment_Export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Copy DataGridView results to clipboard
                copyAlltoClipboard();

                object misValue = System.Reflection.Missing.Value;
                Excel.Application xlexcel = new Excel.Application();

                xlexcel.DisplayAlerts = false; // Without this you will get two confirm overwrite prompts
                Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(misValue);
                Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                // Format column D as text before pasting results, this was required for my data
                Excel.Range rng = xlWorkSheet.get_Range("D:D").Cells;
                rng.NumberFormat = "@";

                // Paste clipboard results to worksheet range
                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                // For some reason column A is always blank in the worksheet. ¯\_(ツ)_/¯
                // Delete blank column A and select cell A1
                Excel.Range delRng = xlWorkSheet.get_Range("A:A").Cells;
                delRng.Delete(Type.Missing);
                xlWorkSheet.get_Range("A1").Select();

                // Save the excel file under the captured location from the SaveFileDialog
                xlWorkBook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlexcel.DisplayAlerts = true;
                xlWorkBook.Close(true, misValue, misValue);
                xlexcel.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlexcel);

                // Clear Clipboard and DataGridView selection
                Clipboard.Clear();
                dataGridViewVehicle.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }

        }

        private void copyAlltoClipboard()
        {
            dataGridViewVehicle.SelectAll();
            DataObject dataObj = dataGridViewVehicle.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void buttonPrintVehicle_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;

            if (printDlg.ShowDialog() == DialogResult.OK)
                printDoc.Print();

        }

        private void dataGridViewVehicle_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        #region Worker---------------------------------------------------------
        Worker worker = new Worker();

        void fillComboBoxWork_Worker()
        {
            comboBoxWork_Worker.DataSource = work.getWork();
            comboBoxWork_Worker.DisplayMember = "TenCV";
            comboBoxWork_Worker.ValueMember = "MaCV";
        }

        void fillComboboxGroup_Worker()
        {
            comboBoxGroup_Worker.DataSource = worker.getGroup_Worker();
            comboBoxGroup_Worker.DisplayMember = "TenNhom";
            comboBoxGroup_Worker.ValueMember = "MaNhom";
        }

        void fillDatagridWorker()
        {

            MyDB mydb = new MyDB();
            Worker worker = new Worker();
            SqlCommand command = new SqlCommand(" Select distinct T.MaTho , T.TenTho , T.GioiTinh ,T.CMND, T.NgaySinh, T.SDT, T.DiaChi, N.TenNhom, CV.TenCV, T.NgayBatDau  from Tho T inner join Nhom N on T.MaNhom = N.MaNhom inner join CongViec CV on T.MaCV = CV.MaCV  ");

            dataGridViewWorker.DataSource = worker.getWorker(command);
        }

        private void buttonAddWorker_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker();

            string name = textBoxFullName.Text;
            string CMND = textBoxIdentityCard.Text;
            // || (radioButtonMale.Checked == false && radioButtonFeMale.Checked == false)
            string phone = textBoxPhoneWorker.Text;

            DateTime bdate = dateTimePickerBDate_Worker.Value;
            DateTime dateStart = dateTimePickerDateStart_Worker.Value;

            string address = textBoxAddressWorker.Text;
            // string work = comboBoxWork_Worker.Text;
            string maCV = comboBoxWork_Worker.SelectedValue.ToString();
            int maNhom = int.Parse(comboBoxGroup_Worker.SelectedValue.ToString());


            string gender = "";

            try
            {
                if (verifyData())
                {
                    int w_id = int.Parse(textBoxWorkerID.Text);
                    if (radioButtonFeMale.Checked == true)
                    {
                        gender = "Female";

                    }
                    else
                    {
                        gender = "Male";
                    }

                    if (worker.checkID(int.Parse(textBoxWorkerID.Text)))
                    {
                        // kiem tra tren 18 tuoi
                        int tuoi = DateTime.Now.Year - dateTimePickerBDate_Worker.Value.Year;
                        if (tuoi < 18)
                        {
                            MessageBox.Show("Worker age is younger than 18", "Add Worker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        else
                        {
                            if (worker.insertWorker(w_id, name, gender, CMND, bdate, address, phone, maNhom, maCV, dateStart))
                            {
                                MessageBox.Show("New Worker Added", "Add Worker", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {
                                MessageBox.Show("Error", "Add Worker", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("This ID Already Exists, Try Another One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Add Worker", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //load lai datagrid
            fillDatagridWorker();
        }

        private void buttonEditWorker_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker();

            string name = textBoxFullName.Text;
            string CMND = textBoxIdentityCard.Text;
            // || (radioButtonMale.Checked == false && radioButtonFeMale.Checked == false)
            string phone = textBoxPhoneWorker.Text;

            DateTime bdate = dateTimePickerBDate_Worker.Value;
            DateTime dateStart = dateTimePickerDateStart_Worker.Value;

            string address = textBoxAddressWorker.Text;
            string maCV = comboBoxWork_Worker.SelectedValue.ToString();
            int maNhom = int.Parse(comboBoxGroup_Worker.SelectedValue.ToString());

            string gender = "";


            try
            {
                if (verifyData())
                {
                    int w_id = int.Parse(textBoxWorkerID.Text);
                    if (radioButtonFeMale.Checked == true)
                    {
                        gender = "Female";

                    }
                    else
                    {
                        gender = "Male";
                    }

                    //if (worker.checkID(int.Parse(textBoxWorkerID.Text)) && )
                    // {
                    // kiem tra tren 18 tuoi
                    int tuoi = DateTime.Now.Year - dateTimePickerBDate_Worker.Value.Year;
                    if (tuoi < 18)
                    {
                        MessageBox.Show("Worker age is younger than 18", "Update Worker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    else
                    {
                        if (worker.updateWorker(w_id, name, gender, CMND, bdate, address, phone, maNhom, maCV, dateStart))
                        {
                            MessageBox.Show("New Worker Updated", "Update Worker", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Error", "Update Worker", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    //}
                    /* else
                     {
                         MessageBox.Show("This ID Already Exists, Try Another One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     }*/
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Update Worker", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //load lai datagrid
            fillDatagridWorker();
        }

        private void dataGridViewWorker_DoubleClick(object sender, EventArgs e)
        {

            if (dataGridViewWorker.CurrentRow.Cells[2].Value.ToString() == "Female")
            {
                radioButtonFeMale.Checked = true;

            }
            else
            {
                radioButtonMale.Checked = true;
            }

            textBoxFullName.Text = dataGridViewWorker.CurrentRow.Cells[1].Value.ToString();
            textBoxWorkerID.Text = dataGridViewWorker.CurrentRow.Cells[0].Value.ToString();
            textBoxIdentityCard.Text = dataGridViewWorker.CurrentRow.Cells[3].Value.ToString();
            // || (radioButtonMale.Checked == false && radioButtonFeMale.Checked == false)
            textBoxPhoneWorker.Text = dataGridViewWorker.CurrentRow.Cells[6].Value.ToString();

            dateTimePickerBDate_Worker.Value = Convert.ToDateTime(dataGridViewWorker.CurrentRow.Cells[4].Value);
            dateTimePickerDateStart_Worker.Value = Convert.ToDateTime(dataGridViewWorker.CurrentRow.Cells[5].Value);

            textBoxAddressWorker.Text = dataGridViewWorker.CurrentRow.Cells[7].Value.ToString();

            comboBoxWork_Worker.Text = dataGridViewWorker.CurrentRow.Cells[8].Value.ToString();
        }

        private void buttonPrintWorker_Click(object sender, EventArgs e)
        {

            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Worker";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;

            if (printDlg.ShowDialog() == DialogResult.OK) printDoc.Print();
        }

        private void buttonRemoveWorker_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewWorker.Rows.Count > 1)
                {
                    int id = int.Parse(dataGridViewWorker.CurrentRow.Cells[0].Value.ToString());

                    Worker worker = new Worker();


                    if ((MessageBox.Show("Do you want to delete this Worker", "Remove Worker", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                    {
                        if (worker.deleteWorker(id))
                        {
                            MessageBox.Show("Worker Deleted", "Remove Worker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //clear fields
                            textBoxWorkerID.Text = "";

                            textBoxFullName.Text = "";
                            textBoxIdentityCard.Text = "";
                            //dioButtonMale.Checked == false && radioButtonFeMale.Checked == false)

                            textBoxPhoneWorker.Text = "";
                            textBoxAddressWorker.Text = "";

                            radioButtonMale.Checked = false;
                            radioButtonFeMale.Checked = false;
                            fillDatagridWorker();
                        }
                        else
                        {
                            MessageBox.Show("Worker not deleted", "remove Worker", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You have to select data in Data GridView", "Remove Worker", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //verify data
        bool verifyData()
        {
            if ((textBoxWorkerID.Text.Trim() == "")
                || (textBoxFullName.Text.Trim() == "")
                || (textBoxIdentityCard.Text.Trim() == "")
                || (radioButtonMale.Checked == false && radioButtonFeMale.Checked == false)
                || (textBoxPhoneWorker.Text.Trim() == "")
                || (textBoxAddressWorker.Text.Trim() == "")

                || (comboBoxWork_Worker.Text.Trim() == ""))
            {
                return false;
            }
            else return true;


        }

        //xuat file word
        private void buttonExportWorker_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "WorkerList.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_Word(dataGridViewWorker, sfd.FileName);
            }
        }

        private void textBoxSearchWorker_TextChanged(object sender, EventArgs e)
        {
            Worker worker = new Worker();
            SqlCommand command = new SqlCommand("Select distinct T.MaTho , T.TenTho , T.GioiTinh ,T.CMND, T.NgaySinh, T.SDT, T.DiaChi, N.TenNhom, CV.TenCV, T.NgayBatDau " +
                " from Tho T inner join Nhom N on T.MaNhom = N.MaNhom inner join CongViec CV on T.MaCV = CV.MaCV " +
                " WHERE CONCAT(T.MaTho, T." +
                "TenTho, T.GioiTinh, T.CMND, T.NgaySinh, T.DiaChi, T.SDT, T.NgayBatDau, CV.TenCV, N.TenNhom) LIKE'%" + textBoxSearchWorker.Text + "%'");

            dataGridViewWorker.DataSource = worker.getWorker(command);
        }

        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    } //end row loop
                } //end column loop

                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;

                //page orintation
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;


                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";

                    }
                }

                //table format
                oRange.Text = oTemp;

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                //table style 
                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                //header text
                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "your header text";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                //save the file
                oDoc.SaveAs2(filename);

                //NASSIM LOUCHANI
            }
        }
        #endregion

        #region Work-----------------------------------------------------------

        Work work = new Work();
        private void buttonAdd_Work_Click(object sender, EventArgs e)
        {
            try
            {
                string workID = textBoxWorkID_Work.Text;
                int workerID = Convert.ToInt32(textBoxWorkerID_work.Text);
                string workName = textBoxWorkName_work.Text;
                string contain = textBoxWorkDetail_work.Text;
                int groupID = Convert.ToInt32(comboBoxGroupName_work.SelectedValue.ToString());
                if (work.insertWork(workID, workerID, workName, contain, groupID))
                {
                    MessageBox.Show("Add Successful!", "Add Work", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Add Fail.", "Add Work", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Work", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonEdit_Work_Click(object sender, EventArgs e)
        {
            try
            {
                string workID = textBoxWorkID_Work.Text;
                int workerID = Convert.ToInt32(textBoxWorkerID_work.Text);
                string workName = textBoxWorkName_work.Text;
                string contain = textBoxWorkDetail_work.Text;
                int groupID = Convert.ToInt32(comboBoxGroupName_work.SelectedValue.ToString());
                if (work.insertWork(workID, workerID, workName, contain, groupID))
                {
                    MessageBox.Show("Update Successful!", "Edit Work", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Edit Fail.", "Edit Work", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Work", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonRemove_Work_Click(object sender, EventArgs e)
        {
            try
            {
                string workID = textBoxWorkID_Work.Text;
                int workerID = Convert.ToInt32(textBoxWorkerID_work.Text);

                if (MessageBox.Show("Do you want to remove this work?", "Delete Work", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (work.deleteWork(workID, workerID))
                    {
                        MessageBox.Show("This work deleted", "Delete Work", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Delete Fail.", "Delete Work", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Work", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonAddGroup_work_Click(object sender, EventArgs e)
        {
            try
            {
                int groupID = Convert.ToInt32(textBoxAddGroupID_work.Text);
                string groupName = textBoxAddGroup_work.Text;
                Group group = new Group();
                if (group.insertGroup(groupID, groupName))
                {
                    MessageBox.Show("Add Successful!", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dashboardForm_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Add Fail.", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonEditGroup_work_Click(object sender, EventArgs e)
        {
            try
            {
                int groupID = Convert.ToInt32(comboBoxEditGroup_work.SelectedValue.ToString());
                string groupName = textBoxNewGroup_work.Text;
                Group group = new Group();
                if (group.updateGroup(groupID, groupName))
                {
                    MessageBox.Show("Update Successful!", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dashboardForm_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Update Fail.", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonRemoveGroup_work_Click(object sender, EventArgs e)
        {
            try
            {
                int groupID = Convert.ToInt32(comboBoxRemoveGroup_work.SelectedValue.ToString());
                Group group = new Group();
                if (MessageBox.Show("Do you want to remove this group?", "Delete Group", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (group.deleteGroup(groupID))
                    {
                        MessageBox.Show("This group deleted", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dashboardForm_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Delete Fail.", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Work", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBoxSearch_work_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPrint_work_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;

            if (printDlg.ShowDialog() == DialogResult.OK)
                printDoc.Print();

        }

        private void buttonExport_work_Click(object sender, EventArgs e)
        {
            // Tham khảo link: https://stackoverflow.com/questions/18182029/how-to-export-datagridview-data-instantly-to-excel-on-button-click

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "Work.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Copy DataGridView results to clipboard
                copyAlltoClipboard();

                object misValue = System.Reflection.Missing.Value;
                Excel.Application xlexcel = new Excel.Application();

                xlexcel.DisplayAlerts = false; // Without this you will get two confirm overwrite prompts
                Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(misValue);
                Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                // Format column D as text before pasting results, this was required for my data
                Excel.Range rng = xlWorkSheet.get_Range("D:D").Cells;
                rng.NumberFormat = "@";

                // Paste clipboard results to worksheet range
                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                // For some reason column A is always blank in the worksheet. ¯\_(ツ)_/¯
                // Delete blank column A and select cell A1
                Excel.Range delRng = xlWorkSheet.get_Range("A:A").Cells;
                delRng.Delete(Type.Missing);
                xlWorkSheet.get_Range("A1").Select();

                // Save the excel file under the captured location from the SaveFileDialog
                xlWorkBook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlexcel.DisplayAlerts = true;
                xlWorkBook.Close(true, misValue, misValue);
                xlexcel.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlexcel);

                // Clear Clipboard and DataGridView selection
                Clipboard.Clear();
                dataGridViewWork.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }

        }

        private void buttonStatistics_work_Click(object sender, EventArgs e)
        {

        }

        private void listBoxGroup_work_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  int groupID = Convert.ToInt32(listBoxGroup_work.SelectedValue.ToString());
            //string query_grid_work = "select distinct Tho.MaTho, TenTho, GioiTinh, SDT, TenNhom, TenCV " +
            //    "from Tho inner join CongViec on Tho.MaCV = CongViec.MaCV" +
            //    " inner join Nhom on Tho.MaNhom = Nhom.MaNhom " +
            //    "where MaNhom = " + groupID;
            //dataGridViewWork.DataSource = vehicle.getVehicle(new SqlCommand(query_grid_work));
        }
        #endregion

        #region Revenue -------------------------------------------------------
        private void buttonPrintRevenue_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;

            if (printDlg.ShowDialog() == DialogResult.OK)
                printDoc.Print();

        }

        private void buttonExportRevenue_Click(object sender, EventArgs e)
        {
            // Tham khảo link: https://stackoverflow.com/questions/18182029/how-to-export-datagridview-data-instantly-to-excel-on-button-click

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "Revenue.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Copy DataGridView results to clipboard
                copyAlltoClipboard();

                object misValue = System.Reflection.Missing.Value;
                Excel.Application xlexcel = new Excel.Application();

                xlexcel.DisplayAlerts = false; // Without this you will get two confirm overwrite prompts
                Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(misValue);
                Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                // Format column D as text before pasting results, this was required for my data
                Excel.Range rng = xlWorkSheet.get_Range("D:D").Cells;
                rng.NumberFormat = "@";

                // Paste clipboard results to worksheet range
                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                // For some reason column A is always blank in the worksheet. ¯\_(ツ)_/¯
                // Delete blank column A and select cell A1
                Excel.Range delRng = xlWorkSheet.get_Range("A:A").Cells;
                delRng.Delete(Type.Missing);
                xlWorkSheet.get_Range("A1").Select();

                // Save the excel file under the captured location from the SaveFileDialog
                xlWorkBook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlexcel.DisplayAlerts = true;
                xlWorkBook.Close(true, misValue, misValue);
                xlexcel.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlexcel);

                // Clear Clipboard and DataGridView selection
                Clipboard.Clear();
                dataGridViewRevenue.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }

        }

        private void buttonRevenueStatistics_Click(object sender, EventArgs e)
        {

        }

        void makeUpGridForAll()
        {
            try
            {
                dataGridViewRevenue.ReadOnly = true;
                dataGridViewRevenue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                DataGridViewImageColumn picCol2 = new DataGridViewImageColumn();
                DataGridViewImageColumn picCol3 = new DataGridViewImageColumn();
                DataGridViewImageColumn picCol4 = new DataGridViewImageColumn();
                DataGridViewImageColumn picCol5 = new DataGridViewImageColumn();


                dataGridViewRevenue.RowTemplate.Height = 80;

                picCol2 = (DataGridViewImageColumn)dataGridViewRevenue.Columns[2];
                picCol3 = (DataGridViewImageColumn)dataGridViewRevenue.Columns[3];
                picCol4 = (DataGridViewImageColumn)dataGridViewRevenue.Columns[4];
                picCol5 = (DataGridViewImageColumn)dataGridViewRevenue.Columns[5];

                picCol2.ImageLayout = DataGridViewImageCellLayout.Stretch;
                picCol3.ImageLayout = DataGridViewImageCellLayout.Stretch;
                picCol4.ImageLayout = DataGridViewImageCellLayout.Stretch;
                picCol5.ImageLayout = DataGridViewImageCellLayout.Stretch;

                dataGridViewRevenue.AllowUserToAddRows = false;
            }
            catch
            {

            }
        }

        private void comboBoxTypeRevenue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTypeRevenue.Text == "Vehicles Parking")
            {
                string dateFrom = dateTimePickerFrom.Value.ToString("yyyy-MM-dd");
                string dateTo = dateTimePickerTo.Value.ToString("yyyy-MM-dd");
                string query = "SELECT LoaiXe, COUNT(Xe.MaTheXe) AS SoLuong, SUM(Total) AS TongDoanhThu " +
                    "FROM Xe INNER JOIN DoanhThu ON Xe.MaTheXe = DoanhThu.MaTheXe " +
                    "WHERE ThoiGianRa BETWEEN '" + dateFrom + " 00:00:00.000" + "' AND '" + dateTo + " 23:59:59.997" + "' " +
                    "GROUP BY LoaiXe";
                System.Data.DataTable table = vehicle.getVehicle(new SqlCommand(query));
                int tatCaXe = 0;
                float tongDoanhThu = 0;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    tatCaXe += int.Parse(table.Rows[i][1].ToString());
                    tongDoanhThu += float.Parse(table.Rows[i][2].ToString());
                }
                table.Rows.Add(new object[] { "Tong Doanh Thu", tatCaXe, tongDoanhThu });
                dataGridViewRevenue.DataSource = table;
                makeUpGridForAll();
            }
        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            comboBoxTypeRevenue_SelectedIndexChanged(sender, e);
            makeUpGridForAll();
        }

        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            comboBoxTypeRevenue_SelectedIndexChanged(sender, e);
            makeUpGridForAll();
        }

        private void textBoxSearchRevenue_TextChanged(object sender, EventArgs e)
        {
            string dateFrom = dateTimePickerFrom.Value.ToString("yyyy-MM-dd");
            string dateTo = dateTimePickerTo.Value.ToString("yyyy-MM-dd");
            string query = "SELECT LoaiXe, COUNT(Xe.MaTheXe) AS SoLuong, SUM(Total) AS TongDoanhThu " +
                "FROM Xe INNER JOIN DoanhThu ON Xe.MaTheXe = DoanhThu.MaTheXe " +
                "WHERE ThoiGianRa BETWEEN '" + dateFrom + " 00:00:00.000" + "' AND '" + dateTo + " 23:59:59.997" + "' AND CONCAT(LoaiXe) LIKE '%" + textBoxSearchVehicle.Text + "%' " +
                "GROUP BY LoaiXe";
            System.Data.DataTable table = vehicle.getVehicle(new SqlCommand(query));
            int tatCaXe = 0;
            float tongDoanhThu = 0;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                tatCaXe += int.Parse(table.Rows[i][1].ToString());
                tongDoanhThu += float.Parse(table.Rows[i][2].ToString());
            }
            table.Rows.Add(new object[] { "Tong Doanh Thu", tatCaXe, tongDoanhThu });
            dataGridViewRevenue.DataSource = table;
            makeUpGridForAll();
        }
        #endregion

        #region Contract

        Contract contract = new Contract();
        private void buttonAddContract_Click(object sender, EventArgs e)
        {
            addContractForm addContract = new addContractForm();
            addContract.Show(this);
        }

        private void buttonEditContract_Click(object sender, EventArgs e)
        {
            editContractForm edit = new editContractForm();

            try
            {
                if (dataGridViewContract.Rows.Count > 1)
                {
                    if (dataGridViewContract.CurrentRow.Cells.Count == 8)
                    {
                        edit.textBoxContractID.Text = dataGridViewContract.CurrentRow.Cells[0].Value.ToString();
                        edit.textBoxCustomerID.Text = dataGridViewContract.CurrentRow.Cells[3].Value.ToString();
                        edit.textBoxDescibe.Text = dataGridViewContract.CurrentRow.Cells[5].Value.ToString();
                        edit.textBoxContractValue.Text = dataGridViewContract.CurrentRow.Cells[6].Value.ToString();
                        edit.comboBoxContractType.Text = dataGridViewContract.CurrentRow.Cells[1].Value.ToString();
                        edit.dateTimePickerSign.Value = Convert.ToDateTime(dataGridViewContract.CurrentRow.Cells[2].Value.ToString());
                        edit.dateTimePicker_LeaseTerm.Value = Convert.ToDateTime(dataGridViewContract.CurrentRow.Cells[7].Value.ToString());
                        edit.textBoxVehicleID.Text = dataGridViewContract.CurrentRow.Cells[4].Value.ToString();
                        edit.Show(this);
                    }
                }
                else
                {

                }
            }
            catch
            {

            }
        }

        void fillDatagridContract()
        {
            MyDB mydb = new MyDB();
            Worker worker = new Worker();
            //SqlCommand command = new SqlCommand(" select SoHD,LoaiHD,NgayKyHD,KhachHang.TenKH,SoXe,MoTaHD,GiaTriHD,NgayNhiemThu from HopDong inner join KhachHang on KhachHang.MaKH=HopDong.MaKH ");
            SqlCommand command = new SqlCommand(" Select * from HopDong");
            dataGridViewContract.DataSource = worker.getWorker(command);
        }

        void fillDatagridContract_Customer()
        {
            MyDB mydb = new MyDB();
            Worker worker = new Worker();

            SqlCommand command = new SqlCommand("Select * from KhachHang");
            dataGridViewContract.DataSource = worker.getWorker(command);
        }

        private void buttonPrintContract_Click(object sender, EventArgs e)
        {

            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;

            if (printDlg.ShowDialog() == DialogResult.OK) printDoc.Print();
        }



        private void buttonShowContract_Click(object sender, EventArgs e)
        {
            fillDatagridContract();
        }

        private void buttonShowCustomer_Click(object sender, EventArgs e)
        {
            fillDatagridContract_Customer();
        }

        private void buttonEditCustomer_Click(object sender, EventArgs e)
        {
            editCustomerForm edit = new editCustomerForm();

            try
            {
                if (dataGridViewContract.Rows.Count > 1)
                {
                    if (dataGridViewContract.CurrentRow.Cells.Count == 5)
                    {
                        edit.textBoxCustomerID.Text = dataGridViewContract.CurrentRow.Cells[0].Value.ToString();
                        edit.textBoxCustomerName.Text = dataGridViewContract.CurrentRow.Cells[1].Value.ToString();
                        edit.textBoxIdentityCard.Text = dataGridViewContract.CurrentRow.Cells[2].Value.ToString();
                        edit.textBoxAddress.Text = dataGridViewContract.CurrentRow.Cells[3].Value.ToString();
                        edit.textBoxPhone.Text = dataGridViewContract.CurrentRow.Cells[4].Value.ToString();
                        //edit.textBoxPhone.Text=dat
                        edit.Show(this);
                    }
                }
                else
                {
                    MessageBox.Show("You have to select data in Data Grid View", "Edit Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {

            }
        }

        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this customer!", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dataGridViewContract.Rows.Count > 1)
                {
                    if (dataGridViewContract.CurrentRow.Cells.Count == 5)
                    {
                        try
                        {
                            string id = dataGridViewContract.CurrentRow.Cells[0].Value.ToString();
                            Customer customer = new Customer();
                            if (customer.deleteCustomer(id))
                            {
                                MessageBox.Show("Delete successfuly", "Delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                fillDatagridContract();
                            }
                            else
                            {
                                MessageBox.Show("Not deleted", "Delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch
                        {

                        }
                    }
                }
                else
                {
                    MessageBox.Show("You have to select data in Data Grid View", "Delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Customer not deleted", "Delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }


        private void buttonDeleteContract_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this contract!", "Delete Contract", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (dataGridViewContract.Rows.Count > 1)
                {
                    if (dataGridViewContract.CurrentRow.Cells.Count == 8)
                    {
                        try
                        {
                            int id = Convert.ToInt32(dataGridViewContract.CurrentRow.Cells[0].Value.ToString());
                            Contract contract = new Contract();
                            if (contract.delete_HopDong(id))
                            {
                                MessageBox.Show("Delete successfuly", "Delete Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                fillDatagridContract();
                            }
                            else
                            {
                                MessageBox.Show("Not deleted", "Delete Contract", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("You have to select data in Data Grid View", "Delete Contract", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You have to select data in Data Grid View", "Delete Contract", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Contract not deleted", "Delete Contract", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            fillDatagridContract();
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            addCustomerForm add = new addCustomerForm();
            add.Show(this);
        }

        private void buttonExportContract_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "WorkerList.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_Word(dataGridViewWorker, sfd.FileName);
            }
        }

        private void textBoxSearchContract_TextChanged(object sender, EventArgs e)
        {
            if (dataGridViewContract.Rows.Count > 1)
            {
                if (dataGridViewContract.Columns.Count >= 8)
                {
                    SqlCommand command = new SqlCommand("select* from HopDong Where Concat(SoHD, NgayKyHD, MaKH, SoXe, MoTaHD, GiaTriHD, NgayNhiemThu)  LIKE '%" + textBoxSearchContract.Text + "%' ");

                    dataGridViewContract.DataSource = contract.getTable(command);
                }
                else if (dataGridViewContract.Columns.Count == 5)
                {
                    SqlCommand command = new SqlCommand("select* from KhachHang Where Concat(MaKH,TenKH,CMND,DiaChi,SDT)  LIKE '%" + textBoxSearchContract.Text + "%' ");

                    dataGridViewContract.DataSource = contract.getTable(command);

                }



            }
        }

        #endregion


    }
}