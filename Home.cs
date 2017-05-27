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
        const int paymentCycleSize = 2;
        int daysToNextPayment;
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
            DBC.OpenConn();

            String query = String.Format("SELECT * FROM {0} WHERE name=\'{1}\'", TableName, playerName);
            DBC.ExecuteQuery(query, ds);


            if (ds.Tables.Count != 0)
            {
                dt = ds.Tables[0];
                DataRow row = (ds.Tables[0].Rows[0]);
                
                
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
                DBC.CloseConn();
                this.Close();
            }

            DBC.CloseConn();

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
                    balance -= paymentAmt;
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
                    //what do we do in game over? 
                    //recettear resets to just after the last payment was due.
                    //does this mean we save all the transactions since last payment
                    //and restore the state to then?

                    //restore state

                    //this.Close();
                }
            }
            else
            {

            }


            savePlayerState();
            //if total due <0
            //you win!

            //get new payment amount
            //reset days to next payment
        }


        private void savePlayerState()
        {
            DBC.OpenConn();




            DBC.CloseConn();
        }

        private void openShop_Click(object sender, EventArgs e)
        {
            //deactivate the other actions
            buyFromGuild.Enabled = false;
            goToMarket.Enabled = false;
            //open shop and do stuff


            switchMode(shopPanel);
            //once we're done, increment the daily timer

            //reactivate actions
            buyFromGuild.Enabled = true;
            goToMarket.Enabled = true;
        }

        private void buyFromGuild_Click(object sender, EventArgs e)
        {
            switchMode(guildPanel);
            refreshGuildTab(guildBuySellTabControl.SelectedTab);
        }

        private void goToMarket_Click(object sender, EventArgs e)
        {
            switchMode(marketPanel);
        }
    }
}
