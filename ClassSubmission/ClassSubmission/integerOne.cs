using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    class integerOne
    {
        public void MyMethod(int a)

        {
            
            Console.WriteLine(a / 2);
            
        }

        public void OutMethod(out int x) //out needs data type reference
        {
            x = 30;
            x += x; //addition: syntax trigger
        }

        public void overload(int az, int b) //overload
        {
            Console.WriteLine(az + b);
        }

        internal static void overLoad(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }

}

//static method keeps one copy of method inside of self..properties belong to that class specifically.