//Booking Application 
//ReservationManager.cs
//Created: 2014-05-14 by Konstantinos Sidiropoulos 

///The ReservationManager class has a 'has a' relation with the Resevation class .
///This class is used to store all the reservations in order the user to retrieve 
///and edit the reservation's data.
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.ReservationFiles;

namespace Project
{
    class ReservationManager
    {
        //---------------------------------------------Variable Declaration --------------------------//

        //A List of objects is used to store all the reservations
        List<Reservation> m_Reservations = new List<Reservation>();
        

        //---------------------------------------Constructor ----------------------------------------//

        public ReservationManager()
        {
        }

        //----------------------------------------Properties ---------------------------------------//

        public int Count { get { return m_Reservations.Count; } }


        //---------------------------------------Methods -------------------------------------------//

        /// <summary>
        /// This method is used to add to the List a new reservation.
        /// Moreover accepts as an argument the maximum number of the rooms in order 
        /// assign the new reservation to a random room.
        /// </summary>
        /// <param name="customerIn"></param>
        /// <param name="maxRooms"></param>
        /// <returns></returns>
        /// 
        public bool AddReservation(CustomerReservation customerIn, int maxRooms)
        {
            bool reserved = false;

            Reservation reservationIn = new Reservation(customerIn);//Create an instance of Reservation class

            if (customerIn != null) 
            {
                m_Reservations.Add(reservationIn);
                reservationIn.RandomRoomNumber(maxRooms);
                reserved = true;
            }

            return reserved;
        }

        /// <summary>
        /// This method is used to change the data of 
        /// a reservation that is already saved in the List
        /// </summary>
        /// <param name="index"></param>
        /// <param name="customerIn"></param>
        /// <returns></returns>
        /// 
        public bool ChangeReservation(int index, CustomerReservation customerIn) 
        {
            bool changed = false;

            Reservation reservationIn = new Reservation(customerIn);

            if (customerIn != null)
            {
                reservationIn.RoomNumber = m_Reservations[index].RoomNumber; // preserve room number
                               
                m_Reservations.RemoveAt(index);//remove the old reservation
                m_Reservations.Insert(index, reservationIn);// and add to the same position the changed one
                changed = true;
            }

            return changed;
        }

        /// <summary>
        /// This method is used to remove a reservation from List
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool DeleteReservation(int index) 
        {
            bool deleted = false;

            if (index != -1)//the user must select on entry from the listbox
            {
                m_Reservations.RemoveAt(index);
                deleted = true;
            }

            return deleted;  
        }

        /// <summary>
        /// This method returns all the data of a specific reservation. 
        /// This data are used to show all the reservation information
        /// to the user of the the selected reservation.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        /// 
        public Reservation GetReservation(int index)
        {  
            if (index >= 0 && index < m_Reservations.Count)
                return m_Reservations[index];

            return null;
        }

        /// <summary>
        /// This method returns all the reservations that exists to the List in an array.
        /// This array is used to fill the ListBox on the MainForm.
        /// </summary>
        /// <returns></returns>
        /// 
        public string[] GetReservations() 
        {
            string[] reservations = new string[m_Reservations.Count];//Create an array with the same length as the List

            //copy the data from the list to the array
            for (int index = 0; index < m_Reservations.Count; index++)
                reservations[index] = m_Reservations[index].ToString(); 

            return reservations;
        }

    }//Class
}//Namespace
