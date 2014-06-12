//Booking Application 
//Reservation.cs
//Created: 2014-05-12 by Konstantinos Sidiropoulos 

///The Reservation class has a 'has a' relation with the CustomerReservation class .
///This class is used to prepare the reservation's data 
///that they will be finally saved to the Reservation Manager
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.ReservationFiles;

namespace Project
{
    public class Reservation
    {
        
        //---------------------------------Variable Declaration -------------------------------------//

        //Create an instance for the objects
        CustomerReservation customerRes = new CustomerReservation();
        Random room = new Random();
        string roomNumber;

        //-------------------------------- Constructors ---------------------------------------------//

        /// <summary>
        /// Declaration of two Constructors        
        /// </summary>
        /// 
        public Reservation(): this(null)
        {
            
        }

        public Reservation(CustomerReservation customerRes)
        {
            this.customerRes = customerRes;
        }

        //----------------------------------Properties ----------------------------------------------//

        public CustomerReservation CustomerResData { get { return customerRes; } set { customerRes = value; } }
        public string RoomNumber { get { return roomNumber; } set { roomNumber = value; } } 

        //----------------------------------Methods ------------------------------------------------//
     
        /// <summary>
        /// This method has as an argument the maximum number of the rooms 
        /// and then assigns a random room to reservation
        /// </summary>
        /// <param name="maxNumberOfRooms"></param>
        /// 
        public void RandomRoomNumber(int maxNumberOfRooms) 
        {          
            roomNumber = room.Next(0, maxNumberOfRooms).ToString();          
        }

        /// <summary>
        /// ToString method returns a string with the information 
        /// that will be showed in the MainForm's listbox
        /// </summary>
        /// <returns></returns>
        /// 
        public override string ToString()
        {
            string strOut = roomNumber+" \t" + customerRes.ToString();
            return strOut;
            //return base.ToString();
        }




    }
}
