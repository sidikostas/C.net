using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    /// <summary>
    /// The program will calculate the sum of float numbers until the user press 0. 
    /// While loop will be used for this purpose 
    /// </summary>
    /// 
    class FloatNumbersWhileAdd
    {
        //variable declaration
        private double sum;


        public void Start() 
        {
            
            WriteProgramInfo(); // Show info to the user

            ReadInputAndSumNumbers();//Let the user enter data and calculate the sum

            ShowResults();//Print the results

        }

        private void WriteProgramInfo() 
        {
            Console.WriteLine();
            Console.WriteLine("\n+++++++++++++++ Summation of real numbers +++++++++++++++");
            Console.WriteLine("                  Using While - statement               ");
            Console.WriteLine();
            Console.WriteLine("Write 0 to finish!");
            Console.WriteLine("Make sure to use the correct decimal character.");
            Console.WriteLine("--------------------------------------------------------\n-");
            Console.WriteLine();
        }

        //This method makes the summary of the inputs 

        private void ReadInputAndSumNumbers() 
        {
            bool done = false;
            
            //I used while loop because the user will decide how many iteration 
            //the program will have and when it will be terminated.

            while (!done) 
            {
                double number = ReadInput(); //I call ReadInput to read the number that the user will type and I saved it to the variable number

                sum += number; // Cumulate the inputs

                if (number == 0) // IF the user press 0 the loop will end
                    done = true;
                
            }
        
        }

        
        private double ReadInput() //Read the users input
        {
            Console.Write("Write an amount to sum or zero to finish :");
            double num = Input.ReadDoubleConsole();// Check if the input is a double value
            return num; //return the input
        }

        private void ShowResults() //Print results
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("This sum is :" + sum); 
        }

    }//class

}//namespace
