using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    public class employee<T> 
    {
        public List<string> Things { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }


        public void Name(string FirstName, string LastName, int Salary)
        {
            FirstName = " ";
            LastName = " ";
            Salary = 50000;

            Console.WriteLine("Name: " + FirstName + " " + LastName + Salary);
        }
    }
}





