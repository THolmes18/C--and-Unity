﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        public Deck() //constructor ALWAYS goes on top before property //method called as soon as object is created

        {
            Cards = new List<Card>();
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach (string face in Faces)  //loop through each face 4 times1 for each suit (nested foreach loop)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card(); //when loop ends theis variable does not exist
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }

        }
        public List<Card> Cards { get; set; } //property

        public void Shuffle(int times = 1) //static (which would go after public) calls method w/o applying to specific deck
        {
        
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                this.Cards = TempList; //this means it is referring to itself; its own object
            }
        
        }
    }
}

//Constructor method is always the same name as the class it is in.
//deck has 13 faces and 4 suits = 52 cards
//always have to create a list