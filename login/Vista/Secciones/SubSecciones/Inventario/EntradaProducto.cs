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
        Model.inventario.varInventario Variables = new Model.inventario.varInventario();
        stock stock = stock.Instance;

        public EntradaProducto()
        {
            InitializeComponent();
            funciones.comboBox(txtProductos, "SELECT nombre FROM productos", "nombre");
            panelAddProduct.Visible = false; 
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de cancelar la Compra?", "Cancelar compra", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (varInventario.countStackEntradas() > 1)
                {
                    for (byte i = 0; i <= varInventario.countStackEntradas(); i++)
                    {
                        funciones.DeleteElement("entradas", varInventario.peekStackEntradas());
                        varInventario.popStackEntradas();
                    }
                    funciones.DeleteElement("compras", Variables.IdCompra);
                    this.Hide();
                }
                else
                {
                    funciones.DeleteElement("compras", Variables.IdCompra);
                    this.Hide();
                }
                    
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtProductos.Text != "" && txtCantidad.Text != "" )
            {
                int idProducto = funciones.GetId("productos", "nombre = '" + txtProductos.Text + "'");
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
                        stock.loadTable();
                        this.Hide();
                    }
                    else
                    {
                        inventario.enlazarEntradasCompras(varInventario.peekStackEntradas(), varInventario.IdCompra);
                        MessageBox.Show("Se finalizó la compra"); 
                        stock.loadTable();
                        this.Hide();
                    }
                } 
            }
            else
            {
                MessageBox.Show("Falta registrar uno de los datos de entrada");
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idProducto = funciones.GetId("productos", "nombre = '"+ txtProductos.Text + "'");
            int cantidadProducto = Int16.Parse(txtCantidad.Text);
            if (inventario.RegEntrada(idProducto , cantidadProducto, inventario.precioProductos(idProducto, cantidadProducto)))
            {
                MessageBox.Show("Entrada registrada");
                varInventario.pushStackEntradas(funciones.GetId("entradas"));
            }
            stock.loadTable();
            txtCantidad.Text = ""; 
            txtProductos.Text = "";
        }

        private void EntradaProducto_Load(object sender, EventArgs e)
        {

        }

        private void txtProductos_Click(object sender, EventArgs e)
        {
            txtProductos.DroppedDown = true;
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if(txtProductos.Text != "" && txtCantidad.Text != "")
            { 
                panelAddProduct.Visible = true;
            }
            if (txtCantidad.Text == "")
            {
                panelAddProduct.Visible = false;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
