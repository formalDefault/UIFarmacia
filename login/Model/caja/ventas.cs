using MySql.Data.MySqlClient;

namespace login.Model.caja
{
    class ventas : varCaja
    {
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=default_local;database=pos;");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        MySqlDataReader reader;
        private string query;
        string date = DateTime.Now.ToString("yyyy/MM/dd");
        string datetime = DateTime.Now.ToString("hh:mm:ss");
        Model.funcGenerales funciones = new Model.funcGenerales();

        //guarda el id de la venta en proceso
        public void setIdVenta()
        {
            query = "SELECT MAX(id) FROM ventas";
            try
            {
                con.Open();
                command = new MySqlCommand(query, con);
                reader = command.ExecuteReader();
                reader.Read();
                IdVenta = Int16.Parse(reader.GetString(0));
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: "+ ex.Message +" ", "vnts 01");
                con.Close();
            }
        }

        //registra la venta
        public Boolean RegVenta()
        {
            query = "";
            try
            {
                con.Open();
                command = new MySqlCommand(query, con);
                //command.Parameters.AddWithValue("", );
                command.ExecuteNonQuery();
                con.Close();
                setIdVenta();
                return true;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Hubo un error en la base de datos: " + ex.Message + " ", "vnts 02");
                return false;
            }
        }

        //registra la salidas de los productos
        public Boolean regSalidas(int idProduct, int cantidad)
        {
            query = "";
            try
            {
                con.Open();
                command = new MySqlCommand(query, con);
                //command.Parameters.AddWithValue("", );
                command.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: "+ex.Message+" ", "vnts 03");
                con.Close();
                return false;
            }
        }

        //enlaza las salidas con una venta
        public Boolean enlazarSalidasVentas(int idSalida)
        {
            query = "";
            try
            {
                con.Open();
                command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("@venta", IdVenta);
                command.Parameters.AddWithValue("@salida", idSalida);
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Se relacionaron las entradas con la compra " + IdVenta + "");
                IdVenta = 0;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message + " ", "vnts 04");
                con.Close();
                return false;
            }
        }
    }
}
