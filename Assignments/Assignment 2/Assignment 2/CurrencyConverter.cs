using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    /// <summary>
    /// This program will convert the given currency value to the corresponding ammount. 
    /// User will enter the type and the rate of the exchange.
    /// We will use do- will loop for this purpose
    /// </summary>
    class CurrencyConverter
    {
        //instance declaration
        private decimal sum, currencyValue, rate;
        private string currencyName;

        public void Start() 
        {
            WriteProgramInfo();//Show program info

            ReadInputAndConvertCurrency();//Read user input and calculate the exchange

            ShowResults();// Print the results

        }

        private void WriteProgramInfo()
        {
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++ The Currency Converter +++++++++++++++");
            Console.WriteLine("                  Using Do While - statement               ");
            Console.WriteLine();
            Console.WriteLine("Write 0 to finish input!");
            Console.WriteLine("Make sure to use the correct decimal character.");
            Console.WriteLine("---------------------------------------------------------\n");
            Console.WriteLine();
        }

        
        /// We will use do while loop because we want to test the condition  after the 1st iteration
        
        private void ReadInputAndConvertCurrency() 
        {
            bool done=false; //initialization of done

            do // Add up numbers until user enter 0
            {
                decimal number = ReadInput();//Read user's input
                
                if (number == 0)// When the user press 0 ask for currency name and rate
                {
                    Console.Write("Name of the foreign currency: ");
                    currencyName = Console.ReadLine();
                    Console.Write("Exchange rate : ");
                    rate = Input.ReadDecimalConsole();   // This method check if the user has typed  decimal value
                    
                    done = true;
                }

                sum  += number;  //Calculate the summary 
               

            } while (!done);

            currencyValue = sum / rate; //CAlculate the value of the new currency

        }


        private decimal ReadInput() // This method allows user to enter values
        {
            Console.Write("Write an amount or zero to exit : ");
            decimal number = Input.ReadDecimalConsole();
            return number;


        }

       
        private void ShowResults() 
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("This sum is : {0:C} ", sum );
            Console.WriteLine();
            //Print the values with the currency symbol
            Console.WriteLine("{0:C} is converted to {1:f2} {2} at the rate of {3:C} /{4}\n", sum, currencyValue, currencyName, rate, currencyName);
        
        }


    }
}
