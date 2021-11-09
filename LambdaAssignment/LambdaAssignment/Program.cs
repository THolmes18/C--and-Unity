using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int ID = Convert.ToInt32(Console.ReadLine());

            List<string> Employees = new List<string>();
            Employees.Add("Joe Tribbiani 001");
            Employees.Add("Rachael Green 002");
            Employees.Add("Ross Geller 003");
            Employees.Add("Phoebe Buffay 004");
            Employees.Add("Monica Geller 005");
            Employees.Add("Chandler Bing 006");
            Employees.Add("Gunther Tyler 007 ");
            Employees.Add("Joe Long 008 ");
            Employees.Add("Carol Willick 009 ");
            Employees.Add("Mike Hannigan 010 ");

            List<int> ID = new List<int>();
            ID.Add(001);


            foreach (string Joe in Employees)
            {
                Console.WriteLine(" ");
            }

            List<int> Employees = ID.FindAll(x => (ID > 5) == 0);

        }

         
    }
}
