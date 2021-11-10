using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTimeSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter file = new StreamWriter(@"C:\Users\T'ana\Documents\GitHub\C--and-Unity\DateTimeSubmission\log.txt", true))
            file.WriteLine(DateTime.Now);
        }
    }
}
