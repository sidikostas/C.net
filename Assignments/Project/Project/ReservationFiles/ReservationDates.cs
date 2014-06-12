//Booking Application 
//ReservationDates.cs
//Created: 2014-05-09 by Konstantinos Sidiropoulos 

///This class is used to manage the dates that the customer will stay to the hotel
///
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ReservationFiles

{
    public class ReservationDates
    {
        // -------------------------- Variable Declaration ---------------------------//

        DateTime checkIn = DateTime.Now.Date;
        DateTime checkOut = DateTime.Now.Date;
        

        // ------------------------Constructors --------------------------------------//
        /// <summary>
        /// Declaration of two Constructors although 
        /// only the default it is used until now by the application.
        /// </summary>
        /// 
        public ReservationDates() 
        {
        }

        public ReservationDates( DateTime checkIn, DateTime checkOut) 
        {
            this.checkIn = checkIn;
            this.checkOut = checkOut;
        }

        //----------------------------Properties ------------------------------------//
                
        public DateTime CheckIn { get { return checkIn; } set { checkIn = value; } }
        public DateTime CheckOut { get { return checkOut; } set { checkOut = value; } }

        //----------------------------Methods --------------------------------------//

        /// <summary>
        /// This method calculate the difference of the days
        /// between the arrival and the departure date.
        /// </summary>
        /// <returns></returns>
        /// 
        public double CalculateDaysOfResidence() 
        {
            int daysOfResidence = (checkOut - checkIn).Days;
            
            if (checkIn.Date.Day == DateTime.Now.Day)
                return daysOfResidence + 1; //because the customer must pay the arrival day 

            else

            return daysOfResidence;
        }

        /// <summary>
        /// ToString method returns a string with the dates
        /// </summary>
        /// <returns></returns>
        /// 
        public override string ToString()
        {   
            string strOut = String.Format(" {0}     {1}", checkIn.ToShortDateString(), checkOut.ToShortDateString());
            return strOut;
        }
        
    }//Class
}//Namespace
