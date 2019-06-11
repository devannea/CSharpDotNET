using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroes
{
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



    public class Program
    {
        public static void Main(String[] args)
        {

        }
    }

    class Person
    {
        public Person(string name, string nickName)
        {
            Name = name;
            NickName = nickName;
        }
        public String Name { get; set; }
        public String NickName { get; set; }
        public static void PrintGreeting(string name, string nickName)
        {
            Console.WriteLine("Hi, my name is " + name + ", you can call me " + nickName + ".");
        }
    }
    class SuperHero
    {
        public SuperHero(string realName, string superPower)
        {
            RealName = realName;
            SuperPower = superPower;
        }
        public String RealName { get; set; }
        public String SuperPower { get; set; }
        public static void PrintGreeting(string realName, string superPower)
        {
            Console.WriteLine("I am " + realName + ". When I am Mr. Incredible, my super power is " + superPower + "!");
        }
    }
    class Villain
    {
        public Villain(string nemesis)
        {
            Nemesis = nemesis;
        }
        public String Nemesis { get; set; }
        public static void PrintGreeting(string nemesis)
        {
            Console.WriteLine("I am " + nemesis + ", have you seen " + "?");
        }
    }
}
