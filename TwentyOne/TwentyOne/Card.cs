using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        public Card() //constructor values assigned to an object upon creation default values given
        {
            Suit = "Spades";
            Face = "Two";
        }
        public string Suit { get; set; } //The card class has a property of data type string called suit and you can get or set this property. Public means other parts of the program can use it as well
        public string Face { get; set; }
    }
}

//Try 1 class to 1 file
//properties = state (suit) get and set only thing you can do
//class is a design for something--a model
//value goes to object
//class= cookie cutter object= cookie