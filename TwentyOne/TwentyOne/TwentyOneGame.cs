using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame : Game
    {
       public override void Play() //implement add overide (step3 somewhat)
        {
            throw new NotImplementedException(); //catch against accidental call until defined
        }
        public override void ListPlayers() //step 5
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();
        }
    }
}
