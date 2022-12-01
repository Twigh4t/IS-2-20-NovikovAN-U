using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Third
{
    internal static class Program
    {
        public class Connect
        {
            string connStr;
            MySqlConnection conn;

            public MySqlConnection Conn()
            {
                conn = new MySqlConnection(connStr);
                return conn;
            }
            public string RConn()
            {
                return connStr;
            }
            public Connect(string conn)
            {
                connStr = conn;
            }
        }
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Third());
        }
    }
}
