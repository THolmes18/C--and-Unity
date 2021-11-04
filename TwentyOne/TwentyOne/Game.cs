using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game //creating it can never instantituated *abstract*(step1)
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

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