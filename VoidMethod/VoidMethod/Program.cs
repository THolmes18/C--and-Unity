using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input a number.");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("[Optional] Please input a second number.");
            int month = Convert.ToInt32(Console.ReadLine());



            MyMethod mymethod = new MyMethod(); //object
                                          //call Class2 method

            Console.WriteLine(MyMethod.mClass(day, month)); //call by class name
            Console.ReadLine();
        }
    }
}
