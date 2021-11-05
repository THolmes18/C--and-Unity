using AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Things<T> things = new Things<T>;


            IQuittable emp2 = new Employee();
            emp2.Quit();
            
            
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };

            employee.SayName();
            Console.ReadLine();

            Employee employee1 = new Employee() { ID = 4 }; //unique objects
            Employee employee2 = new Employee() { ID = 4 };
            Console.WriteLine("Are the employee ID's equal?");
            Console.WriteLine(employee1.ID == employee2.ID);//comparison

            Console.ReadLine();

            Employee<T> employee = new Employee<T>();
            employee.ID = new List<T>();

            Employee<string> Things = new Employee<string>();
        }
    }


}
