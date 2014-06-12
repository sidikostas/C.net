//Assignment 3
//MainForm.cs
//Created by Konstantinos Sidiropoulos

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment3
{
    /// <summary>
    /// This program is managing the seats. 
    /// The user can reserve a seat by entering the name and the corresponding price of the seat or can cancel the reservation.
    /// Furthermore there is a display for the status of the available seats
    /// MainForm is repsonsible for the correct use of the form components and the necessary checks and controls.
    /// All the data are sending to the Ticket class and after that to Seats class for processing.
    /// </summary>
    /// 
    public partial class MainForm : Form
    {

        //Instance declaration 
        private const int numOfSeats = 60; //Total number of available seats
        private int numOfReservedSeats = 0; //Number of reserved seats

        //create object of the Ticket class
        Ticket ticket = new Ticket();
      
        public MainForm()
        {
            InitializeComponent(); // VS' s code

            //1. Prepare the form for the 1st use
            InitializeGUI();
        }

        //----------------------------------------Methods ------------------------------------------------//

        private void InitializeGUI()
        {
            //2.3.2.1 Set the Reserve Button to checked
            rButReserve.Checked = true;

            //2.3.2.2 Clear all output Labels
            lNumOfResSeatsOut.Text = String.Empty;
            lNumOfSeatsOut.Text = String.Empty;
            lNumOfVacSeatsOut.Text = String.Empty;
            listBoxReservations.Items.Clear();

            // Set Default values to the listbox
            ticket.DoTicket();

            // 2.3.2.3 add items to the list box with the default values
            for (int seat = 0; seat < numOfSeats; seat++)
            {
                ticket.SetTicketSeatNumber(seat);
                listBoxReservations.Items.Add(ticket.TicketToString()); 
            }

        }//Initialize

        /// <summary>
        /// Update the output labels and the selected listbox item
        /// </summary>
        /// <param name="selection"></param>
        private void UpdateGUI(int selection)
        {
            int numResidueSeats = numOfSeats - numOfReservedSeats; // Calculate the residue seats

            //Convert numbers to string
            string stringNumOfSeats = numOfSeats.ToString();
            string stringNumresidueSeats = numResidueSeats.ToString();
            string stringNumOfReservedSeats = numOfReservedSeats.ToString();

            //Update the output labels
            lNumOfSeatsOut.Text = stringNumOfSeats;
            lNumOfVacSeatsOut.Text = stringNumresidueSeats;
            lNumOfResSeatsOut.Text = stringNumOfReservedSeats;

            //Update the selected item of the listbox
            listBoxReservations.Items[selection] = ticket.TicketToString();

            //Clear the text boxes
            tBoxName.Text = String.Empty;
            tBoxPrice.Text = String.Empty;
        }     
        
        /// <summary>
        ///This method reads the input from the textbox price 
        ///and if it is negative or empty will show a message to the user
        ///else it will send the price to the ticket class
        /// </summary>
        /// <returns></returns>
        /// 
        private bool ReadAndValidatePrice()
        {
            bool wrongPrice = false;
            double userPrice;

            if (Double.TryParse(tBoxPrice.Text, out userPrice)) // Convert the string to double, Validate that is a number
            {

                if (userPrice < 0 || string.IsNullOrEmpty(tBoxPrice.Text)) //2.1.8 Check if negative or empty
                    wrongPrice = true;

                else
                    ticket.SetTicketPrice(userPrice);
            }

            else wrongPrice = true; 
            
            return wrongPrice;
        }

        /// <summary>
        /// This method returns the number of the selected item on the listbox
        /// </summary>
        /// <returns
        /// ></returns>
        /// 
        private int ReadAndValidateSeatNr() 
        {
            int selection = listBoxReservations.SelectedIndex; 
            return selection;
        }

       
        /// <summary>
        /// Read from the textbox name and send the price to the Ticket class
        /// if it is empty show a message to the user
        /// </summary>
        /// <returns></returns>
        /// 
        private bool  ReadAndValidateName() 
        {
            bool noName = false;

            if (string.IsNullOrEmpty(tBoxName.Text)) noName = true;//2.1.7 Check is the textbox is empty

            else 
                ticket.TicketSetCustomerName(tBoxName.Text); // send the string to the ticket class

            return noName;

        }

        /// <summary>
        /// This method sends the number and the status of the seat to Ticket class
        /// </summary>
        /// <param name="seatNr"></param>
        /// 
        private void ReserveSeat(int seatNr) 
        {
            bool seatState = true;

            ticket.TicketSetReservedTo(seatState);
            ticket.SetTicketSeatNumber(seatNr);
        }

        /// <summary>
        /// This method sends the number and the status of the seat to Ticket class
        /// </summary>
        /// <param name="seatNr"></param>
        /// 
        private void CancelSeat(int seatNr) 
        {
            bool seatState = false;

            ticket.TicketSetReservedTo(seatState);
            ticket.SetTicketSeatNumber(seatNr);
        }


       

        //------------------------------------------Event Hanlders --------------------------------//

        /// <summary>
        /// This code will be executed when the button OK is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void bOK_Click(object sender, EventArgs e)
        {
            //read input common to both cancel and reserve 
            int seatNr = ReadAndValidateSeatNr();
            bool nameValidation, priceValidation;

            if (seatNr < 0) //No item selected
            {
                MessageBox.Show("Please select an item from the list!", "Please...");
                return; //Stop execution
            }

            if (rButReserve.Checked)
            {
                ReserveSeat(seatNr); // Reserves the selected item

                nameValidation = ReadAndValidateName(); // Read the name from the textbox name

                if (nameValidation) // If the textbox name is empty show the message
                {
                    MessageBox.Show("Please enter a name");
                    return;
                }

                priceValidation = ReadAndValidatePrice();// Read the price from the textbox price

                if (priceValidation)// If the textbox price is empty or negative show the message 
                {
                    MessageBox.Show("Please enter correct price");
                    return;
                }

                //check the reserved seats and if there are avaliable increase the number of reserved seats
                if (numOfReservedSeats < numOfSeats) { numOfReservedSeats++; }

            }
            else
            {
                CancelSeat(seatNr); // Cancel the selected item

                //check the reserved seats and if there are decrease the number of reserved seats
                if (numOfReservedSeats > 0) numOfReservedSeats--; //
            }

            UpdateGUI(seatNr); // update the output labels and the listbox items

        }//bOK_Click

        /// <summary>
        /// When Cancel radio button checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void rButCancReserv_CheckedChanged(object sender, EventArgs e)
        {
            //2.1.4 Disable Textboxes
            tBoxName.Enabled = false;
            tBoxPrice.Enabled = false;
        }

        /// <summary>
        /// When Reserve button checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void rButReserve_CheckedChanged(object sender, EventArgs e)
        {
            //2.1.6 Enable Textboxes
            tBoxName.Enabled = true;
            tBoxPrice.Enabled = true;
        }
        

    }//class
}//namespace
