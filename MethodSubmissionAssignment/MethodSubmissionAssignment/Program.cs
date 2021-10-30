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
                //calls the method, passing in both parameters.
                Class1.MyMethod(a, b);
             
            }
            catch (Exception)
            {
                     //calls method, passing in only one parameter
                Class1.MyMethod(a); //call by class name
                Console.ReadLine();
            }
          

          
            
           
        }
    }
}
