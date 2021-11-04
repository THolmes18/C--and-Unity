using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Employee : Person, IQuittable
    {
        public int ID { get; set; }

        public void Quit()
        {
            Console.WriteLine("This person has quit.");
        }
        public static Employee operator== (Employee ID, Person person)
        {
            Employee.(ID);
            return employee;
        }
    }

    
}
