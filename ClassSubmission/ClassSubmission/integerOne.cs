using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    class integerOne
    {
        public static void MyMethod(int a, int b)

        {
            int difference = a + b / 2;
            Console.WriteLine(difference);
            Console.ReadLine();
            Console.WriteLine("Please enter a number");
            double MyMethod = Convert.ToDouble(Console.ReadLine());
            double radious = 0;
            double circumference = CalculateCircle(radious, out double area);
            Console.WriteLine("Circle's circumference is {circumference}");
            Console.WriteLine("Circle's Area is {area}");
            Console.ReadKey();
        }
        static double CalculateCircle(double radious, out double area)
        {
            area = Math.PI * Math.Pow(radious, 2);
            double circumference = 2 * Math.PI * radious;
            return circumference;
        }
    }
}
