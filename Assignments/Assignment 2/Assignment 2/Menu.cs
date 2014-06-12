using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{

    //<Summary>
    //This class handles all about displaying a menu to the user
    //The user is given a number of choices. for each choice, an action is taken by the object of the class.
    //The menu repeats itself until the user wants to exit by choosing the option zero.

    class Menu
    {
        public void start()
        {
            Console.Title = "Assignment 2 "; // Change the title 

            int choice = -1;

            while (choice != 0) // while loop until the choose will be zero
            {

                WriteMenuText();// Show the menu 
                
                //Read user's input
                choice = Input.ReadIntegerConsole();//Check if the user enter whole numbers


                if (choice > 5) Console.WriteLine("\n \t Please choose one of the Menu numbers \n"); // Inform the user to enter a number between 0-5 
               
                                
                else 
                
                    switch (choice)
               
                    {
                 
                        case 1: //Menu item 1 
                        {
                            //create an object of WholeNumbers

                             WholeNumbersForAdd sumObj = new WholeNumbersForAdd();

                                sumObj.Start();
                            
                            break;
                        }

                        case 2://Menu item 2
                        {
                            //create an object of FloatNumbersWhileAdd
                            FloatNumbersWhileAdd sumRealNumb = new FloatNumbersWhileAdd();

                            sumRealNumb.Start();
                            
                            break;

                        }


                        case 3://Menu item 3
                        {
                            //create an object of CurrencyConverter
                            CurrencyConverter money = new CurrencyConverter();

                            money.Start();

                            break;

                        }


                        case 4://Menu item 4
                        {
                            //create an object of WorkingSchedule
                            WorkingSchedule weeks = new WorkingSchedule();

                            weeks.Start();

                            break;

                        }

                        case 5: //Menu item 5
                            {
                                //create an object of ConvertFahrenheitToCelsius
                                ConvertFahrenheitToCelsius degree = new ConvertFahrenheitToCelsius();

                                degree .Start();

                                break;
                            }

                        case 0://Menu item 0
                        {
                            Console.WriteLine("You will exit the program");
                           
                            break;
                        }

                        

                }//switch
              
            } //While

        }//Start

            private void WriteMenuText() //Print the info
        {
            int count;

            
                for (count = 0; count < 60; count++) Console.Write("-");//Create line
                Console.WriteLine("\n                        MAIN MENU                      ");
                for (count = 0; count < 60; count++) Console.Write("-");//Create line
                Console.WriteLine("\n       Whole Numbers with for                :1 ");
                Console.WriteLine("       Floating Point Numbers with While     :2 ");
                Console.WriteLine("       Currency Converter with Do While loop :3 ");
                Console.WriteLine("       Work schedule                         :4 ");
                Console.WriteLine("       Convert Temperature                   :5 ");
                Console.WriteLine("       Exit the program                      :0 ");
                for (count = 0; count < 60; count++) Console.Write("-");//Create line
                    
                Console.Write("     \nYour choise : ");
                

                
            }//WriteMenuText
                    
    }//Menu

}//namespace
