using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooLean_Logic_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = 2 * 16;
            Console.WriteLine(age);
            Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI?");
            Console.WriteLine(false && false);
            Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            int speed = 1 + 0;
            Console.WriteLine(speed);

            Console.WriteLine("Qualified?");
            Console.WriteLine(true && true);
            Console.ReadLine();


        }
    }
}
