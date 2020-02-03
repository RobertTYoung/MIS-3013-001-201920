using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Summing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number do you want to count up to? >>");
            //string input = Console.ReadLine();
            //int htreshold = Convert.To.Int32(input);
            int threshold = Convert.ToInt32(Console.ReadLine());
            //could also use i < 100
            for (int i = 1; i <= threshold; i++)
            {
                Console.Write(i + " ");    
            }

            double sum = 0; //this is an accumulator variable
            string answer;

            do
            {
                Console.WriteLine("Please give us a # to add >>");
                int number = Convert.ToInt32(Console.ReadLine());
                //sum = sum + number;
                sum += number;

                Console.WriteLine("Do you have another number to add? (y,n) >>");
                answer = Console.ReadLine();

            } while (answer == "y");
          //while (answer != "n")
            Console.ReadKey();
        }
    }
}
