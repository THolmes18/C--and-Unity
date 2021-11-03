using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignments
{
    class Employee : Person
    {
        public List<string> Person { get; set; }

        public void ID()
        {
            foreach (string person in Person)
            {
                Console.WriteLine(person);
            }
        }

        public void person()
        {
            throw new NotImplementedException();
        }
    }
}


