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
    public partial class EditShopTransaction : Form
    {
        private DBConnection DBC;
        private DataTable dt = new DataTable();
        private string TableName = "SHOP_TRANSACTION";

        public EditShopTransaction(DBConnection DBC)
        {
            InitializeComponent();
            this.DBC = DBC;
            Results.RowHeaderMouseDoubleClick += Results_RowHeaderMouseDoubleClick;
        }

        private void EditShopTransaction_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            

            String query = String.Format("INSERT INTO {0} VALUES({1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9});", TableName,
                                        transactionid.Value, transactionType.Value, shopid.Value, customerid.Value,
                                        itemid.Value, quantity.Value, transactionAmt.Value, transactionday.Value, transactionTime.SelectedIndex + 1);


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
            String updates = String.Format("transaction_id={0}, transaction_type={1}, shopid={2}, customer_id={3}, itemid={4}, quantity={5}, transaction_amt={6}, transaction_day={7}, transaction_time={8}",
                                            transactionid.Value, transactionType.Value, shopid.Value, customerid.Value,
                                        itemid.Value, quantity.Value, transactionAmt.Value, transactionday.Value, transactionTime.SelectedIndex + 1);


            String query = String.Format("UPDATE {0} SET {1} WHERE transaction_id={2};", TableName, updates, targetID);

            DBC.ExecuteQuery(query, ds);


            
            RefreshTable();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            

            String idToRemove = Results.SelectedRows[0].Cells[0].Value.ToString();
            String query = String.Format("DELETE FROM {0} WHERE transaction_id={1};", TableName, idToRemove);
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

            transactionid.Value = (int)cells[0].Value;
            transactionType.Value = (int)cells[1].Value;
            shopid.Value = (int)cells[2].Value;
            customerid.Value = (int)cells[3].Value;
            itemid.Value = (int)cells[4].Value;
            quantity.Value = (int)cells[5].Value;
            transactionAmt.Value = (int)cells[6].Value;
            transactionday.Value = (int)cells[7].Value;
            transactionTime.SelectedIndex = (int)cells[8].Value - 1;
        }
    }
}
