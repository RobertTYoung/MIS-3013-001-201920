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

            Console.ReadKey();
        }
    }
}
