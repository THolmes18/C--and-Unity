using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Card cardOne = new Card(); //object of datatype card assigned to variable.
            //cardOne.Face = "Queen"; //assigned string queen to property face of card one
            //cardOne.Suit = "Spades";


            Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);
            Console.ReadLine();
        }
    }
}
