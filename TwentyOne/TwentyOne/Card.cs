using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public struct Card
    {
         public Suit Suit { get; set; } //The card class has a property of data type string called suit and you can get or set this property. Public means other parts of the program can use it as well
         public Face Face { get; set; }
    }
    
    public enum Suit //defining ENUM
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Jack,
        Queen,
        King,
        Ace
    }
}

//Try 1 class to 1 file
//properties = state (suit) get and set only thing you can do
//class is a design for something--a model
//value goes to object
//class= cookie cutter object= cookie