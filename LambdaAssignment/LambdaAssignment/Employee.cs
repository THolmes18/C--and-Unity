using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int ID { get; set; }

        public void Names()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName + " " + ID);
        }

    }
}
