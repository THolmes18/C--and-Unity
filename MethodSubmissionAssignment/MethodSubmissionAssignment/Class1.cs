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

        public static int MyMethod(int a, int b) //default parameter value by using equal sign..calling the method without arguement uses default (4)

        {
            b = 4;
            if (a < 10)
                { return a;
            }
            else
            {
                return 1;
            }
            //Console.WriteLine(a + b); 

        }

    }
}