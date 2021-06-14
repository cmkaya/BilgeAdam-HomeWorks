using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4.Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            // Greeting the user
            Console.WriteLine("***Welcome to the palindrome game***");
            string choice;

            do
            {
                // Get input from the user
                Console.Write("Enter something which is two character at least: ");
                string userInput = Console.ReadLine();
                // Checking whether input is more than 2 character
                if (userInput.Length > 2)
                {
                    // Declaring string variable that holds user input
                    string userInput2 = "";
                    for (int i = userInput.Length - 1; i >= 0; i--)
                        userInput2 += userInput[i];

                    // Controlling both variables whether they are same or not
                    if (userInput == userInput2)
                        Console.WriteLine("ıt is a palindrome.");
                    else
                        Console.WriteLine("It is not a palindrome.");
                }
                // if entry less than 3 characters
                else
                    Console.WriteLine("The entry must be at least two characters!!!");

                // Asking user to continue or not
                Console.Write("Do you want to continue? (Y/N) ");
                choice = Console.ReadLine().ToLower();

            } while (choice == "y");
            
            Console.ReadLine();
        }
    }
}
