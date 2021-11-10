using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTimeSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString("F"));

           
            Console.WriteLine("Please pick a number.");

            int userInput = Convert.ToInt32(Console.ReadLine());
            DateTime.Now.AddHours(userInput );


            DateTime d1 = new DateTime(2021, 11, 10, 2, 31, 10);
            DateTime d2 = d1.AddHours(userInput);
            System.Console.WriteLine("Initial DateTime = {0:dd} {0:y}, {0:t} ", d1);
            System.Console.WriteLine("\nNew DateTime (After adding hours) = {0:dd} {0:y}, {0:t} ", d2);



            Console.ReadLine();
        }
    }
}
