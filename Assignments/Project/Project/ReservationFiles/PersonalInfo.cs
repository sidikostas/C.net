//Booking Application 
//PersonalInfo.cs
//Created: 2014-05-09 by Konstantinos Sidiropoulos 

///This class is used to manage the customer's  personal information
///
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ReservationFiles
{
    public class PersonalInfo
    {
        //---------------------------------- Variable Declaration ------------------------------///
        string firstName;
        string lastName;
        string fullName;
        string idNumber;

        //----------------------------------Constructors ---------------------------------------///
        /// <summary>
        /// Declaration of two Constructors although 
        /// only the default it is used until now by the application.
        /// </summary>
        /// 
        public PersonalInfo():this(string.Empty,string.Empty, string.Empty )
        { 
        }

        public PersonalInfo(string firstName, string lastName, string idNumber) 
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.idNumber = idNumber;
        }

        //----------------------------------Properties ------------------------------//

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string FullName { get { return fullName = firstName +" " +lastName; } }
        public string ID { get { return idNumber; } set { idNumber = value; } }


        //---------------------------------Methods --------------------------------//
        /// <summary>
        /// ToString method returns a string with the personal information
        /// </summary>
        /// <returns></returns>
        /// 
        public override string ToString()
        { 
            string strOut = FullName.PadLeft(15, ' ').Substring(0, 15);// Fixed length for the string values 15 character. If less add whitespace and if more trim them             
            return strOut;
            //return base.ToString();
        }
        
    }//Class    
}//Namespace
