using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

using Npgsql;

/*
Guild.cs
    The Guild portion of the Game.
    While in a separate file, it is a partial class
    of Game, since all the components we deal with are
    part of the Game.cs form
*/

namespace CapHo
{

    public partial class Game
    {
        //Guild Panel Data         
        private DataTable guildTransDt = new DataTable();   //data dable for displaying what you can sell/buy at the guild panel

        //retrieve and process initial data for Guild
        private void initGuild()
        {
        }

        private void runGuild()
        {

        }


        /*
            Guild Panel Control Logic
        */

        private void GuildBuySellTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshGuildTab(guildBuySellTabControl.SelectedTab);
        }


        private void GuildBuyDGV_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            throw new NotImplementedException();
        }




        /*refresh the data in the buy/sell tab of the merchants guild*/
        /*
            The guild buy tab displays all of the items the guildmaster is willing to sell to/buy from you
            In other words:
        */
        private void refreshGuildTab(TabPage page)
        {
            String priceQueryPortion;
            if (page == guildBuyTab)
            {
                priceQueryPortion = String.Format("{0} * PLAYER_CHARACTER.merchantlevel, ", 1.1);
            }

            DBC.OpenConn();

            if (page == guildBuyTab)
            {
                //update the table
                //String query = "select ITEM.itemname as Name, ITEM.baseprice from ITEM";
                String query = "select ITEM.itemid, ITEM.itemname, ITEM.Baseprice as price, ITEM.itemdescription as description, NPCSHOP_INVENTORY.Limited, NPCSHOP_INVENTORY.Quantity\n";
                query += "from NPC\n";
                query += "join NPCSHOP on NPC.NPCID = NPCSHOP.npc_ownerID\n";
                query += "join NPCSHOP_INVENTORY on NPCSHOP_INVENTORY.ShopID = NPCSHOP.npc_shopID\n";
                query += "join ITEM on ITEM.ItemID = NPCSHOP_INVENTORY.ItemID\n";
                query += "where NPC.name = 'The Guildmaster';";

                DBC.ExecuteQuery(query, ds);

                if (ds.Tables.Count != 0)
                {
                    guildTransDt = ds.Tables[0];
                    guildBuyDGV.DataSource = guildTransDt;
                }
            }

            DBC.CloseConn();


        }

        private void guildPanelBuy_Click(object sender, EventArgs e)
        {

            //confirmation!

            if(guildBuyDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item");
                return;
            }
            
            int itemID = (int)guildBuyDGV.SelectedRows[0].Cells[0].Value;

            
            playerHasItem(itemID);
            //DataRow itemData = ds.Tables[0].Rows[0];

            //DBC.OpenConn();

            //step1: check if the player has enough money to buy

            //step2: remove from the merchant inventory

            //step 3: add to the player inventory
            //step 3a. 

            //String query = String.Format("some stuff {0}", targetItemID);


            //DBC.CloseConn();

            refreshGuildTab(guildBuyTab);
            savePlayerState();
        }

        private void finishGuild_Click(object sender, EventArgs e)
        {

            //if something actually transpired, increment the counter
            incrementTimer();

            //set the panel to home
            switchMode(homePanel);


        }
    }
}
