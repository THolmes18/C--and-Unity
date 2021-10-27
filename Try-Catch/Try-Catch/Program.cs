using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Press any number to begin.");
        List<int> rNumbers = new List<int>() { 20, 40, 60, 80, 100, 120 };
        int userPick = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Pick a number.");
        int numberOne = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("And another number..");
        int numberTwo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Dividing by the number you entered...");
        int numberThree = numberOne / numberTwo;
        Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
        Console.ReadLine();

        

        
        try //block of code to try
        {
            foreach (int i in rNumbers)
            {
                    Console.WriteLine(i / userPick); 
            }
            Console.WriteLine("The list has been divided by the number chosen.");
            Console.ReadLine();

        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }
        catch (DivideByZeroException ex) //block of code to handle errors
        {
            Console.WriteLine("Please do not divide by zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Uh-oh! Something went wrong!");
        }
        finally //executes always
        {
            Console.ReadLine();
        }
    }
}








//}
//catch (FormatException ex) //only catching format exception and assigning it the "ex" variable.
//{
//    Console.WriteLine(ex.Message); //can change ex.message can customize it and add personal message.
//    return;
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine("Please don't divide by zero.");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//finally //will always run and have a database
//{
//    Console.ReadLine(); //guarantees this is called.
//}
//Console.ReadLine();
//        }
//    }

//Use to help avoid user error. Insert the information into try and place inside brackers.
//try catch blocks
//can write custome messages and log errors