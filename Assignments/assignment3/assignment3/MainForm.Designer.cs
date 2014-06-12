namespace assignment3
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
            this.groupBookingInput = new System.Windows.Forms.GroupBox();
            this.tBoxPrice = new System.Windows.Forms.TextBox();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.lPrice = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.rButCancReserv = new System.Windows.Forms.RadioButton();
            this.rButReserve = new System.Windows.Forms.RadioButton();
            this.bOK = new System.Windows.Forms.Button();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.lNumOfVacSeatsOut = new System.Windows.Forms.Label();
            this.lNumOfResSeatsOut = new System.Windows.Forms.Label();
            this.lNumOfSeatsOut = new System.Windows.Forms.Label();
            this.lNumOfVacSeats = new System.Windows.Forms.Label();
            this.lNumOfResSeats = new System.Windows.Forms.Label();
            this.lNumOfSeats = new System.Windows.Forms.Label();
            this.groupBoxReservertions = new System.Windows.Forms.GroupBox();
            this.listBoxReservations = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBookingInput.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.groupBoxReservertions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBookingInput
            // 
            this.groupBookingInput.Controls.Add(this.tBoxPrice);
            this.groupBookingInput.Controls.Add(this.tBoxName);
            this.groupBookingInput.Controls.Add(this.lPrice);
            this.groupBookingInput.Controls.Add(this.lName);
            this.groupBookingInput.Controls.Add(this.rButCancReserv);
            this.groupBookingInput.Controls.Add(this.rButReserve);
            this.groupBookingInput.Location = new System.Drawing.Point(37, 22);
            this.groupBookingInput.Name = "groupBookingInput";
            this.groupBookingInput.Size = new System.Drawing.Size(248, 131);
            this.groupBookingInput.TabIndex = 0;
            this.groupBookingInput.TabStop = false;
            this.groupBookingInput.Text = "Booking Input";
            // 
            // tBoxPrice
            // 
            this.tBoxPrice.Location = new System.Drawing.Point(178, 98);
            this.tBoxPrice.Name = "tBoxPrice";
            this.tBoxPrice.Size = new System.Drawing.Size(54, 20);
            this.tBoxPrice.TabIndex = 5;
            // 
            // tBoxName
            // 
            this.tBoxName.Location = new System.Drawing.Point(21, 99);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(139, 20);
            this.tBoxName.TabIndex = 4;
            // 
            // lPrice
            // 
            this.lPrice.AutoSize = true;
            this.lPrice.Location = new System.Drawing.Point(175, 70);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(31, 13);
            this.lPrice.TabIndex = 3;
            this.lPrice.Text = "Price";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(21, 70);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(35, 13);
            this.lName.TabIndex = 2;
            this.lName.Text = "Name";
            // 
            // rButCancReserv
            // 
            this.rButCancReserv.AutoSize = true;
            this.rButCancReserv.Location = new System.Drawing.Point(123, 30);
            this.rButCancReserv.Name = "rButCancReserv";
            this.rButCancReserv.Size = new System.Drawing.Size(118, 17);
            this.rButCancReserv.TabIndex = 1;
            this.rButCancReserv.TabStop = true;
            this.rButCancReserv.Text = "Cancel Reservation";
            this.rButCancReserv.UseVisualStyleBackColor = true;
            this.rButCancReserv.CheckedChanged += new System.EventHandler(this.rButCancReserv_CheckedChanged);
            // 
            // rButReserve
            // 
            this.rButReserve.AutoSize = true;
            this.rButReserve.Location = new System.Drawing.Point(21, 30);
            this.rButReserve.Name = "rButReserve";
            this.rButReserve.Size = new System.Drawing.Size(65, 17);
            this.rButReserve.TabIndex = 0;
            this.rButReserve.TabStop = true;
            this.rButReserve.Text = "Reserve";
            this.rButReserve.UseVisualStyleBackColor = true;
            this.rButReserve.CheckedChanged += new System.EventHandler(this.rButReserve_CheckedChanged);
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(75, 170);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(181, 23);
            this.bOK.TabIndex = 1;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.lNumOfVacSeatsOut);
            this.groupBoxOutput.Controls.Add(this.lNumOfResSeatsOut);
            this.groupBoxOutput.Controls.Add(this.lNumOfSeatsOut);
            this.groupBoxOutput.Controls.Add(this.lNumOfVacSeats);
            this.groupBoxOutput.Controls.Add(this.lNumOfResSeats);
            this.groupBoxOutput.Controls.Add(this.lNumOfSeats);
            this.groupBoxOutput.Location = new System.Drawing.Point(37, 246);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(248, 145);
            this.groupBoxOutput.TabIndex = 2;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Output Data";
            // 
            // lNumOfVacSeatsOut
            // 
            this.lNumOfVacSeatsOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lNumOfVacSeatsOut.Location = new System.Drawing.Point(184, 101);
            this.lNumOfVacSeatsOut.Name = "lNumOfVacSeatsOut";
            this.lNumOfVacSeatsOut.Size = new System.Drawing.Size(48, 24);
            this.lNumOfVacSeatsOut.TabIndex = 5;
            // 
            // lNumOfResSeatsOut
            // 
            this.lNumOfResSeatsOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lNumOfResSeatsOut.Location = new System.Drawing.Point(184, 63);
            this.lNumOfResSeatsOut.Name = "lNumOfResSeatsOut";
            this.lNumOfResSeatsOut.Size = new System.Drawing.Size(48, 23);
            this.lNumOfResSeatsOut.TabIndex = 4;
            // 
            // lNumOfSeatsOut
            // 
            this.lNumOfSeatsOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lNumOfSeatsOut.Location = new System.Drawing.Point(184, 25);
            this.lNumOfSeatsOut.Name = "lNumOfSeatsOut";
            this.lNumOfSeatsOut.Size = new System.Drawing.Size(48, 24);
            this.lNumOfSeatsOut.TabIndex = 3;
            // 
            // lNumOfVacSeats
            // 
            this.lNumOfVacSeats.AutoSize = true;
            this.lNumOfVacSeats.Location = new System.Drawing.Point(21, 102);
            this.lNumOfVacSeats.Name = "lNumOfVacSeats";
            this.lNumOfVacSeats.Size = new System.Drawing.Size(120, 13);
            this.lNumOfVacSeats.TabIndex = 2;
            this.lNumOfVacSeats.Text = "Number of vacant seats";
            // 
            // lNumOfResSeats
            // 
            this.lNumOfResSeats.AutoSize = true;
            this.lNumOfResSeats.Location = new System.Drawing.Point(21, 64);
            this.lNumOfResSeats.Name = "lNumOfResSeats";
            this.lNumOfResSeats.Size = new System.Drawing.Size(128, 13);
            this.lNumOfResSeats.TabIndex = 1;
            this.lNumOfResSeats.Text = "Number of reserved seats";
            // 
            // lNumOfSeats
            // 
            this.lNumOfSeats.AutoSize = true;
            this.lNumOfSeats.Location = new System.Drawing.Point(21, 26);
            this.lNumOfSeats.Name = "lNumOfSeats";
            this.lNumOfSeats.Size = new System.Drawing.Size(109, 13);
            this.lNumOfSeats.TabIndex = 0;
            this.lNumOfSeats.Text = "Total number of seats";
            // 
            // groupBoxReservertions
            // 
            this.groupBoxReservertions.Controls.Add(this.label4);
            this.groupBoxReservertions.Controls.Add(this.label3);
            this.groupBoxReservertions.Controls.Add(this.label2);
            this.groupBoxReservertions.Controls.Add(this.label1);
            this.groupBoxReservertions.Controls.Add(this.listBoxReservations);
            this.groupBoxReservertions.Location = new System.Drawing.Point(327, 22);
            this.groupBoxReservertions.Name = "groupBoxReservertions";
            this.groupBoxReservertions.Size = new System.Drawing.Size(467, 369);
            this.groupBoxReservertions.TabIndex = 3;
            this.groupBoxReservertions.TabStop = false;
            this.groupBoxReservertions.Text = "Reservations";
            // 
            // listBoxReservations
            // 
            this.listBoxReservations.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.listBoxReservations.FormattingEnabled = true;
            this.listBoxReservations.ItemHeight = 14;
            this.listBoxReservations.Location = new System.Drawing.Point(32, 36);
            this.listBoxReservations.Name = "listBoxReservations";
            this.listBoxReservations.ScrollAlwaysVisible = true;
            this.listBoxReservations.Size = new System.Drawing.Size(428, 312);
            this.listBoxReservations.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 403);
            this.Controls.Add(this.groupBoxReservertions);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.groupBookingInput);
            this.Name = "MainForm";
            this.Text = "Kostas Ticket Reservation";
            this.groupBookingInput.ResumeLayout(false);
            this.groupBookingInput.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.groupBoxReservertions.ResumeLayout(false);
            this.groupBoxReservertions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBookingInput;
        private System.Windows.Forms.TextBox tBoxPrice;
        private System.Windows.Forms.Label lPrice;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.RadioButton rButCancReserv;
        private System.Windows.Forms.RadioButton rButReserve;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.Label lNumOfVacSeatsOut;
        private System.Windows.Forms.Label lNumOfResSeatsOut;
        private System.Windows.Forms.Label lNumOfSeatsOut;
        private System.Windows.Forms.Label lNumOfVacSeats;
        private System.Windows.Forms.Label lNumOfResSeats;
        private System.Windows.Forms.Label lNumOfSeats;
        private System.Windows.Forms.GroupBox groupBoxReservertions;
        public System.Windows.Forms.ListBox listBoxReservations;
        public System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

