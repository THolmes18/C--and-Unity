﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Dealer

    {
        public string Name { get; set; } //property
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand) //Method
        {
            Hand.Add(Deck.Cards.First()); //hand is a list Deck is composed of cards its a property and first is a method available to a list takes first item.
            Console.WriteLine(Deck.Cards.First().ToString() + "\n"); //Writing to the console the card that I'm putting into the deck
            Deck.Cards.RemoveAt(0); 
        }
    }
}

//if it is a... then inherit if it has a (deck) then include it as a class property. unsure then put it in as a propety