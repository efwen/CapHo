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
    /*
    Queries.cs
    This is a separate file for holding all of the functions which 
    Run queries in the Game class. It should make the demonstration
    of the frontend's relationship with the database easier.
    This file was created partway through development, and thus
    Not all queries have been migrated here, particularly those
    that load in entire tables of data
    */

    public partial class Game
    {
        //Commonly used queries

        
        private bool doesQueryHaveResults(string query)
        {

            DBC.ExecuteQuery(query, ds);
            if (ds.Tables.Count != 0)
            {
                if (ds.Tables[0].Rows.Count > 0)       //rows mean the item exists
                {

                    return true;
                }
                else //query has rows
                {

                    return false;
                }

            }


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
            String query = "select itemID\n";
            query += "from npc_inventory\n";
            query += String.Format("where npcID = {0} AND itemID = {1};", npcID, itemID);
            return doesQueryHaveResults(query);
        }
        private bool NPCShopHasItem(int itemID, int npcID)
        {
            String query = "select itemID\n";
            query += "from npcshop_inventory\n";
            query += "join npcshop on npcshop.npc_shopid = npcshop_inventory.shopid\n";
            query += String.Format("where itemID = {0} and npcshop.npc_ownerid = {1};", itemID, npcID);
            return doesQueryHaveResults(query);
        }


        /*
        Mostly used in Guild.cs
        */
        private int playerInvItemQty(int playerID, int itemID)
        {
            String query;
            query = "select quantity\n";
            query += "from player_inventory\n";
            query += "join playershop on playershop.shopid = player_inventory.shopid\n";
            query += String.Format("where ownerid = {0} and itemid = {1}", playerID, itemID);



            DBC.ExecuteQuery(query, ds);
            if (ds.Tables.Count != 0)
            {
                if (ds.Tables[0].Rows.Count > 0)       //rows mean the item exists
                {

                    return (int)ds.Tables[0].Rows[0].ItemArray[0];
                }
                else
                {

                    return -1;
                }

            }


            return -1;
        }
        private int NPCShopInvItemQty(int npcID, int itemID, ref bool limited)
        {
            String query;
            query = "select quantity, limited\n";
            query += "from npcshop_inventory\n";
            query += "join npcshop on npcshop.npc_shopid = npcshop_inventory.shopid\n";
            query += String.Format("where npc_ownerid = {0} and itemid = {1}", npcID, itemID);


            if (!DBC.ExecuteQuery(query, ds))
            {

                return -1;
            }

            if (ds.Tables.Count != 0)
            {
                if (ds.Tables[0].Rows.Count > 0)       //rows mean the item exists
                {

                    limited = (bool)ds.Tables[0].Rows[0].ItemArray[1];  //set limited
                    return (int)ds.Tables[0].Rows[0].ItemArray[0];      //return qty avail
                }
                else
                {

                    return -1;
                }

            }


            return -1;
        }

        private bool addItemsToPlayerInv(int shopID, int itemID, int quantity)
        {
            String query;
            if (playerHasItem(itemID))
            {
                //update operation only
                query = "update player_inventory\n";
                query += String.Format("set quantity = quantity + {0}\n", quantity);
                query += String.Format("where player_inventory.shopid = {0} and player_inventory.itemid in\n", shopID);
                query += "(select pi.itemid\n";
                query += "from player_inventory as pi\n";
                query += String.Format("where pi.itemid = {0});", itemID);
            }
            else
            {
                //insert operation
                query = "insert into player_inventory\n";
                query += String.Format("values ({0}, {1}, {2});", shopID, itemID, quantity);
            }



            if (!DBC.ExecuteQuery(query, ds))
            {

                return false;
            }


            return true;
        }
        private bool removeItemsFromPlayerInv(int playerID, int itemID, int removeQty)
        {
            String query;
            String removeFromDispQuery = "";
            int curQty = playerInvItemQty(playerID, itemID);
            if (curQty > removeQty)  //we have more than we want to remove
            {
                //update operation only
                query = "update player_inventory\n";
                query += String.Format("set quantity = quantity - {0}\n", removeQty);
                query += "where player_inventory.itemid in\n";
                query += "(select pi.itemid\n";
                query += "from player_inventory as pi\n";
                query += "join playershop on playershop.shopid = pi.shopid\n";
                query += String.Format("where pi.itemid = {0} and playershop.ownerid = {1});", itemID, playerID);
            }
            else if (curQty == removeQty)
            {
                //remove operation
                query = "delete from player_inventory\n";
                query += String.Format("where player_inventory.itemid = {0}\n", itemID);
                query += String.Format("and shopid in (select shopid from playershop where ownerid = {0});", playerID);

                //if the player has the last remaining item in a display, remove it from there too
                removeFromDispQuery = "delete from display_contents\n";
                removeFromDispQuery += String.Format("where display_contents.d_itemid = {0}\n", itemID);
                removeFromDispQuery += String.Format("and shopid in (select shopid from playershop where ownerid = {0});", playerID);

                if (!DBC.ExecuteQuery(removeFromDispQuery, ds))
                {
                    return false;
                }

            }
            else
            {
                //invalid
                MessageBox.Show("You don't have enough!");
                return false;
            }

            if (!DBC.ExecuteQuery(query, ds))
            {
                return false;
            }

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
                    query = "update npcshop_inventory\n";
                    query += String.Format("set quantity = quantity - {0}\n", addQty);
                    query += "where npcshop_inventory.itemid in\n";
                    query += "(select npci.itemid\n";
                    query += "from npcshop_inventory as npci\n";
                    query += "join npcshop on npcshop.shopid = npci.shopid\n";
                    query += String.Format("where npci.itemid = {0} and npcshop.npc_ownerid = {1});", itemID, npcID);
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
                query = "insert into npcshop_inventory\n";
                query += String.Format("select npcshop.npc_shopid, {0}, {1}, {2}\n", itemID, ltd, addQty);
                query += "from npcshop\n";
                query += String.Format("where npcshop.npc_ownerid = {0};", npcID);
            }

            if (!DBC.ExecuteQuery(query, ds))
            {

                return false;
            }


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
                else if (removeQty == NPCShopQty)
                {
                    //remove entry
                    query = "remove from npcshop_inventory\n";
                    query += "join npcshop on npcshop_inventory.shopid = npcshop.shopid\n";
                    query += String.Format("npcid = {0} and itemid = {1};", npcID, itemID);
                }
                else
                {
                    //update w/ increase
                    query = "update npcshop_inventory\n";
                    query += String.Format("set quantity = quantity - {0}\n", removeQty);
                    query += "where npcshop_inventory.itemid in\n";
                    query += "(select npci.itemid\n";
                    query += "from npcshop_inventory as npci\n";
                    query += "join npcshop on npcshop.shopid = npci.shopid\n";
                    query += String.Format("where npci.itemid = {0} and npcshop.npcid = {1});", itemID, npcID);
                }
            }
            else //if quantity is unlimited we don't need to do anything
            {
                return true;
            }

            if (!DBC.ExecuteQuery(query, ds))
            {

                return false;
            }


            return true;
        }

        //get the next available ID number for a given table
        //this helps in making new entries
        //returns the id number
        //or -2 if table not recognized
        //or -1 for other failure
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



            if (!DBC.ExecuteQuery(query, ds))
            {
                return -1;
            }


            return (int)ds.Tables[0].Rows[0].ItemArray[0] + 1;
        }

        //buy an item from an NPC shop (in this case 
        //it's just the guild, but this can
        //expand later
        private bool performNPCShopBuyTransaction(int npcID, int playerID, int itemID, int quantity)
        {
            //figure out how much the item costs so we can test if we can afford it
            String query = "select baseprice\n";
            query += "from item\n";
            query += String.Format("where item.itemid = {0}", itemID);



            if (!DBC.ExecuteQuery(query, ds))
            {
                //query failed
                return false;
            }



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

            if (!addItemsToPlayerInv(playerID, itemID, quantity))
            {
                MessageBox.Show("Could not put items in Player inventory!");
                //put the items back into the npc shop
                if (!addItemsToNPCShopInv(npcID, itemID, quantity))
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

            query = "insert into shop_transaction\n";
            query += String.Format("select {0}, 3, npcshop.npc_shopid, {1}, item.itemid, {2}, item.baseprice, {3}, {4}\n",  //transaction type 3: purchase from shop
                                    newTransID, npcID, quantity, day, dayTime);
            query += "from npcshop\n";
            query += "join npcshop_inventory on npcshop.npc_shopid = npcshop_inventory.shopid\n";
            query += "join item on npcshop_inventory.itemid = item.itemid\n";
            query += String.Format("where npcshop.npcID = {0} and item.itemid = {1};", npcID, itemID);



            //charge the player money
            balance -= (int)totalprice;
            //force a player state update
            savePlayerState();
            return true;
        }


        


        /*
        Queries used in Shop.cs
        */
        private bool performPlayerShopSellTransaction(int npcID, int playerID, int itemID, int price)
        {
            //remove from player inventory, if it is on display remove it there too
            if (!removeItemsFromPlayerInv(playerID, itemID, 1))
            {
                MessageBox.Show("Could not remove items from player");
                return false;
            }

            //add money to player balance
            balance += price;
            savePlayerState();


            //add new shop_transaction tuple
            int newTransID = getNextAvailID("shop_transaction");

            String query =          "insert into shop_transaction\n";
            query += String.Format( "select {0}, 1, playershop.shopid, {1}, {2}, 1, {3}, {4}, {5}\n",   
                                        newTransID, npcID, itemID, price, day, dayTime); //transaction type 1 (sale to customer), quantity 1, shopid = player's shop
            query +=                "from playershop\n";
            query += String.Format( "where playershop.ownerid = {0};", playerID);

            if(!DBC.ExecuteQuery(query, ds))
            {
                MessageBox.Show("Failed to make shop_transaction record!");
            }

            return true;
        }

        //increase/decrease a customer's relationship value
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



            if (!DBC.ExecuteQuery(query, ds))
            {

                return false;
            }

            return true;
        }

        //returns a random itemid currently on display in the shop the customer can afford
        //returns -1 if no item found, or error
        private int getRandomItemOnDisplay(int playerID, int customerID)
        {
            String query;
            query =                 "select display_contents.d_itemid\n";
            query +=                "from item\n";
            query +=                "join display_contents on item.itemid = display_contents.d_itemid\n";
            query +=                "join playershop on display_contents.shopid = playershop.shopid\n";
            query += String.Format( "where ownerid = {0}\n", playerID);
            query +=                "and item.baseprice < (select min(basebudget * budgetscaling * relationship)\n";
            query +=                                        "from customer\n";
            query += String.Format(                         "where customer.n_npcid = {0});", customerID);

            if (!DBC.ExecuteQuery(query, ds))
            {
                MessageBox.Show("Failed to execute query \"" + query + "\"");
                return -1;
            }

            if (ds.Tables.Count != 0)
            {
                if (ds.Tables[0].Rows.Count > 0)       //rows mean the item exists
                {
                    DataTable dt = ds.Tables[0];
                    Random rnd = new Random();

                    int randomIndex = rnd.Next(0, dt.Rows.Count - 1);

                    return (int)dt.Rows[randomIndex].ItemArray[0];
                }
                else
                {
                    return -1;
                }

            }

            return -1;
        }

        //tests if there are any items in shop displays
        private bool areShopDisplaysPopulated(int shopID)
        {
            String query = "select COUNT(*)\n";
            query += "from display_contents\n";
            query += String.Format("where shopid = {0};", shopID);

            if (!DBC.ExecuteQuery(query, ds))
                return false;

            if ((long)ds.Tables[0].Rows[0].ItemArray[0] == 0)
                return false;

            return true;
        }

        //returns a random npc customer for the purposes of haggling
        //returns -1 if error
        private int getRandomCustomer()
        {
            String query = "select *\n";
            query += "from customer\n";

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

                    return (int)ds.Tables[0].Rows[randomIndex].ItemArray[0];      //return npc
                }
                else
                {
                    return -1;
                }

            }

            return -1;
        }

    }
}
