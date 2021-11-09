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
            List<string> Employee = new List<string>();
            Employee employee = new Employee() { firstName = "T'Ana", lastName = "Holmes", ID = 0 };
            Employee employee1 = new Employee() {firstName = "Rachael", lastName = "Holmes", ID = 2 };
            Employee employee2 = new Employee() { firstName = "Joe", lastName = "Holmes", ID = 4 };
            Employee employee3 = new Employee() { firstName = "Ross", lastName = "Holmes", ID = 6 };
            Employee employee4 = new Employee() { firstName = "Monica", lastName = "Holmes", ID = 1 };
            Employee employee5 = new Employee() { firstName = "Gunther", lastName = "Holmes", ID = 3 };
            Employee employee6 = new Employee() { firstName = "Joe", lastName = "Holmes", ID = 5 };
            Employee employee7 = new Employee() { firstName = "Joey", lastName = "Holmes", ID = 7 };
            Employee employee8 = new Employee() { firstName = "Matthew", lastName = "Holmes", ID = 9 };
            Employee employee9 = new Employee() { firstName = "Tyler", lastName = "Holmes", ID = 10 };

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

            //foreach (string Names in Employee)
            //{
            //    Console.WriteLine("Joe Holmes"); 
            //    Console.WriteLine("Joe Long");
            //}
            foreach (Employee firstName in Employee.FindAll(e => (e.ID > 5)).Take(2).ToLost())
            {
                Console.WriteLine("These individuals have an ID number greater than 5.");
            }

            //for (int i = 0; i < ID.Count; i++) ;
            //int sum = employeeID.Sum(x => x + 5);
            Console.ReadLine();
        }
        
        //foreach (Person person in listPersonsInCity.FindAll(e => (e.Age >= 60)).Take(2).ToList())  
        // Console.WriteLine("Name : " + person.Name + " \t\tAge: " + person.Age);  
}

}
}
