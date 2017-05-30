using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

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
        private bool shopOpened = false;
        private const int maxCustomers = 4;
        List<ShopDisplay> SDs = new List<ShopDisplay>();
        int shopID;
        //retrieve and process initial data for Shop
        private void initShop()
        {
            //get our shopid
            String shopIDQuery = String.Format("select shopid from playershop where ownerid = {0}", playerID);
            DBC.OpenConn();

            DBC.ExecuteQuery(shopIDQuery, ds);

            if(ds.Tables[0].Rows.Count != 0)
            {
                shopID = (int)ds.Tables[0].Rows[0].ItemArray[0];
            }
            else
            {
                MessageBox.Show("Error retrieving shopID!");
            }
            DBC.CloseConn();
        }

        private void runShop()
        {
            shopOpened = false;
            setupDisplays();
        }

        private void openShop()
        {
            shopOpened = true;
            int customerCount = 0;
            int curBuyNpc = -1;
            
            while (customerCount < maxCustomers)
            {
                //1. choose a random NPC
                curBuyNpc = getRandomCustomer();
                if(curBuyNpc < 0)
                {
                    MessageBox.Show("Error finding an npc for your shop!");
                    return;
                }

                //2. pick a random item to buy
                //   ---must be an item on display
                int curItem = getRandomItemOnDisplay(playerID);
                if(curItem < 0)
                {
                    MessageBox.Show("No items on display! Cannot sell to customers!");
                    return;
                }

                //3. Haggle for a price
                HaggleSell hsWin = new HaggleSell(DBC, curBuyNpc, curItem);
                hsWin.ShowDialog();
                
                if(hsWin.finalPrice > 0)
                {
                    performPlayerShopSellTransaction(curBuyNpc, playerID, curItem, hsWin.finalPrice);
                    alterCustomerRelationship(curBuyNpc, 1);
                    //increase relationship
                }
                else if (hsWin.finalPrice < 0)
                {
                    //bad result, customer angry
                    alterCustomerRelationship(curBuyNpc, -1);
                }
                else //finalprice == 0
                {
                    //nothing happened, user quit out
                }

                customerCount++;
            }
        }

        private void runOpenShopBtn_Click(object sender, EventArgs e)
        {
            openShop();
        }

        private void configDisplayBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented!");
        }

        private void retHomeBtn_Click(object sender, EventArgs e)
        {
            //if something actually transpired, increment the counter
            if(shopOpened)
            {
                incrementTimer();
            }
            

            //set the panel to home
            switchMode(homePanel);
        }

        //bool sell -> are we selling the item? or buying?
        //return success/fail
        private bool testPrice(int price, int itemID, int customerID, bool sell)
        {
            return false;
        }


        //returns a random npc customer for the purposes of haggling
        //returns -1 if error
        private int getRandomCustomer()
        {
            String query = "select *\n";
            query += "from customer\n";


            DBC.OpenConn();

            if(!DBC.ExecuteQuery(query, ds))
            {
                MessageBox.Show("Failed to execute query \"" + query + "\"");
                return -1;
            }

            if (ds.Tables.Count != 0)
            {
                if (ds.Tables[0].Rows.Count > 0)       //rows mean the item exists
                {
                    Random rnd = new Random();
                    int randomIndex = rnd.Next(0, ds.Tables[0].Rows.Count - 1);


                    DBC.CloseConn();
                    return (int)ds.Tables[0].Rows[randomIndex].ItemArray[0];      //return npc
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

        //returns a random itemid currently on display in the shop
        //returns -1 if no item found, or error
        private int getRandomItemOnDisplay(int playerID)
        {
            String query;
            query = "select d_itemid\n";
            query += "from display_contents\n";
            query += "join playershop on display_contents.shopid = playershop.shopid\n";
            query += String.Format("where ownerid = {0}", playerID);

            DBC.OpenConn();

            if (!DBC.ExecuteQuery(query, ds))
            {
                MessageBox.Show("Failed to execute query \"" + query + "\"");
                return -1;
            }

            if (ds.Tables.Count != 0)
            {
                if (ds.Tables[0].Rows.Count > 0)       //rows mean the item exists
                {
                    Random rnd = new Random();
                    int randomIndex = rnd.Next(0, ds.Tables[0].Rows.Count - 1);


                    DBC.CloseConn();
                    return (int)ds.Tables[0].Rows[randomIndex].ItemArray[0];      //return npc
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

        private void setupDisplays()
        {
            //find the number of displays we need and fill them
            String query = "select COUNT(*)\n";
            query += "from shop_display\n";
            query += String.Format("where shopid = {0};", shopID);

            DBC.OpenConn();

            if (!DBC.ExecuteQuery(query, ds))
            {
                MessageBox.Show("Failed to load shop displays!");
                DBC.CloseConn();
                return;
            }

            DBC.CloseConn();
          
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Failed to load shop displays!");
                DBC.CloseConn();
                return;
            }
            else
            {
                if (SDs.Count == 0)
                {
                    int count = Int32.Parse(ds.Tables[0].Rows[0].ItemArray[0].ToString());
                    for (int i = 0; i < count; i++)
                    {
                        SDs.Add(new ShopDisplay(DBC, shopID, i));
                        SDs[i].Location = new Point(50, 50 + i * 100);
                        //SDs[i].Size = new Size(400, 50);
                        shopPanel.Controls.Add(SDs[i]);
                        SDs[i].Show();
                    }
                }
                else
                {
                    //update the displays, add if necessary
                }
            }

        }
    }
}
