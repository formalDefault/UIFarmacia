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
        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=default_local;database=pos;");

        public MySqlConnection con { get => connection; }

        public void AbrirConexion()
        {
            try
            {
                connection.Open();
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion: "+ex.Message+" ");
            }

        }

        public void CerrarConexion()
        {
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion al cerrar: " + ex.Message + " ");
            }

        }

        //public MySqlConnection con()
        //{

        //    return connection;
        //}

    }
}
