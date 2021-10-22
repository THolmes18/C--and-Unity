using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperatiors
{
    class Program
    {
        static void Main(string[] args)
        { //addition 
          // int total = 5 + 10;
          // int otherTotal = 12 + 22;
          // int combined = total + otherTotal;
          // Console.WriteLine(combined);
          // Console.ReadLine();

            //subtraction
            // int difference = 10 - 5;
            // Console.WriteLine("Ten minus Five = " + difference.ToString());
            // Console.ReadLine();

            //multiplication
            // int product = 10 * 5;
            // Console.WriteLine(product);
            // Console.ReadLine();

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine()

            //division
            //int quotient = 100 / 5;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //remainders
            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();


            //Comparison Operators  true or false
            //bool trueOrFalse = 12 > 5;
            //Console.Write(trueOrFalse.ToString());
            //Console.ReadLine();

            int roomTemperture = 70;
            int currentTemperture = 72;

            //bool isWarm = currentTemperture >= roomTemperture; //>= satisfys this as well if it would need to be greater than or equal too..
            bool isWarm = currentTemperture == roomTemperture; //!= meant not equal == means equals
            Console.WriteLine(isWarm);
            Console.ReadLine();

     
        }
    }
}
