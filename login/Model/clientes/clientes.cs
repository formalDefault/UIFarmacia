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


        //se registra el cliente
        public Boolean regCliente(string name, string telefono, string direccion, string email)
        {
            query = "INSERT INTO clientes (nombre, telefono, direccion, email, fecha_registro) VALUES (@name, @tel, @direc, @email, @date)";
            try
            {
                con.Open();
                command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@tel", telefono);
                command.Parameters.AddWithValue("@direc", direccion);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@date", date);
                command.ExecuteNonQuery();
                con.Close(); 
                return true;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Hubo un error en la base de datos: "+ ex.Message+" ");
                return false;
            }
        }
    }
}
