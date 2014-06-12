//Address.cs
//Created by Kostas Sidiropoulos
//Assignment 6


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.ContactFiles
{
    /// <summary>
    /// The Address class is responsible to hold the address data of the new contact. 
    /// It is consisted by string fields and an enum.
    /// </summary>
    /// 

    public class Address
    {
    
        //---------------- Fields declaration --------------------//
        
        private string m_street;
        private string m_city;
        private string m_ErrMessage;
        private string m_zipcode;
        private Countries m_country;

        //---------------------  Constructors ---------------------//


        public Address()
            : this(string.Empty, string.Empty, "Malmö ")
        {
            Initialize();
        }

        public Address(string street, string zip, string city)
            : this(street, zip, city, Countries.Sverige)
        {
            m_street = street;
            m_zipcode = zip;
            m_city = city;
        }

        public Address(string street, string zip, string city, Countries country)
        {
            m_street = street;
            m_zipcode = zip;
            m_city = city;
            m_country = country;
        }


        //---------------------Properties --------------------------------------------------//

        /// <summary>
        /// Properties is used to access the private variables
        /// </summary>
        #region Properties

        public string Street { get{return m_street;} set { m_street = value; } }
        public string City { get { return m_city; } set { m_city = value; } }
        /**/public string ErrorMessage { get { return m_ErrMessage; } set { m_ErrMessage = value; } }
        public string  ZipCode { get { return m_zipcode; } set { m_zipcode = value; } }
        public Countries Country { get { return m_country; } set { m_country = value; } }

        #endregion

        //-------------------------- Methods -----------------------------------------------//


        /// <summary>
        /// Initialize method set the variables to an not null value
        /// </summary>
        /// 
        private void Initialize()
        {
            m_street = String.Empty;
            m_city = String.Empty;
            m_ErrMessage = String.Empty;
            m_zipcode = String.Empty;
        }

        /// <summary>
        /// The user must enter at least the city and the country for address data
        /// </summary>
        /// <returns></returns>
        /// 
        public bool CheckData()
        {
            bool OK=true;

            if ((String.IsNullOrWhiteSpace(m_city)) || ((int)m_country == -1))
            {
                OK = false;
                m_ErrMessage = "The fields city and country are obligated "; 
            }

            return OK;

        }

        /// <summary>
        /// This method is replacing the character _ with a whitespace and is used when the data are displayed
        /// </summary>
        /// <returns></returns>
        /// 
        public string GetCountryString() 
        {
            string strCountry = m_country.ToString();
            strCountry = strCountry.Replace("_", " ");
            return strCountry;
        }

        /// <summary>
        /// ToString method is used for the results display
        /// </summary>
        /// <returns></returns>
        /// 
        public override string ToString()
        {
            string strOut = String.Format(" {0} {1} {2} {3} ", m_street, m_zipcode, m_city, GetCountryString());

            return strOut;
        }

    }
}
