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

       

            try
            {
                Console.WriteLine("[Optional] Please input a second number.");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();
             
            }
            catch (Exception)
            {
                Class1 class1 = new Class1(); //object
                                              //call Class2 method
                     
                Console.WriteLine(Class1.MyMethod(a, b)); //call by class name
                Console.ReadLine();
            }
          

          
            
           
        }
    }
}
