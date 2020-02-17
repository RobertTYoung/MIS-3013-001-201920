using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P__Conditional___Coin_Toss
{
    class Program
    {
        const string MESSAGE = ("Developed by Robert Young.");
        static void Main(string[] args)
        {
            int randomNumber ;
            int usersGuess ;
            Random rand = new Random();
            int numberOfGuessses = 0;

            /*while (usersGuess != randomNumber)
            {
                randomNumber = rand.Next(0, 2);
                Console.WriteLine(randomNumber);

                Console.WriteLine("Enter Heads or Tails >>");
                string usersGuessAsString = Console.ReadLine();
                
                const int HEADS_VALUE = 0;
                const int TAILS_VALUE = 1;

                if (usersGuessAsString == "Heads")
                {
                    usersGuess = HEADS_VALUE;
                }
                else
                {
                    usersGuess = TAILS_VALUE;
                }/

              
                //use the nest method on 'rand' and pass in 0,2 to generate a random number taht is 0 or 1
               

                if (usersGuess == randomNumber)
                {
                    Console.WriteLine("You are right!");
                }
                else
                {
                    Console.WriteLine("You are Wrong!");
                }

                if (usersGuessAsString == "Heads")
                {
                    Console.WriteLine("It landed on" + usersGuess);
                }
                else
                {
                    Console.WriteLine("It didn't land on " + usersGuess);
                }
            }*/

            do
            {
                {
                    randomNumber = rand.Next(0, 2);
                    Console.WriteLine(randomNumber);

                    Console.WriteLine("Enter Heads or Tails >>");
                    string usersGuessAsString = Console.ReadLine();

                    const int HEADS_VALUE = 0;
                    const int TAILS_VALUE = 1;

                    if (usersGuessAsString == "Heads")
                    {
                        usersGuess = HEADS_VALUE;
                    }
                    else
                    {
                        usersGuess = TAILS_VALUE;
                    }


                //use the nest method on 'rand' and pass in 0,2 to generate a random number taht is 0 or 1


                    if (usersGuess == randomNumber)
                    {
                        Console.WriteLine("You are right!");
                    }
                    else
                    {
                        Console.WriteLine("You are Wrong!");
                    }

                    if (usersGuessAsString == "Heads")
                    {
                        Console.WriteLine("It landed on" + usersGuess);
                    }
                    else
                    {
                        Console.WriteLine("It didn't land on " + usersGuess);
                    }
                }
                numberOfGuessses = numberOfGuessses + 1;
            } while (usersGuess != randomNumber);
            Console.WriteLine($"It took you { numberOfGuessses.ToString("N0")} to guess right");

            Console.WriteLine(MESSAGE);
            Console.ReadKey(); //Prevent teh application from closing until we press a key
        }
    }
}
