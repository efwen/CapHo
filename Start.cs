using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Npgsql;

namespace CapHo
{
    public partial class Start : Form
    {
        private Game game = new Game();
        private Editor editor = new Editor();
        public Start()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            (new Game()).Show();
        }

        private void DBEditButton_Click(object sender, EventArgs e)
        {
            (new Editor()).Show();
        }
    }
}
