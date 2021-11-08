using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
            None
        }

        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            DaysOfTheWeek weekly; //converting string to enum.
            //userInput DaysOfTheWeek = (DaysOfTheWeek)Enum.Parse(typeof(userInput), value);

            try
            {
                weekly = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), value);
               // Console.WriteLine("Please input the current Day of the Week.", Enum.Parse(DaysOfTheWeek);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                weekly = DaysOfTheWeek.None;
            }
            if (weekly == DaysOfTheWeek.Monday)
            {

            }

            Console.ReadLine();
        }
    }
}
