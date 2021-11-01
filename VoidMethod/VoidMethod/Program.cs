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
            MyMethod mymethod = new MyMethod();
            int y = 8;
            int x = 2;
            MyMethod.mClass(x, y);
     
            Console.ReadLine();
        }
    }
}

//instinuate call method from the object