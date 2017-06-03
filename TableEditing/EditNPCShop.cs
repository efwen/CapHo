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
    public partial class EditNPCShop : Form
    {
        private DBConnection DBC;
        private DataTable dt = new DataTable();
        private string TableName = "NPCShop";

        public EditNPCShop(DBConnection DBC)
        {
            InitializeComponent();
            this.DBC = DBC;
            Results.RowHeaderMouseDoubleClick += Results_RowHeaderMouseDoubleClick;
        }

        private void Results_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCellCollection cells = Results.SelectedRows[0].Cells;


            npc_ownerid.Value = (int)cells[0].Value;
            npc_shopid.Value = (int)cells[1].Value;
            shopname.Text = cells[2].Value.ToString();
            location.Text = cells[3].Value.ToString();
        }

        private void EditNPCShop_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            

            String query = String.Format("INSERT INTO {0} VALUES({1}, {2}, \'{3}\', \'{4}\');", TableName,
                                        npc_ownerid.Value, npc_shopid.Value, shopname.Text, location.Text);

            DBC.ExecuteQuery(query, ds);

            if (ds.Tables.Count != 0)
            {
                dt = ds.Tables[0];
                Results.DataSource = dt;
            }

            

            RefreshTable();
        }

        private void RefreshTable()
        {
            
            //update the table
            String query = "SELECT * FROM " + TableName;
            DBC.ExecuteQuery(query, ds);

            if (ds.Tables.Count != 0)
            {
                dt = ds.Tables[0];
                Results.DataSource = dt;
            }

            
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            
            String targetID = Results.SelectedRows[0].Cells[1].Value.ToString();
            String updates = String.Format("npc_ownerid={0}, npc_shopid={1}, shopname=\'{2}\', location=\'{3}\'",
                                            npc_ownerid.Value, npc_shopid.Value, shopname.Text, location.Text);

            String query = String.Format("UPDATE {0} SET {1} WHERE npc_shopid={2};", TableName, updates, targetID);

            DBC.ExecuteQuery(query, ds);


            
            RefreshTable();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            

            String idToRemove = Results.SelectedRows[0].Cells[1].Value.ToString();
            String query = String.Format("DELETE FROM {0} WHERE npc_shopid={1};", TableName, idToRemove);
            DBC.ExecuteQuery(query, ds);

            
            RefreshTable();
        }
    }
}
