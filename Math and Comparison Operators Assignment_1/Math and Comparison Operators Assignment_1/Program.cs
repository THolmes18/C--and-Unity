using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_and_Comparison_Operators_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.ReadLine();

            Console.WriteLine("Hourly Rate?"); 
            int hour1 = 5 * 3;
            Console.WriteLine(hour1);
            Console.ReadLine();

            Console.WriteLine("Hours Worked per week?");
            int week1 = 8 * 5;
            Console.WriteLine(week1);
            Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.ReadLine();

            Console.WriteLine("Hourly Rate?"); //int variable
            int hour2 = 10 * 2;
            Console.WriteLine(hour2);
            Console.ReadLine();

            Console.WriteLine("Hours Worked per week?");
            int week2 = 8 * 5;
            Console.WriteLine(week2);
            Console.ReadLine();

            Console.WriteLine("Annual Salary of Person 1");
            int salary1 = 15 * 40 * 52;
            Console.WriteLine(salary1);
            Console.ReadLine();

            Console.WriteLine("Annual Salary of Person 2");
            int salary2 = 20 * 40 * 52;
            Console.WriteLine(salary2);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more than Person 2?");
            bool salaryCompare = 31200 > 41600;
            Console.Write(salaryCompare.ToString());
            Console.ReadLine();


        }
    }
}
