using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    /// <summary>
    /// This class takes care of the whole process of
    /// (1) reading input from the console window,
    /// (2) performing the calculation and
    /// (3) printing the results to a consol window.
    /// </summary>


    class WholeNumbersForAdd
    {
        // Declaration of the variable 
        private int numOfInput;
        private int sum;

        public void Start() 
        {
            WriteProgramInfo();//Show info to the user

            ReadInput();// Let the user enter the data

            SumNumbers();//Calculate the summary

            ShowResults();// Print the results
        
        }

        private void ReadInput() 
        {
            //Determine how many numbers there are to be added
            Console.Write("Number of values to sum? ");
            numOfInput = int.Parse(Console.ReadLine()); //Convert string to int
            Console.WriteLine();

        }

        private void WriteProgramInfo()// Print the info to the user
        {
            Console.WriteLine("\n\n +++++++ Summation of the whole numbers +++++++ ");
            Console.WriteLine("                Using a for-statement\n");
            Console.WriteLine();

        }

        //void-method that sums up the numbers as they are read
        //and the results are stored in the instance variable sum.
        private void SumNumbers() 
        {
            //Local variables
            int index;// counter variable
            int num = 0;// stores the value that the user gives

            for (index = 0; index < numOfInput; index++)
            {
                Console.Write("Please give the value no {0} (whole number): ",(index+1));//Print value no 1 as first
                num = Input.ReadIntegerConsole();
                sum += num; //Add up the previous number with the next
            }

        }//SumNumbers

        private void ShowResults()  //Print the result
        {
           
            Console.WriteLine("---------------------------------------------\n");
            Console.WriteLine("The sum is \t " + sum);

        }

    }
}
