namespace Assignment6
{
    partial class ContactForm
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
            this.grpName = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.grpEmailPhones = new System.Windows.Forms.GroupBox();
            this.txtPrMail = new System.Windows.Forms.TextBox();
            this.txtBusMail = new System.Windows.Forms.TextBox();
            this.txtCellPhone = new System.Windows.Forms.TextBox();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.lblEmailPrivate = new System.Windows.Forms.Label();
            this.lblEmailBusiness = new System.Windows.Forms.Label();
            this.lblCellPhone = new System.Windows.Forms.Label();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.cmbCountries = new System.Windows.Forms.ComboBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpName.SuspendLayout();
            this.grpEmailPhones.SuspendLayout();
            this.grpAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpName
            // 
            this.grpName.Controls.Add(this.txtLastName);
            this.grpName.Controls.Add(this.txtFirstName);
            this.grpName.Controls.Add(this.lblLName);
            this.grpName.Controls.Add(this.lblFname);
            this.grpName.Location = new System.Drawing.Point(12, 12);
            this.grpName.Name = "grpName";
            this.grpName.Size = new System.Drawing.Size(379, 100);
            this.grpName.TabIndex = 0;
            this.grpName.TabStop = false;
            this.grpName.Text = "Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(108, 62);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(253, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(108, 31);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(253, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(23, 65);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(65, 13);
            this.lblLName.TabIndex = 1;
            this.lblLName.Text = "* Last Name";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(23, 31);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(64, 13);
            this.lblFname.TabIndex = 0;
            this.lblFname.Text = "* First Name";
            // 
            // grpEmailPhones
            // 
            this.grpEmailPhones.Controls.Add(this.txtPrMail);
            this.grpEmailPhones.Controls.Add(this.txtBusMail);
            this.grpEmailPhones.Controls.Add(this.txtCellPhone);
            this.grpEmailPhones.Controls.Add(this.txtHomePhone);
            this.grpEmailPhones.Controls.Add(this.lblEmailPrivate);
            this.grpEmailPhones.Controls.Add(this.lblEmailBusiness);
            this.grpEmailPhones.Controls.Add(this.lblCellPhone);
            this.grpEmailPhones.Controls.Add(this.lblHomePhone);
            this.grpEmailPhones.Location = new System.Drawing.Point(12, 128);
            this.grpEmailPhones.Name = "grpEmailPhones";
            this.grpEmailPhones.Size = new System.Drawing.Size(379, 135);
            this.grpEmailPhones.TabIndex = 1;
            this.grpEmailPhones.TabStop = false;
            this.grpEmailPhones.Text = "Email & Phones";
            // 
            // txtPrMail
            // 
            this.txtPrMail.Location = new System.Drawing.Point(108, 106);
            this.txtPrMail.Name = "txtPrMail";
            this.txtPrMail.Size = new System.Drawing.Size(253, 20);
            this.txtPrMail.TabIndex = 9;
            // 
            // txtBusMail
            // 
            this.txtBusMail.Location = new System.Drawing.Point(108, 81);
            this.txtBusMail.Name = "txtBusMail";
            this.txtBusMail.Size = new System.Drawing.Size(253, 20);
            this.txtBusMail.TabIndex = 8;
            // 
            // txtCellPhone
            // 
            this.txtCellPhone.Location = new System.Drawing.Point(108, 55);
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.Size = new System.Drawing.Size(253, 20);
            this.txtCellPhone.TabIndex = 7;
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Location = new System.Drawing.Point(108, 29);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(253, 20);
            this.txtHomePhone.TabIndex = 6;
            // 
            // lblEmailPrivate
            // 
            this.lblEmailPrivate.AutoSize = true;
            this.lblEmailPrivate.Location = new System.Drawing.Point(23, 110);
            this.lblEmailPrivate.Name = "lblEmailPrivate";
            this.lblEmailPrivate.Size = new System.Drawing.Size(71, 13);
            this.lblEmailPrivate.TabIndex = 5;
            this.lblEmailPrivate.Text = "E-Mail private";
            // 
            // lblEmailBusiness
            // 
            this.lblEmailBusiness.AutoSize = true;
            this.lblEmailBusiness.Location = new System.Drawing.Point(23, 83);
            this.lblEmailBusiness.Name = "lblEmailBusiness";
            this.lblEmailBusiness.Size = new System.Drawing.Size(83, 13);
            this.lblEmailBusiness.TabIndex = 4;
            this.lblEmailBusiness.Text = "E-Mail, business";
            // 
            // lblCellPhone
            // 
            this.lblCellPhone.AutoSize = true;
            this.lblCellPhone.Location = new System.Drawing.Point(23, 55);
            this.lblCellPhone.Name = "lblCellPhone";
            this.lblCellPhone.Size = new System.Drawing.Size(58, 13);
            this.lblCellPhone.TabIndex = 3;
            this.lblCellPhone.Text = "Cell Phone";
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Location = new System.Drawing.Point(23, 30);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(69, 13);
            this.lblHomePhone.TabIndex = 2;
            this.lblHomePhone.Text = "Home Phone";
            // 
            // grpAddress
            // 
            this.grpAddress.Controls.Add(this.cmbCountries);
            this.grpAddress.Controls.Add(this.txtZipCode);
            this.grpAddress.Controls.Add(this.txtCity);
            this.grpAddress.Controls.Add(this.txtStreet);
            this.grpAddress.Controls.Add(this.lblCountry);
            this.grpAddress.Controls.Add(this.lblZipCode);
            this.grpAddress.Controls.Add(this.lblCity);
            this.grpAddress.Controls.Add(this.lblStreet);
            this.grpAddress.Location = new System.Drawing.Point(12, 287);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Size = new System.Drawing.Size(379, 147);
            this.grpAddress.TabIndex = 2;
            this.grpAddress.TabStop = false;
            this.grpAddress.Text = "Address";
            // 
            // cmbCountries
            // 
            this.cmbCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountries.FormattingEnabled = true;
            this.cmbCountries.Location = new System.Drawing.Point(108, 102);
            this.cmbCountries.Name = "cmbCountries";
            this.cmbCountries.Size = new System.Drawing.Size(253, 21);
            this.cmbCountries.TabIndex = 13;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(108, 76);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(253, 20);
            this.txtZipCode.TabIndex = 12;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(108, 50);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(253, 20);
            this.txtCity.TabIndex = 11;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(108, 22);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(253, 20);
            this.txtStreet.TabIndex = 10;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(23, 102);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(50, 13);
            this.lblCountry.TabIndex = 3;
            this.lblCountry.Text = "* Country";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(23, 76);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(50, 13);
            this.lblZipCode.TabIndex = 2;
            this.lblZipCode.Text = "Zip Code";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(23, 50);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 13);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "* City";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(23, 25);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(35, 13);
            this.lblStreet.TabIndex = 0;
            this.lblStreet.Text = "Street";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(74, 441);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(242, 441);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 476);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpAddress);
            this.Controls.Add(this.grpEmailPhones);
            this.Controls.Add(this.grpName);
            this.Name = "ContactForm";
            this.Text = "Register contact data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContactForm_FormClosing);
            this.grpName.ResumeLayout(false);
            this.grpName.PerformLayout();
            this.grpEmailPhones.ResumeLayout(false);
            this.grpEmailPhones.PerformLayout();
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.GroupBox grpEmailPhones;
        private System.Windows.Forms.TextBox txtPrMail;
        private System.Windows.Forms.TextBox txtBusMail;
        private System.Windows.Forms.TextBox txtCellPhone;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.Label lblEmailPrivate;
        private System.Windows.Forms.Label lblEmailBusiness;
        private System.Windows.Forms.Label lblCellPhone;
        private System.Windows.Forms.Label lblHomePhone;
        private System.Windows.Forms.GroupBox grpAddress;
        private System.Windows.Forms.ComboBox cmbCountries;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;

    }
}

