namespace Project
{
    partial class MainForm
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
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.lstSavedReservations = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.grpRoomInfo = new System.Windows.Forms.GroupBox();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRoomCategory = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpCustomerInfo = new System.Windows.Forms.GroupBox();
            this.lblIdNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grpDatesInfo = new System.Windows.Forms.GroupBox();
            this.lblNumberOfDays = new System.Windows.Forms.Label();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.grpRoomInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpCustomerInfo.SuspendLayout();
            this.grpDatesInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(12, 437);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(196, 45);
            this.btnNewCustomer.TabIndex = 0;
            this.btnNewCustomer.Text = "New customer";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // lstSavedReservations
            // 
            this.lstSavedReservations.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lstSavedReservations.FormattingEnabled = true;
            this.lstSavedReservations.ItemHeight = 16;
            this.lstSavedReservations.Location = new System.Drawing.Point(218, 37);
            this.lstSavedReservations.Name = "lstSavedReservations";
            this.lstSavedReservations.Size = new System.Drawing.Size(454, 388);
            this.lstSavedReservations.TabIndex = 1;
            this.lstSavedReservations.SelectedIndexChanged += new System.EventHandler(this.lstSavedReservations_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Room";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Check in";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(577, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Check out";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Category";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(538, 437);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 45);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(379, 437);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 45);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(218, 437);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(143, 45);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // grpRoomInfo
            // 
            this.grpRoomInfo.Controls.Add(this.lblAvailability);
            this.grpRoomInfo.Controls.Add(this.label5);
            this.grpRoomInfo.Controls.Add(this.lblRoomCategory);
            this.grpRoomInfo.Controls.Add(this.label6);
            this.grpRoomInfo.Location = new System.Drawing.Point(12, 292);
            this.grpRoomInfo.Name = "grpRoomInfo";
            this.grpRoomInfo.Size = new System.Drawing.Size(196, 88);
            this.grpRoomInfo.TabIndex = 16;
            this.grpRoomInfo.TabStop = false;
            this.grpRoomInfo.Text = "Room Information";
            // 
            // lblAvailability
            // 
            this.lblAvailability.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAvailability.Location = new System.Drawing.Point(83, 58);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(107, 23);
            this.lblAvailability.TabIndex = 15;
            this.lblAvailability.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Availability";
            // 
            // lblRoomCategory
            // 
            this.lblRoomCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRoomCategory.Location = new System.Drawing.Point(83, 25);
            this.lblRoomCategory.Name = "lblRoomCategory";
            this.lblRoomCategory.Size = new System.Drawing.Size(107, 23);
            this.lblRoomCategory.TabIndex = 13;
            this.lblRoomCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Project.Properties.Resources.logo_aristoteles;
            this.pictureBox1.Location = new System.Drawing.Point(12, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // grpCustomerInfo
            // 
            this.grpCustomerInfo.Controls.Add(this.lblIdNumber);
            this.grpCustomerInfo.Controls.Add(this.lblName);
            this.grpCustomerInfo.Controls.Add(this.label14);
            this.grpCustomerInfo.Controls.Add(this.label13);
            this.grpCustomerInfo.Location = new System.Drawing.Point(12, 121);
            this.grpCustomerInfo.Name = "grpCustomerInfo";
            this.grpCustomerInfo.Size = new System.Drawing.Size(200, 82);
            this.grpCustomerInfo.TabIndex = 13;
            this.grpCustomerInfo.TabStop = false;
            this.grpCustomerInfo.Text = "Customer Information";
            // 
            // lblIdNumber
            // 
            this.lblIdNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdNumber.Location = new System.Drawing.Point(47, 51);
            this.lblIdNumber.Name = "lblIdNumber";
            this.lblIdNumber.Size = new System.Drawing.Size(147, 23);
            this.lblIdNumber.TabIndex = 6;
            this.lblIdNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Location = new System.Drawing.Point(47, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(147, 23);
            this.lblName.TabIndex = 5;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "ID ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Name";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(23, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Days of residence";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grpDatesInfo
            // 
            this.grpDatesInfo.Controls.Add(this.lblNumberOfDays);
            this.grpDatesInfo.Controls.Add(this.label7);
            this.grpDatesInfo.Location = new System.Drawing.Point(12, 209);
            this.grpDatesInfo.Name = "grpDatesInfo";
            this.grpDatesInfo.Size = new System.Drawing.Size(196, 75);
            this.grpDatesInfo.TabIndex = 12;
            this.grpDatesInfo.TabStop = false;
            this.grpDatesInfo.Text = "Dates Information";
            // 
            // lblNumberOfDays
            // 
            this.lblNumberOfDays.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumberOfDays.Location = new System.Drawing.Point(26, 40);
            this.lblNumberOfDays.Name = "lblNumberOfDays";
            this.lblNumberOfDays.Size = new System.Drawing.Size(138, 23);
            this.lblNumberOfDays.TabIndex = 13;
            this.lblNumberOfDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Location = new System.Drawing.Point(12, 386);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(196, 45);
            this.btnShowInfo.TabIndex = 18;
            this.btnShowInfo.Text = "More Info";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 487);
            this.Controls.Add(this.btnShowInfo);
            this.Controls.Add(this.grpCustomerInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpRoomInfo);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpDatesInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSavedReservations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aristotelis Hotel Booking Application";
            this.grpRoomInfo.ResumeLayout(false);
            this.grpRoomInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpCustomerInfo.ResumeLayout(false);
            this.grpCustomerInfo.PerformLayout();
            this.grpDatesInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.ListBox lstSavedReservations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox grpRoomInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblIdNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpDatesInfo;
        private System.Windows.Forms.GroupBox grpCustomerInfo;
        private System.Windows.Forms.Label lblNumberOfDays;
        private System.Windows.Forms.Label lblRoomCategory;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.Label label5;
    }
}

