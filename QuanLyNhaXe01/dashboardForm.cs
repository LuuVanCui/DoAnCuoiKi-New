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

        
        private void tabPageWorker_Click(object sender, EventArgs e)
        {
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            
            
        }

        private void tabControl_Click(object sender, EventArgs e)
        {
            fillDatagridWorker();
            comboBoxWork_Worker.DataSource = getWork();
            comboBoxWork_Worker.DisplayMember = "TenCV";
            comboBoxWork_Worker.ValueMember = "MaCV";
        }

        #region Worker -----------------------------------------------------------------
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

       
    }
}
