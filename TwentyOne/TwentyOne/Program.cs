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

            Game game = new TwentyOneGame(); //overload operators..5
            game.Players = new List<Player>(); //overload operators..8 instantuate.
            Player player = new Player(); //overload operators..6
            game = game + player; //method in a sense overload operators..7 game += player; is a shortcut
            player.Name = "T'Ana";
            game = game - player;

            //TwentyOneGame game = new TwentyOneGame(); //step 6 of abstract
            //game.Players = new List<string>() { "T'Ana", "Ha'Mil", "Holmes" };
            //game.ListPlayers();
            
            
            Console.ReadLine();

            //******Card card = new Card() { Face = "King", Suit = "Spades" }; //object initialization
            //List<Game> games = new List<Game>(); //POLYMORPHISM step 2
            //Game game = new TwentyOneGame();//POLYMORPHISM (this is all it is) STEP 1
            //games.Add(game); //step 3 POLYMORPHISM
            ////POLYMORPHISM is the ability of a class to morph into its inheriting class.

            Game game = new Game(); //if this was TwentyOneGame game = new TwentyOneGame then we can access Play
            game.Players = new List<string>() { "T'Ana", "Holmes", "Ha'Mil" };
            game.ListPlayers();
            game.Play();
            Console.ReadLine(); //super class method--call method from class you inheritent from (game)

            //    Game game = new Game();
            //game.Dealer = "T'Ana";
            //game.Name = "TwentyOne"; 
            //Deck deck = new Deck();
            //deck.Shuffle(3);//shuffle is the method, we're calling it to shuffle on itself
            ////deck = Shuffle(deck); //reassigning variable makes it shuffle (comment it out and it will stop shuffle)
            
            //foreach(Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}

            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();
        }

       
            
          
        }

        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }


//deck uses constructor which is a default
//method has to be used apart of a class (shuffling)
//static object program should be created if not use static
//overload method helps when sharing

//inherit keeps you from repeating code