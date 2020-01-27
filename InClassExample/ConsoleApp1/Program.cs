//Robert Young
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InPutFormattingConvertingAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name >>");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your favorite number >>");
            //string favNumberAsString = Console.ReadLine();
            //int favNumber = Convert.ToInt32(favNumberAsString);
            int favNumber = Convert.ToInt32(Console.ReadLine());

            int favNumberTimes10 = 10 * favNumber;

            string message = firstName + " you have a favorite number of " + favNumber.ToString("N3") + " and if you multiply that by 10 you get " + favNumberTimes10.ToString("C3");

            Console.WriteLine(message);
        
            Console.ReadKey();

        }
    }
}
