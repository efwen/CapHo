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
    public partial class EditCustomer : Form
    {
        private DBConnection DBC;
        private DataTable dt = new DataTable();
        private string TableName = "CUSTOMER";

        public EditCustomer(DBConnection DBC)
        {
            InitializeComponent();
            this.DBC = DBC;
            Results.RowHeaderMouseDoubleClick += Results_RowHeaderMouseDoubleClick;
        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            DBC.OpenConn();

            String query = String.Format("INSERT INTO {0} VALUES({1}, {2}, {3}, {4}, {5}, {6}, {7});", TableName,
                                        npcid.Value, baseBudget.Value, budgetScaling.Value, relationship.Value,
                                        stinginess.Value, plainPref.Value, lightPref.Value);

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
            String targetID = Results.SelectedRows[0].Cells[0].Value.ToString();
            String updates = String.Format("n_npcid={0}, basebudget={1}, budgetscaling={2}, relationship={3}, stinginess={4}, plainpreference={5}, lightpreference={6}",
                                            npcid.Value, baseBudget.Value, budgetScaling.Value, relationship.Value,
                                            stinginess.Value, plainPref.Value, lightPref.Value);


            String query = String.Format("UPDATE {0} SET {1} WHERE n_npcid={2};", TableName, updates, targetID);

            DBC.ExecuteQuery(query, ds);


            DBC.CloseConn();
            RefreshTable();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DBC.OpenConn();

            String idToRemove = Results.SelectedRows[0].Cells[0].Value.ToString();
            String query = String.Format("DELETE FROM {0} WHERE n_npcid={1};", TableName, idToRemove);
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

        private void Results_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCellCollection cells = Results.SelectedRows[0].Cells;

            npcid.Value = (int)cells[0].Value;
            baseBudget.Value = (int)cells[1].Value;
            budgetScaling.Value = (Decimal)cells[2].Value;
            relationship.Value = (int)cells[3].Value;
            stinginess.Value = (Decimal)cells[4].Value;
            plainPref.Value = (Decimal)cells[5].Value;
            lightPref.Value = (Decimal)cells[6].Value;
        }
    }
}
