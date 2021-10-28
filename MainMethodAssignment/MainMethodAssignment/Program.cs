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
            MainMethod methods = new MainMethod(); //use class named method created and create an object to use the properties throughout
            methods.methods(100);
            methods.methods(100, 200);
            methods.methods(100, 200, 300);
            Console.ReadLine();

        }
    }
}
