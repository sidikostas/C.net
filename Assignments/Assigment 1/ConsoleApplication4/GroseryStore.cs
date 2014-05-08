/* This program computes total VAT and the total amount for a product,
 * given the net price, type of product and the corresponding tax rate.
 * The program then displays the results in form of a receipt.
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    //This class creates an object (instance) of the Product class which
    //encapsulates all data and operations related to a product
    public class GroseryStore
    {
        static void Main(string[] args)
        {
            Console.Title = "Apu's Supermarket";

            //Declare and create an instance of the Product class.
            Product product = new Product(); // object create with keyword new

            //Call the product-object's Start method to perfom all
           
            product.Start();

            Console.WriteLine("++++++++++  PLEASE COME AGAIN! ++++++++++ ");
            
            Console.ReadLine(); // Keeps the command prompt windows open
            
                    }
    }
}
