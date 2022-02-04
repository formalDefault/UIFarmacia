using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace login.Model.clientes
{
    class clientes
    {
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=default_local;database=pos;");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        MySqlDataReader reader;
        private string query;
        string date = DateTime.Now.ToString("yyyy/MM/dd");
        string datetime = DateTime.Now.ToString("hh:mm:ss");
         

    }
}
