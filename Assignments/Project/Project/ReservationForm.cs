//Booking Application 
//ReservationForm.cs
//Created: 2014-05-17 by Konstantinos Sidiropoulos 

///The ReservationForm has a 'has a' relation with the CustomerReservation class .
///This class is used to interact with the users in order to receive the data for the reservation
///and inform them about the correct use of the application 
/// 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.ReservationFiles;

namespace Project
{
    public partial class ReservationForm : Form
    {
        //--------------------------------------------Variable Declaretion ------------------------------//

        //Create an instance of the objects 
        CustomerReservation currCustomerReservation = new CustomerReservation();
        ToolTip info = new ToolTip();//Create an tooltip for the better information of the user
        bool closeForm;
       

        //----------------------------------------Constructor ------------------------------------------//
        
        public ReservationForm()
        {
            InitializeComponent();
            InitializeGUI();
        }        

        //---------------------------------------------Properties ----------------------------------------//
        
        public CustomerReservation ReservationData 
        {
            get { return currCustomerReservation; }
            set
            {
                if (value != null) // If there is a value the Reservation form will be filled with the data of the selected reservation
                {
                    currCustomerReservation = value;
                    UpdateGUI();
                }
            }
        }
        

        //---------------------------------------------Methods ----------------------------------------------//

        /// <summary>
        /// This method prepares the form for the first use.
        /// </summary>
        /// 
        private void InitializeGUI() 
        {           
             FillComboBox();
             closeForm = false;
             cmbRoomCategory.SelectedIndex = 0;
             
            toolTip1.SetToolTip(txtPhoneNumber, "This field accepts only numbers");
            toolTip1.SetToolTip(btnCancel, "Return to program without saving ");
        }

        /// <summary>
        /// This method fill the combobox with the values of the RoomCategory enum
        /// </summary>
        /// 
        private void FillComboBox() 
        {
            cmbRoomCategory.Items.Clear(); 

            foreach (var category in Enum.GetValues(typeof(RoomCategory)))
                cmbRoomCategory.Items.Add(category);

        }

        /// <summary>
        /// This method invokes when the user wants to change or edit the data of a reservation
        /// and fills the form with the data of this reservation
        /// </summary>
        /// 
        private void UpdateGUI() 
        {
            txtFistName.Text = currCustomerReservation.PerInfo.FirstName;
            txtLastName.Text = currCustomerReservation.PerInfo.LastName;
            txtIdNumber.Text = currCustomerReservation.PerInfo.ID;

            txtPhoneNumber.Text = currCustomerReservation.Contact.Phone;
            txtEmail.Text = currCustomerReservation.Contact.Email;

            dtmCheckIn.Value = currCustomerReservation.Dates.CheckIn;
            dtmCheckOut.Value = currCustomerReservation.Dates.CheckOut;

            cmbRoomCategory.SelectedIndex = (int)currCustomerReservation.Category;//convert enum to int!!
        }

        /// <summary>
        /// Methods which reads the user's input for the customer's personal information
        /// </summary>
        /// 
        private void ReadPerInfo() 
        {
            currCustomerReservation.PerInfo.FirstName = txtFistName.Text;
            currCustomerReservation.PerInfo.LastName = txtLastName.Text;
            currCustomerReservation.PerInfo.ID = txtIdNumber.Text;
        }

        /// <summary>
        /// Methods which reads the user's input for the customer's contact information
        /// </summary>
        /// 
        private void ReadContactInfo() 
        {
            currCustomerReservation.Contact.Phone = txtPhoneNumber.Text;
            currCustomerReservation.Contact.Email = txtEmail.Text;
        }

        /// <summary>
        /// Methods which reads the user's input for the customer's reservation dates
        /// </summary>
        /// 
        private void ReadDates() 
        {
            currCustomerReservation.Dates.CheckIn = dtmCheckIn.Value;
            currCustomerReservation.Dates.CheckOut = dtmCheckOut.Value;
        }

        /// <summary>
        /// Methods which reads the user's input for the customer's room category selection
        /// </summary>
        /// 
        private void ReadCategory() 
        {
            currCustomerReservation.Category = (RoomCategory)cmbRoomCategory.SelectedIndex;
        }

        /// <summary>
        /// This methods invokes when the user want just to see a reservation's data without change them
        /// </summary>
        /// 
        public void DisableComponents() 
        {            
            grbCategory.Enabled = false;
            grbContactInfo.Enabled = false;                
            grbDates.Enabled = false;               
            grbCustomerInfo.Enabled = false;                
            btnOk.Enabled = false;               
            btnCancel.Text = "Close";                 
        }

        //-------------------------------------Event Handlers -----------------------------------//

        /// <summary>
        /// When the user press OK and the input is valid the Form wil be closed
        /// else it will be an information message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btnOK_Click(object sender, EventArgs e)
        {
            ReadPerInfo();
            ReadContactInfo();
            ReadDates();
            ReadCategory();
            
            if (currCustomerReservation.CheckData() && !currCustomerReservation.CheckDates())
                closeForm = true;

            else MessageBox.Show("Fill the fields with * or check the dates");
        }

        /// <summary>
        /// This event handler occurs when the user changing the check out date and 
        /// is checking that he or she must selected a valid check out date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void dtmCheckOut_ValueChanged(object sender, EventArgs e)
        {
            ReadDates();

            if (currCustomerReservation.CheckDates())
            {
                MessageBox.Show("The check out date must be after the check in date "); 
            }
        }
             
        /// <summary>
        /// This event handler check if the form will close or not.
        /// If the data are valid the form will close else it will return to the form until the user 
        /// correct the input or press Cancel button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void ReservationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeForm)
                e.Cancel = false;//Close form

            else e.Cancel = true;
        }

        /// <summary>
        /// When the user press cancel nothing will be saved and it will return to the main application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btnCancel_Click(object sender, EventArgs e)
        {
            closeForm = true;
            this.Close();
        }

        /// <summary>
        /// In the phone field the user must enter only numbers. 
        /// For this reason this event handler allows to work only the numbers, backspace and delete buttons 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

    }//Class
}//Namespace
