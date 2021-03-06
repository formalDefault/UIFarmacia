using MySql.Data.MySqlClient;
using System.Data;

namespace login.Model
{
    class funcGenerales : Conexion
    {
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=default_local;database=pos;");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        MySqlDataReader reader;
        private string query;
        string date = DateTime.Now.ToString("yyyy/MM/dd");
        string datetime = DateTime.Now.ToString("hh:mm:ss");
         
        //imprime datos en datagridview
        public DataTable TablaDatos(string querySql)
        {
            DataTable dt = new DataTable();
            query = querySql;
            try
            {
                con.Open();
                adapter = new MySqlDataAdapter(query, con);
                adapter.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en la base de datos: " + ex.Message + " ", "funciones generales 1");
                con.Close();
            }
            return dt;
        }

        //llena los combobox
        public Boolean comboBox(ComboBox cb, string query, string columnName)
        {
            try
            {
                con.Open();
                command = new MySqlCommand(query, con);
                reader = command.ExecuteReader();
                command.CommandType = CommandType.StoredProcedure;

                while (reader.Read())
                {
                    cb.Items.Add(String.Format("{0}", reader["" + columnName + ""]));
                }
                con.Close();
                reader.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: "+ ex.Message+" ", "funciones generales 2");
                con.Close();
                return false;
            }
        }

        //retorna el id del campo de la tabla 
        public int GetId(string tabla, string condicion)
        {
            query = "SELECT id FROM " + tabla + " WHERE " + condicion+" ";
            try
            {
                con.Open();
                command = new MySqlCommand(query, con);
                //command.Parameters.AddWithValue("@condicion", condicion);
                //command.Parameters.AddWithValue("@tabla", tabla);

                reader = command.ExecuteReader();
                reader.Read();
                int id = reader.GetInt16(0);
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error: " + ex.Message + " ", "funciones generales 3");
                return 0;
            }
            finally
            {
                reader.Close();
                con.Close();
            }
        }

        //retorna el ultimo id insertado
        public int GetId(string tabla)
        {
            query = "SELECT MAX(id) FROM " + tabla + " ";
            try
            {
                con.Open();
                command = new MySqlCommand(query, con);
                reader = command.ExecuteReader();
                reader.Read();
                int id = Int16.Parse(reader.GetString(0));
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error: " + ex.Message + " ", "funciones generales 4");
                return 0;
            }
            finally
            {
                con.Close();
            }
        }

        //retorna el campo de la tabla dependiendo de las condiciones
        public string GetCampo(string tabla, string columna, string condiciones)
        {
            query = "SELECT " + columna + " FROM " + tabla + " WHERE " + condiciones + " ";
            try
            {
                con.Open();
                command = new MySqlCommand(query, con);
                reader = command.ExecuteReader();
                reader.Read();
                string campo = reader.GetString(0);
                return campo;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Hubo un error " + ex.Message + " ", "funcG 5"); //quitar 
                return "";
            }
            finally
            {
                con.Close();
            }
        }


        //Elimina un registro de la base de datos
        public Boolean DeleteElement(string tabla, int idElement)
        {
            query = "DELETE FROM " + tabla + " WHERE id = " + idElement + " ";
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
                MessageBox.Show("Error en la base de datos: " + ex.Message + " ", "funciones generales 6");
                con.Close();
                return false;
            }
        }

    }
}
