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
        private uint playerID;

        //curPanel contains the controls relevant to the current game state
        private Panel curPanel;



        public Game()
        {
            InitializeComponent();
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

            initModes();
            switchMode(homePanel);
            updateUI();
        }

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


        private void switchMode(Panel switchTo)
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

            runMode(curPanel);
            updateUI();
        }


        private void initModes()
        {
            initHome();
            initShop();
            initGuild();
            initMarket();
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
            else if (modePanel == marketPanel)
            {
                runMarket();
            }
            else
            {
                MessageBox.Show("Game mode panel not recognized!");
            }
        }


        //Commonly used queries
        private bool doesQueryHaveResults(string query)
        {
            DBC.OpenConn();
            DBC.ExecuteQuery(query, ds);
            if (ds.Tables.Count != 0)
            {
                if (ds.Tables[0].Rows.Count > 0)       //rows mean the item exists
                {
                    DBC.CloseConn();
                    return true;
                }
                else //query has rows
                {
                    DBC.CloseConn();
                    return false;
                }

            }

            DBC.CloseConn();
            return false;

        }
        private bool inventoryHasItem(string tableName, uint itemID)
        {
            String query = String.Format("select itemID from {0} where itemid = {1};", tableName, itemID);
            return doesQueryHaveResults(query);
        }

        private bool playerHasItem(uint itemID)
        {
            return inventoryHasItem("player_inventory", itemID);
        }
        private bool NPCHasItem(uint itemID, uint npcID)
        {
            String query =          "select itemID\n";
            query +=                "from npc_inventory\n";
            query += String.Format( "where npcID = {0} AND itemID = {1};", npcID, itemID);
            return doesQueryHaveResults(query);
        }
        private bool NPCShopHasItem(uint itemID, uint npcID)
        {
            String query =          "select itemID\n";
            query +=                "from npcshop_inventory\n";
            query +=                "join npcshop on npcshop.npc_shopid = npcshop_inventory.shopid\n";
            query += String.Format( "where itemID = {0} and npcshop.npc_ownerid = {1};", itemID, npcID);
            return doesQueryHaveResults(query);
        }

        private int  playerInvItemQty(uint playerID, uint itemID)
        {
            String query;
            query = "select quantity\n";
            query += "from player_inventory\n";
            query += "join playershop on playershop.shopid = player_inventory.shopid\n";
            query += String.Format("where ownerid = {0} and itemid = {0}", playerID, itemID);


            DBC.OpenConn();
            DBC.ExecuteQuery(query, ds);
            if (ds.Tables.Count != 0)
            {
                if (ds.Tables[0].Rows.Count > 0)       //rows mean the item exists
                {
                    DBC.CloseConn();
                    return (int)ds.Tables[0].Rows[0].ItemArray[0];
                }
                else
                {
                    DBC.CloseConn();
                    return -1;
                }

            }

            DBC.CloseConn();
            return -1;
        }
        private int  NPCShopInvItemQty(uint npcID, uint itemID, ref bool limited)
        {
            String query;
            query = "select quantity, limited\n";
            query += "from npcshop_inventory\n";
            query += "join npcshop on npcshop.npc_shopid = npcshop_inventory.shopid\n";
            query += String.Format("where npc_ownerid = {0} and itemid = {0}", npcID, itemID);

            DBC.OpenConn();
            DBC.ExecuteQuery(query, ds);
            if (ds.Tables.Count != 0)
            {
                if (ds.Tables[0].Rows.Count > 0)       //rows mean the item exists
                {
                    DBC.CloseConn();
                    limited = (bool)ds.Tables[0].Rows[0].ItemArray[1];  //set limited
                    return (int)ds.Tables[0].Rows[0].ItemArray[0];      //return qty avail
                }
                else
                {
                    DBC.CloseConn();
                    return -1;
                }

            }

            DBC.CloseConn();
            return -1;
        }

        private bool addItemsToPlayerInv(uint shopID, uint itemID, uint quantity)
        {
            String query;
            if(playerHasItem(itemID))
            {
                //update operation only
                query =                 "update player_inventory\n";
                query += String.Format( "set quantity = quantity + {0}\n", quantity);
                query += String.Format("where player_inventory.shopid = {0} and player_inventory.itemid in\n", shopID);
                query +=                "(select pi.itemid\n";
                query +=                "from player_inventory as pi\n";
                query += String.Format( "where pi.itemid = {0});", itemID);
            }
            else
            {
                //insert operation
                query =                "insert into player_inventory\n";
                query += String.Format("values ({0}, {1}, {2});", shopID, itemID, quantity);
            }

            DBC.OpenConn();

            if(!DBC.ExecuteQuery(query, ds))
            {
                DBC.CloseConn();
                return false;
            }

            DBC.CloseConn();
            return true;
        }
        private bool removeItemsFromPlayerInv(uint playerID, uint itemID, uint removeQty)
        {
            String query;
            int curQty = playerInvItemQty(playerID, itemID);
            if (curQty > removeQty)  //we have more than we want to remove
            {
                //update operation only
                query =                 "update player_inventory\n";
                query += String.Format( "set quantity = quantity - {0}\n", removeQty);
                query +=                "where player_inventory.itemid in\n";
                query +=                "(select pi.itemid\n";
                query +=                "from player_inventory as pi\n";
                query +=                "join playershop on playershop.shopid = pi.shopid\n";
                query += String.Format( "where pi.itemid = {0} and playershop.playerid = {1});", itemID, playerID);
            }
            else if(curQty == removeQty)
            {
                //remove operation
                query = "remove from player_inventory\n";
                query += String.Format("where player_inventory.shopid = {0} and player_inventory.itemid = {1};", playerID, itemID);
            }
            else
            {
                //invalid
                MessageBox.Show("You don't have enough!");
                return false;
            }

            DBC.OpenConn();

            if (!DBC.ExecuteQuery(query, ds))
            {
                DBC.CloseConn();
                return false;
            }

            DBC.CloseConn();
            return true;
        }

        private bool addItemsToNPCShopInv(uint npcID, uint itemID, uint addQty)
        {
            String query = "";
            bool ltd = false;
            int NPCShopQty = NPCShopInvItemQty(npcID, itemID, ref ltd);

            if (NPCShopQty > 0)
            {

                if (ltd)
                {
                    query =                 "update npcshop_inventory\n";
                    query += String.Format( "set quantity = quantity - {0}\n", addQty);
                    query +=                "where npcshop_inventory.itemid in\n";
                    query +=                "(select npci.itemid\n";
                    query +=                "from npcshop_inventory as npci\n";
                    query +=                "join npcshop on npcshop.shopid = npci.shopid\n";
                    query += String.Format( "where npci.itemid = {0} and npcshop.npc_ownerid = {1});", itemID, npcID);
                }
                else
                {
                    //don't need to do anything
                    return true;
                }
            }
            else
            {
                //we need to add a new row
                query =                 "insert into npcshop_inventory\n";
                query += String.Format( "select npcshop.npc_shopid, {0}, {1}, {2}\n", itemID, ltd, addQty);        
                query +=                "from npcshop\n";
                query += String.Format( "where npcshop.npc_ownerid = {0};", npcID);
            }


            DBC.OpenConn();

            if (!DBC.ExecuteQuery(query, ds))
            {
                DBC.CloseConn();
                return false;
            }

            DBC.CloseConn();
            return true;


            return false;
        }
        private bool removeItemsFromNPCShopInv(uint npcID, uint itemID, uint removeQty)
        {
            String query = "";
            bool ltd = false;
            int NPCShopQty = NPCShopInvItemQty(npcID, itemID, ref ltd);

            
            if (NPCShopQty < 0)
                return false;       //NPCShop does not contain the item

            if (ltd)
            {
                if (removeQty > NPCShopQty)
                {
                    return false;           //not enough items in npc inventory!
                }
                else if(removeQty == NPCShopQty)
                {
                    //remove entry
                    query =                 "remove from npcshop_inventory\n";
                    query +=                "join npcshop on npcshop_inventory.shopid = npcshop.shopid\n";
                    query += String.Format( "npcid = {0} and itemid = {1};", npcID, itemID);
                }
                else
                {
                    //update w/ increase
                    query =                 "update npcshop_inventory\n";
                    query += String.Format( "set quantity = quantity - {0}\n", removeQty);
                    query +=                "where npcshop_inventory.itemid in\n";
                    query +=                "(select npci.itemid\n";
                    query +=                "from npcshop_inventory as npci\n";
                    query +=                "join npcshop on npcshop.shopid = npci.shopid\n";
                    query += String.Format( "where npci.itemid = {0} and npcshop.npcid = {1});", itemID, npcID);
                }
            }
            else //if quantity is unlimited we don't need to do anything
            {
                return true;
            }


            DBC.OpenConn();

            if (!DBC.ExecuteQuery(query, ds))
            {
                DBC.CloseConn();
                return false;
            }

            DBC.CloseConn();
            return true;
        }
        private bool removeItemFromNPCInv(uint npcID, uint itemID)
        {
            return false;
        }


        private bool performShopBuyTransaction(uint npcID, uint playerID, uint itemID, uint quantity)
        {
            if (!removeItemsFromNPCShopInv(npcID, itemID, quantity))
            {
                MessageBox.Show("Could not remove items from NPC shop!");
                return false;
            }

            if(!addItemsToPlayerInv(playerID, itemID, quantity))
            {
                MessageBox.Show("Could not put items in Player inventory!");
                //put the items back into the npc shop
                if(!addItemsToNPCShopInv(npcID, itemID, quantity))
                {
                    MessageBox.Show("Could not restore items to npc shop inventory!");
                }
                return false;
            }


            //make a transaction record
            //whats the best transaction id we can use?
            uint transactionid = 400;  //get maybe with a MAX()
            uint transactionType = 3;   ///unsure about this, 3 = purchase from npc shop
            uint markup = 0; /* some formula */

            String query = "insert into shop_transaction\n";
            query += String.Format("values({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8});",
                                    transactionid, transactionType, /*shopid*/4, playerID, itemID,
                                    quantity, /*transactionAmt*/, day, dayTime);
            // "select {0}, {1}, npcshop.shopid, {2}, {3}, {4}, item.baseprice * markup, {5}, {6}\n"
            // "from npcshop
            // "join npcshop_inventory on shopid
            // "join item on itemid
            // "where npcshop.npcID = {0}", npcID
            //NOT DONE
            /////////////////
            //////////////////
            ////////////////

            return true;
        }
        //might not need this
        private bool addtemToNPCShop(int itemID)
        {
            return false;
        }



        private bool addItemToNPCInv(int itemID)
        {
            return false;
        }

    }
}
