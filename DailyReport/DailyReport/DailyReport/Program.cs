using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            //This is a simple program
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);
            Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("You're on: " + course);
            Console.ReadLine();

            Console.WriteLine("What page number are you on?"); //int variable
            int page = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Do you need help?");
            bool isHelp = Convert.ToBoolean(Console.ReadLine()); //pass in arguments inside ().

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveFeedback = Console.ReadLine();
            Console.WriteLine("Thank you for your experiences!");
            Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine();
            Console.WriteLine("Thank you for your experiences!");
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?"); //int variable
            int hours = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();



            //class accesses a method(convert, console is a class) (ReadLine is a method)



        }
    }
}
