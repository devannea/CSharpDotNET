using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoCos
{
    public class Program
    {
        public static void Main()
        {

            DriversLicense myDriversLicense = new DriversLicense();
            Book myBook = new Book();
            Airplane myPlane = new Airplane();
            Console.Read();
        }
    }

    class DriversLicense
    {
        public String FullName { get; set; }
        public String Gender { get; set; }
        public String LicenseNumber { get; set; }

        public DriversLicense()
        {
            FullName = "Jane Doe";
            Gender = "F";
            LicenseNumber = "1234567";
        }

        public DriversLicense(string fullName, string gender, string licenseNumber)
        {
            FullName = fullName;
            Gender = gender;
            LicenseNumber = licenseNumber;
        }

    }

    class Book
    {
        public String Title { get; set; }
        public List<string> Authors { get; set; }
        public int NumberOfPages { get; set; }
        public String SKU { get; set; }
        public String Publisher { get; set; }
        public double Price { get; set; }

        public Book()
        {
            Title = "The Best Book";
            Authors = new List<string>();
            NumberOfPages = 18254;
            SKU = "123987456";
            Publisher = "Company of Publishing the Greatest Books of All Time";
            Price = 165.99;
        }

        public Book(string title, List<string> authors, int pages, string sku, string publisher, double price)
        {
            Title = title;
            Authors = authors;
            NumberOfPages = pages;
            SKU = sku;
            Publisher = publisher;
            Price = price;
        }
    }

    class Airplane
    {
        public String Manufacturer { get; set; }
        public String Model { get; set; }
        public String Variant { get; set; }
        public int Capacity { get; set; }
        public int Engines { get; set; }

        public Airplane()
        {
            Manufacturer = "Airplane Manufacturer of the US of A";
            Model = "The Best Model";
            Variant = "A Variant";
            Capacity = 30;
            Engines = 6;
        }

        public Airplane(string manufacturer, string model, string variant, int capacity, int engines)
        {
            Manufacturer = manufacturer;
            Model = model;
            Variant = variant;
            Capacity = capacity;
            Engines = engines;
        }
    }
}
