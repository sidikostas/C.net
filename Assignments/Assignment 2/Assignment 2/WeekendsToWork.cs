//Assignment 2
//WeekendsToWork.cs
//Created by Konstantinos Sidiropoulos

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    /// <summary>
    ///This class  calculates the weekend shift schedule of the employee by using a for loop.
    ///Due to that we know how many iterations we have it is more efficient to use the for loop.
    /// </summary>
    /// 
    class WeekendsToWork
    {
        //instance declaration
        private int weekends;

        public void Start()
        {
            Console.WriteLine("\n Your schedule of the above option is as follows: \n");

            CalculateWeekends(1, 52);// Calculate working weekend by sending the 1st working weekend and the last
                       
        }

        //This method calculates the working weekends and print them as a list
        //It takes to arguments the 1st working weekend and the last weekend of the year
        private void CalculateWeekends(int startWeek, int endWeek) 
        {
           
            int interval = 3;//In the interval variable stores the frequency of the working weekends, 
            int change = 7;// The change variable used for change the printing line when change number is reached

            for (weekends = startWeek; weekends <= endWeek; weekends += interval)
            {
                Console.Write(" \t Week " + weekends);
                
                if (weekends == change)//Create list
                {
                    Console.WriteLine();//Change line
                    change += 9; //After change line every 9 weekends
                }
            }

            

        }//CalculateWeekends

      
    }//class

}//namespace
