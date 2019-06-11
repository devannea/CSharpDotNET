using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroes
{
    public class Person
    {
        public Person (string name, string nickname) // Constructor that accepts name and nickname
        {
            Name = name;
            NickName = nickname;
        }
        public String Name { get; set; } // Name Property
        public String NickName { get; set; } // NickName Property
        public override string ToString() // ToString() Override
        {
            return Name; // returns that person's name
        }
        public void PrintGreeting() // Print Greeting Method
        {
            Console.WriteLine($"Hi, my name is {Name}, you can call me {NickName}.");
            // Hi, my name is _____, you can call me _____.
        }
    }
    public class SuperHero : Person
    {
        public SuperHero(string name, string realname, string superpower) : base(name, nickname:null)
        // Constructor that takes Name, HeroName, and SuperPower, and passes null to NickName
        {
            Name = name; // This would be the superhero name, i.e. Spider-Man
            RealName = realname; // This would be the real name, i.e. Peter Parker
            SuperPower = superpower;
        }
        public String RealName { get; set; } // RealName Property
        public String SuperPower { get; set; } // SuperPower Property
        public new void PrintGreeting() // Override the Print Greeting Method
        {
            Console.WriteLine($"I am {RealName}. When I am {Name}, my super power is {SuperPower}!");
        }
    }
    public class Villain : Person
    {
        public Villain(string name, string nemesis) : base(name, nickname:null)
        // Constructor that takes Name and Nemesis of the Villain, and passes null to NickName
        {
            Name = name; // This is the villain's name
            Nemesis = nemesis; // This is the superhero/ nemesis
        }
        public String Nemesis { get; set; } // Nemesis Name Property
        public new void PrintGreeting() // Override the Print Greeting Method
        {
            Console.WriteLine($"I am {Name}! Have you seen {Nemesis}?");
        }
    }
    public class Program
    {
        // Create a few humans, superheroes, and villains
        // Add them to a list
        // Loop through them and print each one's name followed by the greeting
        public static void Main(String[] args)
        {
            List<Person> CharacterList = new List<Person>(); // List of characters
            CharacterList.Add();
            //Not sure how to do this part
        }
    }








    //public class Point2D
    //{
    //    public Point2D() // Constructor that creates the point (0, 0)
    //    {
    //        X = 0;
    //        Y = 0;
    //    }
    //    public Point2D(int x, int y) // Constructor that creates a point by taking x and y (x, y) => (X, Y)
    //    {
    //        X = x;
    //        Y = y;
    //    }
    //    public int X { get; set; } // X Property
    //    public int Y { get; set; } // Y Property
    //    public override string ToString() // ToString() Override
    //    {
    //        X = 7;
    //        Y = 5;
    //        // return "Origin: (" + X + ", " + Y + ")"; // returns Origin: (7, 5)
    //        return $"({X}, {Y})";
    //    }
    //    public override bool Equals (Object o) // Equals (Object o) Override
    //    {
    //        if(o.GetType().Equals(this.GetType()))
    //        // if(o is Point2D)
    //        {
    //            Point2D point = (Point2D)o;
    //            return X == point.X && Y == point.Y;  // Compare properties
    //        }
    //        else
    //        {
    //            return false;
    //        }
    //    }
    //}

    //public class Point3D : Point2D
    //{
    //    public Point3D()
    //    {
    //        X = 0;
    //        Y = 0;
    //        Z = 0;
    //    }
    //    public Point3D(int x, int y, int z) : base(x, y)
    //    {
    //        X = x;
    //        Y = y;
    //        Z = z;
    //    }
    //    public int Z { get; set; } // Z Property
    //    public override string ToString() // ToString() Override
    //    {
    //        X = 7;
    //        Y = 5;
    //        Z = 12;
    //        //return "Origin: (" + X + ", " + Y + ", " + Z + ")"; // returns Origin: (7, 5, 12)
    //        return $"({X}, {Y}, {Z})";
    //    }
    //    public override bool Equals(Object o) // Equals (Object o) Override
    //    {
    //        if (o.GetType().Equals(GetType()))
    //        // if(o is Point2D)
    //        {
    //            Point3D point = (Point3D)o;
    //            return X == point.X && Y == point.Y && Z == point.Z; // Compare properties
    //        }
    //        else
    //        {
    //            return false;
    //        }
    //    }
    //}

    //public class Program
    //{
    //    public static void Main(String[] args)
    //    {
    //        Point2D p1 = new Point2D();
    //        Point2D p2 = new Point2D(7, 5);
    //        Point2D p3 = new Point2D(-2, 4);
    //        Point2D p4 = new Point2D(7, 5);

    //        Console.WriteLine("p1 = {0}", p1);
    //        Console.WriteLine("p2 = {0}", p2);
    //        Console.WriteLine("p3 = {0}", p3);
    //        Console.WriteLine("p4 = {0}", p4);

    //        Console.WriteLine("p2 == p3? {0}", p2 == p3);
    //        Console.WriteLine("p2.Equals(p3)? {0}", p2.Equals(p3));
    //        Console.WriteLine("p2 == p4? {0}", p2 == p4);
    //        Console.WriteLine("p2.Equals(p4)? {0}", p2.Equals(p4));

    //        Console.WriteLine("========");

    //        Point3D p5 = new Point3D();
    //        Point3D p6 = new Point3D(7, 5, 12);
    //        Point3D p7 = new Point3D(-2, 4, -4);
    //        Point3D p8 = new Point3D(7, 5, 12);

    //        Console.WriteLine("p5 = {0}", p5);
    //        Console.WriteLine("p6 = {0}", p6);
    //        Console.WriteLine("p7 = {0}", p7);
    //        Console.WriteLine("p8 = {0}", p8);

    //        Console.WriteLine("p6 == p7? {0}", p6 == p7);
    //        Console.WriteLine("p6.Equals(p7)? {0}", p6.Equals(p7));
    //        Console.WriteLine("p6 == p8? {0}", p6 == p8);
    //        Console.WriteLine("p6.Equals(p8)? {0}", p6.Equals(p8));

    //        Console.WriteLine("========");
    //    }
    //}
}
