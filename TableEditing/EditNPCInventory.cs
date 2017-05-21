using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapHo.TableEditing
{
    public partial class EditNPCInventory : Form
    {
        private DBConnection DBC;
        private DataTable dt = new DataTable();
        private string TableName = "npc_inventory";

        public EditNPCInventory(DBConnection DBC)
        {
            InitializeComponent();
            this.DBC = DBC;
            Results.RowHeaderMouseDoubleClick += Results_RowHeaderMouseDoubleClick;
        }

        private void Results_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCellCollection cells = Results.SelectedRows[0].Cells;

            npcid.Value = (int)cells[0].Value;
            itemid.Value = (int)cells[2].Value;
            quantity.Value = (int)cells[3].Value;
        }

        private void EditNPCInventory_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            DBC.OpenConn();

            String query = String.Format("INSERT INTO {0} VALUES({1}, {2}, {3});", TableName,
                                        npcid.Value, itemid.Value, quantity.Value);

            DBC.ExecuteQuery(query, ds);

            if (ds.Tables.Count != 0)
            {
                dt = ds.Tables[0];
                Results.DataSource = dt;
            }

            DBC.CloseConn();

            RefreshTable();
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            DBC.OpenConn();

            String targetShopID = Results.SelectedRows[0].Cells[0].Value.ToString();
            String targetItemID = Results.SelectedRows[0].Cells[1].Value.ToString();

            String updates = String.Format("n_npcid={0}, i_itemid={1}, quantity={2}",
                                            npcid.Value, itemid.Value, quantity.Value);

            String query = String.Format("UPDATE {0} SET {1} WHERE n_npcid={2} AND i_itemid={3};", TableName, updates, targetShopID, targetItemID);

            DBC.ExecuteQuery(query, ds);


            DBC.CloseConn();
            RefreshTable();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DBC.OpenConn();

            String targetShopID = Results.SelectedRows[0].Cells[0].Value.ToString();
            String targetItemID = Results.SelectedRows[0].Cells[1].Value.ToString();

            String query = String.Format("DELETE FROM {0} WHERE n_npcid={1} AND i_itemid={2};", TableName, targetShopID, targetItemID);
            DBC.ExecuteQuery(query, ds);

            DBC.CloseConn();
            RefreshTable();
        }

        private void RefreshTable()
        {
            DBC.OpenConn();
            //update the table
            String query = "SELECT * FROM " + TableName;
            DBC.ExecuteQuery(query, ds);

            if (ds.Tables.Count != 0)
            {
                dt = ds.Tables[0];
                Results.DataSource = dt;
            }

            DBC.CloseConn();
        }
    }
}
