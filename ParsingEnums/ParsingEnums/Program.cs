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
            Console.WriteLine("Please input the current Day of the Week.");
            string userInput = Console.ReadLine();
            DaysOfTheWeek weekly; //converting string to enum.

            try
            {
                weekly = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                weekly = DaysOfTheWeek.None;
            }
            Console.ReadLine();
        }
    }
}
