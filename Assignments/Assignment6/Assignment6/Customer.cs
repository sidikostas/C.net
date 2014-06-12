using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment6.ContactFiles;

namespace Assignment6
{
    /// <summary>
    /// This form keeps all the information of the Contact class and 
    /// it is used from the Customer Manager Class to keep a record for all the entries
    /// </summary>
    class Customer
    {

        //--------------------------------------------------Fields declaration -------------------------------------------------//

        Contact m_contact;
        string m_id;// unique ID for each entry

        //--------------------------------------------------Constractors -------------------------------------------------------//

        public Customer() :this( null, string.Empty )
        {
           
        }

        public Customer(Contact contactIn, string id)
        {
            m_contact = contactIn;
            m_id = id;
        }


        

        //------------------------------------------------- Properties----------------------------------------------------------//

        public Contact ContactData { get { return m_contact; } set { m_contact = value; } }
        public string ID { get { return m_id; } set { m_id = value; } }


        //------------------------------------------------- Methods ------------------------------------------------------------//

        private void Initialize()
        {
            m_contact = new Contact();
            m_id = string.Empty;
        }

        
        public override string ToString()
        {
            string strOut = String.Format(" {0}      {1} ",  m_id, m_contact.ToString());

            return strOut;
            //return base.ToString();
        }

    
    }

}
