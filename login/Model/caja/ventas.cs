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

        private string query;

        //imprime los productos en la ventana ventas
        public DataTable TablaProductos()
        {
            DataTable dt = new DataTable();
            query = "select * from productos";
            try
            {
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                adapter.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en la base de datos", ex.Message);
                con.Close();
            }
            return dt;
        } 

    }
}
