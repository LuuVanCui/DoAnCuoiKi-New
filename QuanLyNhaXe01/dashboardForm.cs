﻿using System;
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

namespace QuanLyNhaXe01
{
    public partial class dashboardForm : Form
    {
        public dashboardForm()
        {
            InitializeComponent();
            this.dataGridViewVehicle.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewVehicle_DataError);
        }

        #region Tabar-----------------------------------------------------------------------------
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabelEditInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabelRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        #endregion

        #region Worker -------------------------------------------------------------------
        void fillDatagridWorker()
        {

            MyDB mydb = new MyDB();
            Worker worker = new Worker();

            SqlCommand command = new SqlCommand("Select worker_id as 'ID', name as 'Name', sex as 'Gender'," +
                " identityCard as 'Identity Card', bDate as 'Birth Date', dateStart as 'Date Strat', phone as 'Phone', address as 'Address', work as 'Work'  from Worker");
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
            string work = comboBoxWork_Worker.Text;

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
                            if (worker.insertWorker(w_id, name, gender, phone, CMND, address, bdate, dateStart, work))
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
            catch(Exception ex)
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
            string work = comboBoxWork_Worker.Text;

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
                            MessageBox.Show("Worker age is younger than 18", "Add Worker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        else
                        {
                            if (worker.updateWorker(w_id, name, gender, phone, CMND, address, bdate, dateStart, work))
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
            catch(Exception ex)
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
            SqlCommand command = new SqlCommand("SELECT worker_id as 'ID', name as 'Name', sex as 'Gender'," +
                " identityCard as 'Identity Card', bDate as 'Birth Date', dateStart as 'Date Strat', phone as 'Phone', address as 'Address', work as 'Work' " +
                " FROM Worker WHERE CONCAT(worker_id,name, sex, identityCard,bDate, dateStart, phone, address, work) LIKE'%" + textBoxSearchWorker.Text + "%'");

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

        public DataTable getWork()
        {
            MyDB mydb = new MyDB();
            SqlCommand command = new SqlCommand("Select * From CongViec",mydb.getConnection );

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        #endregion

        #region Vehicles--------------------------------------------------------------------

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

        }

        private void buttonSetMoto_Click(object sender, EventArgs e)
        {

        }

        private void buttonSetCar_Click(object sender, EventArgs e)
        {

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

        private void dashboardForm_Load(object sender, EventArgs e)
        {
            #region VEHICLES
            vehicleControls();
            DataTable table = vehicle.getVehicle(new SqlCommand("SELECT * FROM PhiGuiXeVaSlot"));

            // fill textbox
            textBoxTotalSlot_Bike.Text = table.Rows[0]["Slot"].ToString();
            textBoxTotalSlot_Car.Text = table.Rows[1]["Slot"].ToString();
            textBoxTotalSlot_Moto.Text = table.Rows[2]["Slot"].ToString();
            textBoxPrice_Bike.Text = table.Rows[0]["Phi"].ToString();
            textBoxPrice_Car.Text = table.Rows[1]["Phi"].ToString();
            textBoxPrice_Moto.Text = table.Rows[2]["Phi"].ToString();

            #endregion

            // WORKER
            //fillDatagridWorker();
            //comboBoxWork_Worker.DataSource = getWork();
            //comboBoxWork_Worker.DisplayMember = "TenCV";
            //comboBoxWork_Worker.ValueMember = "MaCV";
        }
    }
}