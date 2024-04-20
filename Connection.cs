using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPlivre
{
    static class Connection
    {
        private static string costr = "server=btssio.dedyn.io;" +
                               "port=3306;" +
                               "Database=ROUSSEL_biblio;" +
                               "Uid=ROUSSEL;" +
                               "pwd=02082004";
        private static MySqlConnection _connection = new MySqlConnection(costr);

        public static MySqlConnection Co { get => _connection; set => _connection = value; }
        //private static MySqlCommand _command;
        //private static MySqlDataReader _reader;
    }
}
