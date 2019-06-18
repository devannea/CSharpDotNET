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
            rentables.Add(new Boat());
            rentables.Add(new House());
            rentables.Add(new Car());
        }
    }
    public interface IRentable
    {
        void GetDailyRate();
        void GetDescription();
    }
    public class Boat : IRentable // what is this error even about?
    {
        // internally store an hourly rate
        private decimal _hourlyRate = 12.5m; // why is this 12.5m? what is m? is 12.5 just a placeholder/ example
        public Decimal GetDailyRate()
        {
            return decimal.Round(_hourlyRate * 24, 2); // _hourlyRate * 24 = DailyRate, rounded to 2 decimal places
        }
        public String Description { get; set; }
        public Boat(string description)
        {
            Description = description;
        }
        public String GetDescription()
        {
            return Description;
        }
    }
    public class House : IRentable
    {
        // internally store a weekly rate
        private decimal _weeklyRate = 1200m;
        public Decimal GetDailyRate()
        {
            return decimal.Round(_weeklyRate / 168, 2); // _weeklyRate / 168 = DailyRate, rounded to 2 decimal places
        }
        public String Description { get; set; }
        public House(string description)
        {
            Description = description;
        }
        public String GetDescription()
        {
            return Description;
        }
    }
    public class Car : IRentable
    {
        public Decimal DailyRate { get; set; }
        public Car(decimal _dailyRate)
        {
            DailyRate = _dailyRate;
        }
        public Decimal GetDailyRate()
        {
            return DailyRate; // 
        }
        public String Description { get; set; }

        public Car(string description)
        {
            Description = description;
        }
        public String GetDescription()
        {
            return Description;
        }
    }
}
