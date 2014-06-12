//Assignment 3
//Ticket.cs
//Created by Konstantinos Sidiropoulos

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{ 
    /// <summary>
    /// This classs is responsible to take the input from the MainForm and
    /// handles the information that have to do with the ticket. (Price and Name)
    /// After assign them to local values it returns them to the Seat class.
    /// </summary>
    /// 
    class Ticket
    {
        //Instance declaration 
        private string customerName; 
        private int numberSeat;
        private bool seatStatus;
        private double price;

        //Create a new object of the Seats class
        private Seats seat = new Seats();


        public void DoTicket()
        {
            seat.Seat(); //Call the Seat method the set the default values
            TicketDefaultValues();            
         }

        private void TicketDefaultValues()
        {
            customerName = " None ";
            price = 0;
        }

        //-------------------------------------- Set Methods -----------------------------------/
        
        /// <summary>
        /// Assign the seat number from the main Form to the local variable 
        /// </summary>
        /// <param name="seat"></param>
        /// 
        public void SetTicketSeatNumber( int seat ) 
        { 
            numberSeat = seat;
            GetTicketSeatNumber();
        }
        
              
        /// <summary>
        ///  IF the user cancel the reservetion the price will be 0 again
        ///else the price will have the value of the textbox
        /// </summary>
        /// <param name="userPrice"></param>
        /// 
        public void SetTicketPrice(double userPrice) 
        {
            price = userPrice;
        }

      

        /// <summary>
        /// Set the name to the local variable
        /// </summary>
        /// <param name="ticketCustomerName"></param>
        /// 
        public void TicketSetCustomerName(string ticketCustomerName) 
        {
            customerName = ticketCustomerName;
            
        }

        /// <summary>
        /// Send the status of the seat to the seats class
        /// </summary>
        /// <param name="ticketSeatState"></param>
        /// 
        public void TicketSetReservedTo(bool ticketSeatState)
        {
          seatStatus = ticketSeatState;
          
          if (!seatStatus)
          {
              seat.Seat(); //Reset the values if the seat is canceled
              TicketDefaultValues();
          }
              
          seat.SetlsReservedTo(ticketSeatState);
           
        }

        //-----------------------------------Get Method ---------------------------//

        /// <summary>
        /// Send the values to the Seat class
        /// </summary>
        /// <returns></returns>
        /// 
        private int GetTicketSeatNumber()
        {
            seat.SetSeatNumber(numberSeat);
            return numberSeat;
        }

        /// <summary>
        /// Invoke the printing method of the Seat class
        /// </summary>
        /// <returns></returns>
        /// 
        public string TicketToString() 
        {

          return (seat.ToString()+ price.ToString("0.00")+ "\t\t" +customerName );
        }

    }//class

}//namespace
