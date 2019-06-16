using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLot
{
    class CarLot // CarLot class
    {
        public String Name { get; set; } // Name Property
        public List<string> Vehicles { get; set; } // List of Vehicles Property
        public static void AddVehicle() // Method to Add a Vehicle to the CarLot
        {
            // code goes here
        }
        public virtual string PrintInventory() // Method to Print the Inventory of the CarLot
        {
            // include amount of vehicles
            // include details of each vehicle
            return $"{Vehicles}"; // sort this out later
        }
    }
    abstract class Vehicle // abstract Vehicle class **Note: You cannot make instances of abstract classes
    {
        public String LicenseNumber { get; set; } // License Number Property
        public String Make { get; set; } // Make Property
        public String Model { get; set; } // Model Property
        public Double Price { get; set; } // Price Property : Should I use int, double, or decimal?
        public static string VehicleDetails() // Vehicle Details Method
        {
            // return a description of the vehicle
            // including the license number, make, model, and price
            return $" ";
        }
    }
    class Car : Vehicle // Car sub-class that extends the Vehicle class
    {
        public String Type { get; set; } // Type Property
        public int NumberOfDoors { get; set; } // Number of Doors Property : Is int fine for this?
    }
    class Truck : Vehicle // Truck sub-class that extends the Vehicle class
    {
        public String BedSize { get; set; } // Bed Size Property : Short, Standard, or Long, right?
    }
    class Program
    {
        static void Main(string[] args) // "driver" for program
        {
            // instantiate 2 different car lots, and add various vehicles to the car lots
            // print out the inventory for each of the car lots, showing the details for each vehicle
            // print the appropriate info for a car, or a truck accordingly
        }
    }
}
