//Booking Application 
//ContactInfo.cs
//Created: 2014-05-09 by Konstantinos Sidiropoulos 

//This class is used to manage the customer's  contact information
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ReservationFiles
{
    public class ContactInfo
    {
      
        //--------------------------------Variable Declaration ----------------------//

        string phone;
        string email;

        //--------------------------------Contructors ------------------------------//
        /// <summary>
        /// Declaration of two Constructors although 
        /// only the default it is used until now by the application.
        /// </summary>
        /// 
        public ContactInfo() 
        {
        }

        public ContactInfo(string phone, string email)
        {
            this.phone = phone;
            this.email =email;
        }

        //---------------------------------Properties ----------------------------//
       
        #region Properties

        public string Phone { get { return phone; } set { phone = value; } }
        public string Email { get { return email; } set { email = value; } }

        #endregion

        //---------------------------------Methods-------------------------------//
        /// <summary>
        /// ToString method returns a string with the contact information
        /// </summary>
        /// <returns></returns>
        /// 
        public override string ToString()
        {
            string strOut = String.Format("{0}   {1}", phone, email);
            return strOut;
            //return base.ToString();
        }

    }//Class    
}//Namespace
