using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    class Program
    {
               

        public static void Main(string[] args)
        {
            integerOne myObject = new integerOne();//instantiate class name and object calling by object directly

            Console.WriteLine("Enter a number.");
            int a = Convert.ToInt32(Console.ReadLine());

            //calling all methods         
            myObject.MyMethod(a);
            Console.WriteLine("Input a word"); //out
            string userInput = Console.ReadLine();
            string count = myObject.OverLoad(userInput, out int x); //changes to an integer
            Console.WriteLine(count);

            Console.WriteLine("Input 1 number.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input a second number.");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = myObject.OverLoad(num1, num2);
            Console.WriteLine("Your two numbers added equals " + num3);

            Console.WriteLine("Pick a number"); //static class declared.
            int sts = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(StaticClass.statMethod(sts));
            Console.ReadLine();


        }

     
    }
}

//out passes for refrences when returning multiples.(1 value inside of a method)
//static does not need new object.