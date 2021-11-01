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

            myObject.MyMethod(a);
         
             Console.ReadLine();

            int i; //save i in memory but dk how to use yet
            myObject.OutMethod(out i); //passing in i through object and method
            Console.WriteLine(i);
            Console.ReadLine();

            int overLoad = Convert.ToInt32(Console.ReadLine());

            integerOne.overLoad(10, 20);
            integerOne.overLoad((int)10.5, (int)20.5);
            integerOne.overLoad(40, 80);
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();


        }
    }
}

//out passes for refrences when returning multiples.(1 value inside of a method)