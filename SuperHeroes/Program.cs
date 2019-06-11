using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroes
{
    public class Point2D
    {
        public Point2D()
        {
            
        }
        public int X { get; set; }
        public int Y { get; set; }
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        // your code here

    }

    public class Point3D : Point2D
    {
        public Point3D()
        {
            // your code here
        }
        public Point3D(int x, int y, int z) : base(x, y)
        {
            // your code here
        }

        // your code here
    }

    public class Program
    {
        public static void Main(String[] args)
        {
            Point2D p1 = new Point2D();
            Point2D p2 = new Point2D(7, 5);
            Point2D p3 = new Point2D(-2, 4);
            Point2D p4 = new Point2D(7, 5);

            Console.WriteLine("p1 = {0}", p1);
            Console.WriteLine("p2 = {0}", p2);
            Console.WriteLine("p3 = {0}", p3);
            Console.WriteLine("p4 = {0}", p4);

            Console.WriteLine("p2 == p3? {0}", p2 == p3);
            Console.WriteLine("p2.Equals(p3)? {0}", p2.Equals(p3));
            Console.WriteLine("p2 == p4? {0}", p2 == p4);
            Console.WriteLine("p2.Equals(p4)? {0}", p2.Equals(p4));

            Console.WriteLine("========");

            Point3D p5 = new Point3D();
            Point3D p6 = new Point3D(7, 5, 12);
            Point3D p7 = new Point3D(-2, 4, -4);
            Point3D p8 = new Point3D(7, 5, 12);

            Console.WriteLine("p5 = {0}", p5);
            Console.WriteLine("p6 = {0}", p6);
            Console.WriteLine("p7 = {0}", p7);
            Console.WriteLine("p8 = {0}", p8);

            Console.WriteLine("p6 == p7? {0}", p6 == p7);
            Console.WriteLine("p6.Equals(p7)? {0}", p6.Equals(p7));
            Console.WriteLine("p6 == p8? {0}", p6 == p8);
            Console.WriteLine("p6.Equals(p8)? {0}", p6.Equals(p8));

            Console.WriteLine("========");
        }
    }





    //class Person
    //{
    //    public Person(string name, string nickName)
    //    {
    //        Name = name;
    //        NickName = nickName;
    //    }
    //    public String Name { get; set; }
    //    public String NickName { get; set; }
    //    public static void PrintGreeting(string name, string nickName)
    //    {
    //        Console.WriteLine("Hi, my name is " + name + ", you can call me " + nickName + ".");
    //    }
    //}
    //class SuperHero
    //{
    //    public SuperHero(string realName, string superPower)
    //    {
    //        RealName = realName;
    //        SuperPower = superPower;
    //    }
    //    public String RealName { get; set; }
    //    public String SuperPower { get; set; }
    //    public static void PrintGreeting(string realName, string superPower)
    //    {
    //        Console.WriteLine("I am " + realName + ". When I am Mr. Incredible, my super power is " + superPower + "!");
    //    }
    //}
    //class Villain
    //{
    //    public Villain(string nemesis)
    //    {
    //        Nemesis = nemesis;
    //    }
    //    public String Nemesis { get; set; }
    //    public static void PrintGreeting(string nemesis)
    //    {
    //        Console.WriteLine("I am " + nemesis + ", have you seen " + "?");
    //    }
    //}
}
