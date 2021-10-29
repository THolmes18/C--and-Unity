using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace MethodSubmissionAssignment
{
    class Class1
    {

        public static void MyMethod(int a, string b = "4") //default parameter value by using equal sign..calling the method without arguement uses default (4)

        {
            Console.WriteLine(a + b); 

        }

    }
}