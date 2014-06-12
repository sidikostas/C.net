using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment6.ContactFiles;//Files in another directory

namespace Assignment6
{
    /// <summary>
    /// The Contact form class is responsible for the data input 
    /// and to inform the user for the results and the correct use of the program.
    /// </summary>
    /// 
    public partial class ContactForm : Form
    {
        //------------------------------------------Fields declaration ------------------------------------------//

        private Contact currContact = new Contact();
        private bool m_closeForm;

        //------------------------------------------Constructor ------------------------------------------//
        public ContactForm()
        {
            InitializeComponent();
            InitializeGUI();           
        }



        //------------------------------------------Property ------------------------------------------//
        public Contact ContactData 
        { 
            get { return currContact; } 
            set 
            { 
                if (value != null) 
                currContact = value; 
                UpdateGUI(); 
            }
        }


        //------------------------------------------Methods ------------------------------------------//

        /// <summary>
        /// Prepare the form for the first use
        /// </summary>
        /// 
        private void InitializeGUI()
        {
            FillCountryComboBox();
            m_closeForm = true;
        }
        
        /// <summary>
        /// Show the information of the selected entry
        /// </summary>
        public void UpdateGUI()
        {
            txtFirstName.Text = currContact.FirstName;
            txtLastName.Text = currContact.LastName;
            
            txtHomePhone.Text = currContact.PhoneData.Home;
            txtCellPhone.Text = currContact.PhoneData.Work;
            
            txtBusMail.Text = currContact.EmailData.Work;
            txtPrMail.Text = currContact.EmailData.Personal;

            txtCity.Text = currContact.AddressData.City;
            txtStreet.Text = currContact.AddressData.Street;
            txtZipCode.Text = currContact.AddressData.ZipCode;

            cmbCountries.SelectedIndex = (int)currContact.AddressData.Country;
        }

        /// <summary>
        /// Fills the combobox with the countries of the enum and replace the character _ with whitespace.
        /// </summary>
        /// 
        private void FillCountryComboBox() 
        {
            cmbCountries.Items.Clear();

            string[] countryStrings = Enum.GetNames(typeof(Countries));
                        
            for (int index = 0; index < countryStrings.Length - 1; index++)
                countryStrings[index] = countryStrings[index].Replace("_", " ");
            cmbCountries.Items.AddRange(countryStrings);

        }

        /// <summary>
        /// Reads the input for the contacts name
        /// </summary>
        /// 
        private void ReadName() 
        {
            currContact.FirstName = txtFirstName.Text;
            currContact.LastName = txtLastName.Text;
        }

        /// <summary>
        /// Reads the input for the Address
        /// </summary>
        /// 
        private void ReadAddress() 
        {
            currContact.AddressData.Country = (Countries)cmbCountries.SelectedIndex;
            currContact.AddressData.City = txtCity.Text;
            currContact.AddressData.Street = txtStreet.Text;
            currContact.AddressData.ZipCode = txtZipCode.Text;
        }

        /// <summary>
        /// Reads the user input for the phone
        /// </summary>
        /// 
        private void ReadPhone()
        {
            currContact.PhoneData.Home = txtHomePhone.Text;
            currContact.PhoneData.Work = txtCellPhone.Text; 
        }

        /// <summary>
        /// Reads the user input for the Emails
        /// </summary>
        /// 
        private void ReadEmails()
        {
            currContact.EmailData.Personal = txtPrMail.Text;
            currContact.EmailData.Work = txtBusMail.Text;
        }

        /// <summary>
        /// When the user press Ok this event handle is fired and reads and displays the user inputs.
        /// The necessary checks are invoked in order the user enters the required data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btnOK_Click(object sender, EventArgs e)
        {
            ReadName();
            ReadAddress();
            ReadPhone();
            ReadEmails();



            if (currContact.AddressData.CheckData() && currContact.CheckData())                         
                m_closeForm = true;                
            
            else
            {
                m_closeForm = false;
                MessageBox.Show("The fields with * are obligatory");
            }
            
        }

        /// <summary>
        /// If the user press cancel, it will be an verification
        /// if the program will close without saving the data or else to return to the contact form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Discard all data", "Think Twice", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes) 
            {
               currContact = new Contact(); 
               m_closeForm = true;
               this.Close();
                
            }

            else m_closeForm = false;
        }
       
        /// <summary>
        /// Form Closing event to check if th user will exit or not the Contact form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContactForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_closeForm)
                e.Cancel = false; // Close contact form
            else e.Cancel = true;
        }
    }
}
