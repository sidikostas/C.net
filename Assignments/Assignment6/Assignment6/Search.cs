using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class Search : Form
    {
        /// <summary>
        /// This form shows the results of the user search in a listbox
        /// </summary>
        /// 

        //-----------------------------------------------Field Declaration ------------------------------///

        CustomerManager mngrCustomer = new CustomerManager();

        //-----------------------------------Constructors -----------------------------------------------------///

        public Search()
        {
            InitializeComponent();
        }

        public Search(string [] inCustomers)
        {
            InitializeComponent();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(inCustomers);

        }
       
    }
}
