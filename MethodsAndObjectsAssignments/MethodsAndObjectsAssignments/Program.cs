using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignments
{
    class Program
    {
        static void Main(string[] args)
        {
            Person myObjs = new Person();
            myObjs.Name = "T'Ana";
            Console.WriteLine(myObjs.Name);
            myObjs.SayName();

            Employee employee = new Employee();
            employee.Person = new List<string>() { "T'Ana", "Ha'Mil", "Holmes", "Furqan" };
            employee.ID();

            Console.WriteLine(employee.Person);

            employee.person();
            //employee.ID(); //superclass
            Console.ReadLine();
        }
    }
}
