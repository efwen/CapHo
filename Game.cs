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
        private string playerName = "Recette";
        private int playerID;

        //curPanel contains the controls relevant to the current game state
        private Panel curPanel;
       

        public Game()
        {
            InitializeComponent();
            guildBuySellTabControl.SelectedIndexChanged += GuildBuySellTabControl_SelectedIndexChanged;
        }


        //load the player data for this session
        private void Game_Load(object sender, EventArgs e)
        {
            //log in to the server and make a DBC object
            DBC = new DBConnection("css475sp17-capho.c2b3wqyc8e3g.us-west-2.rds.amazonaws.com",
                                    5432,
                                    "CapHo",
                                    "Recette", "CapitalismHo");
            DBC.OpenConn();

            initModes();
            switchMode(homePanel);
            updateUI();

        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Make sure we close our Database connection before we quit
            DBC.CloseConn();
        }

        //Increment the timer for displaying what day/time of day it is
        private void incrementTimer()
        {
            dayTime++;
            if (dayTime >= dayTimesStr.Length)
            {
                day++;
                daysToNextPayment--;
                dayTime = 0;
            }

            updateUI();
        }

        //update the ui to reflect new data
        private void updateUI()
        {
            merchantLevelLbl.Text = String.Format("Lv. {0}", merchantLevel);
            BalanceLabel.Text = String.Format("${0}", balance);
            debtAmountLbl.Text = String.Format("${0}", debtAmt);
            daysToPaymentLbl.Text = String.Format("{0} days", daysToNextPayment);
            paymentAmtLbl.Text = String.Format("${0}", paymentAmt);

            dayPeriodLbl.Text = String.Format("({0})", dayTimesStr[dayTime]);
            dayNumLbl.Text = day.ToString();
        }

        //switch the game mode (Home, Guild, Shop)
        private void switchMode(Panel switchTo)
        {
            if (curPanel != null)
            {
                curPanel.Visible = false;
                curPanel.Enabled = false;
                curPanel.SendToBack();
            }

            curPanel = switchTo;

            curPanel.Location = new Point(240, 0);
            curPanel.Size = new Size(650, 550);
            curPanel.Visible = true;
            curPanel.Enabled = true;
            curPanel.BringToFront();

            runMode(curPanel);
            updateUI();
        }


        private void initModes()
        {
            initHome();
            initShop();
            initGuild();
        }

        //user swiched to a new mode
        //run some initial logic for the original panel
        private void runMode(Panel modePanel)
        {
            if (modePanel == homePanel)
            {
                runHome();
            }
            else if (modePanel == shopPanel)
            {
                runShop();
            }
            else if (modePanel == guildPanel)
            {
                runGuild();
            }
            else
            {
                MessageBox.Show("Game mode panel not recognized!");
            }
        }



        private void quitGameBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to quit?", "Capitalism, Ho!", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.No)
                return;

            savePlayerState();

            this.Close();
        }


    }
}
