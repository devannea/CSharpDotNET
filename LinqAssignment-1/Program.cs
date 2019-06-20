using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment_1
{
    using Extensions;
    class Program
    {
        static void Main(string[] args)
        {
            WhereMethod();
            SelectMethod();
            AggregateMethod();
            A a = new A();
            a.ExampleMethodA(1);
            a.ExampleMethodB();
            Console.Read();
        }
        // Enumerable.Where Method: Filters a sequence of values based on a predicate
        public static void WhereMethod()
        {
            List<string> reptiles = new List<string> { "turtle", "chameleon", "crocodile", "gecko", "iguana" };
            IEnumerable<string> query = reptiles.Where(reptile => reptile.Length > 7);
            foreach (string reptile in query)
            {
                Console.WriteLine(reptile);
                // chameleon
                // crocodile
            }
        }
        // Enumerable.Select Method: Projects each element of a sequence into a new form
        public static void SelectMethod()
        {
            IEnumerable<int> cubes = Enumerable.Range(1, 5).Select(x => x * x * x);
            foreach (int num in cubes)
            {
                Console.WriteLine(num);
                // 1
                // 8
                // 27
                // 64
                // 125
            }
        }
        // Enumerable.Aggregate Method: Applies an accumulator function over a sequence
        public static void AggregateMethod()
        {
            string tongueTwister = "how much wood could a woodchuck chuck if a woodchuck could chuck wood";
            string[] words = tongueTwister.Split(' ');
            string backwards = words.Aggregate((workingSentence, next) => next + " " + workingSentence);
            Console.WriteLine(backwards);
        }
        // Extension Method
        class A : IExtensionMethod
        {
            public void ExampleMethodB() { Console.WriteLine("A.ExampleMethodB()"); }
        }
    }
    // Extension Method stuff
    public interface IExtensionMethod
    {
        void ExampleMethodB();
    }
}
// More Extension Method stuff
namespace Extensions
{
    using LinqAssignment_1;
    public static class Extension
    {
        public static void ExampleMethodA(this IExtensionMethod myExtMethod, int i)
        {
            Console.WriteLine("Extension.ExampleMethodA(this IExtensionMethod myExtMethod, int i)");
        }
        public static void ExampleMethodA(this IExtensionMethod myExtMethod, string j)
        {
            Console.WriteLine("Extension.ExampleMethodA(this IExtensionMethod myExtMethod, string j)");
        }
        public static void ExampleMethodB(this IExtensionMethod myExtMethod)
        {
            Console.WriteLine("Extension.ExampleMethodB(this IExtensionMethod myExtMethod)");
        }
    }
}