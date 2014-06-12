using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    /// <summary>
    /// In this class I calculate the night schedule of the employee by using a for loop.
    /// Due to that we know how many iterations we have it is more efficient to use the for loop.
    /// </summary>
    class NightsToWork
    {
        private int nights;

        public void Start()
        {
            Console.WriteLine(); //blank line
            Console.WriteLine(" Your schedule of the above option is as follows: ");

            CalculateNights(6,52); // Calculate night weekend shifts by sending the 1st working and the last

            Console.WriteLine();


        }//start

        //This method calculates the nights shifts and print them as a list
        //It takes to arguments the 1st working weekend and the last weekend of the year
        private void CalculateNights(int startNight, int endNight) 
        {
            int interval = 5; //In this variable stores the frequency of the working weekends 
            int change = 16;// This number is only for print reasons, it changes the line when change number is reached 

            for (nights = startNight; nights <= endNight; nights += interval) 
            {
                Console.Write(" \t Week " + nights);

                if (nights == change)// Create a list by changing line
                {
                    Console.WriteLine();// change line
                    change += 15; //After change line every 15 weekends
                }

            }
            
           
        }//CalculateWeekends
    
    }//class

}//namespace
