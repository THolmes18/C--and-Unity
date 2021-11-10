using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game //creating it can never instantituated *abstract*(step1)
    {
        private List<Player> _players = new List<Player>(); //players always = empty list not a null.
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
        
        public List<Player> Players { get { return _players; } set { _players = value; } }
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }

        public abstract void Play(); //can only use abstract in a class and method must be implemented (step 2)

        public virtual void ListPlayers() //own implementation (virtual-method is inherited but can be overwritten) step 4
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}

//can only be inherited is abstract class