using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login.Vista.Secciones.SubSecciones.Inventario
{
    public partial class AgregarEntrada : Form
    {
        Model.inventario.inventario inventario = new Model.inventario.inventario();
        Model.funcGenerales funciones = new Model.funcGenerales();  

        public AgregarEntrada()
        {
            InitializeComponent();
            funciones.comboBox(comboBox1, "SELECT nombre FROM proveedores", "nombre");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            this.Hide(); 
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            if(textTotal.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Faltan campos por llenar");
            } 
            else
            {
                if (inventario.registrarCompra(funciones.GetId("proveedores", "nombre = '"+ comboBox1.Text +"' "), textTotal.Text, textDescripcion.Text))
                {
                    EntradaProducto entradaProducto = new EntradaProducto();
                    entradaProducto.Show();
                    this.Hide();
                }
            }
        }

        private void textTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.DroppedDown = true;
        }
    }
}
