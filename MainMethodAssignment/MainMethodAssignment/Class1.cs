using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class MainMethod
    {
        
        public void methods(int a) //void = do not need the return method ...this will have one parameter
        {
            Console.WriteLine("Arguements: " + a);
        }

        public void methods(int a, int b) //2 parameters
        {
            Console.WriteLine("Arguements:" + a + " and " + b);
        }


        public void methods(int a, int b, int c) //3 parameters
        {
            Console.WriteLine("Arguements:" + a + " and " + b + " and " + c);
        }
    }
}
