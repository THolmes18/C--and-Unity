using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway 
    {
        public TwentyOneDealer Dealer { get; set; }
        public override void Play() //implement add overide 
        {
            Dealer = new TwentyOneDealer();
            foreach (Player player in Players)
            {

            }
        }
        public override void ListPlayers() //step 5
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();
        }
        public void WalkAway(Player player) //implementing
        {
            throw new NotImplementedException();
        }
    }
}
