//Assignment 2
//WorkingSchedule.cs
//Created by Konstantinos Sidiropoulos

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    /// <summary>
    /// This program will print the working weekend schedule and the nigh shifts of an employee
    /// The user can make a choice from a Menu.
    /// </summary>
    /// 
    class WorkingSchedule
    {  

        public void Start() 
        {
            int userChoise=-1;

          
            
            while (userChoise != 0)  // If the user press 0 the Main menu will appear
            {
                MenuDisplay(); // Show information
                

                userChoise = Input.ReadIntegerConsole(); // Read user's input

                if (userChoise > 2) Console.WriteLine("\n \t Please choose one of the Menu numbers \n"); // Inform the user to enter a number between 0-2

                else 
            

            switch (userChoise) 
            {
                case 1: // Menu 1
                    {
                        
                        //Create new object
                        WeekendsToWork firstMenu = new WeekendsToWork();

                        firstMenu.Start();

                        break;
                    }
             
                case 2: // Menu 2
                    {
                        //Create new object
                        NightsToWork secondMenu = new NightsToWork();

                        secondMenu.Start();

                        break;
                    }
                                   
            }//switch
          
            
            }//while
            

        }//Start

        private void MenuDisplay() // Prints the menu to the user with all the necessary information
        {
            
            Console.WriteLine();
            Console.WriteLine("                  Your Schedule Program                 ");
            Console.WriteLine(" Select from the menu which type of the schedule you would like to see. ");
            Console.WriteLine("----------------------------------------------------------------------\n");
            Console.WriteLine(" 1 Show a list of the weekends to work");
            Console.WriteLine(" 2 Show a list of the nights to work ");
            Console.WriteLine(" 0 Return to the main menu\n");
            Console.Write(" Your choice : ");
            
        }//MenuDisplay

        
    }//class

}//Namespace
