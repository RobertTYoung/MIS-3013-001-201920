using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P__Collections
{
    class Program
    {//Robert Young collaberted with Shaun Poweshiek
        static void Main(string[] args)
        {

            //Console.WriteLine("Please enter an exam grade! >>");
            //double eGrade = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Do you have another exam score? Please enter true or false. >>");
            //bool Another = Convert.ToBoolean(Console.ReadLine());
            //double eGrade = 0;
            bool Another = true;

            List<double> examGrades = new List<double>();
            //examGrades.Add(eGrade);

            do
            {
                Console.WriteLine("Please enter an exam grade! >>");
                double eGrade = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Do you have another exam score? Please enter true or false. >>");
                bool AnotherOne = Convert.ToBoolean(Console.ReadLine());
               
                examGrades.Add(eGrade);

            } while (Another == true);

            int results = examGrades.Count();
            Console.WriteLine($"You've entered {results} grade(s)! >>" );

            Console.ReadKey();
        }
    }
}
