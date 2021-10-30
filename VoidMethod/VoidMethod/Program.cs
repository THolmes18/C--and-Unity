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
            int x = Convert.ToInt32(Console.ReadLine());


            try
            {
                int y = Convert.ToInt32(Console.ReadLine()); //calls method, passing in both parameters

                MyMethod.mClass(x, y);
            }
            catch (Exception)
            {
              
                MyMethod.mClass(y);
                Console.ReadLine();
            }

            //MyMethod mymethod = new MyMethod(); //object
            //                              //call Class2 method

            //Console.WriteLine(MyMethod.mClass(x, y)); //call by class name
            //Console.ReadLine();
        }
    }
}
