using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {//Robert Young
        static void Main(string[] args)
        {
            //Create an array off type int with a size of 3
            int[] studentIds = new int[3];
            //string[] studentNames = new string[3]; //these two arrays are parallel, values at the same INDEX correlate to each other
            string[] studentNames = { "Adam", "Katie", "Micah" };

            //   [0]     [1]      [2]
            //["Adam"]["Katie"]["Micah"]
            studentIds[0] = 1;
            studentIds[1] = 2;
            studentIds[2] = 3;
            //INDEX OUT OF RANGE BECAUSE WE ONLY HAVE SPACE FOE 3 VALUES -- studentIds[3] = 4

            //Console.WriteLine($"Student with ID {studentIds[0]} has a name of {studentNames[0]}.");

            for (int i = 0; i < studentIds.Length; i++) //could also do studentNames.Length as they are parallel
            {
                Console.WriteLine($"Student with ID {studentIds[i]} has a name of {studentNames[i]}.");
            }

            //DO THE SAME THING BUT WITH LISTS

            List<int> studIds = new List<int>();
            studIds.Add(4);
            studIds.Add(5);
            studIds.Add(6);
            List<string> studNames = new List<string>() { "Lakin", "Grant", "Eric" };
            //studNames.Add("Lakin");
            //studNames.Add("Grant");
            //studNames.Add("Eric");

            for (int i = 0; i < studIds.Count; i++) //could also do studentNames.Length as they are parallel
            {
                Console.WriteLine($"Student with ID {studIds[i]} has a name of {studNames[i]}.");
            }

            //COMBINE ARRAY DATA AND LIST DATA INTO A DICTIONARY



            Console.ReadKey();
        }
    }
}
