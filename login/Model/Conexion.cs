using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login.Model
{
    class Conexion
    {
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=default_local;database=pos;"); 

        public Conexion()
        {
            try
            {
                con.Open();
            } 
            catch (Exception ex)
            {

            }

        }

    }
}
