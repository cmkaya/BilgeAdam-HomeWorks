using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            ASKAGAIN: // if number is negative, ask user again

            // Asking user for a positive number
            Console.Write("Enter a positive number: ");
            int userInput2 = Convert.ToInt32(Console.ReadLine());

            // Check the number
            if (userInput2 < 1)
                goto ASKAGAIN;

            // Declaring variable to hold total
            int sum = 1; 

            // Calculating factorial
            for (int i = 1; i <= userInput2; i++) 
                sum *= i;

            Console.WriteLine($"Factorial of {userInput2} is {sum}");

            Console.ReadLine();
        }
    }
}
