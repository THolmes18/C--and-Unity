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
            //Things.add("Rachel green");
           

            Employee<int> FirstName = new Employee<int>();
            FirstName.Things = new List<int>() { 40000, 60000, 82000  }; //FirstName = object

            foreach (string Names in employee.Things)
            {
                Console.WriteLine(Names);
            }

            foreach (int Salary in FirstName.Things)
            {
                Console.WriteLine(Salary);
            }


          



            Console.ReadLine();
        }

     
    }
}
//generic 3 Player<Card> player = new Player<Card>();
//generic 4 player.Hand = new List<Card>(); (Generics is primarily used for List
//E= class e = object