namespace QuanLyNhaXe01
{
    partial class paymentForm
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxVehiclePicture = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.labelCardID = new System.Windows.Forms.Label();
            this.labelTypeOfVehicle = new System.Windows.Forms.Label();
            this.labelInTime = new System.Windows.Forms.Label();
            this.labelParkingTimes = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelPayment = new System.Windows.Forms.Label();
            this.buttonPay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVehiclePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(50, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card ID:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCancel.Location = new System.Drawing.Point(389, 606);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(200, 55);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(398, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type Of Vehicle:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(157, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Parking times:";
            // 
            // pictureBoxVehiclePicture
            // 
            this.pictureBoxVehiclePicture.Location = new System.Drawing.Point(324, 192);
            this.pictureBoxVehiclePicture.Name = "pictureBoxVehiclePicture";
            this.pictureBoxVehiclePicture.Size = new System.Drawing.Size(265, 137);
            this.pictureBoxVehiclePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVehiclePicture.TabIndex = 18;
            this.pictureBoxVehiclePicture.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(98, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "Vehicle Picture:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label.Location = new System.Drawing.Point(157, 372);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(100, 29);
            this.label.TabIndex = 23;
            this.label.Text = "In Time:";
            // 
            // labelCardID
            // 
            this.labelCardID.AutoSize = true;
            this.labelCardID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCardID.Location = new System.Drawing.Point(177, 125);
            this.labelCardID.Name = "labelCardID";
            this.labelCardID.Size = new System.Drawing.Size(66, 29);
            this.labelCardID.TabIndex = 26;
            this.labelCardID.Text = "label";
            // 
            // labelTypeOfVehicle
            // 
            this.labelTypeOfVehicle.AutoSize = true;
            this.labelTypeOfVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTypeOfVehicle.Location = new System.Drawing.Point(595, 125);
            this.labelTypeOfVehicle.Name = "labelTypeOfVehicle";
            this.labelTypeOfVehicle.Size = new System.Drawing.Size(66, 29);
            this.labelTypeOfVehicle.TabIndex = 27;
            this.labelTypeOfVehicle.Text = "label";
            // 
            // labelInTime
            // 
            this.labelInTime.AutoSize = true;
            this.labelInTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelInTime.Location = new System.Drawing.Point(375, 372);
            this.labelInTime.Name = "labelInTime";
            this.labelInTime.Size = new System.Drawing.Size(66, 29);
            this.labelInTime.TabIndex = 28;
            this.labelInTime.Text = "label";
            // 
            // labelParkingTimes
            // 
            this.labelParkingTimes.AutoSize = true;
            this.labelParkingTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelParkingTimes.Location = new System.Drawing.Point(375, 451);
            this.labelParkingTimes.Name = "labelParkingTimes";
            this.labelParkingTimes.Size = new System.Drawing.Size(66, 29);
            this.labelParkingTimes.TabIndex = 29;
            this.labelParkingTimes.Text = "label";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(157, 530);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 29);
            this.label9.TabIndex = 30;
            this.label9.Text = "Payment:";
            // 
            // labelPayment
            // 
            this.labelPayment.AutoSize = true;
            this.labelPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPayment.Location = new System.Drawing.Point(375, 530);
            this.labelPayment.Name = "labelPayment";
            this.labelPayment.Size = new System.Drawing.Size(165, 29);
            this.labelPayment.TabIndex = 31;
            this.labelPayment.Text = "Parking times:";
            // 
            // buttonPay
            // 
            this.buttonPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonPay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPay.Location = new System.Drawing.Point(103, 606);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(200, 55);
            this.buttonPay.TabIndex = 32;
            this.buttonPay.Text = "Pay";
            this.buttonPay.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(1, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 23);
            this.panel1.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(264, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 58);
            this.label3.TabIndex = 34;
            this.label3.Text = "Payment";
            // 
            // paymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 707);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.labelPayment);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelParkingTimes);
            this.Controls.Add(this.labelInTime);
            this.Controls.Add(this.labelTypeOfVehicle);
            this.Controls.Add(this.labelCardID);
            this.Controls.Add(this.label);
            this.Controls.Add(this.pictureBoxVehiclePicture);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "paymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "paymentForm";
            this.Load += new System.EventHandler(this.paymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVehiclePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxVehiclePicture;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelCardID;
        private System.Windows.Forms.Label labelTypeOfVehicle;
        private System.Windows.Forms.Label labelInTime;
        private System.Windows.Forms.Label labelParkingTimes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelPayment;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}