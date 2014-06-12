using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.ContactFiles
{
    /// <summary>
    /// The Contact class connected with a "has a" relation with the Phone, Email and Address classes. 
    /// In this class also are stored the first and last name of the contact
    /// </summary>
    /// 

    public class Contact
    {
        //------------------------------------------Fields declaration ------------------------------------------//
        
        //Except from the first and last name fields the class has instances of Address, Email and Phone.
        Address m_address;
        Phone m_phone;
        Email m_email;
        string m_firstName;
        string m_lastName;

        //------------------------------------------Constructors ------------------------------------------//

        public Contact() : this(string.Empty, string.Empty, null, null, null )
        {
            Initialize();
        }

        public Contact(string firstName, string lastName, Address adr, Phone tel, Email mail) 
        {
            m_lastName = lastName;
            m_firstName = firstName;
            m_address = adr;
            m_phone = tel;
            m_email = mail;
        }


        //------------------------------------------Properties ------------------------------------------//

        /// <summary>
        /// Properties is used to access the private variables
        /// </summary>
        /// 
        public Address AddressData { get { return m_address; } set { m_address = value; } }
        public Email EmailData { get { return m_email; } set { m_email = value; } }
        public Phone PhoneData { get { return m_phone; } set { m_phone = value; } }
        public string FirstName { get { return m_firstName; } set { m_firstName = value; } }
        public string LastName { get { return m_lastName; } set { m_lastName = value; } }
        public string FullName { get { return String.Format(m_firstName +" " +m_lastName); } }


        //------------------------------------------Methods ------------------------------------------//
        /// <summary>
        /// Initialize method set the variables to an not null value.
        /// Create an new objects for the instances
        /// </summary>
        private void Initialize() 
        {
            m_address = new Address();
            m_phone = new Phone();
            m_email = new Email();
            m_firstName = string.Empty;
            m_lastName = string.Empty;
        }

        /// <summary>
        /// The user must enter at least the first and the last name 
        /// </summary>
        /// <returns></returns>
        /// 
        public bool CheckData()
        {
            bool OK = true;

            if (String.IsNullOrWhiteSpace(m_firstName) || String.IsNullOrWhiteSpace(m_lastName))
            {
                OK = false;
              
            }

            return OK;

        }

        /// <summary>
        /// ToString method is used for the results display
        /// </summary>
        /// <returns></returns>
        /// 
        public override string ToString()
        {
            string strOut = String.Format("{0,-15} {1,0} {2,0} {3,0}", Truncate(FullName, 25),  Truncate (m_address.ToString(),35), Truncate(m_phone.ToString(),25) , Truncate(m_email.ToString(),25)) ;
            return strOut;
        }

        private string Truncate(string text, int length) 
        {
            if (String.IsNullOrEmpty(text) || length > text.Length)
                return text;
            else

                return text.Substring(0, length); 
        }

    }
}
