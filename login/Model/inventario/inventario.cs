using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace login.Model.inventario
{
    class inventario : varInventario
    {
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=default_local;database=pos;");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        MySqlDataReader reader;
        private string query;
        string date = DateTime.Now.ToString("yyyy/MM/dd");
        string datetime = DateTime.Now.ToString("hh:mm:ss");
        Model.funcGenerales funciones = new Model.funcGenerales();  
         
        //registra los productos en el catalogo (no se registran como inventario)
        public Boolean registrarProducto(string code, string name, string descrip, string costo, string retail, string mayoreo, string categoria, string devolucion) //registrar producto en el catalogo
        {
            query = "INSERT INTO productos (codigo, nombre, descripcion, costo, retail, mayoreo, categoria, periodoDevolucion_dias) VALUES (@code, @name, @descrip, @costo, @retail, @mayoreo, @categoria, @devolucion)";
            
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("@code", code);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@descrip", descrip);
                command.Parameters.AddWithValue("@costo", costo);
                command.Parameters.AddWithValue("@retail", retail);
                command.Parameters.AddWithValue("@mayoreo", mayoreo);
                command.Parameters.AddWithValue("@categoria", categoria);
                command.Parameters.AddWithValue("@devolucion", devolucion);
                command.ExecuteNonQuery();
                MessageBox.Show("Se registro el producto correctamente");
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un Error en la base de datos: ", ex.Message);
                con.Close();
                return false;
            }
        }

        //se registra la compra de productos a un proveedor
        public Boolean registrarCompra(int proveedor, string costoTotal, string descripcion)
        {
            query = "INSERT INTO compras ( idProveedor, costoTotal, fecha, hora, descripcion ) VALUES ( @prov, @total, @date, @time, @descripcion )";
            try
            {
                con.Open();
                command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("@prov", proveedor);
                command.Parameters.AddWithValue("@total", costoTotal);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@time", datetime);
                command.Parameters.AddWithValue("@descripcion", descripcion);
                command.ExecuteNonQuery(); 
                con.Close();
                setIdCompra();
                return true;
            } 
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
                return false;
            }
        }
         
        //guarda el id de los productos
        public void setIdProducto()
        {
            query = "SELECT id FROM productos";
            varInventario variables = new varInventario(); 
            try
            {
                con.Open();
                command = new MySqlCommand(query, con); 
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    variables.pushStackProductos(reader.GetInt16(0));
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message+" ");  
            }
            finally
            {
                con.Close();  
            }
        }

        //guarda el id de la compra en proceso
        public void setIdCompra()
        {
            varInventario variables = new varInventario();
            query = "SELECT MAX(id) FROM compras";
            try
            {
                con.Open();
                command = new MySqlCommand(query, con);
                reader = command.ExecuteReader();
                reader.Read();
                variables.IdCompra = Int16.Parse(reader.GetString(0));
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: ", ex.Message);
                con.Close();
            } 
        }

        //retorna el costo por cantidad de un cierto producto 
        public int precioProductos(int id, int cantidad)
        {
            query = "SELECT (costo * " + cantidad + ") FROM productos WHERE id = " + id+" ";
            try
            {
                con.Open();
                command = new MySqlCommand(query, con);
                reader = command.ExecuteReader();
                reader.Read();
                int total = reader.GetInt16(0);
                con.Close();
                reader.Close();
                return total;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error " + ex.Message + " ");
                con.Close();
                return 0;
            } 
        }

        //registra la entrada de un producto
        public Boolean RegEntrada(int idProd, int cantidad, float total)
        {
            query = "INSERT INTO entradas ( idProducto, cantidad, fecha, hora, total ) VALUES ( @idProd, @cant, @date, @time, @total )"; 
            varInventario variables = new varInventario(); 
            try
            {
                con.Open();
                command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("@idprod", idProd);
                command.Parameters.AddWithValue("@cant", cantidad);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@time", datetime);
                command.Parameters.AddWithValue("@total", total);
                command.ExecuteNonQuery(); 
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message + " ");
                con.Close();
                funciones.DeleteElement("compras", variables.IdCompra);
                return false;
            }
        }
         
        //enlaza las entradas con las compras
        public Boolean enlazarEntradasCompras(int idEntrada, int idCompra)
        {
            query = "INSERT INTO compras_entradas ( idEntrada, idCompra, estado ) VALUES (@entrada, @compra, 'completado')";
            try
            {
                con.Open();
                command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("@entrada",idEntrada);
                command.Parameters.AddWithValue("@compra",idCompra);
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Se relacionaron las entradas con la compra "+IdCompra+"");
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error en la base de datos: "+ex.Message+" ");
                con.Close();
                return false;
            }
        }
         


        //MODELO DE DATOS ENTRADAS
        

    }
}
