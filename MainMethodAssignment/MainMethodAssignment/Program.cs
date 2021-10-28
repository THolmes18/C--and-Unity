using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        public static void Main(string[] args)

        {
            //Class code
            Console.WriteLine("Enter a number.");
            int userinput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number.");
            int userinput2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a third number.");
            int userinput3 = Convert.ToInt32(Console.ReadLine());

            MainMethod methods = new MainMethod(); //use class named method created and create an object to use the properties throughout
            methods.methods(userinput);
            methods.methods(userinput, userinput2);
            methods.methods(userinput, userinput2, userinput3);
            Console.ReadLine();
     
        } 
    }
}
