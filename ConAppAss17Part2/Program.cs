using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAss17Part2
{
    public  class Program
    {
      
            static void Main()
            {
                HerbalProduct herbalProduct = new HerbalProduct();

                
                herbalProduct.SetInformation(101, "Herbal Shampoo", 12.99, "Aloe Vera", DateTime.Parse("2023-01-01"), DateTime.Parse("2024-01-01"));

                Console.WriteLine("Herbal Product Details:");
                herbalProduct.ShowDetails();
                 Console.ReadKey();
            }
    }

}

