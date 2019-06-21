using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment_2
{
    class Product
    {
        public string Name;
        public decimal Price;
        public bool IsOnSale;
        public override string ToString()
        {
            return Name;
        }
    }

    class Store
    {
        private static List<Product> _products = new List<Product>()
        {
            new Product { Name = "Laptop", Price = 429.99M, IsOnSale = false },
            new Product { Name = "Backpack", Price = 69.99M, IsOnSale = true },
            new Product { Name = "Camera", Price = 199.99M, IsOnSale = false },
            new Product { Name = "Printer", Price = 119.99M, IsOnSale = true }
        };

        /// <summary>
        /// Returns the total value of all items in the store.
        /// </summary>
        public static decimal TotalValue()
        {
            foreach (var Product in _products)
            {
                decimal priceTotal = _products.Sum(x => x.Price);
                return priceTotal;
            }
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a list of products that are on sale.
        /// </summary>
        /// <returns></returns>
        public static List<Product> GetSaleProducts()
        {
            foreach (var Product in _products)
            {
                return _products.Where(x => x.IsOnSale = true).ToList();
            }
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a list of brief product descriptions.
        /// </summary>
        /// <returns></returns>
        public static List<string> GetBriefDescriptions()
        {
            foreach (var Product in _products)
            {
                // what?
            }
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Store.GetBriefDescriptions().ForEach(Console.WriteLine);
            // Laptop - $429.00
            // Backpack - $69.99
            // Camera - $199.99
            // Printer - $119.99

            Store.GetSaleProducts().ForEach(Console.WriteLine);
            // Backpack
            // Printer

            Console.WriteLine(Store.TotalValue());
            // 819.96

            Console.ReadLine();
        }
    }
}
