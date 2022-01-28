using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace login.Model.caja
{
    class ventas
    {
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=default_local;database=pos;");

        string query;
        
        //imprime los productos en la ventana ventas
        public DataTable vista()
        {
            query = "select * from productos";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;  
        }

    }
}
