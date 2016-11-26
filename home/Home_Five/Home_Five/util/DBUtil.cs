using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Home_Five.util
{
    class DBUtil
    {
        private SqlConnection conn;

        public SqlConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }
        private SqlCommand command;

        public SqlCommand Command
        {
            get { return command; }
            set { command = value; }
        }

        public DBUtil()
        {
            conn = new SqlConnection(getConnection());///获取连接
            command = new SqlCommand();
            conn.Open();
            command.Connection = conn;
        }
        public bool isConnect()
        {
            return conn.State == ConnectionState.Open ? true : false;
        }        
        private string getConnection()
        {
            return "server=localhost;Integrated Security=SSPI;database=Student";
        }
        
        //~DBUtil()
        //{
        //    if (null != conn)
        //    {
        //        conn.Close();
        //        conn = null;
        //    }
        //    if (null != command)
        //    {
        //        command = null;
        //    }
        //}
    }
}
