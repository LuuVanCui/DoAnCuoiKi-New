namespace QuanLyNhaXe01
{
    partial class dashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageVehicles = new System.Windows.Forms.TabPage();
            this.listBoxVehicle = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStatistics = new System.Windows.Forms.Button();
            this.buttonShowAllVehicle = new System.Windows.Forms.Button();
            this.buttonRemoveVehicle = new System.Windows.Forms.Button();
            this.buttonSlot = new System.Windows.Forms.Button();
            this.buttonPay = new System.Windows.Forms.Button();
            this.buttonEditVehicle = new System.Windows.Forms.Button();
            this.buttonAddVehicle = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.buttonShowFullListWorker = new System.Windows.Forms.Button();
            this.buttonStaticsWorker = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddSpeciality = new System.Windows.Forms.Button();
            this.buttonEditSpeciality = new System.Windows.Forms.Button();
            this.buttonDeleteSpeciality = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddWork = new System.Windows.Forms.Button();
            this.buttonEditWork = new System.Windows.Forms.Button();
            this.buttonDeleteWork = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddWorker = new System.Windows.Forms.Button();
            this.buttonEditWorker = new System.Windows.Forms.Button();
            this.buttonDeleteWorker = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBoxSearchContract = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTotalContract = new System.Windows.Forms.Label();
            this.dataGridViewContract = new System.Windows.Forms.DataGridView();
            this.buttonExportContract = new System.Windows.Forms.Button();
            this.buttonPrintContract = new System.Windows.Forms.Button();
            this.buttonStatisticsContract = new System.Windows.Forms.Button();
            this.buttonDeleteContract = new System.Windows.Forms.Button();
            this.buttonEditContract = new System.Windows.Forms.Button();
            this.buttonAddContract = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewRevenue = new System.Windows.Forms.DataGridView();
            this.buttonRevenueRental = new System.Windows.Forms.Button();
            this.buttonRevenueTakeCare = new System.Windows.Forms.Button();
            this.buttonRevenueParking = new System.Windows.Forms.Button();
            this.buttonRevenueStatistics = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPageVehicles.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContract)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRevenue)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageVehicles);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1222, 728);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageVehicles
            // 
            this.tabPageVehicles.Controls.Add(this.listBoxVehicle);
            this.tabPageVehicles.Controls.Add(this.label1);
            this.tabPageVehicles.Controls.Add(this.buttonStatistics);
            this.tabPageVehicles.Controls.Add(this.buttonShowAllVehicle);
            this.tabPageVehicles.Controls.Add(this.buttonRemoveVehicle);
            this.tabPageVehicles.Controls.Add(this.buttonSlot);
            this.tabPageVehicles.Controls.Add(this.buttonPay);
            this.tabPageVehicles.Controls.Add(this.buttonEditVehicle);
            this.tabPageVehicles.Controls.Add(this.buttonAddVehicle);
            this.tabPageVehicles.Location = new System.Drawing.Point(4, 42);
            this.tabPageVehicles.Name = "tabPageVehicles";
            this.tabPageVehicles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVehicles.Size = new System.Drawing.Size(1214, 682);
            this.tabPageVehicles.TabIndex = 0;
            this.tabPageVehicles.Text = "Vehicles";
            this.tabPageVehicles.UseVisualStyleBackColor = true;
            this.tabPageVehicles.Click += new System.EventHandler(this.tabPageVehicles_Click);
            // 
            // listBoxVehicle
            // 
            this.listBoxVehicle.FormattingEnabled = true;
            this.listBoxVehicle.ItemHeight = 33;
            this.listBoxVehicle.Location = new System.Drawing.Point(20, 88);
            this.listBoxVehicle.Name = "listBoxVehicle";
            this.listBoxVehicle.Size = new System.Drawing.Size(443, 532);
            this.listBoxVehicle.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Vehicles ID";
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.Location = new System.Drawing.Point(505, 512);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Size = new System.Drawing.Size(306, 66);
            this.buttonStatistics.TabIndex = 0;
            this.buttonStatistics.Text = "Statistics";
            this.buttonStatistics.UseVisualStyleBackColor = true;
            // 
            // buttonShowAllVehicle
            // 
            this.buttonShowAllVehicle.Location = new System.Drawing.Point(505, 389);
            this.buttonShowAllVehicle.Name = "buttonShowAllVehicle";
            this.buttonShowAllVehicle.Size = new System.Drawing.Size(306, 66);
            this.buttonShowAllVehicle.TabIndex = 0;
            this.buttonShowAllVehicle.Text = "Show All Vehicles";
            this.buttonShowAllVehicle.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveVehicle
            // 
            this.buttonRemoveVehicle.Location = new System.Drawing.Point(494, 162);
            this.buttonRemoveVehicle.Name = "buttonRemoveVehicle";
            this.buttonRemoveVehicle.Size = new System.Drawing.Size(294, 66);
            this.buttonRemoveVehicle.TabIndex = 0;
            this.buttonRemoveVehicle.Text = "Remove";
            this.buttonRemoveVehicle.UseVisualStyleBackColor = true;
            // 
            // buttonSlot
            // 
            this.buttonSlot.Location = new System.Drawing.Point(866, 512);
            this.buttonSlot.Name = "buttonSlot";
            this.buttonSlot.Size = new System.Drawing.Size(329, 66);
            this.buttonSlot.TabIndex = 0;
            this.buttonSlot.Text = "Slot";
            this.buttonSlot.UseVisualStyleBackColor = true;
            // 
            // buttonPay
            // 
            this.buttonPay.Location = new System.Drawing.Point(866, 389);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(329, 66);
            this.buttonPay.TabIndex = 0;
            this.buttonPay.Text = "Pay";
            this.buttonPay.UseVisualStyleBackColor = true;
            // 
            // buttonEditVehicle
            // 
            this.buttonEditVehicle.Location = new System.Drawing.Point(848, 38);
            this.buttonEditVehicle.Name = "buttonEditVehicle";
            this.buttonEditVehicle.Size = new System.Drawing.Size(306, 66);
            this.buttonEditVehicle.TabIndex = 0;
            this.buttonEditVehicle.Text = "Edit";
            this.buttonEditVehicle.UseVisualStyleBackColor = true;
            // 
            // buttonAddVehicle
            // 
            this.buttonAddVehicle.Location = new System.Drawing.Point(494, 38);
            this.buttonAddVehicle.Name = "buttonAddVehicle";
            this.buttonAddVehicle.Size = new System.Drawing.Size(306, 66);
            this.buttonAddVehicle.TabIndex = 0;
            this.buttonAddVehicle.Text = "Add";
            this.buttonAddVehicle.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel9);
            this.tabPage2.Controls.Add(this.panel8);
            this.tabPage2.Controls.Add(this.panel7);
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 42);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1214, 682);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Worker";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.buttonShowFullListWorker);
            this.panel9.Controls.Add(this.buttonStaticsWorker);
            this.panel9.Location = new System.Drawing.Point(33, 526);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1024, 128);
            this.panel9.TabIndex = 4;
            // 
            // buttonShowFullListWorker
            // 
            this.buttonShowFullListWorker.Location = new System.Drawing.Point(577, 33);
            this.buttonShowFullListWorker.Name = "buttonShowFullListWorker";
            this.buttonShowFullListWorker.Size = new System.Drawing.Size(235, 68);
            this.buttonShowFullListWorker.TabIndex = 2;
            this.buttonShowFullListWorker.Text = "Show Full List";
            this.buttonShowFullListWorker.UseVisualStyleBackColor = true;
            // 
            // buttonStaticsWorker
            // 
            this.buttonStaticsWorker.Location = new System.Drawing.Point(203, 33);
            this.buttonStaticsWorker.Name = "buttonStaticsWorker";
            this.buttonStaticsWorker.Size = new System.Drawing.Size(235, 68);
            this.buttonStaticsWorker.TabIndex = 2;
            this.buttonStaticsWorker.Text = "Statistics";
            this.buttonStaticsWorker.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.buttonAddSpeciality);
            this.panel8.Controls.Add(this.buttonEditSpeciality);
            this.panel8.Controls.Add(this.buttonDeleteSpeciality);
            this.panel8.Location = new System.Drawing.Point(800, 47);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(257, 440);
            this.panel8.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 51);
            this.label4.TabIndex = 1;
            this.label4.Text = "Speciality";
            // 
            // buttonAddSpeciality
            // 
            this.buttonAddSpeciality.Location = new System.Drawing.Point(39, 127);
            this.buttonAddSpeciality.Name = "buttonAddSpeciality";
            this.buttonAddSpeciality.Size = new System.Drawing.Size(172, 68);
            this.buttonAddSpeciality.TabIndex = 2;
            this.buttonAddSpeciality.Text = "Add";
            this.buttonAddSpeciality.UseVisualStyleBackColor = true;
            // 
            // buttonEditSpeciality
            // 
            this.buttonEditSpeciality.Location = new System.Drawing.Point(39, 239);
            this.buttonEditSpeciality.Name = "buttonEditSpeciality";
            this.buttonEditSpeciality.Size = new System.Drawing.Size(172, 68);
            this.buttonEditSpeciality.TabIndex = 2;
            this.buttonEditSpeciality.Text = "Edit";
            this.buttonEditSpeciality.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteSpeciality
            // 
            this.buttonDeleteSpeciality.Location = new System.Drawing.Point(39, 347);
            this.buttonDeleteSpeciality.Name = "buttonDeleteSpeciality";
            this.buttonDeleteSpeciality.Size = new System.Drawing.Size(172, 68);
            this.buttonDeleteSpeciality.TabIndex = 2;
            this.buttonDeleteSpeciality.Text = "Delete";
            this.buttonDeleteSpeciality.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.buttonAddWork);
            this.panel7.Controls.Add(this.buttonEditWork);
            this.panel7.Controls.Add(this.buttonDeleteWork);
            this.panel7.Location = new System.Drawing.Point(421, 47);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(257, 440);
            this.panel7.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 51);
            this.label3.TabIndex = 1;
            this.label3.Text = "Work";
            // 
            // buttonAddWork
            // 
            this.buttonAddWork.Location = new System.Drawing.Point(39, 127);
            this.buttonAddWork.Name = "buttonAddWork";
            this.buttonAddWork.Size = new System.Drawing.Size(172, 68);
            this.buttonAddWork.TabIndex = 2;
            this.buttonAddWork.Text = "Add";
            this.buttonAddWork.UseVisualStyleBackColor = true;
            // 
            // buttonEditWork
            // 
            this.buttonEditWork.Location = new System.Drawing.Point(39, 239);
            this.buttonEditWork.Name = "buttonEditWork";
            this.buttonEditWork.Size = new System.Drawing.Size(172, 68);
            this.buttonEditWork.TabIndex = 2;
            this.buttonEditWork.Text = "Edit";
            this.buttonEditWork.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteWork
            // 
            this.buttonDeleteWork.Location = new System.Drawing.Point(39, 347);
            this.buttonDeleteWork.Name = "buttonDeleteWork";
            this.buttonDeleteWork.Size = new System.Drawing.Size(172, 68);
            this.buttonDeleteWork.TabIndex = 2;
            this.buttonDeleteWork.Text = "Delete";
            this.buttonDeleteWork.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.buttonAddWorker);
            this.panel6.Controls.Add(this.buttonEditWorker);
            this.panel6.Controls.Add(this.buttonDeleteWorker);
            this.panel6.Location = new System.Drawing.Point(33, 47);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(257, 440);
            this.panel6.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Worker";
            // 
            // buttonAddWorker
            // 
            this.buttonAddWorker.Location = new System.Drawing.Point(39, 127);
            this.buttonAddWorker.Name = "buttonAddWorker";
            this.buttonAddWorker.Size = new System.Drawing.Size(172, 68);
            this.buttonAddWorker.TabIndex = 2;
            this.buttonAddWorker.Text = "Add";
            this.buttonAddWorker.UseVisualStyleBackColor = true;
            // 
            // buttonEditWorker
            // 
            this.buttonEditWorker.Location = new System.Drawing.Point(39, 239);
            this.buttonEditWorker.Name = "buttonEditWorker";
            this.buttonEditWorker.Size = new System.Drawing.Size(172, 68);
            this.buttonEditWorker.TabIndex = 2;
            this.buttonEditWorker.Text = "Edit";
            this.buttonEditWorker.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteWorker
            // 
            this.buttonDeleteWorker.Location = new System.Drawing.Point(39, 347);
            this.buttonDeleteWorker.Name = "buttonDeleteWorker";
            this.buttonDeleteWorker.Size = new System.Drawing.Size(172, 68);
            this.buttonDeleteWorker.TabIndex = 2;
            this.buttonDeleteWorker.Text = "Delete";
            this.buttonDeleteWorker.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(729, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(12, 447);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(355, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(12, 447);
            this.panel2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBoxSearchContract);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.labelTotalContract);
            this.tabPage3.Controls.Add(this.dataGridViewContract);
            this.tabPage3.Controls.Add(this.buttonExportContract);
            this.tabPage3.Controls.Add(this.buttonPrintContract);
            this.tabPage3.Controls.Add(this.buttonStatisticsContract);
            this.tabPage3.Controls.Add(this.buttonDeleteContract);
            this.tabPage3.Controls.Add(this.buttonEditContract);
            this.tabPage3.Controls.Add(this.buttonAddContract);
            this.tabPage3.Location = new System.Drawing.Point(4, 42);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1214, 682);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Contract";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchContract
            // 
            this.textBoxSearchContract.Location = new System.Drawing.Point(167, 28);
            this.textBoxSearchContract.Name = "textBoxSearchContract";
            this.textBoxSearchContract.Size = new System.Drawing.Size(529, 41);
            this.textBoxSearchContract.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 33);
            this.label6.TabIndex = 4;
            this.label6.Text = "Search:";
            // 
            // labelTotalContract
            // 
            this.labelTotalContract.AutoSize = true;
            this.labelTotalContract.Location = new System.Drawing.Point(987, 546);
            this.labelTotalContract.Name = "labelTotalContract";
            this.labelTotalContract.Size = new System.Drawing.Size(73, 33);
            this.labelTotalContract.TabIndex = 4;
            this.labelTotalContract.Text = "Total";
            // 
            // dataGridViewContract
            // 
            this.dataGridViewContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContract.Location = new System.Drawing.Point(15, 92);
            this.dataGridViewContract.Name = "dataGridViewContract";
            this.dataGridViewContract.RowHeadersWidth = 62;
            this.dataGridViewContract.RowTemplate.Height = 28;
            this.dataGridViewContract.Size = new System.Drawing.Size(1149, 451);
            this.dataGridViewContract.TabIndex = 3;
            // 
            // buttonExportContract
            // 
            this.buttonExportContract.Location = new System.Drawing.Point(979, 15);
            this.buttonExportContract.Name = "buttonExportContract";
            this.buttonExportContract.Size = new System.Drawing.Size(176, 54);
            this.buttonExportContract.TabIndex = 2;
            this.buttonExportContract.Text = "Export";
            this.buttonExportContract.UseVisualStyleBackColor = true;
            // 
            // buttonPrintContract
            // 
            this.buttonPrintContract.Location = new System.Drawing.Point(770, 13);
            this.buttonPrintContract.Name = "buttonPrintContract";
            this.buttonPrintContract.Size = new System.Drawing.Size(176, 51);
            this.buttonPrintContract.TabIndex = 2;
            this.buttonPrintContract.Text = "Print";
            this.buttonPrintContract.UseVisualStyleBackColor = true;
            // 
            // buttonStatisticsContract
            // 
            this.buttonStatisticsContract.Location = new System.Drawing.Point(786, 583);
            this.buttonStatisticsContract.Name = "buttonStatisticsContract";
            this.buttonStatisticsContract.Size = new System.Drawing.Size(176, 68);
            this.buttonStatisticsContract.TabIndex = 2;
            this.buttonStatisticsContract.Text = "Statistics";
            this.buttonStatisticsContract.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteContract
            // 
            this.buttonDeleteContract.Location = new System.Drawing.Point(546, 583);
            this.buttonDeleteContract.Name = "buttonDeleteContract";
            this.buttonDeleteContract.Size = new System.Drawing.Size(176, 68);
            this.buttonDeleteContract.TabIndex = 2;
            this.buttonDeleteContract.Text = "Delete";
            this.buttonDeleteContract.UseVisualStyleBackColor = true;
            // 
            // buttonEditContract
            // 
            this.buttonEditContract.Location = new System.Drawing.Point(314, 583);
            this.buttonEditContract.Name = "buttonEditContract";
            this.buttonEditContract.Size = new System.Drawing.Size(176, 68);
            this.buttonEditContract.TabIndex = 2;
            this.buttonEditContract.Text = "Edit";
            this.buttonEditContract.UseVisualStyleBackColor = true;
            // 
            // buttonAddContract
            // 
            this.buttonAddContract.Location = new System.Drawing.Point(74, 583);
            this.buttonAddContract.Name = "buttonAddContract";
            this.buttonAddContract.Size = new System.Drawing.Size(176, 68);
            this.buttonAddContract.TabIndex = 2;
            this.buttonAddContract.Text = "Add";
            this.buttonAddContract.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewRevenue);
            this.tabPage1.Controls.Add(this.buttonRevenueRental);
            this.tabPage1.Controls.Add(this.buttonRevenueTakeCare);
            this.tabPage1.Controls.Add(this.buttonRevenueParking);
            this.tabPage1.Controls.Add(this.buttonRevenueStatistics);
            this.tabPage1.Location = new System.Drawing.Point(4, 42);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1214, 682);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Revenue";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRevenue
            // 
            this.dataGridViewRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRevenue.Location = new System.Drawing.Point(23, 24);
            this.dataGridViewRevenue.Name = "dataGridViewRevenue";
            this.dataGridViewRevenue.RowHeadersWidth = 62;
            this.dataGridViewRevenue.RowTemplate.Height = 28;
            this.dataGridViewRevenue.Size = new System.Drawing.Size(1155, 470);
            this.dataGridViewRevenue.TabIndex = 1;
            // 
            // buttonRevenueRental
            // 
            this.buttonRevenueRental.Location = new System.Drawing.Point(645, 554);
            this.buttonRevenueRental.Name = "buttonRevenueRental";
            this.buttonRevenueRental.Size = new System.Drawing.Size(251, 70);
            this.buttonRevenueRental.TabIndex = 0;
            this.buttonRevenueRental.Text = "Vehicle Rental";
            this.buttonRevenueRental.UseVisualStyleBackColor = true;
            // 
            // buttonRevenueTakeCare
            // 
            this.buttonRevenueTakeCare.Location = new System.Drawing.Point(342, 554);
            this.buttonRevenueTakeCare.Name = "buttonRevenueTakeCare";
            this.buttonRevenueTakeCare.Size = new System.Drawing.Size(251, 70);
            this.buttonRevenueTakeCare.TabIndex = 0;
            this.buttonRevenueTakeCare.Text = "Take Care";
            this.buttonRevenueTakeCare.UseVisualStyleBackColor = true;
            // 
            // buttonRevenueParking
            // 
            this.buttonRevenueParking.Location = new System.Drawing.Point(40, 554);
            this.buttonRevenueParking.Name = "buttonRevenueParking";
            this.buttonRevenueParking.Size = new System.Drawing.Size(251, 70);
            this.buttonRevenueParking.TabIndex = 0;
            this.buttonRevenueParking.Text = "Parking";
            this.buttonRevenueParking.UseVisualStyleBackColor = true;
            // 
            // buttonRevenueStatistics
            // 
            this.buttonRevenueStatistics.Location = new System.Drawing.Point(927, 554);
            this.buttonRevenueStatistics.Name = "buttonRevenueStatistics";
            this.buttonRevenueStatistics.Size = new System.Drawing.Size(251, 70);
            this.buttonRevenueStatistics.TabIndex = 0;
            this.buttonRevenueStatistics.Text = "Statistics";
            this.buttonRevenueStatistics.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 68);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tabControl1);
            this.panel5.Location = new System.Drawing.Point(12, 86);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1228, 734);
            this.panel5.TabIndex = 2;
            // 
            // dashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 885);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "dashboardForm";
            this.Text = "Dash Board Form";
            this.tabControl1.ResumeLayout(false);
            this.tabPageVehicles.ResumeLayout(false);
            this.tabPageVehicles.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContract)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRevenue)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageVehicles;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonShowAllVehicle;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Button buttonEditVehicle;
        private System.Windows.Forms.Button buttonAddVehicle;
        private System.Windows.Forms.Button buttonStatistics;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonDeleteWorker;
        private System.Windows.Forms.Button buttonEditWorker;
        private System.Windows.Forms.Button buttonAddWorker;
        private System.Windows.Forms.Button buttonShowFullListWorker;
        private System.Windows.Forms.Button buttonStaticsWorker;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonDeleteContract;
        private System.Windows.Forms.Button buttonEditContract;
        private System.Windows.Forms.Button buttonAddContract;
        private System.Windows.Forms.Button buttonRevenueStatistics;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddSpeciality;
        private System.Windows.Forms.Button buttonEditSpeciality;
        private System.Windows.Forms.Button buttonDeleteSpeciality;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddWork;
        private System.Windows.Forms.Button buttonEditWork;
        private System.Windows.Forms.Button buttonDeleteWork;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxSearchContract;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTotalContract;
        private System.Windows.Forms.DataGridView dataGridViewContract;
        private System.Windows.Forms.Button buttonExportContract;
        private System.Windows.Forms.Button buttonPrintContract;
        private System.Windows.Forms.Button buttonStatisticsContract;
        private System.Windows.Forms.DataGridView dataGridViewRevenue;
        private System.Windows.Forms.Button buttonRevenueRental;
        private System.Windows.Forms.Button buttonRevenueTakeCare;
        private System.Windows.Forms.Button buttonRevenueParking;
        private System.Windows.Forms.Button buttonSlot;
        private System.Windows.Forms.ListBox listBoxVehicle;
        private System.Windows.Forms.Button buttonRemoveVehicle;
    }
}