using System;
using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
        {

        List<int> intList = new List<int>();
        intList.Add(4);
        intList.Add(10);
        intList.Remove(10);

        Console.WriteLine(intList[0]);
        Console.ReadLine();

        //fixed quanitity you want to grounp together you'll use an array. or storing a large quantity of something.

     

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

        }
    }

