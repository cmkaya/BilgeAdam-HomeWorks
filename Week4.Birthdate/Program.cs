using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4.Birthdate
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user for birthdate
            Console.Write("Enter your birthdate in (mm/dd/yyyy) format: ");
            string userBirthDate = Console.ReadLine();

            // Converting birthdate from string to DateTime type, and initialize a new instance from CultureInfo class
            DateTime birthDate = DateTime.Parse(userBirthDate, new CultureInfo("en"));

            // Make calculation as dynamic, declaring and initializing an new instance from DateTime class. The variable will hold current date and time 
            DateTime currentDateTime = DateTime.Now;

            // Subtracting difference and hold it in TimeSpan class
            TimeSpan diff1 = currentDateTime.Subtract(birthDate);

            Console.WriteLine(Math.Round((diff1.TotalDays / 365),2));

            Console.ReadLine();
        }
    }
}
