using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    /// <summary>
    /// This program consisted by 5 applications which user can choose through a Main Menu
    /// </summary>
   

    class MainProgram
    {
        static void Main(string[] args)
        {
            


            Menu menu = new Menu(); //Create an Menu object

            menu.start(); // Call start method from the menu object

            Console.ReadLine(); // Keep the console window open
            

        }
    }
}
