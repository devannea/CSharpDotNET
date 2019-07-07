using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLot
{
    class CarLot // CarLot class
    {
        //public string Name { get; set; } // Name Property
        //public List<Vehicle> Vehicles = new List<Vehicle> { get; set; } // List of Vehicles Property
        public string Name;
        public List<Vehicle> Vehicles = new List<Vehicle>();
        public void AddVehicle(Vehicle vehicle1) // Method to Add a Vehicle to the CarLot
        {
            Vehicles.Add(vehicle1);
        }
        public void PrintInventory() // Method to Print the Inventory of the CarLot
        {
            // include amount of vehicles
            // include details of each vehicle
            Console.WriteLine($"{Name} Inventory:");
            foreach (Vehicle Vehicle in Vehicles)
            {
                string description = Vehicle.VehicleDetails();
                Console.WriteLine(description);
            }
            Console.WriteLine();
        }
    }
    abstract class Vehicle // abstract Vehicle class **Note: You cannot make instances of abstract classes
    {
        public string LicenseNumber { get; set; } // License Number Property
        public string Make { get; set; } // Make Property
        public string Model { get; set; } // Model Property
        public string Price { get; set; } // Price Property 
        public abstract string VehicleDetails(); // Vehicle Details Method
        // return a description of the vehicle
        // including the license number, make, model, and price
    }
    class Car : Vehicle // Car sub-class that extends the Vehicle class
    {
        public string Type { get; set; } // Type Property
        public int NumberOfDoors { get; set; } // Number of Doors Property : Is int fine for this?
        public override string VehicleDetails()
        {
            return $"{base.LicenseNumber}; {base.Make}; {base.Model}; {base.Price}; {this.Type}; {this.NumberOfDoors}";
        }
    }
    class Truck : Vehicle // Truck sub-class that extends the Vehicle class
    {
        public String BedSize { get; set; } // Bed Size Property : Short, Standard, or Long, right?
        public override string VehicleDetails()
        {
            return $"{base.LicenseNumber}; {base.Make}; {base.Model}; {base.Price}; {this.BedSize}";
        }
    }
    class Program
    {
        static void Main(string[] args) // "driver" for program
        {
            // instantiate 2 different car lots, and add various vehicles to the car lots
            // print out the inventory for each of the car lots, showing the details for each vehicle
            // print the appropriate info for a car, or a truck accordingly
            CarLot CarLot1 = new CarLot();
            CarLot1.Name = "Toyota";

            Truck Truck1 = new Truck();
            Truck1.LicenseNumber = "ABC-DEFG";
            Truck1.Make = "Toyota";
            Truck1.Model = "Tundra";
            Truck1.Price = "$30,000";
            Truck1.BedSize = "Long";

            CarLot1.AddVehicle(Truck1);

            Car Car1 = new Car();
            Car1.LicenseNumber = "123-4567";
            Car1.Make = "Toyota";
            Car1.Model = "Camry";
            Car1.Price = "$23,000";
            Car1.Type = "SE";
            Car1.NumberOfDoors = 4;

            CarLot1.AddVehicle(Car1);

            Car Car2 = new Car();
            Car2.LicenseNumber = "EFG-4567";
            Car2.Make = "Toyota";
            Car2.Model = "4Runner";
            Car2.Price = "$31,000";
            Car2.Type = "Premium";
            Car2.NumberOfDoors = 4;

            CarLot1.AddVehicle(Car2);

            CarLot1.PrintInventory();

            CarLot CarLot2 = new CarLot();
            CarLot2.Name = "Ford";

            Truck Truck2 = new Truck();
            Truck2.LicenseNumber = "ABC-1234";
            Truck2.Make = "Ford";
            Truck2.Model = "F-150";
            Truck2.Price = "$28,000";
            Truck2.BedSize = "Standard";

            CarLot2.AddVehicle(Truck2);

            Truck Truck3 = new Truck();
            Truck3.LicenseNumber = "123-ABCD";
            Truck3.Make = "Ford";
            Truck3.Model = "Ranger";
            Truck3.Price = "$24,000";
            Truck3.BedSize = "Standard";

            CarLot2.AddVehicle(Truck3);

            Car Car3 = new Car();
            Car3.LicenseNumber = "EFG-4567";
            Car3.Make = "Ford";
            Car3.Model = "Fushion";
            Car3.Price = "$22,000";
            Car3.Type = "SE";
            Car3.NumberOfDoors = 4;

            CarLot2.AddVehicle(Car3);

            CarLot2.PrintInventory();
        }
    }
}
