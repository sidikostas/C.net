using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.ContactFiles
{
    /// <summary>
    /// Phone class is used to save the phone data of the contact
    /// </summary>
    public class Phone
    {
        
        //------------------------------------------Fields declaration ------------------------------------------//

        string m_home;
        string m_work;
        

       //------------------------------------------Constructors ---------------------------------------------------//

       /// <summary>
       /// The chain-calling method is used to invoke the appropriate constructor. 
       /// There is a constructor with no arguments, 1 argument and 2 arguments
       /// </summary>

        public Phone():this (string.Empty)
        {
            Initialize();
        }

        public Phone(string homePhone):this (homePhone, string.Empty)
        {
            m_home = homePhone;
          
        }

        public Phone(string homePhone, string workPhone)
        {
            m_home = homePhone;
            m_work = workPhone;
          
        }

        //------------------------------------------Properties ---------------------------------------------------//

        /// <summary>
        /// Properties is used to access the private variables
        /// </summary>

        public string Home { get { return m_home; } set { m_home = value; } }
        public string Work { get { return m_work; } set { m_work = value; } }
      

        //------------------------------------------Methods ---------------------------------------------------//

        /// <summary>
        /// Initialize method set the variables to an not null value
        /// </summary>
        private void Initialize() 
        {
            m_work = string.Empty;
            m_home = string.Empty;
          
        }

        /// <summary>
        /// ToString method is used for the results display
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string strOut = String.Format("  {0}     {1}", m_home, m_work);
            return strOut;
        }
    }
}
