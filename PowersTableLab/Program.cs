using System;

namespace PowersTableLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Learn your Squares and Cubes");
            bool letsGo = true;
            
                // setting a bool for later//
            while (letsGo)
            {
                int userInput = askQuestion($"Enter an integer: ");
                DisplayTable(userInput);
                
                letsGo =GetContinue();
            }

        }

            // prompt user to enter an integer
            // The application displays a table of squares and cubes from 1 to the value entered.

        public static int askQuestion(string message)
        {
            Console.Write(message);
            //ask for user input// 
            // converting to int with Parse and returning//

            int userInput = int.Parse(Console.ReadLine());
            return userInput;

        }
        public static void DisplayTable(int number)
        {

            for (int i = 1; i <= number; i++)
            {

                {
                    Console.WriteLine($"Number: {i}\t" + $"Squared:{i * i} \t " + $"Cubed:{i * i * i}");

                }

            }

        }
        public static bool GetContinue()
        {
            bool letsGo = true;
            bool noMore = false;
            // input from iser on whether they want to conintue (y/n)
            Console.WriteLine($"Would you like to continue? y/n");
            // processing - if y, retun true, if n, return false,
            // if neither, call GetContinue() 
            string userContinue = Console.ReadLine();

            switch (userContinue.ToLower())
            {
                case "y":
                    return letsGo;
                case "n":
                    return false;
                default:
                    return GetContinue();
            }



        }
    }
}
