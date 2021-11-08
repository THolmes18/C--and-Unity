using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    public class Employee<T>
    {
        public List<string> Things { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int salary { get; set; }


        public void Name(string FirstName, string LastName)
        {
            FirstName = " ";
            LastName = " ";
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        public void Salary(int salary, int salary2)
        {
            salary = 25000;
            salary2 = 55000;

            List<int> Salary = new List<int>(3) { 60000, 75000, 86000 };
            Salary.Add(88000);
            Salary.Add(98000);

            Console.WriteLine("Salary: " + salary + " " + salary2);
        }

       
    }
}





