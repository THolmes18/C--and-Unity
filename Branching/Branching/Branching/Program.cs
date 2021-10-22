using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite Number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 12 ? "You have an awesome favorite number." : "You do not have a nice number.";

            Console.WriteLine(result);
            Console.ReadLine();
            
            int roomTemperture = 70;

            Console.WriteLine("Hi, what is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hi, " + name + ", what is the temperture where you are?");
            int currentTemperture = Convert.ToInt32(Console.ReadLine());

            if (currentTemperture == roomTemperture)
            {
                Console.WriteLine("It is exactly room temperture");
            }
            else if (currentTemperture > roomTemperture)
            {
                Console.WriteLine("It is warmer than room temperture.");
            }
            else if (roomTemperture > currentTemperture)
            {
                Console.WriteLine("It is colder than room temperture.");
            }
            else
            {
                Console.WriteLine("UHHHH.. something went wrong.");
            }
            Console.ReadLine();

            //int currentTemperture = 80;
            //int roomTemperture = 70;

            //string comparisonResult = currentTemperture == roomTemperture ? "It is room temp." : "It is not room temp."; //if else statement that compacts code same as at the bottom.
            //Console.WriteLine(comparisonResult);
            //Console.ReadLine();

            //if (currentTemperture == roomTemperture)
            //{
            //    Console.WriteLine("It is exactly room temperture.");
            //}
            //else if (currentTemperture > roomTemperture)
            //{
            //    Console.WriteLine("it is warmer than room temperture.");
            //}
            //else if (roomTemperture > currentTemperture)
            //{
            //    Console.WriteLine("Room temperture is wamrer than current temperture");
            //}
            //else
            //{
            //    Console.WriteLine("It is not exactly room temperture.");
            //}
            Console.ReadLine();
        }
            
    }
}
