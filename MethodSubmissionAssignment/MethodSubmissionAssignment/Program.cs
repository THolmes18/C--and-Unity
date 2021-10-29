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
            int sum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input a second number.");
            int sum2 = Convert.ToInt32(Console.ReadLine());
            
            Class1 class1 = new Class1(); //object
                                          //call Class2 method
            Console.WriteLine(class1.Add(sum, sum2));
            Console.ReadLine();
        }
    }
}
