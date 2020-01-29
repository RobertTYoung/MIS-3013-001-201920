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
            int Heads = 0;
            int Tail = 1;

            Console.WriteLine( "Enter Heads or Tails >>");
            string usersGuessAsString = Console.ReadLine();
            int usersGuess;

            if (usersGuessAsString == "Heads")
            {
                usersGuess = 0;
            }
            else
            {
                usersGuess = 1;
            }

            if (usersGuessAsString == "Tails")
            {
                usersGuess = 0;
            }
            else
            {
                usersGuess = 1;
            }

            Random rand = new Random();
            //use the nest method on 'rand' and pass in 0,2 to generate a random number taht is 0 or 1
            int randomNumber = rand.Next(0, 2); 

            //var cointoss = new cointossed();
            //Random.NextCointoss(cointossed);

            //Console.WriteLine("It was ");

            Console.WriteLine(MESSAGE);
            Console.ReadKey(); //Prevent teh application from closing until we press a key
        }
    }
}
