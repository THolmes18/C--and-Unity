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
            Employee<T> employee = new Employee<T>() { FirstName = "T'Ana", LastName = "Holmes" };
            employee.Things = new List<T>();
            Console.ReadLine();


        }
    }
}
//generic 3 Player<Card> player = new Player<Card>();
//generic 4 player.Hand = new List<Card>(); (Generics is primarily used for List