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
    public partial class EntradaProducto : Form
    { 
        Model.funcGenerales funciones = new Model.funcGenerales();
        Model.inventario.varInventario varInventario = new Model.inventario.varInventario();
        Model.inventario.inventario inventario = new Model.inventario.inventario();

        public EntradaProducto()
        {
            InitializeComponent();
            funciones.comboBox(txtProductos, "id, nombre", "productos");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idProducto = funciones.GetId("productos", txtProductos.Text);
            int cantidadProducto = Int16.Parse(txtCantidad.Text);
            if (inventario.RegEntrada(idProducto, cantidadProducto, inventario.precioProductos(idProducto, cantidadProducto)))
            {
                varInventario.pushStackEntradas(funciones.GetId("entradas"));
                if (varInventario.countStackEntradas() > 1)
                {
                    for (byte i = 0; i <= varInventario.countStackEntradas(); i++)
                    {
                        inventario.enlazarEntradasCompras(varInventario.peekStackEntradas(), varInventario.IdCompra);
                        varInventario.popStackEntradas();
                    }
                    MessageBox.Show("Se finalizó la compra"); 
                    this.Hide();
                }
                else
                {
                    inventario.enlazarEntradasCompras(varInventario.peekStackEntradas(), varInventario.IdCompra);
                    MessageBox.Show("Se finalizó la compra"); 
                    this.Hide();
                }
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idProducto = funciones.GetId("productos",txtProductos.Text);
            int cantidadProducto = Int16.Parse(txtCantidad.Text);
            if (inventario.RegEntrada(idProducto , cantidadProducto, inventario.precioProductos(idProducto, cantidadProducto)))
            {
                MessageBox.Show("Entrada registrada"); 
                varInventario.pushStackEntradas(funciones.GetId("entradas"));
            }
            txtCantidad.Text = ""; 
            txtProductos.Text = "";
        }

        private void EntradaProducto_Load(object sender, EventArgs e)
        {

        }
    
    }
}
