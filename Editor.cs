using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapHo.TableEditing;

namespace CapHo
{
    public partial class Editor : Form
    {
        private DBConnection DBC;
        private DataTable dt = new DataTable();
        

        public Editor()
        {
            InitializeComponent();
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            //log in to the server and make a DBC object
            DBC = new DBConnection("css475sp17-capho.c2b3wqyc8e3g.us-west-2.rds.amazonaws.com",
                                    5432,
                                    "CapHo",
                                    "Recette", "CapitalismHo");

            selectTable.Items.AddRange(new String[10]
                         {  "PLAYER_CHARACTER",
                            "PLAYER_SHOP",
                            "SHOP_INVENTORY",
                            "NPC",
                            "CUSTOMER",
                            "NPC_SHOP",
                            "NPCSHOP_INVENTORY",
                            "NPC_INVENTORY",
                            "SHOP_TRANSACTION",
                            "ITEM"});
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DBC.OpenConn();

            DBC.ExecuteQuery(SQLCmdBox.Text, ds);

            if (ds.Tables.Count != 0)
            {
                dt = ds.Tables[0];
                Results.DataSource = dt;
            }

            DBC.CloseConn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(selectTable.Text)
            {
                case "NPC":
                {
                   (new EditNPC(DBC)).Show();
                    break;
                }
                case "NPC_SHOP":
                {
                    (new EditNPCShop(DBC)).Show();
                    break;
                }
                case "PLAYER_CHARACTER":
                {
                    (new EditPlayerCharacter(DBC)).Show();
                    break;
                }
                case "ITEM":
                {
                    (new EditItem(DBC)).Show();
                    break;
                }
                case "CUSTOMER":
                {
                    (new EditCustomer(DBC)).Show();
                    break;
                }
                case "PLAYER_SHOP":
                {
                    (new EditPlayerShop(DBC)).Show();
                    break;
                }
                case "SHOP_INVENTORY":
                {
                    (new EditShopInventory(DBC)).Show();
                    break;
                }
                case "NPCSHOP_INVENTORY":
                {
                    (new EditNPCShopInventory(DBC)).Show();
                    break;
                }
                case "NPC_INVENTORY":
                {
                    (new EditNPCInventory(DBC)).Show();
                    break;
                }
                case "SHOP_TRANSACTION":
                {
                    (new EditShopTransaction(DBC)).Show();
                    break;
                }
                default:
                    MessageBox.Show("Not implemented!");
                    break;
            }
        }
    }
}
