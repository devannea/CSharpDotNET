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
            rentables.Add(new Boat("sonic speed", 25)); // like i know that strings go there but like ???
            rentables.Add(new House("Two-story murder trap", 50));
            rentables.Add(new Car("used, but in good condition", 45));
            
            foreach(IRentable rentable in rentables) // is this even right?
            {
                string desc = rentable.GetDescription();
                decimal deci = rentable.GetDailyRate();
                Console.WriteLine($"Description: {desc}; Daily Rate: ${deci}");
            }
            Console.Read();
        }
    }
    public interface IRentable
    {
        string GetDescription();
        decimal GetDailyRate();
    }
    public class Boat : IRentable
    {
        private String _description { get; set; }
        private decimal _hourlyRate = 12.5m;
        public Boat(string description, decimal dailyRate)
        {
            _description = description;
            _hourlyRate = dailyRate;
        }
        public String GetDescription()
        {
            return _description;
        }
        // internally store an hourly rate
        public Decimal GetDailyRate()
        {
            return decimal.Round(_hourlyRate * 24, 2); // _hourlyRate * 24 = DailyRate, rounded to 2 decimal places
        }
    }
    public class House : IRentable
    {
        public String _description { get; set; }
        private decimal _weeklyRate = 1200m;
        public House(string description, decimal dailyRate)
        {
            _description = description;
            _weeklyRate = dailyRate;
        }
        public String GetDescription()
        {
            return _description;
        }
        // internally store a weekly rate
        public Decimal GetDailyRate()
        {
            return decimal.Round(_weeklyRate / 7, 2); // _weeklyRate / 7 = DailyRate, rounded to 2 decimal places
        }
    }
    public class Car : IRentable
    {
        public String _description { get; set; }

        public Car(string description, decimal dailyRate)
        {
            _description = description;
            _dailyRate = dailyRate;
        }
        public String GetDescription()
        {
            return _description;
        }
        public Decimal _dailyRate { get; set; }
        public Decimal GetDailyRate()
        {
            return _dailyRate; // yes? no?
        }
    }
}
