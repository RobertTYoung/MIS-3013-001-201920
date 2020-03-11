using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P__Functions_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which participation do you want to run? \n1. CaloriesToBurn \n2. FizzBuzz");
            string answer = Console.ReadLine();
            if (answer == "CaloriesToBurn")
            {
                return CaloriesToBurn();         
            }
            else if (answer == "FizzBuzz")
            {
                return FizzBuzz();
            }
        }
        static double CaloriesToBurn(double goal);
        {
            double CPM = 3.9;
            double CBurnt = 0;
            double Minute = 1;

            Console.WriteLine("How many calories would you like to burn?");
            double Goal = Convert.ToDouble(Console.ReadLine());

            while (CBurnt <= Goal)
            {
                CBurnt = Minute * CPM;
                Console.WriteLine($"After {Minute} minute(s) {CBurnt} calories burned.");
                Minute++;
            }

            Console.ReadKey();
        }
        static string FizzBuzz(string LuckyNumber);
        {
            Console.WriteLine("Please enter your lucky number!");
            string LuckyNumber = Console.ReadLine();
            bool validInput;
            int CorrectLuckyNumber; //= Convert.ToInt32(FavoriteNumber);

            validInput = Int32.TryParse(LuckyNumber, out CorrectLuckyNumber);

            if (validInput == false)
            {
                Console.WriteLine("I'm sorry, but I'm are unable to run the FizzBuzz process due to the input not being a valid number.");
            }

            else if (validInput == true) 
            {
                if (CorrectLuckyNumber % 5 == 0 && CorrectLuckyNumber % 3 == 0)
                {
                    Console.WriteLine(LuckyNumber + ' ' + "FizzBuzz");
                }

                else if (CorrectLuckyNumber % 3 == 0)
                {
                    Console.WriteLine(LuckyNumber + ' ' + "Fizz");
                }

                else if (CorrectLuckyNumber % 5 == 0)
                {
                    Console.WriteLine(LuckyNumber + ' ' + "Buzz");
                }

                else
                {
                    Console.WriteLine(LuckyNumber);
                }
            }

            Console.ReadKey();
        }
    }
}
