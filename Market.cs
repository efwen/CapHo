using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;

/*
  market.cs
    The Market portion of the Game.
    While in a separate file, it is a partial class
    of Game, since all the components we deal with are
    part of the Game.cs form
*/

namespace CapHo
{
    public partial class Game
    {

        private void returnFromMarket_Click(object sender, EventArgs e)
        {

            //set the panel to home
            switchPanel(homePanel);

            //if something actually transpired, increment the counter
            incrementTimer();
        }
    }
}
