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
            //int ID = Convert.ToInt32(Console.ReadLine());
            

            List<string> Employees = new List<string>();
            Employees.Add("Joe Tribbiani");
            Employees.Add("Rachael Green");
            Employees.Add("Ross Geller");
            Employees.Add("Phoebe Buffay");
            Employees.Add("Monica Geller");
            Employees.Add("Chandler Bing");
            Employees.Add("Gunther Tyler");
            Employees.Add("Joe Long");
            Employees.Add("Carol Willick");
            Employees.Add("Mike Hannigan");

            List<int> employeeID = new List<int>();
            employeeID.Add(001);
            employeeID.Add(002);
            employeeID.Add(003);
            employeeID.Add(004);
            employeeID.Add(005);
            employeeID.Add(006);
            employeeID.Add(007);
            employeeID.Add(008);
            employeeID.Add(009);
            employeeID.Add(010);

            foreach (string Joe in Employees)
            {
                Console.WriteLine(" Joe Long, Joe Tribbiani");
            }

            for (int i = 0; i < employeeID.Count; i++) ;
            int sum = employeeID.Sum(x => x + 5);
            Console.ReadLine();
        }
        
         
    }
}
