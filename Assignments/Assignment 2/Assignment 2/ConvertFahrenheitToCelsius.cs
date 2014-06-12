using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    /// <summary>
    /// This program converts the given temperature from Fahrenheit to Celsius and backwards.
    /// Also print the temperatures from 0-100 from Fahrenheit to Celsius and backwards.
    /// User can make his choise through the given menu
    /// </summary>

    class ConvertFahrenheitToCelsius
    {
        public void Start() 
        {
            int choise=-1; //initialization of choice

            ///<summary>
            ///In this class I used while loop because we do not know the number of iterations. 
            ///The user will decide when the program will stopped.
            ///Moreover I used switch loop to create the Menu because it easier to create 
            ///a decision making structure than if - else.
            ///</summary>

            while (choise != 0) // If the user press 0 the Main menu will be appeared 
            {
                WriteProgramInfo(); // print program info
                
                choise = Input.ReadIntegerConsole(); // Read user's info

                if (choise > 4) Console.WriteLine("\n \t Please choose one of the Menu numbers \n");// Inform the user to enter a number between 0-4

                else

                switch (choise) 
                {
                    case 1://Menu 1
                        {
                           
                            FahrenheitToCelsius(); //Calculate from F to C

                            break;
                        }

                    case 2: //Menu 2
                        {
                            CelsiusToFahrenheit();//Calculate from C to F

                            break;

                        }

                    case 3: //Menu 3
                        {
                            ShowDegreesInFahreneit(); //Show from 0-100 degrees from C to F

                            break;
                        }
                    case 4: //Menu 4
                        {
                            ShowDegreesInCelsius(); //Show from 0-100 degrees from F to C

                            break;

                        }
                   
                }//switch


            }//while

            



        }//start

        private void WriteProgramInfo() //Show Menu
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------"); 
            Console.WriteLine(" This Program calculates the Fahreneit temperature to Celcius and backwards");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Convert from Fahreneit to Celsius : 1");
            Console.WriteLine("Convert from Celsius to Fahreneit : 2");
            Console.WriteLine("Show degrees from 0 to 100 Fahreneit to corresponding Celsius : 3");
            Console.WriteLine("Show degrees from 0 to 100 Celsius to corresponding Fahreneit : 4");
            Console.WriteLine("Return to Main menu : 0 \n ");
            Console.Write("Enter a choice: ");
        }

        private void FahrenheitToCelsius() //Calculate Celsius
        {
            Console.Write("\n Enter a degree in Fahreneit: ");

            double valueToConvert = Input.ReadDoubleConsole(); //Read user's input

            double toCelcius = 5.0 / 9.0  * (valueToConvert - 32);

                Console.WriteLine(" \n The degree in Celsius is : {0:f2} ", toCelcius);// Print value rounded on the 2nd decimal

                
              
        }

        private void CelsiusToFahrenheit()//Calculate Fahrenheit
        {
            Console.Write("Enter a degree in Celsius: ");
           
            double valueToConvert = Input.ReadDoubleConsole();//Read users input

            double toFahrenheit = 9.0 / 5.0 * valueToConvert + 32; //Calculate Fahrenheit

            Console.WriteLine(" The degree in Fahrenheit is : {0:f2}", toFahrenheit); //Print the value rounded on the 2nd decimal

          
        }

        private void ShowDegreesInFahreneit()//Show from 0-100 degrees from C to F
        {
            int valueToConvert;
            Console.WriteLine(" \t Temperature Table ");
            Console.WriteLine(" Changing  Celsius to Fahrenheit");
            Console.WriteLine(" --------------------------------------------");
            for (valueToConvert = 0; valueToConvert <= 100; valueToConvert += 4) //print the corresponting temperature every 4 degrees
            {
                double toFahrenheit = 9.0 / 5.0 * valueToConvert + 32;
                Console.WriteLine(" \t {0:f2} C = {1:f2} F ", valueToConvert, toFahrenheit);// Print the values rounded on the 2nd decimal

            }

        }

        private void ShowDegreesInCelsius()//Show from 0-100 degrees from F to C
        {
            int valueToConvert;
            Console.WriteLine(" \t Temperature Table ");
            Console.WriteLine(" Changing Fahrenheit to Celsius ");
            Console.WriteLine(" --------------------------------------------");
            for (valueToConvert = 0; valueToConvert <= 100; valueToConvert += 4) //print the corresponting temperature every 4 degrees
            {
                double toCelcius = 5.0 / 9.0 * (valueToConvert - 32);
                Console.WriteLine(" \t {0:f2} F = {1:f2} C ", valueToConvert, toCelcius);// Print the values rounded on the 2nd decimal

            }

        }


    }//class
}// Namespace
