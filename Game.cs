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
        private bool inventoryHasItem(string tableName, int itemID)
        {
            String query = String.Format("select itemID from {0} where itemid = {1};", tableName, itemID);
            return doesQueryHaveResults(query);
        }

        private bool playerHasItem(int itemID)
        {
            return inventoryHasItem("player_inventory", itemID);
        }
        private bool NPCHasItem(int itemID, int npcID)
        {
            String query =          "select itemID\n";
            query +=                "from npc_inventory\n";
            query += String.Format( "where npcID = {0} AND itemID = {1};", npcID, itemID);
            return doesQueryHaveResults(query);
        }
        private bool NPCShopHasItem(int itemID, int npcID)
        {
            String query =          "select itemID\n";
            query +=                "from npcshop_inventory\n";
            query +=                "join npcshop on npcshop.npc_shopid = npcshop_inventory.shopid\n";
            query += String.Format( "where itemID = {0} and npcshop.npc_ownerid = {1};", itemID, npcID);
            return doesQueryHaveResults(query);
        }

        private int  playerInvItemQty(int playerID, int itemID)
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
        private int  NPCShopInvItemQty(int npcID, int itemID, ref bool limited)
        {
            String query;
            query = "select quantity, limited\n";
            query += "from npcshop_inventory\n";
            query += "join npcshop on npcshop.npc_shopid = npcshop_inventory.shopid\n";
            query += String.Format("where npc_ownerid = {0} and itemid = {1}", npcID, itemID);

            DBC.OpenConn();
            if (!DBC.ExecuteQuery(query, ds))
            {
                DBC.CloseConn();
                return -1;
            }

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

        private bool addItemsToPlayerInv(int shopID, int itemID, int quantity)
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
        private bool removeItemsFromPlayerInv(int playerID, int itemID, int removeQty)
        {
            String query;
            bool removeFromDisplay = false;         //if the player runs out of this item, and its in a display, remove from there too
            String removeFromDispQuery = "";
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

                //if the player has the last remaining item in a display, remove it from there too
                removeFromDisplay = true;
                removeFromDispQuery = "remove from display_contents\n";
                removeFromDispQuery += String.Format("where display_contents.d_itemid = {0}\n", itemID);
                removeFromDispQuery += String.Format("and shopid in (select shopid from playershop where ownerid = {0});", playerID);

                DBC.OpenConn();
                if (!DBC.ExecuteQuery(removeFromDispQuery, ds))
                {
                    DBC.CloseConn();
                    return false;
                }
                DBC.CloseConn();

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

        private bool addItemsToNPCShopInv(int npcID, int itemID, int addQty)
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
        }
        private bool removeItemsFromNPCShopInv(int npcID, int itemID, int removeQty)
        {
            String query = "";
            bool ltd = false;
            int NPCShopQty = NPCShopInvItemQty(npcID, itemID, ref ltd);


            if (ltd && (NPCShopQty < 0))
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

        //get the next available id number for inserting into a table
        private int getNextAvailID(String tableName)
        {
            String attrName;
            
            switch (tableName)
            {
                case "player_character":
                    attrName = "playerid";
                    break;
                case "npc":
                    attrName = "npcid";
                    break;
                case "item":
                    attrName = "itemid";
                    break;
                case "item_type":
                    attrName = "index";
                    break;
                case "npcshop":
                    attrName = "npc_shopid";
                    break;
                case "playershop":
                    attrName = "shopid";
                    break;
                case "shop_display":
                    attrName = "displaynum";
                    break;
                case "shop_transaction":
                    attrName = "transactionid";
                    break;
                default:
                    return -2;
            }


            String query = String.Format("select MAX({0}) from {1};", attrName, tableName);

            DBC.OpenConn();

            if (!DBC.ExecuteQuery(query, ds))
            {
                DBC.CloseConn();
                return -1;
            }
            
            DBC.CloseConn();
            return (int)ds.Tables[0].Rows[0].ItemArray[0] + 1;
        }

        private bool performNPCShopBuyTransaction(int npcID, int playerID, int itemID, int quantity)
        {
            //figure out how much the item costs so we can test if we can afford it
            String query =  "select baseprice\n";
            query += "from item\n";
            query += String.Format("where item.itemid = {0}", itemID);

            DBC.OpenConn();

            if (!DBC.ExecuteQuery(query, ds))
            {
                DBC.CloseConn();    //query failed
                return false;
            }

            DBC.CloseConn();

            int itemprice = (int)ds.Tables[0].Rows[0].ItemArray[0];
            int totalprice = itemprice * quantity;

            //check if the player has enough money
            if (balance < totalprice)
            {
                MessageBox.Show("You don't have enough money for that!");
                return false;
            }


            //remove/add
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
            //get a new transaction id
            int newTransID = getNextAvailID("shop_transaction");

            if (newTransID < 0)
                return false;

            query =                 "insert into shop_transaction\n";
            query += String.Format( "select {0}, 1, npcshop.npc_shopid, {1}, item.itemid, {2}, item.baseprice, {3}, {4}\n",
                                    newTransID, playerID, quantity, day, dayTime);
            query +=                "from npcshop\n";
            query +=                "join npcshop_inventory on npcshop.npc_shopid = npcshop_inventory.shopid\n";
            query +=                "join item on npcshop_inventory.itemid = item.itemid\n";
            query += String.Format( "where npcshop.npcID = {0} and item.itemid = {1};", npcID, itemID);


            
            //charge the player money
            balance -= (int)totalprice;
            //force a player state update
            savePlayerState();
            return true;
        }


        private bool performPlayerShopSellTransaction(int npcID, int playerID, int itemID, int price)
        {
            //remove from player inventory, if it is on display remove it there too
            if(!removeItemsFromPlayerInv(playerID, itemID, 1))
            {
                MessageBox.Show("Could not remove items from player");
                return false;
            }

            //add money to player balance
            balance += price;
            savePlayerState();
            return true;
        }

        private bool alterCustomerRelationship(int npcID, int amt)
        {
            String query = "update customer\n";
            if (amt < 0)
            {
                query += String.Format("set relationship = relationship - {0}\n", Math.Abs(amt));
                query += String.Format("where n_npcid = {0}\n", npcID);
                query += String.Format("and n_npcid in (select n_npcid from customer where relationship > {0});", Math.Abs(amt));
            }
            else
            {
                query += String.Format("set relationship = relationship + {0}\n", amt);
                query += String.Format("where n_npcid = {0};", npcID);
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
