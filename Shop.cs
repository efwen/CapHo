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
            

            DBC.ExecuteQuery(shopIDQuery, ds);

            if(ds.Tables[0].Rows.Count != 0)
            {
                shopID = (int)ds.Tables[0].Rows[0].ItemArray[0];
            }
            else
            {
                MessageBox.Show("Error retrieving shopID!");
            }
            
        }

        //start the shop view
        private void runShop()
        {
            shopOpened = false;
            runOpenShopBtn.Enabled = true;
            setupDisplays();
        }

        //open the shop for business
        private void openShop()
        {
            shopOpened = true;
            int customerCount = 0;
            int curBuyNpc = -1;
            
            while (customerCount < maxCustomers)
            {
                //0. Do we have anything to sell?
                if (!areShopDisplaysPopulated(shopID))
                {
                    MessageBox.Show("Your shop displays are empty!");
                    return;
                }


                //1. choose a random NPC
                curBuyNpc = getRandomCustomer();
                if(curBuyNpc < 0)
                {
                    MessageBox.Show("Error finding an npc for your shop!");
                    return;
                }


                //2. pick a random item to buy
                //   ---must be an item on display
                //   ---customers won't try to buy items larger than their budget
                int curItem = getRandomItemOnDisplay(playerID, curBuyNpc);
                if(curItem < 0)
                {
                    MessageBox.Show("Customer could not find an item to buy!");
                    return;
                }

                //3. Haggle for a price
                HaggleSell hsWin = new HaggleSell(DBC, curBuyNpc, curItem);
                hsWin.ShowDialog();
                
                if(hsWin.finalPrice > 0) //successful purchase!
                {
                    performPlayerShopSellTransaction(curBuyNpc, playerID, curItem, hsWin.finalPrice);
                    alterCustomerRelationship(curBuyNpc, 1);
                }
                else if (hsWin.finalPrice < 0) //bad result, customer angry
                {
                    alterCustomerRelationship(curBuyNpc, -1);
                }

                customerCount++;
            }
            //update the shop displays
            foreach (ShopDisplay d in SDs)
            {
                d.UpdateData();
            }
        }

        private void runOpenShopBtn_Click(object sender, EventArgs e)
        {
            openShop();
           runOpenShopBtn.Enabled = false;
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


        //Make shopdisplays as necessary and fill them with data
        private void setupDisplays()
        {
            //find the number of displays we need and fill them
            String query = "select COUNT(*)\n";
            query += "from shop_display\n";
            query += String.Format("where shopid = {0};", shopID);


            if (!DBC.ExecuteQuery(query, ds))
            {
                MessageBox.Show("Failed to load shop displays!");
                return;
            }

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Failed to load shop displays!");
                return;
            }
            else
            {
                int count = Int32.Parse(ds.Tables[0].Rows[0].ItemArray[0].ToString());

                //update the displays, add if necessary
                for (int i = 0; i < count; i++)
                {
                    if (i == SDs.Count)
                    {
                        SDs.Add(new ShopDisplay(DBC, shopID, SDs.Count));
                        SDs.Last().Location = new Point(50, 50 + i * 100);
                        shopPanel.Controls.Add(SDs.Last());
                    }
                    else
                    {
                        //already exists, so just update the info
                        SDs[i].UpdateData();
                    }
                }

            }

        }
    }
}
