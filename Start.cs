using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Npgsql;

namespace CapHo
{
    public partial class Start : Form
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        public Start()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection DBC = new DBConnection(tbHost.Text, 5432, tbUser.Text, tbPass.Text, tbDBName.Text);

                DBC.OpenConn();


                string sql = "SELECT * FROM npc";

                // data adapter making request from our connection
                NpgsqlDataAdapter da = DBC.ExecuteQuery(sql);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                QueryResults.DataSource = dt;



                DBC.CloseConn();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
        }
    }
}
