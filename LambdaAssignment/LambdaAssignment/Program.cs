using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        public static int ID;

        static void Main(string[] args)
        {
            
            List<Employee> emList = new List<Employee>();
            List<Employee> newList = new List<Employee>();
            List<Employee> fList = new List<Employee>();

            Employee employee = new Employee() { firstName = "T'Ana", lastName = "Holmes", ID = 0 };
            Employee employee1 = new Employee() {firstName = "Rachael", lastName = "Holmes", ID = 2 };
            Employee employee2 = new Employee() { firstName = "Joe", lastName = "Holmes", ID = 4 };
            Employee employee3 = new Employee() { firstName = "Ross", lastName = "Geller", ID = 6 };
            Employee employee4 = new Employee() { firstName = "Monica", lastName = "Geller", ID = 1 };
            Employee employee5 = new Employee() { firstName = "Gunther", lastName = "Holmes", ID = 3 };
            Employee employee6 = new Employee() { firstName = "Joe", lastName = "Long", ID = 5 };
            Employee employee7 = new Employee() { firstName = "Joey", lastName = "Holmes", ID = 7 };
            Employee employee8 = new Employee() { firstName = "Chandler", lastName = "Bing", ID = 9 };
            Employee employee9 = new Employee() { firstName = "Phoebe", lastName = "Buffay", ID = 10 };

            emList.Add(employee);
            emList.Add(employee1);
            emList.Add(employee2);
            emList.Add(employee3);
            emList.Add(employee4);
            emList.Add(employee5);
            emList.Add(employee6);
            emList.Add(employee7);
            emList.Add(employee8);

            newList.Add(employee2);
            newList.Add(employee6);


            foreach (Employee em in emList)
            {
                if (em.firstName == "Joe")
                {
                    fList.Add(em);
                }
            }

           

            List<Employee> idEmpList = emList.Where(x => x.firstName == "Joe").ToList(); //x correlates to em
            

            List<Employee> idList = newList.Where(x => x.ID > 5).ToList();

            //foreach( Employee c in fList) //checks fList
            //{
            //    Console.WriteLine(c.firstName);
            //}


            //LAMBDA  the first part of our statement should be defining a list of Employee objects: List<Employee> idEmpList = 
            //LAMBDA Expressions--where returns all instances

            Console.ReadLine();
        }
    }
}

