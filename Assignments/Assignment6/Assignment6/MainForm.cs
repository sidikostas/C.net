using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment6.ContactFiles;

namespace Assignment6
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// In the MainForm the user can enter, edit, delete or search among the results. 
        /// It has an object both of CustomerManager and ContactForm and throught them receives the output from the other classes.
        /// </summary>


        //---------------------------------------- Field Declaration ---------------------------------------------------//

        CustomerManager customerMngr = new CustomerManager();

        
        //-----------------------------------------Constructor ------------------------------------------------------//

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        //-----------------------------------------Methods ----------------------------------------------------------//

        /// <summary>
        /// Prepare the GUI for the 1st use
        /// </summary>
        /// 
        private void InitializeGUI() 
        {
            lstCustomerRegistry.Items.Clear();
            txtSearchFirstName.Text = string.Empty;
            txtSearchLastName.Text = string.Empty;
            btnAdd.Focus();
        }

        /// <summary>
        /// Update the listbox with the new output
        /// </summary>
        /// 
        private void UpdateCustomerList()
        {
            lstCustomerRegistry.Items.Clear();
            lstCustomerRegistry.Items.AddRange(customerMngr.GetCustomerInfo());
        }

        //--------------------------------------------Event Handlers-------------------------------------------//

        /// <summary>
        /// Open the Contact form and if the user press OK the data will be save in the Customer Manager.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ContactForm frmContact = new ContactForm();   //Create an Object of Contact Form                    

            if (frmContact.ShowDialog() == DialogResult.OK) //Show the Contact form and if OK
            {
                customerMngr.AddCustomer(frmContact.ContactData);// add to the List of Customer MAnager
                UpdateCustomerList();//Update the Listbox
            }           

        }

       
        /// <summary>
        /// Delete the selected user from the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (customerMngr.DeleteCustomer(lstCustomerRegistry.SelectedIndex))
                UpdateCustomerList();

            else MessageBox.Show(" Select one of the customers ");
        }

        /// <summary>
        /// This event handler shows the Contact form filled with the information of the selected customer
        /// and the user can edit the data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btnChange_Click(object sender, EventArgs e)
        {
            ContactForm frmContact = new ContactForm();

            int index = lstCustomerRegistry.SelectedIndex; 
            
            if (index != -1) //use must select a customer from the listbox
            {
                frmContact.ContactData = customerMngr.GetCustomer(index).ContactData;// fill the contact form with the information of the selected customer          
            }

            if (frmContact.ShowDialog() == DialogResult.OK)//if the user press OK
            {
                customerMngr.ChangeCustomer(frmContact.ContactData,index);// Change the information of the selected customer
                UpdateCustomerList();// update the listbox
            }      

        }

        /// <summary>
        /// The user can search throught the saved customers by the first and the last name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btnSearch_Click(object sender, EventArgs e)
        {           
            
            string[] foundCustomers = customerMngr.SearchCustomer(txtSearchFirstName.Text, txtSearchLastName.Text);// Save an array with the results

            if (foundCustomers.Count()!=0)//if there is a customer with the same First and Last name
            {
                Search frmSearch = new Search(foundCustomers);
                if (frmSearch.ShowDialog() == DialogResult.Cancel) //Show the Search form
                    frmSearch.Close();
            }

            else
                MessageBox.Show("No entries with these criteria");     
        }
    }
}
