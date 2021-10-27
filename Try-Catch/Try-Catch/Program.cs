using System;

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


        try
        {

            Console.WriteLine("Pick a number.");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            int userPick = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing by the number you entered...");
            int numberTwo = numberOne / userPick;
            Console.WriteLine(numberOne + " divided by " + userPick + " equals " + numberTwo);
            Console.ReadLine();
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please do not divide by zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
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