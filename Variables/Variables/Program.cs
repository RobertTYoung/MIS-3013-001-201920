//Robert Young
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create string named FirstName
            string firstName;

            //Assign a value to firstName (use your name)
            firstName = "Robert";

            //Create an int named favoriteNumber and assign your favorite number to it
            int favoriteNumber = 7;

            double crazyNumber = 7.6767 * favoriteNumber;

            string lastName = "Young";
            string fullName = firstName + " " + lastName;
            //string fullName = ($"{firstName}{lastName}");

            Console.Write(fullName + " has the favorite number of " + favoriteNumber + " \nwhich equates to the crazy number " + crazyNumber);

            //MAKE IT DYNAMIC
            Console.WriteLine(" \nPlease enter your last name: >>");
            firstName = Console.ReadLine();

            Console.WriteLine("Please enter your first name: >>");
            lastName = Console.ReadLine();

            Console.WriteLine("Please enter your favorite number: >>");
            string favoriteNumberAsString = Console.ReadLine();
            favoriteNumber = Convert.ToInt32(favoriteNumberAsString);
            //favoriteNumber = Convert.ToInt32(Console.ReadLine());

            fullName = firstName + " " + lastName;
            double crazyNumber = 7.6767 * favoriteNumber;
            Console.Write(fullName + " has the favorite number of " + favoriteNumber + " \nwhich equates to the crazy number " + crazyNumber);
            //Console.WriteLine(${fullName} has the favorite number of {favoriteNumber} \nwhich equates to a crazy number of {crazyNumber}");

            Console.ReadKey();
        }
    }
}
