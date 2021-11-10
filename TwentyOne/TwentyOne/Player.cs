using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Player //generic 1 change to Player<T>
    {
        public Player(string name, int beginningBalance)
        {
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;
        }

        public List<Card> Hand { get; set; } //generic 2 change <Card> to <T>public List<
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool  isActivelyPlaying { get; set; }

        public static Game operator+ (Game game, Player player) //Overload Operator..1
        {
            game.Players.Add(player); //Overload Operator..2
            return game;  //Overload Operator..3
        }

        public static Game operator -(Game game, Player player) 

        {
            game.Players.Remove(player);
            return game;
        }
    }
}
