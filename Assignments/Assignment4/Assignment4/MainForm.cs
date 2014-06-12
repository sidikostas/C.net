//MainForm.cs
//Created by Kostas Sidiropoulos 15/03/2014

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment4
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// This program is a reminder which the user can save specific tasks.
        /// The MainForm contains all the components that the user can interact with the program.
        /// The user can select the date, the time and the description of the task that he wants to be reminded
        /// </summary>
        /// 
        
        
        //3.5.1 Declaration of the Task instance
        Task currTask;

        public MainForm()
        {
            //VS code
            InitializeComponent();
            
            //Prepare the program before the first use
            InitializeGUI();
      }
        //3.5.2 Initializaton of the program
        private void InitializeGUI()
        {
            //Create a new object of Task class
            currTask = new Task(DateTime.Now);
            
            //3.1.2 the form names is different and the components is clear at the startup
            lstReminder.Items.Clear();
            txtToDo.Clear();

            //Start the timer
            timer1.Start();

            //Customize the date format 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd              HH:mm";

            //All the data that is on the enum class is saved to a string and adds them to the ComboBox
            //Default selection Normal
            foreach (string priority in Enum.GetNames(typeof(PriorityWithEnum.PriorityType))) 
            cmbPriority.Items.Add(priority.Replace("_"," "));
            cmbPriority.SelectedIndex = 2;

            //Enable file menu
            openDatafileToolStripMenuItem.Enabled = true;
            saveDatafileToolStripMenuItem.Enabled = true;

            //3.1.5 Show info when the mouse is over components
            ShowToolTip();
        }

        /// <summary>
        /// 3.4.5 This method is used the ToolTip component in order to show hints and info when the mouse
        /// is over of specific components
        /// </summary>
        /// 
        private void ShowToolTip() 
        {
            //create a new tooltip object
            ToolTip showInfo = new ToolTip();
            showInfo.ShowAlways = true;
            
            showInfo.SetToolTip(dateTimePicker1, "Click to open calendar for date");
            showInfo.SetToolTip(lstReminder, "This is the list with the things that you have to do");
            showInfo.SetToolTip(lblClock, "Current time");
            showInfo.SetToolTip(btnAdd, "Adds the current task to the list");

        }

        /// <summary>
        ///Code that executes when the button add pressed. Adds to the list the task, the priority and its date  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///   
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //The user is obligated to enter a task
            if (string.IsNullOrEmpty(txtToDo.Text)) MessageBox.Show("Enter a task first");

            else
            {
                //Read users input
                ReadInput();

                currTask.Date = dateTimePicker1.Value;

                lstReminder.Items.Add(currTask.ToString());
            }
        }

        /// <summary>
        ///This method is used to read the input that the user entered from the components.
        ///This inputs are sent to the Task class for further processing 
        /// </summary>
        /// 
        private void ReadInput() 
        {
            //Select from the Enum the user's choice and save it to a variable
            PriorityWithEnum.PriorityType toEnumPriority = (PriorityWithEnum.PriorityType)cmbPriority.SelectedIndex;
 
            //Send the inputs to the Task class
            currTask.Date = dateTimePicker1.Value;
            currTask.Priority = toEnumPriority;
            currTask.Description = txtToDo.Text;

        }

        /// <summary>
        /// 3.1.7 When the timer starts it will show a clock on a label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        /// <summary>
        /// 3.1.4.1 This method creates a new reminder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeGUI();
        }

        /// <summary>
        /// 3.1.4.2-3 This method terminates the program after the user confirmation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Sure to exit the program?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }

            else return;
        }

        /// <summary>
        /// 3.1.6 When the about button pressed a new form with the info of the program will show.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create a new object of About class
            AboutBox about = new AboutBox();

            //Show the form
            about.Show();
        }

        /// <summary>
        /// When the user press the open button, the program first will be reset and 
        /// then all the data that are contained to a specific file will be added to the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void openDatafileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeGUI();
            OpenFileAndSaveToListBox();
        }

        /// <summary>
        /// This method reads from a file the data and add them in the listbox.
        /// To succeed that the Streamreader object is used.
        /// Moreover in order to inform the user when an exception occurs and to keep from
        /// unexpected closing of the application the try / catch block is used.
        /// </summary>
        /// 
        public void OpenFileAndSaveToListBox() 
        {
            //This is the file with the data
            string fileName = Application.StartupPath + "\\Tasks.txt";
            //object declaration with null as value
            StreamReader reader = null;

            //Clear the listbox first
            lstReminder.Items.Clear();

            //The code in the try block is the code in which something can go wrong
            try
            {
                string textIn;

                //create a new Streamreader object with the file as argument
                reader = new StreamReader(fileName);

                //the items will be added until the stream will finish
                while (!reader.EndOfStream)
                {
                    textIn = reader.ReadLine();
                    lstReminder.Items.Add(textIn);
                }
            }

            //When an exception occur show the following message
            catch
            {
                MessageBox.Show("Problem saving data to file!");
            }

            //This code will execute no matter of what will happen before
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        /// <summary>
        /// When this event handler is fired the all the data from the listbox
        /// that the user had entered are saved in a file on the hard disk.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void saveDatafileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveListBoxToFile();
        }

        /// <summary>
        /// This method saves the data from the listbox in to a file
        /// To succeed that the Streamwriter object is used.
        /// Moreover in order to inform the user when an exception occurs and to keep from
        /// unexpected closing of the application the try / catch block is used.
        /// </summary>
        /// 
        public void SaveListBoxToFile() 
        {
            string fileName = Application.StartupPath + "\\Tasks.txt";
            StreamWriter writer = null;

            //The code in the try block is the code in which something can go wrong
            try
            {
                //create a new Streamwriter object
                writer = new StreamWriter(fileName);

                //Writes all the items to the file
                for (int i = 0; i < lstReminder.Items.Count; i++)
                {
                    writer.WriteLine(lstReminder.Items[i].ToString());
                }
            }

            //When an exception occur show the following message + what is the description of the exception
            catch (Exception e)
            {
                MessageBox.Show("Problem saving data to file!" +e.Message);
            }


            //This code will execute no matter of what will happen before
            finally
            {
                if(writer!=null)
                    writer.Close();
            }
        }


    }//class
}//namespace
