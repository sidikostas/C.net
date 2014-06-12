namespace Project
{
    partial class ReservationForm
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
            this.txtFistName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdNumber = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grbCustomerInfo = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.grbDates = new System.Windows.Forms.GroupBox();
            this.dtmCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dtmCheckIn = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grbCategory = new System.Windows.Forms.GroupBox();
            this.cmbRoomCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grbContactInfo = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grbCustomerInfo.SuspendLayout();
            this.grbDates.SuspendLayout();
            this.grbCategory.SuspendLayout();
            this.grbContactInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFistName
            // 
            this.txtFistName.Location = new System.Drawing.Point(95, 31);
            this.txtFistName.Name = "txtFistName";
            this.txtFistName.Size = new System.Drawing.Size(382, 20);
            this.txtFistName.TabIndex = 3;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(95, 19);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(382, 20);
            this.txtPhoneNumber.TabIndex = 2;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Phone *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID number *";
            // 
            // txtIdNumber
            // 
            this.txtIdNumber.Location = new System.Drawing.Point(95, 85);
            this.txtIdNumber.Name = "txtIdNumber";
            this.txtIdNumber.Size = new System.Drawing.Size(382, 20);
            this.txtIdNumber.TabIndex = 5;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(34, 371);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(200, 35);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(289, 371);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 35);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grbCustomerInfo
            // 
            this.grbCustomerInfo.Controls.Add(this.txtLastName);
            this.grbCustomerInfo.Controls.Add(this.label4);
            this.grbCustomerInfo.Controls.Add(this.txtFistName);
            this.grbCustomerInfo.Controls.Add(this.label1);
            this.grbCustomerInfo.Controls.Add(this.txtIdNumber);
            this.grbCustomerInfo.Controls.Add(this.label3);
            this.grbCustomerInfo.Location = new System.Drawing.Point(12, 12);
            this.grbCustomerInfo.Name = "grbCustomerInfo";
            this.grbCustomerInfo.Size = new System.Drawing.Size(502, 119);
            this.grbCustomerInfo.TabIndex = 0;
            this.grbCustomerInfo.TabStop = false;
            this.grbCustomerInfo.Text = "Customer Information";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(95, 58);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(382, 20);
            this.txtLastName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Last Name *";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(95, 46);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(382, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(19, 49);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // grbDates
            // 
            this.grbDates.Controls.Add(this.dtmCheckOut);
            this.grbDates.Controls.Add(this.dtmCheckIn);
            this.grbDates.Controls.Add(this.label6);
            this.grbDates.Controls.Add(this.label5);
            this.grbDates.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbDates.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.grbDates.Location = new System.Drawing.Point(12, 217);
            this.grbDates.Name = "grbDates";
            this.grbDates.Size = new System.Drawing.Size(502, 83);
            this.grbDates.TabIndex = 2;
            this.grbDates.TabStop = false;
            this.grbDates.Text = "Reservation Dates";
            // 
            // dtmCheckOut
            // 
            this.dtmCheckOut.Location = new System.Drawing.Point(277, 44);
            this.dtmCheckOut.Name = "dtmCheckOut";
            this.dtmCheckOut.Size = new System.Drawing.Size(200, 20);
            this.dtmCheckOut.TabIndex = 3;
            this.dtmCheckOut.ValueChanged += new System.EventHandler(this.dtmCheckOut_ValueChanged);
            // 
            // dtmCheckIn
            // 
            this.dtmCheckIn.Location = new System.Drawing.Point(22, 44);
            this.dtmCheckIn.Name = "dtmCheckIn";
            this.dtmCheckIn.Size = new System.Drawing.Size(200, 20);
            this.dtmCheckIn.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Check Out";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Check In";
            // 
            // grbCategory
            // 
            this.grbCategory.Controls.Add(this.cmbRoomCategory);
            this.grbCategory.Controls.Add(this.label7);
            this.grbCategory.Location = new System.Drawing.Point(12, 306);
            this.grbCategory.Name = "grbCategory";
            this.grbCategory.Size = new System.Drawing.Size(502, 59);
            this.grbCategory.TabIndex = 3;
            this.grbCategory.TabStop = false;
            this.grbCategory.Text = "Room Caterogy";
            // 
            // cmbRoomCategory
            // 
            this.cmbRoomCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomCategory.FormattingEnabled = true;
            this.cmbRoomCategory.Location = new System.Drawing.Point(95, 23);
            this.cmbRoomCategory.Name = "cmbRoomCategory";
            this.cmbRoomCategory.Size = new System.Drawing.Size(382, 21);
            this.cmbRoomCategory.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Type of room";
            // 
            // grbContactInfo
            // 
            this.grbContactInfo.Controls.Add(this.txtEmail);
            this.grbContactInfo.Controls.Add(this.lblEmail);
            this.grbContactInfo.Controls.Add(this.label2);
            this.grbContactInfo.Controls.Add(this.txtPhoneNumber);
            this.grbContactInfo.Location = new System.Drawing.Point(12, 137);
            this.grbContactInfo.Name = "grbContactInfo";
            this.grbContactInfo.Size = new System.Drawing.Size(502, 74);
            this.grbContactInfo.TabIndex = 1;
            this.grbContactInfo.TabStop = false;
            this.grbContactInfo.Text = "Contact Information";
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 414);
            this.Controls.Add(this.grbContactInfo);
            this.Controls.Add(this.grbCategory);
            this.Controls.Add(this.grbDates);
            this.Controls.Add(this.grbCustomerInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ReservationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reservation Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReservationForm_FormClosing);
            this.grbCustomerInfo.ResumeLayout(false);
            this.grbCustomerInfo.PerformLayout();
            this.grbDates.ResumeLayout(false);
            this.grbDates.PerformLayout();
            this.grbCategory.ResumeLayout(false);
            this.grbCategory.PerformLayout();
            this.grbContactInfo.ResumeLayout(false);
            this.grbContactInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFistName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdNumber;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grbCustomerInfo;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox grbDates;
        private System.Windows.Forms.DateTimePicker dtmCheckOut;
        private System.Windows.Forms.DateTimePicker dtmCheckIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grbCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbRoomCategory;
        private System.Windows.Forms.GroupBox grbContactInfo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}