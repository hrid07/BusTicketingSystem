using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketingSystem
{
    internal class DBConnection
    {
        private static readonly string connString =
            ConfigurationManager.ConnectionStrings["BusDB"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connString);
        }

        // Quick sanity check you can call from anywhere to confirm the DB is reachable
        public static bool TestConnection()
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection failed:\n" + ex.Message,
                    "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
