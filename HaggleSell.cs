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
    public partial class HaggleSell : Form
    {
        private DBConnection DBC;
        private DataSet ds = new DataSet();

        //haggle tracking
        int customerID;
        int itemID;
        int basebudget;
        Decimal budgetScaling;
        int relationship;
        Decimal stinginess;

        //
        int basePrice;
        int acceptablePrice;                        //the highest price the npc will accept
        const int baseMaxAttempts = 2;              //everyone has a minimum of two sale attempts
        int maxAttempts = 0;

        public int failedAttempts { get; set; }     //the number of attempts
        public int finalPrice { get; set; }



        public HaggleSell(DBConnection DBC, int customerID, int itemID)
        {
            InitializeComponent();
            this.DBC = DBC;
            this.customerID = customerID;
            this.itemID = itemID;
        }

        private void HaggleSell_Load(object sender, EventArgs e)
        {
            if(!getCustomerInfo(customerID))
            {
                MessageBox.Show("Failed to retrieve customer info!");
                this.Close();
                return;
            }

            if(!getItemInfo(itemID))
            {
                MessageBox.Show("Failed to retrieve item info!");
                this.Close();
                return;
            }

            message.Text = String.Format("\"I want to buy this {0}, how much is it?\"", itemName.Text);

            //set acceptable price (the max price this customer will pay)
            acceptablePrice =  (int)((Decimal)basePrice * stinginess);
            //set max attempts to reach this price
            maxAttempts = (int)(baseMaxAttempts + relationship / 5);
        }

        private void makeOfferBtn_Click(object sender, EventArgs e)
        {
            
            //check if price falls under acceptable price
            if(offerPrice.Value > acceptablePrice)
            {
                if(++failedAttempts >= maxAttempts)
                {
                    MessageBox.Show("\"Ugh, you people are unreasonable. I'm leaving!\"");
                    finalPrice = -1;    //failed signal
                    this.Close();
                }
                else
                {
                    message.Text = "\"I can't pay for that, that's too high!\"";
                }
            }
            else
            {
                MessageBox.Show(String.Format("\"Thanks! Here's ${0}.\"", (int)offerPrice.Value));
                finalPrice = (int)offerPrice.Value;
                this.Close();
            }
        }

        //getCustomerInfo
        //fills out fields in the form related to the customer
        //and saves customer variables affecting the haggling process
        private bool getCustomerInfo(int customerID)
        {
            String customerQuery = "select basebudget, budgetscaling, relationship, stinginess, name\n";
            customerQuery += "from customer\n";
            customerQuery += "join npc on customer.n_npcid = npc.npcid\n";
            customerQuery += String.Format("where npc.npcid = {0};", customerID);

            DBC.OpenConn();
            DBC.ExecuteQuery(customerQuery, ds);
            if (ds.Tables.Count != 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DBC.CloseConn();
                    basebudget = (int)ds.Tables[0].Rows[0].ItemArray[0];
                    budgetScaling = (Decimal)ds.Tables[0].Rows[0].ItemArray[1];
                    relationship = (int)ds.Tables[0].Rows[0].ItemArray[2];
                    stinginess = (Decimal)ds.Tables[0].Rows[0].ItemArray[3];
                    customerName.Text = (String)ds.Tables[0].Rows[0].ItemArray[4];

                    DBC.CloseConn();
                    return true; 
                }
                else
                {
                    MessageBox.Show("Customer not Found!");
                    DBC.CloseConn();
                    return false;
                }

            }
            DBC.CloseConn();
            return false;
        }

        //getItemInfo
        //retrieves the information about the item in question useful
        //for 
        private bool getItemInfo(int itemID)
        {
            String itemQuery = "select itemname, itemdescription, baseprice, item_type.type\n";
            itemQuery += "from item\n";
            itemQuery += "join item_type on item.itemtype = item_type.index\n";
            itemQuery += String.Format("where itemid = {0}", itemID);

            DBC.OpenConn();
            DBC.ExecuteQuery(itemQuery, ds);
            if (ds.Tables.Count != 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DBC.CloseConn();

                    itemName.Text = (String)ds.Tables[0].Rows[0].ItemArray[0];
                    itemDescription.Text= (String)ds.Tables[0].Rows[0].ItemArray[1];
                    basePrice = (int)ds.Tables[0].Rows[0].ItemArray[2];
                    basePriceLbl.Text = String.Format("${0}", basePrice.ToString());
                    itemType.Text = String.Format("({0})", (String)ds.Tables[0].Rows[0].ItemArray[3]);


                    //set the initial price offer
                    offerPrice.Value = (Decimal)(basePrice * 1.3);

                    DBC.CloseConn();
                    return true;
                }
                else
                {
                    MessageBox.Show("Customer not Found!");
                    DBC.CloseConn();
                    return false;
                }

            }
            DBC.CloseConn();
            return false;
        }
    }
}
