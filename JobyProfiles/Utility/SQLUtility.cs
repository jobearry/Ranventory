﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobyProfiles
{
    class SQLUtility
    {
        public static string ConnectionString = "Server=localhost;Database=RASZ;Trusted_Connection=true";
        public static string TableName = "RZINVT01";

        public static SqlConnection DBConnect()
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);   
            return Connection;
        }
    }
}
