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
                               "Database=ELMANOU_Ado;" +
                               "Uid=ELMANOU;" +
                               "pwd=17042003";
        private static MySqlConnection _connection = new MySqlConnection(costr);

        public static MySqlConnection Co { get => _connection; set => _connection = value; }
        //private static MySqlCommand _command;
        //private static MySqlDataReader _reader;
    }
}
