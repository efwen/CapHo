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
    public partial class EditNPC : Form
    {
        private DBConnection DBC;
        private DataTable dt = new DataTable();

        public EditNPC(DBConnection DBC)
        {
            InitializeComponent();
            this.DBC = DBC;
            Results.RowHeaderMouseDoubleClick += Results_RowHeaderMouseDoubleClick;
        }

        private void Results_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCellCollection cells = Results.SelectedRows[0].Cells;

            name.Text = cells[0].Value.ToString();
            npcid.Value = (int)cells[1].Value;
            gender.Text = cells[2].Value.ToString();
            age.Value = (int)cells[3].Value;
            race.Text = cells[4].Value.ToString();
        }

        private void EditNPC_Load(object sender, EventArgs e)
        {
            DBC.OpenConn();

            String query = "SELECT * FROM NPC";
            DBC.ExecuteQuery(query, ds);

            if (ds.Tables.Count != 0)
            {
                dt = ds.Tables[0];
                Results.DataSource = dt;
            }

            DBC.CloseConn();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            DBC.OpenConn();

            String query = String.Format("INSERT INTO NPC VALUES(\'{0}\', {1}, \'{2}\', {3}, \'{4}\');",
                                        name.Text, npcid.Value, gender.Text, age.Value, race.Text);

            DBC.ExecuteQuery(query, ds);

            if (ds.Tables.Count != 0)
            {
                dt = ds.Tables[0];
                Results.DataSource = dt;
            }

            DBC.CloseConn();

            RefreshTable();
        }

        private void RefreshTable()
        {
            DBC.OpenConn();
            //update the table
            String query = "SELECT * FROM NPC";
            DBC.ExecuteQuery(query, ds);

            if (ds.Tables.Count != 0)
            {
                dt = ds.Tables[0];
                Results.DataSource = dt;
            }

            DBC.CloseConn();
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            DBC.OpenConn();
            String targetID = Results.SelectedRows[0].Cells[1].Value.ToString();
            String updates = String.Format("name=\'{0}\', npcid={1}, gender=\'{2}\', age={3}, race=\'{4}\'",
                                            name.Text, npcid.Value, gender.Text, age.Value, race.Text);
            String query = String.Format("UPDATE NPC SET {0} WHERE npcid={1};", updates, targetID);

            DBC.ExecuteQuery(query, ds);

            
            DBC.CloseConn();
            RefreshTable();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DBC.OpenConn();

            String idToRemove = Results.SelectedRows[0].Cells[1].Value.ToString();
            String query = String.Format("DELETE FROM NPC WHERE npcid={0};", idToRemove);
            DBC.ExecuteQuery(query, ds);

            DBC.CloseConn();
            RefreshTable();
        }
    }
}
