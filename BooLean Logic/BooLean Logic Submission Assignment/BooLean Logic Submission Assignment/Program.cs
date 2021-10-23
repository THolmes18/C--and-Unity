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
            int age = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Have you ever had a DUI? Please answer true or false.");
            bool isDUI = Convert.ToBoolean(Console.ReadLine());

            Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            int speed = Convert.ToInt32(Console.ReadLine());

        

            Console.WriteLine("Qualified?");

            if (age > 15 && isDUI == false && speed < 3) //if ALL necessary conditions
            {
                Console.WriteLine("true");
            }

            else //all other circumstances
            {
                Console.WriteLine("false");
            }


            Console.ReadLine();

            //Console.WriteLine(true && false); //AND
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);

            //Console.WriteLine(true || true);
            //Console.WriteLine(true || false); //only 1 needs to be true (OR)
            //Console.WriteLine(false || false);

            //Console.WriteLine(true == true);
            //Console.WriteLine(false == true);
            //Console.WriteLine(false == false); //equal to

            //Console.WriteLine(true != true); //Not equal
            //Console.WriteLine(true != false);
            //Console.WriteLine(false != false);

            //Console.WriteLine(true ^ true); // XOR operator if 1 is true but not equal
            //Console.WriteLine(true ^ false);
            //Console.WriteLine(false ^ false);

        }


    
    }
}
