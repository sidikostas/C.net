using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment6.ContactFiles;

namespace Assignment6
{
    /// <summary>
    /// Customer manager is keeping a record of all the entries and it is used from the MainForm 
    /// to retrieve data for the customers in order to display or change them.
    /// </summary>
    /// 
    class CustomerManager
    {
        //---------------------------------------------Fields declaration---------------------------------------//
        
        //All the customer data will save in a List of objects
        List<Customer> m_customers;
        
        private int id = 100;//The ID will start from number 100

        //------------------------------------------------Constructors--------------------------------------------//

        public CustomerManager()
        {
            m_customers = new List<Customer>();
        }


        //------------------------------------------------Properties---------------------------------------------//

        public int Count { get { return m_customers.Count; } }
        public int GetNewID { get { return id; } }// Temponary 

        //------------------------------------------------Methods-----------------------------------------------//

        /// <summary>
        /// This method add a contact to the List by creating first a customer object and 
        /// invokes the constructor of the Customer class with the 2 parameters
        /// </summary>
        /// <param name="contactIn"></param>
        /// <returns></returns>
        /// 
        public bool AddCustomer(Contact contactIn) 
        {
            bool check = false;

            
             Customer customerIn = new Customer(contactIn, id.ToString());

            if (customerIn != null) // check that the object is not null
            {                
                m_customers.Add(customerIn);  //Add to the list           
                id++; // raise the id by one in the next customer
                check = true;                
            }

            return check;
        }

        /// <summary>
        /// This method is used in order to change the data of an existent customer.
        /// First remove the old entry and after inserts a new one in the same position
        /// </summary>
        /// <param name="contactIn"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        /// 
        public bool ChangeCustomer(Contact contactIn, int index)
        {
            bool check = false;

            Customer customerIn = new Customer(contactIn, m_customers[index].ID);//Create a new customer with the same ID         

            if (contactIn != null)
            {
                m_customers.RemoveAt(index);// remove the old one
                m_customers.Insert(index, customerIn);// enter the new in the same position 
                check = true;
            }
            
            return check;
        }

        /// <summary>
        /// This method removes the selected customer from the List
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        /// 
        public bool DeleteCustomer(int index) 
        {
            bool check = false;

            if (index != -1)// The user must select one of the items in the listbox
            {
                m_customers.RemoveAt(index); // Remove the customer
                check = true;
            }

            return check;

        }

        /// <summary>
        /// The following method returns all the information of the selected customer in order to fill the contact form
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        /// 
        public Customer GetCustomer(int index) 
        {
            if (index >= 0 && index < m_customers.Count)
                return m_customers[index];

            else return null; 
        }

        /// <summary>
        /// This method returns an array of all the customers data in the list
        /// and it is used to update the listbox on the mainform
        /// </summary>
        /// <returns></returns>
        /// 
        public string[] GetCustomerInfo() 
        {
            string[] infoCustomer =new string [m_customers.Count] ;


            for (int i = 0; i < m_customers.Count; i++)
                infoCustomer[i] =m_customers[i].ToString();

                return infoCustomer;
        }

      
        /// <summary>
        /// This method is searching the List if there is an entry 
        /// with the First and the Last name which user has enter 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="LastName"></param>
        /// <returns></returns>
        /// 
        public string[] SearchCustomer(string firstName, string LastName)
        {
            
            List<string> foundCustomers = new List<string>();   //create a new list         
       
            for(int i=0; i <m_customers.Count; i++)
            {
                if(m_customers[i].ContactData.FirstName == firstName &&
                    m_customers[i].ContactData.LastName == LastName)
                    
                    foundCustomers.Add( m_customers[i].ToString());                
            }            
            
            return foundCustomers.ToArray();//return an array in order to add in a new listbox
        }     

    }
}
