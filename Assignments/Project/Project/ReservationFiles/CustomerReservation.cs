//Booking Application 
//CustomerReservation.cs
//Created: 2014-05-10 by Konstantinos Sidiropoulos 

///The Customer Reservation class has a 'has a' relation with the classes PersonalInfo - ContactInfo - ReservationDates.
/// This class is used to manage all the data for the reservation and make some necessary checks 
///
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Project.ReservationFiles
{
    public class CustomerReservation
    {

        //------------------------------Variables Declaration ------------------------//
      
        //Create an instance for the objects
        PersonalInfo perInfo;
        ContactInfo contact;
        ReservationDates dates;
        RoomCategory category;

 
        //---------------------------------Constructors ------------------------------//
        /// <summary>
        /// Declaration of two Constructors although 
        /// only the default it is used until now by the application.
        /// </summary>
        /// 
        public CustomerReservation() 
        {
            Initialize();
        }

        public CustomerReservation(PersonalInfo perInfo, ContactInfo contact, ReservationDates dates, RoomCategory category) 
        {
            this.perInfo = perInfo;
            this.contact = contact;
            this.dates = dates;
            this.category = category;
        }

        //------------------------------------Properties --------------------------------//

        public PersonalInfo PerInfo { get { return perInfo; } set { perInfo = value; } }
        public ContactInfo Contact { get { return contact; } set { contact = value; } }
        public ReservationDates Dates { get { return dates; } set { dates = value; } }
        public RoomCategory Category { get { return category; } set { category = value; } }


        //------------------------------Methods-------------------------------------------------//

        /// <summary>
        /// The Initialize method is ised to create an instance for the objects.
        /// </summary>
        /// 
        private void Initialize() 
        {
            perInfo = new PersonalInfo();
            contact = new ContactInfo();
            dates = new ReservationDates();
        }

        /// <summary>
        /// The Checkdata is checking if the user has enter the necessary data for the reservation
        /// which are the first and last name, Id number and phone.
        /// </summary>
        /// <returns></returns>
        /// 
        public bool CheckData()
        {
            bool ok = false;

            if (!String.IsNullOrWhiteSpace(perInfo.FirstName)
                && !String.IsNullOrWhiteSpace(perInfo.LastName)
                && !String.IsNullOrWhiteSpace(perInfo.ID)
                &&!String.IsNullOrWhiteSpace(contact.Phone))
                ok = true;

            return ok;
        }

        /// <summary>
        /// The CheckData method is checking if the user has enter a valid date.
        /// Which means that the arrival date cannot be equal or after the departure date.
        /// </summary>
        /// <returns></returns>
        /// 
        public bool CheckDates() 
        {
            bool impossible = false;

            if (Dates.CheckIn.Date >= Dates.CheckOut.Date)
                impossible = true;

            return impossible;
        }

        /// <summary>
        /// ToString method returns a string with the information 
        /// that will be showed in the MainForm's listbox
        /// </summary>
        /// <returns></returns>
        /// 
        public override string ToString()
        {
            string strOut = String.Format(" {0}   {1} ",perInfo.ToString(), dates);

            return strOut;
            //return base.ToString();
        }

    }

}
