namespace QuanLyNhaXe01
{
    partial class manageVehiclesForm
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
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridVManageVehicle = new System.Windows.Forms.DataGridView();
            this.buttonPay = new System.Windows.Forms.Button();
            this.comboBoxTypeVehicle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxSearchLicenPlate = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelDaRa = new System.Windows.Forms.Label();
            this.labelDangGui = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSecond = new System.Windows.Forms.Label();
            this.timerWoking = new System.Windows.Forms.Timer(this.components);
            this.labelMinute = new System.Windows.Forms.Label();
            this.labelHour = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVManageVehicle)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(521, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Search:";
            // 
            // dataGridVManageVehicle
            // 
            this.dataGridVManageVehicle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVManageVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVManageVehicle.Location = new System.Drawing.Point(17, 187);
            this.dataGridVManageVehicle.Name = "dataGridVManageVehicle";
            this.dataGridVManageVehicle.RowHeadersWidth = 62;
            this.dataGridVManageVehicle.RowTemplate.Height = 28;
            this.dataGridVManageVehicle.Size = new System.Drawing.Size(1446, 451);
            this.dataGridVManageVehicle.TabIndex = 0;
            this.dataGridVManageVehicle.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridVManageVehicle_DataError);
            // 
            // buttonPay
            // 
            this.buttonPay.BackColor = System.Drawing.Color.Green;
            this.buttonPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPay.Location = new System.Drawing.Point(1269, 121);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(148, 57);
            this.buttonPay.TabIndex = 9;
            this.buttonPay.Text = "Pay";
            this.buttonPay.UseVisualStyleBackColor = false;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // comboBoxTypeVehicle
            // 
            this.comboBoxTypeVehicle.FormattingEnabled = true;
            this.comboBoxTypeVehicle.Location = new System.Drawing.Point(220, 139);
            this.comboBoxTypeVehicle.Name = "comboBoxTypeVehicle";
            this.comboBoxTypeVehicle.Size = new System.Drawing.Size(227, 28);
            this.comboBoxTypeVehicle.TabIndex = 8;
            this.comboBoxTypeVehicle.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeVehicle_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(6, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type of vehicle:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Maroon;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDelete.Location = new System.Drawing.Point(834, 709);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(197, 57);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEdit.Location = new System.Drawing.Point(524, 709);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(196, 57);
            this.buttonEdit.TabIndex = 0;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Green;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd.Location = new System.Drawing.Point(218, 709);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(196, 57);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxSearchLicenPlate
            // 
            this.textBoxSearchLicenPlate.Location = new System.Drawing.Point(629, 142);
            this.textBoxSearchLicenPlate.Name = "textBoxSearchLicenPlate";
            this.textBoxSearchLicenPlate.Size = new System.Drawing.Size(430, 26);
            this.textBoxSearchLicenPlate.TabIndex = 6;
            this.textBoxSearchLicenPlate.TextChanged += new System.EventHandler(this.textBoxSearchLicenPlate_TextChanged);
            // 
            // labelStatus
            // 
            this.labelStatus.BackColor = System.Drawing.Color.Purple;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelStatus.Location = new System.Drawing.Point(1188, 641);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(275, 44);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "Status";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStatus.Click += new System.EventHandler(this.labelStatus_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Blue;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRefresh.Location = new System.Drawing.Point(1086, 121);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(140, 57);
            this.buttonRefresh.TabIndex = 0;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelDaRa
            // 
            this.labelDaRa.BackColor = System.Drawing.Color.Purple;
            this.labelDaRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDaRa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDaRa.Location = new System.Drawing.Point(907, 641);
            this.labelDaRa.Name = "labelDaRa";
            this.labelDaRa.Size = new System.Drawing.Size(275, 44);
            this.labelDaRa.TabIndex = 10;
            this.labelDaRa.Text = "Status";
            this.labelDaRa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDangGui
            // 
            this.labelDangGui.BackColor = System.Drawing.Color.Purple;
            this.labelDangGui.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDangGui.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDangGui.Location = new System.Drawing.Point(626, 641);
            this.labelDangGui.Name = "labelDangGui";
            this.labelDangGui.Size = new System.Drawing.Size(275, 44);
            this.labelDangGui.TabIndex = 11;
            this.labelDangGui.Text = "Status";
            this.labelDangGui.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(681, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Working Time:";
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecond.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSecond.Location = new System.Drawing.Point(1008, 33);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(39, 29);
            this.labelSecond.TabIndex = 12;
            this.labelSecond.Text = "00";
            // 
            // timerWoking
            // 
            this.timerWoking.Enabled = true;
            this.timerWoking.Interval = 1000;
            this.timerWoking.Tick += new System.EventHandler(this.timerWoking_Tick);
            // 
            // labelMinute
            // 
            this.labelMinute.AutoSize = true;
            this.labelMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinute.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMinute.Location = new System.Drawing.Point(938, 33);
            this.labelMinute.Name = "labelMinute";
            this.labelMinute.Size = new System.Drawing.Size(39, 29);
            this.labelMinute.TabIndex = 12;
            this.labelMinute.Text = "00";
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHour.Location = new System.Drawing.Point(868, 33);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(39, 29);
            this.labelHour.TabIndex = 12;
            this.labelHour.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(983, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(913, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = ":";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.labelWelcome);
            this.panel1.Controls.Add(this.labelHour);
            this.panel1.Controls.Add(this.pictureBoxProfile);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.labelMinute);
            this.panel1.Controls.Add(this.labelSecond);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1471, 100);
            this.panel1.TabIndex = 13;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelWelcome.Location = new System.Drawing.Point(153, 33);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(115, 29);
            this.labelWelcome.TabIndex = 1;
            this.labelWelcome.Text = "Welcome";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(4, 0);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(122, 97);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonExit.Location = new System.Drawing.Point(1203, 19);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(140, 57);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // manageVehiclesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1476, 787);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.labelDangGui);
            this.Controls.Add(this.labelDaRa);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.dataGridVManageVehicle);
            this.Controls.Add(this.comboBoxTypeVehicle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxSearchLicenPlate);
            this.Name = "manageVehiclesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Vehicles";
            this.Load += new System.EventHandler(this.manageVehiclesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVManageVehicle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridVManageVehicle;
        private System.Windows.Forms.TextBox textBoxSearchLicenPlate;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxTypeVehicle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelDaRa;
        private System.Windows.Forms.Label labelDangGui;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.Timer timerWoking;
        private System.Windows.Forms.Label labelMinute;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button buttonExit;
    }
}