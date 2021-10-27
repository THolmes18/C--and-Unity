using System;

    class Program
    {
        static void Main(string[] args)
        {
        try
        {
            Console.WriteLine("Pick a number.");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a second number.");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing the two...");
            int numberThree = numberOne / numberTwo;
            Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
            Console.ReadLine();
        }
       catch (FormatException ex) //only catching format exception and assigning it the "ex" variable.
        {
            Console.WriteLine(ex.Message); //can change ex.message can customize it and add personal message.
            return;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally //will always run and have a database
        {
            Console.ReadLine(); //guarantees this is called.
        }
        Console.ReadLine();
        }
    }

//Use to help avoid user error. Insert the information into try and place inside brackers.
//try catch blocks
//can write custome messages and log errors