using MySql.Data.MySqlClient;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace login
{
    public partial class SingUp : Form
    {
        public SingUp()
        {
            InitializeComponent();
        }
         
        private void flowLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }

        private void label6_MouseClick(object sender, MouseEventArgs e)
        { 
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        //Boton para enviar formulario
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            string date = hoy.ToString();
            Model.Usuarios user = new Model.Usuarios();
            if (user.Registro(textBox4.Text, textBox5.Text, textBox6.Text, date, textBox1.Text, textBox2.Text, textBox3.Text))
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            } 
        }

        private void panel8_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox5.PasswordChar == '*')
            {
                textBox5.PasswordChar = '\0';
            }
            else
            {
                textBox5.PasswordChar = '*';
            }
        }

        private void panel9_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox6.PasswordChar == '*')
            {
                textBox6.PasswordChar = '\0';
            }
            else
            {
                textBox6.PasswordChar = '*';
            }
        }

        private void flowLayoutPanel2_Click(object sender, EventArgs e)
        { 
            WindowState = FormWindowState.Minimized;
        }

        private void label10_Click(object sender, EventArgs e)
        { 
        }
         
    }
}
