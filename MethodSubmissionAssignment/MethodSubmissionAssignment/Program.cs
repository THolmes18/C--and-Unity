using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Please input a number.");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("[Optional] Please input a second number.");
            string b = "4";
            Console.ReadLine();
          
            
            Class1 class1 = new Class1(); //object
                                          //call Class2 method
            
            Console.WriteLine(class1.MyMethod(a, b));
            Console.ReadLine();
        }
    }
}
