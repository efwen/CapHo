using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Windows.Forms; //for messagebox errors
using Npgsql;
using NpgsqlTypes;

namespace CapHo
{
    class DBConnection
    {
        public DBConnection(String URL, UInt16 port, String DBName, String username, String password)
        {
            //make a connection string
            String connectionString = String.Format("Server={0};Port={1};" +
                                                    "User Id={2};Password={3};Database={4};",
                                                    URL, port.ToString(), username,
                                                    password, DBName);
            conn = new NpgsqlConnection(connectionString);
        }

        //open a connection
        public void OpenConn()
        {
            try
            {
                conn.Open();
            }
            catch(NpgsqlException e)
            {
                MessageBox.Show(e.Message, "SQL Exception!");
            }
        }

        //close the connection
        public void CloseConn()
        {
            try
            {
                conn.Close();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show(e.Message, "SQL Exception!");
            }
        }

        public void ExecuteQuery(String query, DataSet ds)
        {
            ds.Reset();
            try
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                da.Fill(ds);
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show(e.Message, "SQL Exception!");
            }
        }

        //data
        private NpgsqlConnection conn;

    }
}
