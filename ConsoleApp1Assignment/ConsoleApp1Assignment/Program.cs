using System;
using System.Collections.Generic;

    class Program
    {
    static void Main(string[] args)
    {
        //// 1 dimensional array of strings
        //string[] newArray = { "Good Evening!", "C# and Unity", "Project Management", "Live Project", "Almost completed!" };
        //Console.WriteLine("Please input a number, 0-4.");
        //int wordings = Convert.ToInt32(Console.ReadLine());

        //for (int i = 0; i < newArray.Length; i++)
        //{
        //    Console.WriteLine(i);
        //}
        //Console.ReadLine();

        //infinite loop
        //int i = 0;
        //while (i < 1000)
        //{
        //    Console.WriteLine(i);
        //    i++; //add 2 numbers at a time.
        //    Console.Read();
        //}

        //loop with operators
        //int l = 0;
        //while (l < 1000)
        //{
        //    Console.WriteLine(l);
        //    l++; //add 2 numbers at a time.


        //        if (l > 500)
        //        {
        //        Console.WriteLine(l++);
        //        }

        //    Console.Read();
        //}

        //int t = 0;
        //while (t <= 400)
        //{
        //    Console.WriteLine(t++);

        //}
        //Console.ReadLine();

        //unique strings part 4
        //Console.WriteLine("Guess a number?");
        //int number = Convert.ToInt32(Console.ReadLine());

        //bool isGuessed = false;
        //do //add before while and it will correct the while error.
        //{
        //    //switch statements starts with switch (what you want to check)
        //    switch (number)
        //    {
        //        case 62: //if number = 62
        //            Console.WriteLine("You Guessed 62. Try again.");
        //            Console.WriteLine("Guess a number?");
        //            number = Convert.ToInt32(Console.ReadLine());
        //            break;

        //        case 29:
        //            Console.WriteLine("You guessed 29. Try again.");
        //            Console.WriteLine("Guess a number?");
        //            number = Convert.ToInt32(Console.ReadLine());
        //            break;


        //        case 55:
        //            Console.WriteLine("You guessed 55. Try again.");
        //            Console.WriteLine("Guess a number?");
        //            number = Convert.ToInt32(Console.ReadLine());
        //            break;

        //        case 12:
        //            Console.WriteLine("You guessed 12. That is correct.");
        //            isGuessed = true;
        //            break;

        //        default: //if no case is guessed.
        //            Console.WriteLine("You are wrong.");
        //            Console.WriteLine("Guess a number?");
        //            number = Convert.ToInt32(Console.ReadLine());
        //            break;
        //    }
        //}
        //while (!isGuessed); //good to avoid while  loops it can be endless
        //Console.Read();

        // 2 identical strings..and loop
        
        List<string> names = new List<string>() { "Hallowen", "Thanksgiving", "Birthday", "Christmas", "Birthday" };
        List<string> duplicate = new List<string>();

        foreach (string name in names)
        {    
                Console.WriteLine(name);
            if (duplicate.Contains(name)) //passed into the foreach loop
            {
                Console.WriteLine(name+ " has appeared already");
            }
            else
            {
                Console.WriteLine("Has not appeared yet.");
            }
            duplicate.Add(name);

        }
        Console.ReadLine();

    }
}
