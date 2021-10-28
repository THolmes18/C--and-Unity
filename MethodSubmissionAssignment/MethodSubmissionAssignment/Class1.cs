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

        public static void Add(int a, int b, [ Optional ] int[] n)
        {
            int Sum = a + b;
            if (n != null)
            {
                foreach (int no in n)
                {
                    Sum += no;
                }
            }
            Console.WriteLine("Sum is {0}: ", Sum);
        }

        private class OptionalAttribute : Attribute
        {
        }



        //public int Add(int a, int b, [ Optional ] int[] n)
        //{
        //    int sum = a + b;
        //    return sum;
    }
    
}

