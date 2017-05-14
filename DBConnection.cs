using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms; //for messagebox errors
using Npgsql;
using NpgsqlTypes;

namespace CapHo
{
    class DBConnection
    {
        public DBConnection(String URL, UInt16 port, String DBName, String username, String password)
        {
            connectionOpen = false;

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
                connectionOpen = true;
            }
            catch(Exception e)
            {
                MessageBox.Show("Exception!" + e.ToString());
            }
        }

        //close the connection
        public void CloseConn()
        {
            try
            {
                conn.Close();
                connectionOpen = false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception!" + e.ToString());
            }
        }

        public NpgsqlDataAdapter ExecuteQuery(String query)
        {
            try
            {
                return new NpgsqlDataAdapter(query, conn);
            }
            catch(NpgsqlException e)
            {
                MessageBox.Show("NpgSQL exception: " + e.Detail);
                return new NpgsqlDataAdapter(); //just return an empty adapter
            }
        }

        //data
        private NpgsqlConnection conn;
        private bool connectionOpen;

    }
}
