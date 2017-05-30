using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Net.Sockets;
using System.Windows.Forms; //for messagebox errors
using Npgsql;
using NpgsqlTypes;

namespace CapHo
{
    public class DBConnection
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
        public bool OpenConn()
        {

            try
            {
                conn.Open();
                open = true;
                return true;
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show(e.Message, "SQL Exception!");
                return false;
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message, "Could not Open Connection!");
                return false;
            }
            
        }

        //close the connection
        public bool CloseConn()
        {
            try
            {
                conn.Close();
                open = false;
                return true;
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show(e.Message, "SQL Exception!");
                return false;
            }
        }

        public bool ExecuteQuery(String query, DataSet ds, String column = "")
        {
            ds.Reset();

            if(open == false)
            {
                MessageBox.Show("Connection not open!");
                return false;
            }

            try
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                if(column != "")
                {
                    da.Fill(ds, column);
                }
                else
                {
                    da.Fill(ds);
                }
                return true;
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show(e.Message, "SQL Exception!");
                return false;
            }
        }

        //data
        private NpgsqlConnection conn;
        bool open = false;

    }
}
