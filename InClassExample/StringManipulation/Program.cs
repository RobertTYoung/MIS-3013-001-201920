using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{//Robert Young
    class Program
    {
        static void Main(string[] args)
        {
            //                  0123
            string FirstName = "Robert";
            String LastName = "Young";

            Console.WriteLine($"You have {FirstName.Length.ToString("N0")} characters in your first name.");
            //Console.WriteLine("You have " + FirstName.Length.ToString("N0") + "characters in your first name.");
            Console.WriteLine($"You have {LastName.Length.ToString("N0")} characters in your last name.");
            char FirstInitial = FirstName[0];
            char LastInitial = LastName[0];

            /* Console.WriteLine(FirstName.ToUpper()[0]);
            Console.WriteLine(FirstName.ToUpper()[1]);
            Console.WriteLine(FirstName.ToUpper()[2]);
            Console.WriteLine(FirstName.ToUpper()[3]);
            Console.WriteLine(FirstName.ToUpper()[4]);
            Console.WriteLine(FirstName.ToUpper()[5]); */

            FirstName = FirstName.ToUpper();
            //output every charater of the firstname on a sepertate line in BIG LETTERS
            /* for (int i = 0; i < FirstName.Length; i++)
             {
                 char currentLetter = FirstName[i];
                 Console.WriteLine(currentLetter);
             } */

          
            foreach (var currentLetter in FirstName)
            {
                Console.WriteLine(currentLetter);
            }

            //Robert Young
            //gnuoY treboR

            string Name = FirstName + " " + LastName;
            var pieces = Name.Split(' ');
            string fName = Name.Substring(0, FirstName.Length);
            fName = "      " + fName + "     ";
            fName = fName.Trim();

            for (int i = Name.Length - 1; i >= 0; i--)
            {
                Console.Write(Name[i]);
            }

          
            Console.WriteLine("Output every other letter of the firstname");
            for (int i = 0; i < FirstName.Length; i = i + 2)
            {
                char currentLetter = FirstName[i];
                Console.WriteLine(currentLetter + " ");
            }

            Console.WriteLine($"Your initails are {FirstInitial}.{LastInitial}.");

            Console.ReadKey();

        }
    }
}
