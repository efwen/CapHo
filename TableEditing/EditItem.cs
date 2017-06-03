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
    public partial class EditItem : Form
    {
        private DBConnection DBC;
        private DataTable dt = new DataTable();
        private string TableName = "ITEM";

        public EditItem(DBConnection DBC)
        {
            InitializeComponent();
            this.DBC = DBC;
            Results.RowHeaderMouseDoubleClick += Results_RowHeaderMouseDoubleClick;
        }

        private void EditItem_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            

            String query = String.Format("INSERT INTO {0} VALUES({1}, \'{2}\', \'{3}\', {4}, {5});", TableName,
                                        itemid.Value, itemName.Text, itemDescription.Text, basePrice.Value, itemType.Value);

            DBC.ExecuteQuery(query, ds);

            if (ds.Tables.Count != 0)
            {
                dt = ds.Tables[0];
                Results.DataSource = dt;
            }

            

            RefreshTable();
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            
            String targetID = Results.SelectedRows[0].Cells[0].Value.ToString();
            String updates = String.Format("itemid={0}, itemname=\'{1}\', itemdescription=\'{2}\', baseprice={3}, itemtype={4}",
                                            itemid.Value, itemName.Text, itemDescription.Text, basePrice.Value, itemType.Value);

            String query = String.Format("UPDATE {0} SET {1} WHERE itemid={2};", TableName, updates, targetID);

            DBC.ExecuteQuery(query, ds);


            
            RefreshTable();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            

            String idToRemove = Results.SelectedRows[0].Cells[0].Value.ToString();
            String query = String.Format("DELETE FROM {0} WHERE itemid={1};", TableName, idToRemove);
            DBC.ExecuteQuery(query, ds);

            
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

        private void Results_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCellCollection cells = Results.SelectedRows[0].Cells;


            itemid.Value = (int)cells[0].Value;
            itemName.Text = cells[1].Value.ToString();
            itemDescription.Text = cells[2].Value.ToString();
            basePrice.Value = (int)cells[3].Value;
            itemType.Value = (int)cells[4].Value;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
