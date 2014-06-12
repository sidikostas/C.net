using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.ContactFiles
{
    /// <summary>    
    /// Email class is used to save the phone data of the contact    
    /// </summary>
    /// 

    public class Email
    {
        //------------------------------------------Fields declaration ------------------------------------------//

        private string m_personal;
        private string m_work;

        //------------------------------------------Constructors ------------------------------------------//

        /// <summary>
        /// The chain-calling method is used to invoke the appropriate constructor. 
        /// There is a constructor with no arguments, 1 arguments and 2 arguments
        /// </summary>
        public Email():this (string.Empty)
        {
            Initialize();
        }

        public Email(string workMail):this (workMail, string.Empty)
        {
            m_work = workMail;
        }

        public Email(string workMail, string personalMail) 
        {
            m_work = workMail;
            m_personal = personalMail;
        }

        //------------------------------------------Properties ------------------------------------------//
        
        /// <summary>
        /// Properties is used to access the private variables
        /// </summary>
        public string Personal { get { return m_personal; } set { m_personal = value; } }
        public string Work { get { return m_work; } set { m_work = value; } }

        //------------------------------------------Methods ------------------------------------------//

        /// <summary>
        /// Initialize method set the variables to an not null value
        /// </summary>
        private void Initialize()
        {
            m_personal = string.Empty;
            m_work = string.Empty;
        }

        /// <summary>
        /// ToString method is used for the results display
        /// </summary>
        /// <returns></returns>
        public override string ToString() 
        {
            string outStr = String.Format(" {0}     {1}  ", m_personal, m_work);
            return outStr;
        }
    }
}
