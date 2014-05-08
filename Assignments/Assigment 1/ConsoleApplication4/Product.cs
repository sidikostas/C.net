using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
     class Product 
    {   //viriables declaration
        private int count; 
        private string name;
        private double unitPrice;
        private bool foodItem;
        private const double foodVATRate = 0.12, otherVATRate = 0.25;
        private double totalVAT, totalNetValue;
        
         
        public void Start() 
        {
            //Read input
            ReadInput();
                
            //Calculate total tax
            CalculateValues();

            //Calculate totalNetPrice, total price
            PrintReceipt();

        }

        private void ReadInput()
        {   //1. Read name of the product
            ReadName();
            
            //2. Read price without VAT
            ReadNetUnitPrice();

            //3.Ask the user if the item is a food item
            ReadifFoodItem();
            
            //4. Read number of items (quantity)
            ReadCount();
            
        }

        private void ReadName() { // Allow user to type the product name

            Console.Write("Enter the product name:"); 
            name = Console.ReadLine(); // save the input into to variable
        }

        private void ReadNetUnitPrice() // Allow the user to type the price
        {
            
            Console.Write("Net unit price:");
            unitPrice = double.Parse(Console.ReadLine()); // save the input to variable by converting the string to double

        }

       
        private void ReadifFoodItem() 
        {
            Console.Write("Food item (y/n):");

            char response = char.Parse(Console.ReadLine());

            if ((response == 'y') || (response == 'Y'))
                foodItem = true;
            else 
                foodItem = false;
        }

        private void ReadCount()// Allow the user to type the quantity 
        {

            Console.Write("Count:");
            count = int.Parse(Console.ReadLine());// save the input to variable by converting the string to int
        }

         //Calculate totalNetValue TotalVat
        private void CalculateValues()
        {
            
            // If it is food item the tax will be 12% else 25%
            if (foodItem == true)
            {
                totalNetValue = unitPrice * count; // Calculate the total price
                totalVAT = totalNetValue * foodVATRate; // Calculate the Tax
                

            }

            else
            {
                totalNetValue = unitPrice * count; // Calculate the total price
                totalVAT = totalNetValue * otherVATRate; // Calculate the Tax
                
            }
 
        }

         // Print results
        private void PrintReceipt()
        {
            // Print all the information
            Console.WriteLine("++++++++++  Welcome to APU'S Supermarket  ++++++++++");
            Console.WriteLine("+++");
            Console.WriteLine("+++ Name of the product:                     " + name);
            Console.WriteLine("Quantity:                                    " + count);
            Console.WriteLine("Unit price:                                  " + unitPrice);
            Console.WriteLine("Food item                                    " + foodItem);
            Console.WriteLine("+++");
            
            Console.WriteLine("+++Total amount to pay:                      " + totalNetValue);
            if(foodItem == true) 
            Console.WriteLine("+++Inclunding VAT at 12%:                    " + totalVAT); //If it is food it will print 12%
            else
                Console.WriteLine("+++Inclunding VAT at 25%:                " + totalVAT);// else it will be 25%
            Console.WriteLine("+++");
            Console.WriteLine("+++This program developed by: \n+++  Konstantinos Sidiropoulos");

            
        }

    }
}
