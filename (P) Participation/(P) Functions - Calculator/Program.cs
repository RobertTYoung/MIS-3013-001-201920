using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P__Functions___Calculator
{
    class Program
    {//Robert Young

       
        static void Main(string[] args)
        {     
            string DeveloperName = " ";
            string ClassName = " ";
            string Date = " ";

            string InfoMessage = DeveloperInformation(DeveloperName, ClassName, Date);
            Console.WriteLine(InfoMessage);

            Console.WriteLine("What kind of calculation would you like to do? Add, Substract, Multiply, or Divide >>");
            string FunctionType = Console.ReadLine();

            Console.WriteLine("What is your first number?");
            double firstNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your second number?");
            double secondNum = Convert.ToDouble(Console.ReadLine());
            //double Answer = FunctionType(firstNum, secondNum);
            double result = 0;

            if (FunctionType == "Add")
            {
                result = Add(firstNum, secondNum);
                Console.WriteLine(result);
            }
            else if (FunctionType == "Subtract")
            {
                result = Subtract(firstNum, secondNum);
                Console.WriteLine(result);
            }
            else if (FunctionType == "Multiply")
            {
                result = Multiply(firstNum, secondNum);
                Console.WriteLine(result);
            }
            else if (FunctionType == "Divide")
            {
                result = Divide(firstNum, secondNum);
                Console.WriteLine(result);
            }

            Console.ReadKey();
        }
        static double Add(double first, double second)
        {
            return first + second;
        }
        static double Subtract(double first, double second)
        {
            return first - second;
        }

        static double Multiply(double first, double second)
        {
            return first * second;
        }
        static double Divide(double first, double second)
        {
            return first / second;
        }
        static string DeveloperInformation(string DeveloperName, string ClassName, string Date)
        {
            Console.WriteLine("What is your full name? >>");
            DeveloperName = Console.ReadLine();
            Console.WriteLine("What is your class name? >>");
            ClassName = Console.ReadLine();
            Console.WriteLine("What is today's date? >>");
            Date = Console.ReadLine();
            return ($"{DeveloperName} created this application for {ClassName} on {Date}.");
        }
        //developers name, a string for the class name, and a string for the date of writing ,, who wrote the application, for what class, and on what date
    }
}
