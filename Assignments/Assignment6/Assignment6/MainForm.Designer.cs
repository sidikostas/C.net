namespace Assignment6
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
            this.lstCustomerRegistry = new System.Windows.Forms.ListBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchLastName = new System.Windows.Forms.TextBox();
            this.txtSearchFirstName = new System.Windows.Forms.TextBox();
            this.lblSLastName = new System.Windows.Forms.Label();
            this.lblSName = new System.Windows.Forms.Label();
            this.grpCudtomer = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.grpCudtomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCustomerRegistry
            // 
            this.lstCustomerRegistry.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lstCustomerRegistry.FormattingEnabled = true;
            this.lstCustomerRegistry.ItemHeight = 15;
            this.lstCustomerRegistry.Location = new System.Drawing.Point(158, 33);
            this.lstCustomerRegistry.Name = "lstCustomerRegistry";
            this.lstCustomerRegistry.Size = new System.Drawing.Size(828, 319);
            this.lstCustomerRegistry.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(168, 17);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(233, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(142, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name (Surname, First Name)";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(450, 17);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(144, 13);
            this.lblLocation.TabIndex = 3;
            this.lblLocation.Text = "Street, zip code, city, country";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(702, 17);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(123, 13);
            this.lblContact.TabIndex = 4;
            this.lblContact.Text = "Office and home phones";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(906, 17);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 32);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 34);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(9, 72);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(117, 34);
            this.btnChange.TabIndex = 7;
            this.btnChange.Text = "&Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(9, 112);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 34);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearchLastName);
            this.groupBox1.Controls.Add(this.txtSearchFirstName);
            this.groupBox1.Controls.Add(this.lblSLastName);
            this.groupBox1.Controls.Add(this.lblSName);
            this.groupBox1.Location = new System.Drawing.Point(12, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 163);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(9, 118);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 34);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchLastName
            // 
            this.txtSearchLastName.Location = new System.Drawing.Point(9, 92);
            this.txtSearchLastName.Name = "txtSearchLastName";
            this.txtSearchLastName.Size = new System.Drawing.Size(117, 20);
            this.txtSearchLastName.TabIndex = 3;
            // 
            // txtSearchFirstName
            // 
            this.txtSearchFirstName.Location = new System.Drawing.Point(9, 53);
            this.txtSearchFirstName.Name = "txtSearchFirstName";
            this.txtSearchFirstName.Size = new System.Drawing.Size(117, 20);
            this.txtSearchFirstName.TabIndex = 2;
            // 
            // lblSLastName
            // 
            this.lblSLastName.AutoSize = true;
            this.lblSLastName.Location = new System.Drawing.Point(36, 76);
            this.lblSLastName.Name = "lblSLastName";
            this.lblSLastName.Size = new System.Drawing.Size(58, 13);
            this.lblSLastName.TabIndex = 1;
            this.lblSLastName.Text = "Last Name";
            // 
            // lblSName
            // 
            this.lblSName.AutoSize = true;
            this.lblSName.Location = new System.Drawing.Point(36, 27);
            this.lblSName.Name = "lblSName";
            this.lblSName.Size = new System.Drawing.Size(57, 13);
            this.lblSName.TabIndex = 0;
            this.lblSName.Text = "First Name";
            // 
            // grpCudtomer
            // 
            this.grpCudtomer.Controls.Add(this.btnAdd);
            this.grpCudtomer.Controls.Add(this.btnChange);
            this.grpCudtomer.Controls.Add(this.btnDelete);
            this.grpCudtomer.Location = new System.Drawing.Point(12, 30);
            this.grpCudtomer.Name = "grpCudtomer";
            this.grpCudtomer.Size = new System.Drawing.Size(140, 163);
            this.grpCudtomer.TabIndex = 11;
            this.grpCudtomer.TabStop = false;
            this.grpCudtomer.Text = "Customer";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 370);
            this.Controls.Add(this.grpCudtomer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lstCustomerRegistry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Customer Registry";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpCudtomer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCustomerRegistry;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchLastName;
        private System.Windows.Forms.TextBox txtSearchFirstName;
        private System.Windows.Forms.Label lblSLastName;
        private System.Windows.Forms.Label lblSName;
        private System.Windows.Forms.GroupBox grpCudtomer;
    }
}