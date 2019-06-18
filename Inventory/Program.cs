using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate Boats, Houses, and Cars
            // add them to a single list
            // loop through list and print the description, type, and daily rate for each element
            List<IRentable> rentables = new List<IRentable>();
            rentables.Add(new Boat($"what do i put here")); // like i know that strings go there but like ???
            rentables.Add(new House($"and here"));
            rentables.Add(new Car($"and here???"));

            foreach(IRentable rentable in rentables) // is this even right?
            {
                rentable.GetDescription();
                rentable.GetDailyRate();
            }
        }
    }
    public interface IRentable
    {
        void GetDescription();
        void GetDailyRate();
    }
    public class Boat : IRentable // what is this error even about?
    {
        public String Description { get; set; }
        public Boat(string description)
        {
            Description = description;
        }
        public String GetDescription()
        {
            return Description;
        }
        // internally store an hourly rate
        private decimal _hourlyRate = 12.5m; // why is this 12.5m? what is m? is 12.5 just a placeholder/ example
        public Decimal GetDailyRate()
        {
            return decimal.Round(_hourlyRate * 24, 2); // _hourlyRate * 24 = DailyRate, rounded to 2 decimal places
        }
    }
    public class House : IRentable
    {
        public String Description { get; set; }
        public House(string description)
        {
            Description = description;
        }
        public String GetDescription()
        {
            return Description;
        }
        // internally store a weekly rate
        private decimal _weeklyRate = 1200m;
        public Decimal GetDailyRate()
        {
            return decimal.Round(_weeklyRate / 7, 2); // _weeklyRate / 7 = DailyRate, rounded to 2 decimal places
        }
    }
    public class Car : IRentable
    {
        public String Description { get; set; }

        public Car(string description)
        {
            Description = description;
        }
        public String GetDescription()
        {
            return Description;
        }
        public Decimal DailyRate { get; set; }
        public Car(decimal _dailyRate)
        {
            DailyRate = _dailyRate;
        }
        public Decimal GetDailyRate()
        {
            return DailyRate; // yes? no?
        }
    }
}
