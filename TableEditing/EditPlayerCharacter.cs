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
    public partial class EditPlayerCharacter : Form
    {
        private DBConnection DBC;
        private DataTable dt = new DataTable();
        private string TableName = "player_character";

        public EditPlayerCharacter(DBConnection DBC)
        {
            InitializeComponent();
            this.DBC = DBC;
            Results.RowHeaderMouseDoubleClick += Results_RowHeaderMouseDoubleClick;
        }

        private void Results_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCellCollection cells = Results.SelectedRows[0].Cells;


            playerid.Value = (int)cells[0].Value;
            name.Text = cells[1].Value.ToString();
            gender.Text = cells[2].Value.ToString();
            merchantlevel.Value = (int)cells[3].Value;
            currentbalance.Value = (int)cells[4].Value;
            currentdebt.Value = (int)cells[5].Value;
        }

        private void EditPlayerCharacter_Load(object sender, EventArgs e)
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
            

            String query = String.Format("INSERT INTO {0} VALUES({1}, \'{2}\', \'{3}\', {4}, {5}, {6});", TableName,
                                        playerid.Value, name.Text, gender.Text, merchantlevel.Value, currentbalance.Value, currentdebt.Value);

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
            String updates = String.Format("playerid={0}, name=\'{1}\', gender=\'{2}\', merchantlevel={3}, currentbalance={4}, currentdebt={5}",
                                            playerid.Value, name.Text, gender.Text, merchantlevel.Value, currentbalance.Value, currentdebt.Value);

            String query = String.Format("UPDATE {0} SET {1} WHERE playerid={2};", TableName, updates, targetID);

            DBC.ExecuteQuery(query, ds);


            
            RefreshTable();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            

            String idToRemove = Results.SelectedRows[0].Cells[0].Value.ToString();
            String query = String.Format("DELETE FROM {0} WHERE playerid={1};", TableName, idToRemove);
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
