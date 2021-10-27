using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsSubmission
{
    class Program
    {
        static void Main(string[] args) //void= return nothing change to interger for a return
        {
            MethodsCreated methodTwo = new MethodsCreated(); //use class named method created and create an object to use the properties throughout

            int input = Convert.ToInt32(Console.ReadLine());

            methodTwo.methodOne(input); //calling method user input for arguement
            Console.ReadLine();


            MethodsCreated methodThree = new MethodsCreated(); //use class named method created and create an object to use the properties throughout

            int input_2 = Convert.ToInt32(Console.ReadLine());

            methodThree.methodTwo(input_2); //calling method user input for arguement
            Console.ReadLine();

            MethodsCreated methodOne = new MethodsCreated(); //use class named method created and create an object to use the properties throughout

            int input_3 = Convert.ToInt32(Console.ReadLine());

            methodOne.methodThree(input_3); //calling method user input for arguement
            Console.ReadLine();

        }
    
      
      

      
    }
}

