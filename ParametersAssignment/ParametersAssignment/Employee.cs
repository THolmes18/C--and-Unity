using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    public class Employee<T>
    {
        public List<T> Things { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public void Name(string FirstName)
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}





