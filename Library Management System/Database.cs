using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Library_Management_System
{
    public class Database
    {
        private static string connectionstring = "Server=localhost;Database=lms;Username=lms_svc;Password=lms@123";

        public static MySqlConnection GetConnecton()
        {
            return new MySqlConnection(connectionstring);
        }
    }
}
