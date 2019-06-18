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
    public class Boat : IRentable // extend IRentable interface
    {
        // internally store an hourly rate
        private decimal _hourlyRate = 12.5m;
        public void GetDailyRate(decimal _hourlyRate)
        {
            return decimal.Round(_hourlyRate * 24, 2);
        }
        public void GetDescription(string description)
        {
            return Description;
        }
        public Boat(string description)
        {
            Description = description;
        }
        public String Description { get; set; }
    }
    public class House : IRentable // extend IRentable interface
    {
        // internally store a weekly rate
        private decimal _weeklyRate = ;
        public House()
        {
            // code goes here
        }
    }
    public class Car : IRentable // extend IRentable interface
    {
        public Car()
        {
            // code goes here
        }
    }
}
