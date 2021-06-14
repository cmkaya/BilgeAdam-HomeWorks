using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question 1 - Algoritma
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Question 1 - Algoritma

            //// Ask user for numbers
            //Console.Write("Enter the first number: ");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the second number: ");
            //int number2 = Convert.ToInt32(Console.ReadLine());

            //// Ask user for choosing an operator 
            //Console.WriteLine("Please choose the mathematical operator");
            //Console.Write("1- Addition \n2- Subtraction \n3- Multiplication \n4- Division\n");
            //char userChoice = Convert.ToChar(Console.ReadLine());

            //// Calculating
            //switch (userChoice)
            //{
            //    case '1':
            //        Console.WriteLine($"The sum of {number1} and {number2} is {number1 + number2}");
            //        break;
            //    case '2':
            //        Console.WriteLine($"Subtracting {number1} to {number2} is {number1 - number2}");
            //        break;
            //    case '3':
            //        Console.WriteLine($"{number1} times {number2} is {number1 * number2}");
            //        break;
            //    case '4':
            //        Console.WriteLine($"The division of {number1} by {number2} is {(double)number1 / number2}");
            //        break;
            //}

            #endregion

            #region Question 2 - Palindrom

            //// Greeting the user
            //Console.WriteLine("***Welcome to the palindrome game***");
            //string choice;

            //do
            //{
            //    // Get input from the user
            //    Console.Write("Enter something which is two character at least: ");
            //    string userInput = Console.ReadLine();
            //    // Checking whether input is more than 2 character
            //    if (userInput.Length > 2)
            //    {
            //        // Declaring string variable that holds user input
            //        string userInput2 = "";
            //        for (int i = userInput.Length - 1; i >= 0; i--) 
            //            userInput2 += userInput[i];

            //        // Controlling both variables whether they are same or not
            //        if (userInput == userInput2)
            //            Console.WriteLine("ıt is a palindrome.");
            //        else
            //            Console.WriteLine("It is not a palindrome.");
            //    }
            //    // if entry less than 3 characters
            //    else
            //        Console.WriteLine("The entry must be at least two characters!!!");

            //    // Asking user to continue or not
            //    Console.Write("Do you want to continue? (Y/N) ");
            //    choice = Console.ReadLine().ToLower();

            //} while (choice == "y");

            #endregion

            #region Question 3 - Factorial

            /*ASKING: // if number is negative, ask user again

            // Asking user for a positive number
            Console.Write("Enter a positive number: ");
            int userInput2 = Convert.ToInt32(Console.ReadLine());

            // Check the number
            if (userInput2 < 1)
                goto ASKING;

            // Declaring variable to hold total
            int sum = 1; 

            // Calculating factorial
            for (int i = 1; i <= userInput2; i++) 
                sum *= i;

            Console.WriteLine($"Factorial of {userInput2} is {sum}");*/

            #endregion

            #region Question 4 - Staircase

            //for (int i = 1; i <= 8; i++)
            //{
            //    for (int j = 1; j <= 8; j++)
            //    {
            //        // if row and column numbers are even, display star operator; otherwise display gap
            //        if (i % 2 == 0)
            //        {
            //            if (j % 2 == 0)
            //                Console.Write("*");
            //            else
            //                Console.Write(" ");
            //        }
            //        else
            //        {
            //            if (j % 2 != 0)
            //                Console.Write("*");
            //            else
            //                Console.Write(" ");
            //        }
            //    }

            //    Console.WriteLine();
            //}

            #endregion

            #region Question 5 - Birthdate

            //// Ask user for birthdate
            //Console.Write("Enter your birthdate in (mm/dd/yyyy) format: ");
            //string userBirthDate = Console.ReadLine();

            //// Converting birthdate from string to DateTime type, and initialize a new instance from CultureInfo class
            //DateTime birthDate = DateTime.Parse(userBirthDate, new CultureInfo("en"));
            
            //// Make calculation as dynamic, declaring and initializing an new instance from DateTime class. The variable will hold current date and time 
            //DateTime currentDateTime = DateTime.Now;

            //// Subtracting difference and hold it in TimeSpan class
            //TimeSpan diff1 = currentDateTime.Subtract(birthDate);
            
            //Console.WriteLine(Math.Round((diff1.TotalDays / 365),2)); 
            
            #endregion

            Console.ReadLine();
        }
    }
}
