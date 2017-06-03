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
    public partial class ShopDisplay : Control
    {
        private Label[] indicators = new Label[4];
        private ComboBox[] selectors = new ComboBox[4];
        private Button[] setButtons = new Button[4];
        private DataSet[] ds = new DataSet[4];

        private DBConnection DBC;
        private int shopID;
        private int displayIndex;

        public ShopDisplay(DBConnection DBC, int shopID, int displayIndex) : base()
        {
            InitializeComponent();
            this.DBC = DBC;
            this.shopID = shopID;
            this.displayIndex = displayIndex;
            this.BackColor = Color.Black;
            Size = new Size(400, 60);
            

            for (uint i = 0; i < selectors.Length; i++)
            {
                //Add indicators
                indicators[i] = new Label();
                indicators[i].Location = new Point((int)i * Width / 4, 0);
                indicators[i].Size = new Size(Width / 4, Height / 3);
                indicators[i].TextAlign = ContentAlignment.MiddleCenter;
                indicators[i].Font = new Font("Monotype Corsiva", 12);
                indicators[i].ForeColor = Color.Gold;
                Controls.Add(indicators[i]);

                //Add drop-downs
                selectors[i] = new ComboBox();
                ds[i] = new DataSet();
                selectors[i].Location = new Point((int)i * Width / 4, Height / 3);
                selectors[i].Size = new Size(Width / 4, Height / 3);
                selectors[i].DropDownStyle = ComboBoxStyle.DropDownList;
                Controls.Add(selectors[i]);

                //add Set buttons
                setButtons[i] = new Button();
                setButtons[i].MouseClick += ShopDisplay_SetButtonClicked;
                setButtons[i].Location = new Point((int)i * Width / 4, 2 * Height / 3);
                setButtons[i].Size = new Size(Width / 4, Height / 3);
                setButtons[i].Text = "Set";
                setButtons[i].BackColor = Color.White;
                Controls.Add(setButtons[i]);
            }

            UpdateData();
        }

        private void ShopDisplay_SetButtonClicked(object sender, EventArgs e)
        {
            //figure out the index of the button clicked
            int index = Array.IndexOf(setButtons, (Button)sender);

            if (index < 0) return; //wrong index! This shouldn't happen

            String indicatorVal = indicators[index].Text;
            String selectorVal = (String)((DataRowView)selectors[index].SelectedValue)["itemname"];
            
            //use the index to update the value in the database if different
            if (indicatorVal != selectorVal)
            {
                //update DB with new state
                UpdateSlot((uint)index);

                //update Indicator
                indicators[index].Text = selectorVal;
            }

        }


        //update the information this control is connected to on the DB
        public void UpdateData()
        {
            if (DBC == null || shopID < 0 || displayIndex < 0)
                return;


            for (uint i = 0; i < selectors.Length; i++)
            {
                getIndicatorData(i);
                getSelectorData(i);
            }
        }

        //set the list of selectables in the selector to reflect the DB
        private void getSelectorData(uint slot)
        {
            
            if (slot >= selectors.Length)
            {
                MessageBox.Show("slot >= slots.length!");
                return;
            }
            

            //run a query to get the full list of selectable items
            String query = "select item.itemname, item.itemid\n";
            query += "from item\n";
            query += "join player_inventory on player_inventory.itemid = item.itemid\n";
            query += String.Format("where shopid = {0}\n", shopID);
            query += "group by item.itemname, item.itemid;";


            if (!DBC.ExecuteQuery(query, ds[slot], "itemPicker"))
                return;

            DataTable dt = ds[slot].Tables["itemPicker"];
      
            //add a spot for "(empty)"
            DataRow blank = dt.NewRow();
            blank["itemname"] = "(empty)";
            blank["itemid"] = -1;
            dt.Rows.InsertAt(blank, 0);


            selectors[slot].DisplayMember = "itemname";     //display only the "itemname" column
            selectors[slot].DataSource = dt;


            //selectors[slot].SelectedValue = indicators[slot].Text;
        }

        //set the indicator for a slot to represent the DB
        private void getIndicatorData(uint slot)
        {
            //get the name of the item currently in the slot indicated
            String query = "select itemname\n";
            query += "from item\n";
            query += "join display_contents on display_contents.d_itemid = item.itemid\n";
            query += String.Format("where display_contents.displaynum = {0} and display_contents.slot = {1} and shopID = {2};", displayIndex + 1, slot + 1, shopID);
            DataSet indicDs = new DataSet();

            if (!DBC.ExecuteQuery(query, indicDs))
                return;

            if (indicDs.Tables[0].Rows.Count != 0)
            {
                indicators[slot].Text = (String)indicDs.Tables[0].Rows[0].ItemArray[0];
            }
            else
            {
                indicators[slot].Text = "(empty)";
            }
        }

        //Update what the slot holds in the DB
        private bool UpdateSlot(uint slot)
        {
            String indicatorVal = indicators[slot].Text;
            String selectorVal = (String)((DataRowView)selectors[slot].SelectedValue)["itemname"];
            int d_itemid = (int)((DataRowView)selectors[slot].SelectedValue)["itemid"];

            String slotQuery;
            //three different scenarios
            //scenario 1: adding something to an empty slot
            if (indicatorVal == "(empty)" && selectorVal != "(empty)")
            {
                slotQuery =                "insert into display_contents\n";
                slotQuery += String.Format("values({0}, {1}, {2}, {3});", shopID, displayIndex + 1, slot + 1, d_itemid);
            }
            //scenario 2: removing an item from the slot
            else if(indicatorVal != "(empty)" &&  selectorVal == "(empty)")
            {
                slotQuery =                 "delete from display_contents\n";
                slotQuery += String.Format( "where shopid = {0} and displaynum = {1} and slot = {2};", shopID, displayIndex + 1, slot + 1);
            }
            //scenario 3: replacing one item with another
            else
            {
                slotQuery =                 "update display_contents\n";
                slotQuery += String.Format( "set d_itemid = {0}\n", d_itemid);
                slotQuery += String.Format( "where shopid = {0} and displaynum = {1} and slot = {2};", shopID, displayIndex + 1, slot + 1);
            }

            DataSet tmp = new DataSet();
            if (!DBC.ExecuteQuery(slotQuery, tmp))
                return false;

            return true;
        }

    }
}
