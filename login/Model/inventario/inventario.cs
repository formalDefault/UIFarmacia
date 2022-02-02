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

        //imprime los productos en la ventana ventas
        public DataTable TablaProductoInventarios()
        {
            DataTable dt = new DataTable();
            query = "SELECT p.id, p.`codigo`, p.`nombre`, p.`descripcion`, p.`costo`, p.`retail`, p.`mayoreo`, p.`categoria`, p.`periodoDevolucion_dias` as devolucion, SUM(e.cantidad) AS stock FROM productos AS p LEFT JOIN entradas AS e ON e.`idProducto` = p.`id` ";
            try
            {
                con.Open();
                adapter = new MySqlDataAdapter(query, con);
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
                MessageBox.Show("Hubo un error en la base de datos", ex.Message);
                con.Close();
                return false;
            }
        }

        //guarda el id de la compra en proceso
        public void getIdCompra()
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
                MessageBox.Show("Hubo un error", ex.Message);
                con.Close();
            } 
        }

        //se registra la compra de productos a un proveedor
        public Boolean registrarCompra(string proveedor, string costoTotal, string descripcion)
        {
            query = "INSERT INTO compras ( idProveedor, costoTotal, fecha, hora, descripcion ) VALUES ( @prov, @total, @date, @time, @descripcion )";
            varInventario variables = new varInventario(); //quitar (solo se ocupa para mostrar el id de la compra)
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
                getIdCompra();
                MessageBox.Show("Se inicio la compra "+ variables.IdCompra + " ");//quitar el id de la compra
                return true;
            } 
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //llena los combobox
        public Boolean comboBox(ComboBox cb, string columnas, string tabla)
        {
            query = "SELECT "+columnas+" FROM "+tabla+" ";
            try
            {
                con.Open();
                command = new MySqlCommand(query, con);
                reader = command.ExecuteReader();
                command.CommandType = CommandType.StoredProcedure;

                while (reader.Read())
                {
                    cb.ValueMember = String.Format("{0}", reader["id"]); 
                    cb.Items.Add(String.Format("{0}", reader["nombre"])); 
                }  
                con.Close();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error en la base de datos", ex.Message);
                con.Close();
                return false;
            }
        }
        
        //(sobrecarga de comboBox) llena los combobox con flitros
        public Boolean comboBox(ComboBox cb, string columnas, string tabla, string condiciones)
        {
            query = "SELECT "+columnas+" FROM "+tabla+" "+condiciones+" ";
            try
            {
                con.Open();
                command = new MySqlCommand(query, con);
                reader = command.ExecuteReader();
                command.CommandType = CommandType.StoredProcedure;

                while (reader.Read())
                {
                    cb.ValueMember = String.Format("{0}", reader["id"]); 
                    cb.Items.Add(String.Format("{0}", reader["nombre"])); 
                }  
                con.Close();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error en la base de datos", ex.Message);
                con.Close();
                return false;
            }
        }

        //retorna el id del producto
        public int getIdProducto(string name)
        {
            query = "SELECT id FROM productos WHERE nombre = @name";
            try
            {
                con.Open();
                command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("@name", name);
                reader = command.ExecuteReader(); 
                reader.Read();
                int id = reader.GetInt16(0); 
                return id; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error "+ex.Message+" "); 
                return 0;
            }
            finally
            {
                con.Close();  
            }
        }

        //retorna el id de la ultima compra
        public int getIdEntrada()
        {
            query = "SELECT MAX(id) FROM entradas";
            try
            {
                con.Open();
                command = new MySqlCommand(query, con);
                reader = command.ExecuteReader();
                reader.Read();
                int id = reader.GetInt16(0);
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error " + ex.Message + " ");
                return 0;
            }
            finally
            {
                con.Close();
            }
        }

        //registra la entrada de un producto
        public Boolean regEntrada(int idProd, string cantidad)
        {
            query = "INSERT INTO entradas ( idProducto, cantidad, fecha, hora ) VALUES ( @idProd, @cant, @date, @time )";
            try
            {
                con.Open();
                command = new MySqlCommand(query, con);
                command.Parameters.AddWithValue("@idprod", idProd);
                command.Parameters.AddWithValue("@cant", cantidad);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@time", datetime);
                command.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos " + ex.Message + " ");
                con.Close();
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


    }
}
