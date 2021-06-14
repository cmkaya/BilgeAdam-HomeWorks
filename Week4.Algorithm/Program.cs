using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4.Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user for numbers
            Console.Write("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            // Ask user for choosing an operator 
            Console.WriteLine("Please choose the mathematical operator");
            Console.Write("1- Addition \n2- Subtraction \n3- Multiplication \n4- Division\n");
            char userChoice = Convert.ToChar(Console.ReadLine());

            // Calculating
            switch (userChoice)
            {
                case '1':
                    Console.WriteLine($"The sum of {number1} and {number2} is {number1 + number2}");
                    break;
                case '2':
                    Console.WriteLine($"Subtracting {number1} to {number2} is {number1 - number2}");
                    break;
                case '3':
                    Console.WriteLine($"{number1} times {number2} is {number1 * number2}");
                    break;
                case '4':
                    Console.WriteLine($"The division of {number1} by {number2} is {(double)number1 / number2}");
                    break;
            }

            Console.ReadLine();
        }
    }
}
