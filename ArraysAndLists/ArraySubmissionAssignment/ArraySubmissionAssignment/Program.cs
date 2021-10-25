using System;
using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
        {

        int[]yearArray = new int[5];  //declaring array
        yearArray[0] = 1996;
        yearArray[1] = 2015;
        yearArray[2] = 2018;
        yearArray[3] = 2019;
        yearArray[4] = 2020;

        yearArray[4] = 2019;

        string[] lifeLine = { "Born", "Graudated HS", "Graduated College", "Had a Daughter", "Had a Son" };

        Console.WriteLine(yearArray[4]);
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
////another shortcute

//int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

//numArray2[5] = 650; //targeting a certain array

//Console.WriteLine(numArray2[5]);
//Console.ReadLine();
