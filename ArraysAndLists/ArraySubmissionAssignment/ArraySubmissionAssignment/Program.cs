using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        string[] stringArray = { "Hello!", "How's it going?", "Who are you?", "Where are you located?" }; //stringArray object
        Console.WriteLine("Please select a number (0-3)."); //asking the users
        int userInput = Convert.ToInt32(Console.ReadLine()); //Users input set to a variable.

        if (userInput <= 3 && userInput >= 0)
        {
            Console.WriteLine(stringArray[userInput]); //user display index value

        }
        else
        {
            Console.WriteLine("Value doesn't exist at index.");
        }
        Console.ReadLine();

        int[] numArray = new int[] { 10, 20, 40, 60, 80 };
        Console.WriteLine("Please select a number (0-4).");
        int userSelection = Convert.ToInt32(Console.ReadLine());

        if (userSelection <=4 && userSelection >= 0)
        {
            Console.WriteLine(numArray [userSelection]);
        }
        else
        {
            Console.WriteLine("Selected index does not exist.");
        }
        
        Console.ReadLine();
        
        
        
        

    }
}

//List<int> intList = new List<int>();
//intList.Add(4);
//intList.Add(10);
//intList.Remove(10);

//Console.WriteLine(intList[0]);
//Console.ReadLine();

////int[] numArray = new int[5];  //declaring array
////numArray[0] = 5;
////numArray[1] = 2;
////numArray[2] = 10;
////numArray[3] = 200;
////numArray[4] = 5000;

////shortcut
////int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };
////another shortcut

//int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

//numArray2[5] = 650; //targeting a certain array

//Console.WriteLine(numArray2[5]);
//Console.ReadLine();
