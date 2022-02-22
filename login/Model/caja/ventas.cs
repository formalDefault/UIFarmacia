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
        string time = DateTime.Now.ToString("hh:mm:ss");
        Model.funcGenerales funciones = new Model.funcGenerales();
        Conexion conexion = new Conexion();

        static async Task<Boolean> Metodo(MySqlConnection conn, MySqlCommand cmd)
        {
            try
            {
                await cmd.ExecuteNonQueryAsync();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex.Message + " ");
                return false;
            }
        }

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
        public Boolean RegVenta(float total)
        {
            query = "INSERT INTO ventas (idCliente, fecha, hora, total, estado) VALUES (6, @date, @time, @total, 'completado') ";
            try
            {
                con.Open();
                command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@time", time);
                command.Parameters.AddWithValue("@total", total);
                command.ExecuteNonQuery();
                con.Close();
                //regSalidas(total);
                setIdVenta();
                //enlazarSalidasVentas();
                return true;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Hubo un error en la base de datos: " + ex.Message + " ", "vnts 02");
                return false;
            }
        }

        //registra la salidas de los productos (funcion asincrona)
        public async void regSalidas(int producto, int cantidad, float total)
        {
            query = "INSERT INTO salidas (idProducto, cantidad, fecha, hora, total) VALUES ( @producto, @cantidad, @date, @time, @total )";

            try
            {  
                conexion.AbrirConexion();
                command = new MySqlCommand(query, conexion.con);
                command.Parameters.AddWithValue("@time", time);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@cantidad", cantidad);
                command.Parameters.AddWithValue("@total", total);
                command.Parameters.AddWithValue("@producto", producto); 
                await Metodo(conexion.con, command); 
                conexion.CerrarConexion();
                pushStackSalidas(GetIdSalidas("SELECT MAX(id) FROM salidas ")); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: "+ex.Message+" ", "vnts 03"); 
                borrarVenta(IdVenta); 
            }
        } 
         
        //enlaza las salidas con una venta
        public Boolean enlazarSalidasVentas()
        {
            query = "INSERT INTO venta_salidas (idVenta, idSalida) VALUES ( @venta, @salida )";
            try
            {
                if(countStackSalidas() > 1 )
                {
                    for(byte i = 0; i <= countStackSalidas() + 1 ; i++)
                    {
                        con.Open();
                        command = new MySqlCommand(query, con);
                        command.Parameters.AddWithValue("@venta", IdVenta);
                        command.Parameters.AddWithValue("@salida", peekStackSalidas());
                        command.ExecuteNonQuery();
                        con.Close();
                        popStackSalidas();
                    }
                }
                else
                {
                    con.Open();
                    command = new MySqlCommand(query, con);
                    command.Parameters.AddWithValue("@venta", IdVenta);
                    command.Parameters.AddWithValue("@salida", peekStackSalidas());
                    command.ExecuteNonQuery();
                    con.Close();
                    popStackSalidas();
                } 
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message + " ", "vnts 04");
                con.Close();
                borrarVenta(IdVenta);
                return false;
            }
        }

        //para borrar venta en caso de algun error
        public Boolean borrarVenta(int id)
        {
            query = "DELETE FROM ventas WHERE id = "+id;
            try
            {
                con.Open();
                command = new MySqlCommand(query, con); 
                command.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message + " ", "vnts 05");
                con.Close();
                return false;
            }
        }

        public int GetIdSalidas(string query)
        {
            //query = "SELECT MAX(id) FROM salidas ";
            try
            {
                con.Open();
                command = new MySqlCommand(query, con);
                reader = command.ExecuteReader();
                reader.Read();
                int id = Int16.Parse(reader.GetString(0));
                reader.Close();
                con.Close();
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error " + ex.Message + " ", "vnts 06");
                return 0;
            } 
        }

    }
}
