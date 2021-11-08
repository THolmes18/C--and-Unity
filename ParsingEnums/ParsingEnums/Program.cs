using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            

            try 
            {
                Weekly weekly = new Weekly();
                Console.WriteLine("Please input the current Day of the Week.", Enum.Parse(DaysOfTheWeek);
            }
            
            catch (Exception e)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.ReadLine();
        }
    }
}
