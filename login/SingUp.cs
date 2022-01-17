using MySql.Data.MySqlClient;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; 
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class SingUp : Form
    {
        public SingUp()
        {
            InitializeComponent();
        }

        private void SaveUser()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=test;";
            string query = "INSERT INTO user(`id`, `first_name`, `last_name`, `address`) VALUES (NULL, '" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "')";
            // Que puede ser traducido con un valor a:
            // INSERT INTO user(`id`, `first_name`, `last_name`, `address`) VALUES (NULL, 'Bruce', 'Wayne', 'Wayne Manor')

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Usuario insertado satisfactoriamente");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Mostrar cualquier error
                MessageBox.Show(ex.Message);
            }
        }

        private void flowLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void label6_MouseClick(object sender, MouseEventArgs e)
        { 
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {  
        }

        private void button1_Click(object sender, EventArgs e)
        {   
        }
    }
}
