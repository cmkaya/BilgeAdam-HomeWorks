using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4.FindingName
{
    class Program
    {
        static void Main(string[] args)
        {
            // List of names
            string[] names = new[]
                       {
                "Robert Deniro",
                "Roberto Carlos",
                "Metin Oktay",
                "Georghe Hagi",
                "Radamel Falcao"
            };

            DisplayNameList(names);
            string userInput;
            // Total right to guess is 5
            int totalRight = 5;
            // Choose a random name in the list
            string randomName = BringRandomName(names);
            bool matchResult = false;

            for (int i = totalRight - 1; i > 0; i--)
            {
                // Get a name from the user
                userInput = GetAName();
                // Check whether the name written by the user is the same as the random name or not
                matchResult = CheckInputMatch(userInput, randomName, i);
                // If the user guess is right, exit from the loop
                if (matchResult)
                    break;
            }
        }

        static bool CheckInputMatch(string userEntry, string rndName, int right)
        {
            // The variable will return false or true at the end
            bool result = false;
            // Splitting name and surname
            string[] arrNames = rndName.Split();

            // If user entry is equal to name or surname, then display the result, and turn result into true
            if (arrNames[0].ToLower() == userEntry.ToLower() || arrNames[1].ToLower() == userEntry.ToLower())
            {
                Console.WriteLine("Congratulations! You found the name.");
                result = true;
            }
            else
                Console.WriteLine("Your guess was not found.\nPlease try again!!!\nRemaning right: {0}", right);

            return result;
        }

        static string BringRandomName(string[] names)
        {
            // Creating an instance from the Random Class
            Random random = new Random();
            // Assigning the random number to the variable
            int randomNumber = random.Next(0, names.Length);
            // The number will clarify the index of the name list
            string name = names[randomNumber];

            return name;
        }

        static void DisplayNameList(string[] nameList)
        {
            // Displaying every name and surname in the name list
            foreach (var name in nameList)
                Console.WriteLine(name);
        }

        static string GetAName()
        {
            // The input variable is defined to hold user entry
            string input;
            // The loop will iterate till user entry in the correct format
            do
            {
                Console.Write("Enter an name: ");
                input = Console.ReadLine().Trim();

            } while (!(input.All(char.IsLetter) && input.Length >= 2));

            return input;
        }
    }
}
