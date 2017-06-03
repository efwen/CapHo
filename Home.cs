using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Drawing;
using System.Windows.Forms;
/*
  Home.cs
    The Home portion of the Game.
    While in a separate file, it is a partial class
    of Game, since all the components we deal with are
    part of the Game.cs form
*/
namespace CapHo
{
    public partial class Game
    {
        const uint paymentCycleSize = 2;
        uint daysToNextPayment;
        int paymentAmt;

        int balance;            //get from db every time?
        int merchantLevel;
        int debtAmt;

        private readonly string[] dayTimesStr = { "Morning", "Midday", "Afternoon", "Night" };
        private uint dayTime = 0;
        private uint day = 1;

        //retrieve and process initial data for Home
        private void initHome()
        {

            String query = String.Format("SELECT * FROM {0} WHERE name=\'{1}\'", TableName, playerName);

            if(!DBC.ExecuteQuery(query, ds))
            {
                MessageBox.Show("Failed to get player data!");
                this.Close();
                return;
            }


            if (ds.Tables.Count != 0)
            {
                dt = ds.Tables[0];
                DataRow row = (ds.Tables[0].Rows[0]);

                playerID = (int)row.ItemArray[0];
                playerNameLbl.Text = (String)row.ItemArray[1];

                balance = (int)row.ItemArray[4];
                BalanceLabel.Text = String.Format("${0}", row.ItemArray[4]);

                merchantLevel = (int)row.ItemArray[3];
                merchantLevelLbl.Text = String.Format("Lv. {0}", row.ItemArray[3]);

                debtAmt = (int)row.ItemArray[5];                
            }
            else
            {
                MessageBox.Show("Failed to load player data!");
                this.Close();
            }

            //set the UI elements to match the data
            dayPeriodLbl.Text = String.Format("({0})", dayTimesStr[dayTime]);
            dayNumLbl.Text = day.ToString();

            daysToNextPayment = paymentCycleSize;
            daysToPaymentLbl.Text = daysToNextPayment.ToString();

            paymentAmt = merchantLevel * 1000;
            paymentAmtLbl.Text = paymentAmt.ToString();

            updateUI();
        }

        //This function runs the main game state logic
        //determining if the player won, calculating debt and
        //if a payment is due, etc.
        private void runHome()
        {
            //things we do here:
            //check if payment is due
            if (daysToNextPayment <= 0)
            {
                MessageBox.Show("Time for a payment!");

                //check if we can subtract amt due from balance
                if(paymentAmt < balance)
                {
                    balance -= (int)paymentAmt;
                    debtAmt -= paymentAmt;
                    //save state
                    
                    //reset the paymennt timer
                    daysToNextPayment = paymentCycleSize;
                    merchantLevel++;
                    paymentAmt = (merchantLevel) * 1000;


                    //check if we won
                    if (debtAmt <= 0)
                    {
                        MessageBox.Show("Congratulations! You won!");
                    }
                }
                else
                {
                    MessageBox.Show("Game over!");

                    this.Close();
                }
            }

            savePlayerState();

            if(debtAmt <= 0)
            {
                MessageBox.Show("You win!");
            }
        }

        //save the player state to the DB
        private void savePlayerState()
        {
            String query = "update player_character\n";
            query += String.Format("set merchantlevel = {0}, currentbalance = {1}, currentdebt = {2}", merchantLevel, balance, debtAmt);
            query += String.Format("where playerid = {0};", playerID);
            DBC.ExecuteQuery(query, ds);   
        }

        //go to the shop mode
        private void openShop_Click(object sender, EventArgs e)
        {
            switchMode(shopPanel);
        }

        private void buyFromGuild_Click(object sender, EventArgs e)
        {
            switchMode(guildPanel);
        }
    }
}
