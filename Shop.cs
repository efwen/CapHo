﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

using Npgsql;

/*
  Shop.cs
    The Shop portion of the Game.
    While in a separate file, it is a partial class
    of Game, since all the components we deal with are
    part of the Game.cs form
*/

namespace CapHo
{

    public partial class Game
    {
        private void runShop()
        {
            MessageBox.Show("a thing");
            MessageBox.Show("another thing");

            //set the panel to home
            switchPanel(homePanel);

            //if something actually transpired, increment the counter
            incrementTimer();
        }
    }
}