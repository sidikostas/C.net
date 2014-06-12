//Assignment 3
//Seats.cs
//Created by Konstantinos Sidiropoulos

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    /// <summary>
    /// This class is responsible for all the processes and the calculation of the data that the program is using.
    /// Moreover handles the data that have to do only with the seat.
    /// It is using Set method to retrieve data from the ticket class and Get methods to return the new saved values.
    /// </summary>
    ///     
    class Seats
    {
        //instance variable declaration      
        private int number;
        private bool isReserved;
        


        public void  Seat()
        {
            SetDefaultValues();  
        }

        /// <summary>
        /// Set the defaul values on the variables
        /// </summary>
        /// 
        private void SetDefaultValues()
        {         
          isReserved = false;          
        }


        //--------------------------------------------Set MEthods ---------------------------------//

        /// <summary>
        /// Set the selected seat number to the local variable number 
        /// </summary>
        /// <param name="seatNum"></param>
        /// 
        public void SetSeatNumber(int seatNum) 
        {
          number = seatNum; 
        }

        /// <summary>
        ///Gives the value to the isReserved
        ///if it is true is the seat will be reserved else will be vacant        
        /// </summary>
        /// <param name="seatStatus"></param>
        /// 
        public void SetlsReservedTo(bool seatStatus) 
        {
            isReserved = seatStatus;
        }


        //----------------------------------- Get Methods -----------------------------------------------//

        private int GetNumber()
        {
            int newNumber = number + 1;// Start the seat number from the 1

            return newNumber;
        }
                
        private bool GetReserved()
        {
          return isReserved;
        }

        /// <summary>
        ///Read the status of the Seat
        ///is it true status will be reserved else it will be vacant    
        /// </summary>
        /// <returns></returns>
        /// 
        private string GetStatus() 
        {
            string statusGet;

            if (isReserved == true)
                statusGet = "Reserved";
           
            else
                statusGet = "Vacant";

            return statusGet;
        }



        
        /// <summary>
        ///This method adds and update the items in the listbox
        /// </summary>
        /// <returns></returns>
        /// 
        public string ToString()
        {
            //local variable declaration
            string statusTostring=" Vacant ";
            int seatPosition = GetNumber();

            statusTostring = GetStatus();
            
            string allItems = System.String.Format("{0} \t {1} \t ",seatPosition,statusTostring);

            return allItems;
        }

    }//class
}//namespace
