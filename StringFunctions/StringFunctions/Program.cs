using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "T'Ana";
            //string quote = "The man said, \"Hello\", T'Ana. \n Hello on a new line. \n \t Hello on a tab.";
            //string fileName = @"C:\Users\T'Ana";
            ////if you want a backslash then double \\

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToUpper();

            //Console.WriteLine(length);

            //Console.WriteLine(quote);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append("My name is T'Ana");


            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
