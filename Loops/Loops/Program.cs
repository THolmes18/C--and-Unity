using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isGuessed = false;
            do //add before while and it will correct the while error.
            {
                //switch statements starts with switch (what you want to check)
                switch (number)
                {
                    case 62: //if number = 62
                        Console.WriteLine("You Guessed 62. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;


                    case 55:
                        Console.WriteLine("You guessed 55. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 12:
                        Console.WriteLine("You guessed 12. That is correct.");
                        isGuessed = true;
                        break;

                    default: //if no case is guessed.
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }

            }
            while (!isGuessed); //good to avoid while  loops it can be endless

            Console.Read();

            int i = 0;
            while (i < 100)
            {
                Console.WriteLine(i);
                i++; //add 2 numbers at a time.
                Console.Read();
            }
        }
    }
}
