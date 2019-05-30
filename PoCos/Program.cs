using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoCos
{
    public class Program
    {
        public static void Main()
        {
            DriversLicense MyDriversLicense = new DriversLicense();
            MyDriversLicense.GetFullName = "Devanne Aceves";
            MyDriversLicense.GetGender = "Female";
            MyDriversLicense.GetLicenseNumber = 4204204;
            Console.WriteLine();
            Console.WriteLine();
            Console.Read();
        }
    }

    class DriversLicense
    {
        public String GetFullName { get; set; } public String GetGender { get; set; } public int GetLicenseNumber { get; set; }

        public DriversLicense(string Name, string Gender, int LicenseNumber)
        {
            string[] FullName = Name.Split(' ');
            GetFullName = FullName[0] + " " + FullName[1];
            GetGender = Gender;
            GetLicenseNumber = LicenseNumber;
        }

        public String GetDriversLicenseDetails { get; set; }
        {
            
        }

    }
}
