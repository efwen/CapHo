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
    public partial class EditPlayerShop : Form
    {
        private DBConnection DBC;
        private DataTable dt = new DataTable();
        private string TableName = "playershop";

        public EditPlayerShop(DBConnection DBC)
        {
            InitializeComponent();
            this.DBC = DBC;
            Results.RowHeaderMouseDoubleClick += Results_RowHeaderMouseDoubleClick;
        }

        private void Results_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCellCollection cells = Results.SelectedRows[0].Cells;


            ownerid.Value = (int)cells[0].Value;
            shopid.Value =  (int)cells[1].Value;
            shopName.Text = cells[2].Value.ToString();
            location.Text = cells[3].ToString();
            shopLevel.Value = (int)cells[4].Value;
        }

        private void EditPlayerShop_Load(object sender, EventArgs e)
        {
            

            String query = "SELECT * FROM " + TableName;
            DBC.ExecuteQuery(query, ds);

            if (ds.Tables.Count != 0)
            {
                dt = ds.Tables[0];
                Results.DataSource = dt;
            }

            
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            

            String query = String.Format("INSERT INTO {0} VALUES({1}, {2}, \'{3}\', \'{4}\', {5});", TableName,
                                        ownerid.Value, shopid.Value, shopName.Text, location.Text, shopLevel.Value);

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
            

            String targetShopID = Results.SelectedRows[0].Cells[1].Value.ToString();
            String updates = String.Format("ownerid={0}, shopid={1}, shopname=\'{2}\', location=\'{3}\', shoplevel={4}",
                                            ownerid.Value, shopid.Value, shopName.Text, location.Text, shopLevel.Value);

            String query = String.Format("UPDATE {0} SET {1} WHERE shopid={2};", TableName, updates, targetShopID);

            DBC.ExecuteQuery(query, ds);


            
            RefreshTable();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            

            String idToRemove = Results.SelectedRows[0].Cells[1].Value.ToString();
            String query = String.Format("DELETE FROM {0} WHERE shopid={1};", TableName, idToRemove);
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
    }
}
