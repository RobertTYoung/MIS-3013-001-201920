using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P__Functions___Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Console.ReadKey();
        }
        static int Add(int first, int second)
        {
            return first + second;
        }
        static double Subtract(int first, int second)
        {
            return first - second;
        }

        static int Multiply(int first, int second)
        {
            return first * second;
        }
        static int Divide(int first, int second)
        {
            return first / second;
        }
        static string DeveloperInformation(string DeveloperName, string ClassName, string Date)
        {
            return ($"{DeveloperName} created this application for {ClassName} on {Date}.");
        }
        //developers name, a string for the class name, and a string for the date of writing ,, who wrote the application, for what class, and on what date
    }
}
