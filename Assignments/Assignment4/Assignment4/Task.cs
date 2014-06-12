//Assignment 4
//Task.cs
//Developed by Kostantinos Sidiropoulos


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    /// <summary>
    /// The Task class is rensposible for the input processing 
    /// and the display of the results on the MainForm
    /// </summary>
    /// 
    class Task
    {
        //3.4.1 Instance variables declaration
        private DateTime date;
        private string description;
        private PriorityWithEnum.PriorityType priority;
        private DateTime taskln;

        /// <summary>
        ///3.4.1 Constructor with on parameter
        /// </summary>
        /// <param name="taskln"></param>
        /// 
        public Task(DateTime taskln)
        {
            //Set default values
            DefaultValues();

            this.taskln = taskln;
        }

        private void DefaultValues() 
        {
            date = DateTime.Now;
            description = "  ";
        }

        #region Properties
        //3.2.2, 3.4.2 Declaration of properties in order to access to the MainForm data
        public DateTime Date 
        {
            get { return date; }
            set { date = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public PriorityWithEnum.PriorityType Priority 
        {
            get { return priority; }
            set { priority = value; }
        }

        public DateTime TaskDate 
        {
            get { return TaskDate; }
            set { TaskDate = value; }
         }
        #endregion

        //3.4.4 This method is used to replace the char _  with a blank of the values in the Enum Priority 
        private string GetPriorityString()
        {

            string stringPriority = priority.ToString();
        
            return stringPriority.Replace("_"," ");
        }

        //3.4.2 This method is rensponsibly for the data display in the ListBox
        public string ToString() 
        {
            string forListBox;
            string newStringPriority = GetPriorityString();

            forListBox = date.ToString("dd MMMM yyyy \t\t\t HH:mm")+"\t\t"+newStringPriority+"\t\t"+description;
            

            return forListBox ;

        }

    }
}
