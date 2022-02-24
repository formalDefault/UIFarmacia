using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace login.Model
{
    class Usuarios
    {
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=default_local;database=pos;");
         
        public static string GetSHA1(String texto)
        {
            SHA1 sha1 = SHA1.Create();
            Byte[] textOriginal = ASCIIEncoding.Default.GetBytes(texto);
            Byte[] hash = sha1.ComputeHash(textOriginal);
            StringBuilder cadena = new StringBuilder();
            foreach (byte i in hash)
            {
                cadena.AppendFormat("{0:x2}", i);
            }
            return cadena.ToString();
        } //algoritmo de encriptacion
         
        public static bool ComprobarFormatoEmail(string seEmailAComprobar)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(seEmailAComprobar, sFormato))
            {
                if (Regex.Replace(seEmailAComprobar, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }//Comprobar el formato del email

        public bool FormatoEmail(string email)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, sFormato))
            {
                if (Regex.Replace(email, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }//Comprobar el formato del email

        public bool Login(String User, String Pass) 
        {
            try
            {
                con.Open();
                DateTime hoy = DateTime.Now;
                MySqlCommand query = new MySqlCommand("SELECT email, password, CONCAT(nombre, ' ', appat, ' ', apmat) AS nombre  FROM usuarios WHERE email = @user AND password = @pass", con);
                query.Parameters.AddWithValue("@user", User);
                query.Parameters.AddWithValue("@pass", GetSHA1("" + User + "" + Pass + ""));

                MySqlDataReader reader = query.ExecuteReader(); 

                if (reader.Read())
                { 
                    MessageBox.Show("Bienvenido"); 
                    Vista.Variables var = new Vista.Variables();
                    var.User = String.Format("{0}", reader["nombre"]);
                    con.Close();
                    return true;
                }
                else
                {
                    con.Close();
                    MessageBox.Show("Datos incorrectos");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error de parte de la base de datos");
                return false;
            }
        }//Login(<usuario>,<contraseña>)

        public bool Registro(String Email, String Pass, String PassConfirm, String Date, String Nombre, String Appat, String Apmat) 
        {
            try
            {
                if (ComprobarFormatoEmail(Email))
                {
                    if (Pass == PassConfirm)
                    {
                        con.Open();
                        DateTime hoy = DateTime.Now;
                        MySqlCommand query = new MySqlCommand("INSERT INTO usuarios ( nombre, appat, apmat ,email, password, fecha_registro ) VALUES ( @name, @appat, @apmat, @user, @pass, @date)", con);
                        
                        query.Parameters.AddWithValue("@name", Nombre);
                        query.Parameters.AddWithValue("@appat", Appat);
                        query.Parameters.AddWithValue("@apmat", Apmat);
                        query.Parameters.AddWithValue("@user", Email);
                        query.Parameters.AddWithValue("@pass", GetSHA1("" + Email + "" + Pass + "")); 
                        query.Parameters.AddWithValue("@date", hoy);
                        query.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Se realizo el registro correctamente");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un correo valido");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error de parte de la base de datos");
                return false;
            }
        }//Registro(<Correo>,<contraseña>,<Confirmacion Contraseña>,<Fecha>,<Nombre>,<primer apellido>,<segundo apellido>)
    
    }
}
