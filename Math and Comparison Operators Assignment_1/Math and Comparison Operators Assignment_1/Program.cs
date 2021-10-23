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
            int hour1 = Convert.ToInt32(Console.ReadLine());
       

            Console.WriteLine("Hours Worked per week?");
            int week1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.ReadLine();

            Console.WriteLine("Hourly Rate?"); //int variable
            int hour2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hours Worked per week?");
            int week2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Annual Salary of Person 1");
            
            int salary1 = hour1 * week1 * 52;
            Console.WriteLine(salary1);
            Console.ReadLine();

            Console.WriteLine("Annual Salary of Person 2");
            int salary2 = hour2 * week2 * 52;
            Console.WriteLine(salary2);
            Console.ReadLine();


            Console.WriteLine("Does Person 1 make more than Person 2?");
            
            if (salary1 > salary2)
            {
                Console.WriteLine("true");
            }

            else if (salary1 < salary2)
            {
                Console.WriteLine("false");
            }

            Console.ReadLine();
            
            


        }
    }
}
