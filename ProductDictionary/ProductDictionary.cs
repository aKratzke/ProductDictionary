using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDictionary
{
    class Product
    {
        //Initialize all varaibles I want to use throughout the class

        string pName;
        double pCost;
        string pManufacturer;


        public Product()            //Plug in some values for our Constructor
        { }

        //Create Method to hold information with product cost and the product manufacturer
        public Product(string pN, double pC, string pM)
        {
            pName = pN;
            pCost = pC;
            pManufacturer = pM;
        }

        public void printItemName()
        {
            Console.WriteLine("\nProduct Name: {0}\n", pName);
            Console.WriteLine("Product Cost: {0}", pCost);
            Console.WriteLine("Product Manufacturer: {0}", pManufacturer);
        }
    }
}