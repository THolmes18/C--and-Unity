using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        

            Console.WriteLine("Please enter the package weight:");
            Console.ReadLine();

            if (heavyPackage == packageWeight)
            {
                Console.WriteLine("Your package has been accepted.");
            }
            else if (heavyPackage > packageWeight)
            {
                Console.WriteLine("Your package has been accepted.");
            }
            else if (heavyPackage < packageWeight)
            {
                Console.WriteLine("Package too heavy to be shipped vis Package Express. Have a good day.");
            }
            Console.ReadLine();


            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
           


            
        }
    }
}
