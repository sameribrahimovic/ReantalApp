using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReantalApp
{
    public class DbConnection
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        MySqlDataReader dr;
        private string con;

        public string MyConnection()
        {
            //con = @"Data Source=.;Initial Catalog=dbPOS;Integrated Security=True";
            string con = @"server=localhost;user id=root;password=;database=rentaldb;";
            return con;
        }
    }
}
