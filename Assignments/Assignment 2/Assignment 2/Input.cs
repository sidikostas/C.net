//Assignment 2
//Input.cs
//Created by Konstantinos Sidiropoulos

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Summary
//Reads the user's input and checks if a correct input is given

namespace Assignment_2
{
    class Input
    {
      
        public static int ReadIntegerConsole()//Check for Intenger
        {
            int input;
            if (int.TryParse(Console.ReadLine(), out input))
                return input;
            else
                Console.Write("Wrong input. Please try again: ");
            return ReadIntegerConsole();

        }

        public static double ReadDoubleConsole() //Check for Double
        {
            double input;
            if (double.TryParse(Console.ReadLine(), out input))
                return input;
            else
                Console.Write("Wrong input. Please try again: ");
            return ReadDoubleConsole();
        
        }
        
        public static decimal ReadDecimalConsole()// Check for Decimal
        {
            decimal input;
            if (decimal.TryParse(Console.ReadLine(), out input))
                return input;
            else
                Console.Write("Wrong input. Please try again: ");
            return ReadDecimalConsole();

        }



    }
}
