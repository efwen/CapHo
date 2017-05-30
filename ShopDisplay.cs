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
        private ComboBox[] slots = new ComboBox[4];
        private Label[] indicators = new Label[4];
        private Button[] setButtons = new Button[4];
        private DataSet[] ds = new DataSet[4];

        private DBConnection DBC;
        private int shopID;
        private int displayIndex;

        public ShopDisplay() : base()
        {
            InitializeComponent();
            DBC = null;
            shopID = -1;
            displayIndex = -1;
            for (int i = 0; i < slots.Length; i++)
            {

                slots[i] = new ComboBox();
                Controls.Add(slots[i]);
                ds[i] = new DataSet();
                slots[i].SelectedValueChanged += ShopDisplay_SelectedValueChanged;
                slots[i].Location = new Point(i * Width / 4, 0);
                slots[i].Size = new Size(Width / 4, Height);
                slots[i].DataSource = ds[i];
            }
        }

        public ShopDisplay(DBConnection DBC, int shopID, int displayIndex) : base()
        {
            InitializeComponent();
            this.DBC = DBC;
            this.shopID = shopID;
            this.displayIndex = displayIndex;

            Location = new Point(0, 0);
            Size = new Size(400, 20);
            

            for (int i = 0; i < slots.Length; i++)
            {
                slots[i] = new ComboBox();
                Controls.Add(slots[i]);
                ds[i] = new DataSet();
                slots[i].SelectedValueChanged += ShopDisplay_SelectedValueChanged;
                slots[i].Location = new Point(i * Width / 4, 0);
                slots[i].Size = new Size(Width / 4, Height);
                //slots[i].DropDownStyle = ComboBoxStyle.DropDownList;
                slots[i].Show();
            }

            UpdateInfo();
        }

        private void ShopDisplay_SelectedValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("value changed!");
            ComboBox cbox = (ComboBox)sender;

            int index = cbox.SelectedIndex;
            //MessageBox.Show(index.ToString());

            if(index > 0)
            {
                MessageBox.Show(((DataTable)cbox.DataSource).Rows[index].ItemArray[0].ToString());
            }
            
            String query = "update display_contents\n";
            query += "select shopid, displaynum, slot, d_itemid";
        }

        //update the information this control is connected to on the db
        public void UpdateInfo()
        {
            if (DBC == null || shopID < 0 || displayIndex < 0)
                return;

            for (uint i = 0; i < slots.Length; i++)
            {
                getSlotData(i);
            }
        }

        private void getSlotData(uint slot)
        {
            if (slot >= slots.Length)
                return;


            //run a query to get the full list of selectable items
            String query = "select itemname\n";
            query += "from player_inventory\n";
            query += "join item on player_inventory.itemid = item.itemid\n";
            query += String.Format("where shopid = {0}\n", shopID);
            query += "group by itemname;";

            DBC.OpenConn();

            DBC.ExecuteQuery(query, ds[slot], "itemname");

            DBC.CloseConn();

            //MessageBox.Show(ds[slot].Tables[0].Rows[0].);
            //DataTable dt = ds[slot].Tables[0];
            //slots[slot].BindingContext = new BindingContext();
            //slots[slot].DisplayMember = "itemname";
            //slots[slot].DataSource = ds[slot].Tables[0];
            DataTable dt = ds[slot].Tables[0];

            DataRow blank = dt.NewRow();
            dt.Rows.InsertAt(blank, 0);
            blank.ItemArray.SetValue("(empty)", 0);




            //figure out which is the currently selected item
            String curQuery = "select itemname\n";
            curQuery += "from display_contents\n";
            curQuery += "join item on display_contents.d_itemid = item.itemid\n";
            curQuery += String.Format("where shopid = {0} and displaynum = {1} and slot = {2};", shopID, displayIndex + 1, slot + 1);

            DataSet tmp = new DataSet();
            DBC.OpenConn();

            if(!DBC.ExecuteQuery(curQuery, tmp))
            {
                MessageBox.Show("failed to get selected item query!");
            }

            DBC.CloseConn();

            if (tmp.Tables[0].Rows.Count != 0)
            {
                String value = "shoe";//= (String)tmp.Tables[0].Rows[0].ItemArray[0];
                
                slots[slot].DisplayMember = "itemname";
                
                //slots[slot].ValueMember = value;
                slots[slot].DataSource = dt; // ds[slot].Tables[0];
                                             //slots[slot].SelectedItem = value;
                                             //slots[slot].SelectedIndex = 2;


                /*    if(slots[slot].Items.Count > 0)
                    {
                        for(int i = 0; i < slots[slot].Items.Count; i++)
                        {
                            object item = slots[slot].Items[i];
                            object thisValue = item.GetType().GetProperty(slots[slot].ValueMember).GetValue(item);
                            if(thisValue != null && thisValue.Equals(value))
                            {
                                slots[slot].SelectedIndex = i;
                                return;
                            }
                        }
                        slots[slot].SelectedIndex = 0;
                    }*/
            }
            else  //nothing in this slot
            {
                slots[slot].SelectedIndex = slots[slot].FindStringExact("");
            }

        }

        protected void SetLabels()
        {
            //query for the current items contained
            for (int i = 0; i < 4; i++)
            {

            }

        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            for (int i = 0; i < slots.Length; i++)
            {
                slots[i].Location = new Point(i * Width / 4, 0);
                slots[i].Size = new Size(Width / 4, Height);
            }

        }
    }
}
