using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Submission_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());


            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Package width?");
                int width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Package height?");
                int height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Package length?");
                int length = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Quote");
                int Quote = height * width * length * weight / 100;
                Console.WriteLine(Quote);
                Console.ReadLine();



            }

        }
    }
}
