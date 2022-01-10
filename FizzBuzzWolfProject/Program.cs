using System;
using System.IO;

namespace FizzBuffWoofProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This is the FizzBuzzWoof program. You will be asked to enter 5 numbers and the program will determine if they need to be replaced by the keywords!");

            Console.WriteLine("How many numbers would you like to process?");
            string totalNumberValidation = Console.ReadLine();

            //Checks if the the user has inputted a number
            var TotalNumsIsNumeric = int.TryParse(totalNumberValidation, out int totalNumbers);
            if (TotalNumsIsNumeric == true)
            {
                List<int> numbersList = new List<int>();
                for (int i = 1; i < totalNumbers + 1; i++)
                {
                    Console.WriteLine($"Please enter number {i}");
                    string numberValidation = Console.ReadLine();

                    var isNumeric = int.TryParse(numberValidation, out int number);
                    if (isNumeric == true)
                    {
                        numbersList.Add(number);
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid value, exiting now...");
                        Environment.Exit(0);
                    }
                }

                Console.Write(Environment.NewLine);
                int[] numberArray = numbersList.ToArray();
                foreach (var number in numberArray)
                {
                    bool IsDivisbile = CalculateIfNumberIsDivisble(number);

                    if (IsDivisbile == false)
                    {
                        Console.WriteLine(number);
                    }
                    Console.WriteLine(Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("That is not a valid value, exiting now...");
                Environment.Exit(0);
            }
        }

        public static bool CalculateIfNumberIsDivisble(int number)
        {
            bool isDivisble = false;

            if (number % 3 == 0)
            {
                Console.Write("Fizz");
                isDivisble = true;
            }
            if (number % 5 == 0)
            {
                Console.Write("Buzz");
                isDivisble = true;
            }
            if (number % 7 == 0)
            {
                Console.Write("Woof");
                isDivisble = true;
            }

            return isDivisble;
        }
    }
}