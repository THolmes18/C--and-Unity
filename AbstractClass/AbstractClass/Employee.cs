using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Employee : Person, IQuittable
    {
        public int ID { get; set; } 
    }

    public void Quittable(Employee employee)
    {
        throw new NotImplementedException();
    }
}
