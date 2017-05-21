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




        /*
            Guild Panel Control Logic
        */

        private void GuildBuySellTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("index changed");
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
            select ITEM.Name, BasePrice * (some formula involving merchant level) as price, NPC_SHOP_INVENTORY.Limited, NPC_SHOP_INVENTORY.Quantity
            from NPC
            join NPC_SHOP on NPC.NPCID = NPC_SHOP.OwnerID
            join NPC_SHOP_INVENTORY on NPC_SHOP_INVENTORY.ShopID = npcshop.ShopID
            join ITEM on ITEM.ItemID = NPC_SHOP_INVENTORY.I_ItemID;
        */
        private void refreshGuildTab(TabPage page)
        {
            String priceQueryPortion;
            if (page == guildBuyTab)
            {
                priceQueryPortion = String.Format("{0} * PLAYER_CHARACTER.merchantlevel, ", 1.1);
            }
            else if (page == guildSellTab)
            {
                priceQueryPortion = String.Format("{0} * PLAYER_CHARACTER.merchantlevel, ", 0.9);
            }

            DBC.OpenConn();

            //update the table
            String query = "select ITEM.itemname as Name, ITEM.baseprice from ITEM";
            DBC.ExecuteQuery(query, ds);

            if (ds.Tables.Count != 0)
            {
                guildTransDt = ds.Tables[0];
                guildBuyDGV.DataSource = guildTransDt;
            }

            DBC.CloseConn();


        }

        private void guildPanelBuy_Click(object sender, EventArgs e)
        {

        }

        private void guildPanelSell_Click(object sender, EventArgs e)
        {

        }

        private void finishGuild_Click(object sender, EventArgs e)
        {

            //set the panel to home
            switchPanel(homePanel);

            //if something actually transpired, increment the counter
            incrementTimer();
        }
    }
}
