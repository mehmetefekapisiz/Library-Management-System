﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LibraryManagementSystem.THE_DATABASE
{
    internal class MYDB
    {
        private SqlConnection connection = new SqlConnection("Data Source=DESKTOP-J9OU9EE\\SQLEXPRESS;Initial Catalog=LibraryManagementSystem;Integrated Security=True");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return connection;
        }
    }
}
