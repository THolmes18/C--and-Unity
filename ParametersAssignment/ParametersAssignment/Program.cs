using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>(); 
            employee.Things = new List<string>() { "T'Ana", "Holmes" };

            employee<string> employee2 = new employee<string>();
            //employee.FirstName = new employee<string>("");

            employee<int> employee1 = new employee<int>();

            
            Console.ReadLine();
        }

        private class Employee<T>
        {
            public List<string> Things { get; internal set; }
        }
    }
}
//generic 3 Player<Card> player = new Player<Card>();
//generic 4 player.Hand = new List<Card>(); (Generics is primarily used for List