using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapHo
{
    public partial class Game : Form
    {
        //General Game data
        private DBConnection DBC;

        private DataTable dt = new DataTable();
        private string TableName = "player_character";
        private string playerName = "Bob";

        private readonly string[] dayTimesStr = {"Morning", "Midday", "Afternoon", "Night"};
        private uint dayTime = 0;
        private uint day = 1;

        //curPanel contains the controls relevant to the current game state
        private Panel curPanel;                
        
        
        //Game Panel Data
        
        //Open Shop Panel Data


        public Game()
        {
            InitializeComponent();
            switchPanel(homePanel);

            //
            guildBuySellTabControl.SelectedIndexChanged += GuildBuySellTabControl_SelectedIndexChanged;
            guildBuyDGV.RowHeaderMouseDoubleClick += GuildBuyDGV_RowHeaderMouseDoubleClick;
        }







        //load the player data for this session
        private void Game_Load(object sender, EventArgs e)
        {
            //log in to the server and make a DBC object
            DBC = new DBConnection("css475sp17-capho.c2b3wqyc8e3g.us-west-2.rds.amazonaws.com",
                                    5432,
                                    "CapHo",
                                    "Recette", "CapitalismHo");
            //update the UI to reflect the DB
            updateUI();
        }

        private void openShop_Click(object sender, EventArgs e)
        {
            //deactivate the other actions
            buyFromGuild.Enabled = false;
            goToMarket.Enabled = false;
            //open shop and do stuff


            switchPanel(shopPanel);
            runShop();
            //once we're done, increment the daily timer

            //reactivate actions
            buyFromGuild.Enabled = true;
            goToMarket.Enabled = true;
        }

        private void incrementTimer()
        {
            dayTime++;
            if(dayTime >= dayTimesStr.Length)
            {
                day++;
                dayTime = 0;
            }

            updateUI();
            //dayPeriodLbl.Text = String.Format("({0})", dayTimesStr[dayTime]);
        }

        private void updateUI()
        {
            //Set up the UI data to reflect the database
            DBC.OpenConn();

            String query = String.Format("SELECT * FROM {0} WHERE name=\'{1}\'", TableName, playerName);
            DBC.ExecuteQuery(query, ds);


            if (ds.Tables.Count != 0)
            {
                dt = ds.Tables[0];
                DataRow row = (ds.Tables[0].Rows[0]);
                BalanceLabel.Text = String.Format("${0:0.00}", row.ItemArray[5]);
            }
            else
            {
                MessageBox.Show("Failed to load player data!");
                DBC.CloseConn();
                this.Close();
            }

            DBC.CloseConn();

            dayPeriodLbl.Text = String.Format("({0})", dayTimesStr[dayTime]);
            dayNumLbl.Text = day.ToString();
            
            //update the current panel
        }


        private void switchPanel(Panel switchTo)
        {
            if (curPanel != null)
            {
                curPanel.Visible = false;
                curPanel.Enabled = false;
                curPanel.SendToBack();
            }

            curPanel = switchTo;

            curPanel.Location = new Point(226, 9);
            curPanel.Visible = true;
            curPanel.Enabled = true;
            curPanel.BringToFront();
        }

        private void buyFromGuild_Click(object sender, EventArgs e)
        {
            switchPanel(guildPanel);
            refreshGuildTab(guildBuySellTabControl.SelectedTab);
        }




    }
}
