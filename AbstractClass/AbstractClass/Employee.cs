using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Employee : Person, IQuittable
    {
        public static Employee employee { get; internal set; }
        public int ID { get; set; }

        public void Quit()
        {
            Console.WriteLine("This person has quit.");
        }
        public static bool operator == (Employee employee, Employee employee1)
        {
            if (employee.ID == employee1.ID)
                return true;
            else
                return false;
        }
        public static bool operator !=(Employee employee, Employee employee1)
        {
            if (employee.ID != employee1.ID)
                return false;
            else
                return true;
        }
    }


}
