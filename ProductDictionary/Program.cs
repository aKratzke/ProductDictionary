using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            buildDictionary();
        }

        static void buildDictionary()
        {
            int x;

            string pName;
            double pCost;
            string pManufacturer;

            Dictionary<string, Product> productCatalog = new Dictionary<string, Product>();

            

            do
            {
                Console.WriteLine("Please enter the name of a product you wish to add to the dictionary.");
                pName = Console.ReadLine();

                Console.WriteLine("What is the cost of this product?");
                pCost = double.Parse(Console.ReadLine());

                Console.WriteLine("Who manufactures this product?");
                pManufacturer = Console.ReadLine();

                Product newProduct = new Product(pName, pCost, pManufacturer);
                
                productCatalog.Add(pName, newProduct);

                Console.WriteLine("Would you like to enter another product, or view the product catalog?");

                Console.WriteLine("Press 1 to enter another product or 2 to view the product catalog");
                x = Int32.Parse(Console.ReadLine());
            } while (x != 2);


            foreach (KeyValuePair<string, Product> item in productCatalog)
            {
                item.Value.printItemName();
            }
            
        }
    }
}
