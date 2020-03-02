using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P__Collections_2
{
    class Program
    {//Robert Young
        static void Main(string[] args)
        {
            //1
            //string [] classes = { "MIS", "MATH", "MGT", "FIN" };
            //string[] courseNum = { "3013", "3033", "3013", "2303" };

            string[] classes = new string[3];
            string[] courseNum = new string[3];

            for (int i = 0; i < classes.Length; i++)
            {
                Console.WriteLine("Please enter your course name. >>");
                classes[i] = Console.ReadLine();
            }

            for (int i = 0; i < courseNum.Length; i++)
            {
                Console.WriteLine("Please enter your course number. >>");
                courseNum[i] = Console.ReadLine();
            }

            for (int i = 0; i < classes.Length; i++)
            {
                Console.WriteLine(string.Concat(classes[i].ToUpper(), courseNum[i].ToUpper()));
            }
            //Console.WriteLine(string.Concat(classes[0], courseNum[0]));
            //Console.WriteLine("Please enter the number 3.");

            //2
            List<double> grades = new List<double>();
            string assignmentScore, answer;            
            double gradeScore;

            do
            {
                Console.WriteLine($"Please enter your grade.");
                assignmentScore = Console.ReadLine();
                gradeScore = Convert.ToDouble(assignmentScore);
                grades.Add(gradeScore);

                Console.WriteLine("Do you have another exam score? Please enter yes or no. >>");
                answer = Console.ReadLine();
            } while (answer.ToLower() == "yes");

            double sum = 0;

            for (int i = 0; i < grades.Count; i++)
            {
                double score = grades[i];
                sum = sum + score;
            }
                       
            double average = sum / grades.Count;

            Console.WriteLine($"Your average for the {grades.Count} grades is {average.ToString("N3")}");

            //3

            Console.ReadKey();
        }
    }
}
