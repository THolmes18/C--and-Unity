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

        public string OverLoad(string word, out int x) //out needs data type reference..takes in string and outputs length
        {
            x = word.Length;
            string y = "Your string is " + x + " characters long.";
            return y;
        }

        public int OverLoad(int az, int b) //overload diff method but same name.
        {
            int num = (az + b);
            return num;
        }
    }

}

//static method keeps one copy of method inside of self..properties belong to that class specifically.
//void returns nothing