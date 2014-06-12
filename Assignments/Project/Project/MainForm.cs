//Booking Application 
//MainForm.cs
//Created: 2014-05-20 by Konstantinos Sidiropoulos 

///The ReservationForm has a 'has a' relation with the ReservationForm and ReservationManager classes .
///This class is used to interact with the users in order to add, edit and delete reservations.
///Furthermore is used to inform the users about the saved reservations.
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

namespace Project
{
    public partial class MainForm : Form
    {
        //----------------------------------------Variable Declaration ------------------------------------------//

        //Create an object and declare the maximun number of the rooms
        ReservationManager mngReservation= new ReservationManager();
        int maxNumberOfRooms = 100;
       
        // ---------------------------------------Constructor ------------------------------------------------//

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }
        
      
        //-----------------------------------------Methods ----------------------------------------------------//

        /// <summary>
        /// This method prepares the GUI for the first use
        /// </summary>
        /// 
        private void InitializeGUI() 
        {
            lstSavedReservations.Items.Clear();
            lblAvailability.Text = maxNumberOfRooms.ToString();
        }

        /// <summary>
        /// This method is used to update the GUI after a reservation is added, edited or deleted.
        /// </summary>
        /// 
        private void UpdateGUI() 
        {
            lstSavedReservations.Items.Clear();
            lstSavedReservations.Items.AddRange(mngReservation.GetReservations());
            lblAvailability.Text = maxNumberOfRooms.ToString();

            lblName.Text = string.Empty;
            lblIdNumber.Text = string.Empty;
            lblNumberOfDays.Text = string.Empty;
            lblRoomCategory.Text = string.Empty;

        }

        /// <summary>
        /// This method fills the info fields of the GUI with the necessary data.
        /// </summary>
        /// <param name="index"></param>
        /// 
        private void FillTheForm(int index) 
        {
            lblName.Text = mngReservation.GetReservation(index).CustomerResData.PerInfo.FullName;
            lblNumberOfDays.Text = mngReservation.GetReservation(index).CustomerResData.Dates.CalculateDaysOfResidence().ToString();
            lblRoomCategory.Text = mngReservation.GetReservation(index).CustomerResData.Category.ToString();
            lblIdNumber.Text = mngReservation.GetReservation(index).CustomerResData.PerInfo.ID;
        }

        //---------------------------------------------------Event Handlers ---------------------------------------------//
        
        /// <summary>
        /// When the user press the New Customer Button the Reservation Form will be appeared 
        /// and if the user press OK the reservation will be saved to the Reservation's Manager List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            ReservationForm frmReservation = new ReservationForm(); //Create an instance of Reservation Form

            if (frmReservation.ShowDialog() == DialogResult.OK)//If the form close with OK
            {
                mngReservation.AddReservation(frmReservation.ReservationData, maxNumberOfRooms);
                maxNumberOfRooms--;
                UpdateGUI();
            }
        }

        /// <summary>
        /// If the user press the Exit there will be an confirmation in order to close the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(" Are you sure you want to Exit","Exit Application " , MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes) 
            {                
                Application.Exit();
            }

        }

        /// <summary>
        /// This event handler deletes a selected entry from the Reservation Manager and from the ListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void Delete_Click(object sender, EventArgs e)//Delete
        {
            if (mngReservation.DeleteReservation(lstSavedReservations.SelectedIndex))
            {
                maxNumberOfRooms++;
                UpdateGUI();
            }
            else
                MessageBox.Show(" First select a customer from the list");
        }

       
        /// <summary>
        /// When the user press the More Info button the Reservation Form will be showed 
        /// with all the information of the selected reservation.
        /// However all the Components will be disabled except from the Close button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btnShowInfo_Click(object sender, EventArgs e)
        {            
            ReservationForm frmReservation = new ReservationForm();

            int index = lstSavedReservations.SelectedIndex;

            if (index != -1) // fill the contact form with the information of the selected customer          
            {
                frmReservation.ReservationData = mngReservation.GetReservation(index).CustomerResData;
                frmReservation.DisableComponents();              
                frmReservation.Show();
            }

            else MessageBox.Show("Select first an entry from the list");            
        }

        /// <summary>
        /// When the user press Edit the Reservation Form will be showed filled 
        /// with the information of the selected reservation
        /// and the user will be in position to edit them.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btnEdit_Click(object sender, EventArgs e)
        {
            ReservationForm changeReservation = new ReservationForm();

            int index = lstSavedReservations.SelectedIndex;

            if (index != -1)
            {
                changeReservation.ReservationData = mngReservation.GetReservation(index).CustomerResData;

                if (changeReservation.ShowDialog() == DialogResult.OK)
                {
                    mngReservation.ChangeReservation(index, changeReservation.ReservationData);
                    UpdateGUI();
                }
            }

            else MessageBox.Show("Select first an entry from the list");   
        }

        /// <summary>
        /// When the user select one of the items in the ListBox 
        /// the fields that are on the MainForm will be filled with the 
        /// corresponting data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void lstSavedReservations_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstSavedReservations.SelectedIndex;

            if (index != -1)
            {
                FillTheForm(index);
            }
        }

    }//Class
}//NameSpace
