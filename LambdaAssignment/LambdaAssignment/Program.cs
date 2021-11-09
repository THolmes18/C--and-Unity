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



            employee.Names();
            employee1.Names();
            employee2.Names();
            employee3.Names();
            employee4.Names();
            employee5.Names();
            employee6.Names();
            employee7.Names();
            employee8.Names();
            employee9.Names();

            foreach (Employee em in emList)
            {
                if (employee.firstName == "Joe");
            }

            List<int> employee = ID.FindAll(x => x > 5).ToList();  
            //int count = ID.Employee.Count(x => x.ID > 5);
           

            //foreach (Employee firstName in Employee.FindAll(e => (e.ID > 5)).Take(2).ToLost())
            {
              //  Console.WriteLine("These individuals have an ID number greater than 5.");
            }

            //for (int i = 0; i < emList.ID; i++) ;
            //int ID = emList.ID (x => 5 );
            Console.ReadLine();
        }
        
        //foreach (Person person in listPersonsInCity.FindAll(e => (e.Age >= 60)).Take(2).ToList())  
        // Console.WriteLine("Name : " + person.Name + " \t\tAge: " + person.Age);  
    }

}

