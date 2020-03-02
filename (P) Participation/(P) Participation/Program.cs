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
            /*bool Another = true;

            List<double> examGrades = new List<double>();
            
            do
            {
                Console.WriteLine("Please enter an exam grade! >>");
                double eGrade = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Do you have another exam score? Please enter true or false. >>");
                bool AnotherOne = Convert.ToBoolean(Console.ReadLine());
               
                examGrades.Add(eGrade);

            } while (Another == true);

            int results = examGrades.Count();
            Console.WriteLine($"You've entered {results} grade(s)! >>" );*/

            string examScore, answer;
            List<double> scores = new List< double > ();
            
            do
            {
                Console.WriteLine($"Please enter your exam score.");
                examScore = Console.ReadLine();
                double es = Convert.ToDouble(examScore);

                Console.WriteLine("Do you have another exam score? Please enter yes or no. >>");
                answer = Console.ReadLine();
            } while (answer.ToLower() == "yes");

            double sum = 0;
            double minimum = 100;
            double maximum = -1;

            /*for (int i = 0; i < scores.Count; i++)
            {
                double score = scores[i];
                sum = sum + score;

                if (score < minimum)
                {
                    minimum = score;
                }

                if (score > maximum)
                {
                    maximum = score;
                }
            }*/

            foreach (var score in scores)
            {
                sum = sum + score;

                if (score < minimum)
                {
                    minimum = score;
                }

                if (score > maximum)
                {
                    maximum = score;
                }
            }


            double average = sum / scores.Count;

            Console.WriteLine($"Your average for the {scores.Count} exam grade is {average.ToString("N3")}");
            Console.WriteLine($"Your minimum score for the exam grade is {minimum.ToString("N3")}");
            Console.WriteLine($"Your max score for the exam grade is {maximum.ToString("N3")}");


            Console.ReadKey();
        }
    }
}
