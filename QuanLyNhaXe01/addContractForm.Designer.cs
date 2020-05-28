namespace QuanLyNhaXe01
{
    partial class addContractForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAddVehicle = new System.Windows.Forms.Button();
            this.buttonFindVehicle = new System.Windows.Forms.Button();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.buttonFindCustomer = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxVehicleID = new System.Windows.Forms.TextBox();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_LeaseTerm = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerSign = new System.Windows.Forms.DateTimePicker();
            this.comboBoxContractType = new System.Windows.Forms.ComboBox();
            this.textBoxDescibe = new System.Windows.Forms.TextBox();
            this.textBoxUnpaid = new System.Windows.Forms.TextBox();
            this.textBoxPaid = new System.Windows.Forms.TextBox();
            this.textBoxContractValue = new System.Windows.Forms.TextBox();
            this.textBoxContractID = new System.Windows.Forms.TextBox();
            this.labelUnpaid = new System.Windows.Forms.Label();
            this.labelPaid = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contract ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Contract Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sign Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Vehicle ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Describe:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 426);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Contract Value:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(431, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(204, 55);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(42, 12);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(204, 55);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonAddVehicle);
            this.panel1.Controls.Add(this.buttonFindVehicle);
            this.panel1.Controls.Add(this.buttonAddCustomer);
            this.panel1.Controls.Add(this.buttonFindCustomer);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textBoxVehicleID);
            this.panel1.Controls.Add(this.textBoxCustomerID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateTimePicker_LeaseTerm);
            this.panel1.Controls.Add(this.dateTimePickerSign);
            this.panel1.Controls.Add(this.comboBoxContractType);
            this.panel1.Controls.Add(this.textBoxDescibe);
            this.panel1.Controls.Add(this.textBoxUnpaid);
            this.panel1.Controls.Add(this.textBoxPaid);
            this.panel1.Controls.Add(this.textBoxContractValue);
            this.panel1.Controls.Add(this.textBoxContractID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelUnpaid);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelPaid);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(16, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 580);
            this.panel1.TabIndex = 2;
            // 
            // buttonAddVehicle
            // 
            this.buttonAddVehicle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonAddVehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddVehicle.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.buttonAddVehicle.Location = new System.Drawing.Point(516, 126);
            this.buttonAddVehicle.Name = "buttonAddVehicle";
            this.buttonAddVehicle.Size = new System.Drawing.Size(157, 38);
            this.buttonAddVehicle.TabIndex = 11;
            this.buttonAddVehicle.Text = "Add Vehicle";
            this.buttonAddVehicle.UseVisualStyleBackColor = false;
            this.buttonAddVehicle.Click += new System.EventHandler(this.buttonAddVehicle_Click);
            // 
            // buttonFindVehicle
            // 
            this.buttonFindVehicle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonFindVehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFindVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFindVehicle.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.buttonFindVehicle.Location = new System.Drawing.Point(414, 126);
            this.buttonFindVehicle.Name = "buttonFindVehicle";
            this.buttonFindVehicle.Size = new System.Drawing.Size(77, 38);
            this.buttonFindVehicle.TabIndex = 10;
            this.buttonFindVehicle.Text = "Find";
            this.buttonFindVehicle.UseVisualStyleBackColor = false;
            this.buttonFindVehicle.Click += new System.EventHandler(this.buttonFindVehicle_Click);
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCustomer.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.buttonAddCustomer.Location = new System.Drawing.Point(516, 66);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(157, 40);
            this.buttonAddCustomer.TabIndex = 9;
            this.buttonAddCustomer.Text = "Add Customer";
            this.buttonAddCustomer.UseVisualStyleBackColor = false;
            this.buttonAddCustomer.Click += new System.EventHandler(this.buttonAddCustomer_Click);
            // 
            // buttonFindCustomer
            // 
            this.buttonFindCustomer.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonFindCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFindCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFindCustomer.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.buttonFindCustomer.Location = new System.Drawing.Point(414, 66);
            this.buttonFindCustomer.Name = "buttonFindCustomer";
            this.buttonFindCustomer.Size = new System.Drawing.Size(77, 40);
            this.buttonFindCustomer.TabIndex = 8;
            this.buttonFindCustomer.Text = "Find";
            this.buttonFindCustomer.UseVisualStyleBackColor = false;
            this.buttonFindCustomer.Click += new System.EventHandler(this.buttonFindCustomer_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(526, 479);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 29);
            this.label14.TabIndex = 7;
            this.label14.Text = "VNĐ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(526, 526);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 29);
            this.label13.TabIndex = 7;
            this.label13.Text = "VNĐ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(526, 426);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 29);
            this.label10.TabIndex = 7;
            this.label10.Text = "VNĐ";
            // 
            // textBoxVehicleID
            // 
            this.textBoxVehicleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVehicleID.Location = new System.Drawing.Point(200, 126);
            this.textBoxVehicleID.Name = "textBoxVehicleID";
            this.textBoxVehicleID.Size = new System.Drawing.Size(189, 30);
            this.textBoxVehicleID.TabIndex = 3;
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerID.Location = new System.Drawing.Point(200, 72);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(189, 30);
            this.textBoxCustomerID.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Customer ID:";
            // 
            // dateTimePicker_LeaseTerm
            // 
            this.dateTimePicker_LeaseTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_LeaseTerm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_LeaseTerm.Location = new System.Drawing.Point(200, 280);
            this.dateTimePicker_LeaseTerm.Name = "dateTimePicker_LeaseTerm";
            this.dateTimePicker_LeaseTerm.Size = new System.Drawing.Size(256, 30);
            this.dateTimePicker_LeaseTerm.TabIndex = 6;
            // 
            // dateTimePickerSign
            // 
            this.dateTimePickerSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerSign.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSign.Location = new System.Drawing.Point(200, 233);
            this.dateTimePickerSign.Name = "dateTimePickerSign";
            this.dateTimePickerSign.Size = new System.Drawing.Size(256, 30);
            this.dateTimePickerSign.TabIndex = 5;
            // 
            // comboBoxContractType
            // 
            this.comboBoxContractType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxContractType.FormattingEnabled = true;
            this.comboBoxContractType.Items.AddRange(new object[] {
            "Ky Gui",
            "Cty Cho Thue"});
            this.comboBoxContractType.Location = new System.Drawing.Point(200, 182);
            this.comboBoxContractType.Name = "comboBoxContractType";
            this.comboBoxContractType.Size = new System.Drawing.Size(256, 33);
            this.comboBoxContractType.TabIndex = 4;
            // 
            // textBoxDescibe
            // 
            this.textBoxDescibe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescibe.Location = new System.Drawing.Point(200, 326);
            this.textBoxDescibe.Multiline = true;
            this.textBoxDescibe.Name = "textBoxDescibe";
            this.textBoxDescibe.Size = new System.Drawing.Size(310, 83);
            this.textBoxDescibe.TabIndex = 7;
            // 
            // textBoxUnpaid
            // 
            this.textBoxUnpaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnpaid.Location = new System.Drawing.Point(200, 525);
            this.textBoxUnpaid.Name = "textBoxUnpaid";
            this.textBoxUnpaid.Size = new System.Drawing.Size(310, 30);
            this.textBoxUnpaid.TabIndex = 8;
            // 
            // textBoxPaid
            // 
            this.textBoxPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPaid.Location = new System.Drawing.Point(200, 478);
            this.textBoxPaid.Name = "textBoxPaid";
            this.textBoxPaid.Size = new System.Drawing.Size(310, 30);
            this.textBoxPaid.TabIndex = 8;
            // 
            // textBoxContractValue
            // 
            this.textBoxContractValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContractValue.Location = new System.Drawing.Point(200, 426);
            this.textBoxContractValue.Name = "textBoxContractValue";
            this.textBoxContractValue.Size = new System.Drawing.Size(310, 30);
            this.textBoxContractValue.TabIndex = 8;
            // 
            // textBoxContractID
            // 
            this.textBoxContractID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContractID.Location = new System.Drawing.Point(200, 21);
            this.textBoxContractID.Name = "textBoxContractID";
            this.textBoxContractID.Size = new System.Drawing.Size(189, 30);
            this.textBoxContractID.TabIndex = 1;
            // 
            // labelUnpaid
            // 
            this.labelUnpaid.AutoSize = true;
            this.labelUnpaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnpaid.Location = new System.Drawing.Point(103, 525);
            this.labelUnpaid.Name = "labelUnpaid";
            this.labelUnpaid.Size = new System.Drawing.Size(96, 29);
            this.labelUnpaid.TabIndex = 0;
            this.labelUnpaid.Text = "Unpaid:";
            // 
            // labelPaid
            // 
            this.labelPaid.AutoSize = true;
            this.labelPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaid.Location = new System.Drawing.Point(19, 479);
            this.labelPaid.Name = "labelPaid";
            this.labelPaid.Size = new System.Drawing.Size(180, 29);
            this.labelPaid.TabIndex = 0;
            this.labelPaid.Text = "Deposit Money:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Lease Term:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonAdd);
            this.panel2.Controls.Add(this.buttonCancel);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(16, 670);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(721, 73);
            this.panel2.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label9.Location = new System.Drawing.Point(210, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(284, 47);
            this.label9.TabIndex = 0;
            this.label9.Text = "Add Contract";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(12, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(757, 758);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // addContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(781, 766);
            this.Controls.Add(this.panel3);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addContractForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addContract";
            this.Load += new System.EventHandler(this.addContractForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePickerSign;
        private System.Windows.Forms.ComboBox comboBoxContractType;
        private System.Windows.Forms.TextBox textBoxDescibe;
        private System.Windows.Forms.TextBox textBoxContractValue;
        private System.Windows.Forms.TextBox textBoxContractID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker_LeaseTerm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonAddVehicle;
        private System.Windows.Forms.Button buttonFindVehicle;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.Button buttonFindCustomer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxUnpaid;
        private System.Windows.Forms.TextBox textBoxPaid;
        private System.Windows.Forms.Label labelUnpaid;
        private System.Windows.Forms.Label labelPaid;
        public System.Windows.Forms.TextBox textBoxCustomerID;
        public System.Windows.Forms.TextBox textBoxVehicleID;
    }
}