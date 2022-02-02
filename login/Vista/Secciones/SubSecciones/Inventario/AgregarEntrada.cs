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
        public AgregarEntrada()
        {
            InitializeComponent();
            Model.inventario.inventario inventario = new Model.inventario.inventario();
            inventario.comboBox(textProveedor, "id, nombre", "proveedores");
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
            if(textTotal.Text == "" || textProveedor.Text == "")
            {
                MessageBox.Show("Faltan campos por llenar");
            } 
            else
            {
                Model.inventario.inventario inventario = new Model.inventario.inventario();
                if (inventario.registrarCompra(textProveedor.ValueMember, textTotal.Text, textDescripcion.Text))
                {
                    EntradaProducto entradaProducto = new EntradaProducto();
                    entradaProducto.Show();
                    this.Hide();
                }
            }
        }
    }
}
