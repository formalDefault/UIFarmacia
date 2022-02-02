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
        Model.inventario.inventario inventario = new Model.inventario.inventario();
        Model.inventario.varInventario varInventario = new Model.inventario.varInventario();

        public EntradaProducto()
        {
            InitializeComponent();
            Model.inventario.inventario inventario = new Model.inventario.inventario();
            inventario.comboBox(txtProductos, "id, nombre", "productos");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (inventario.regEntrada(inventario.getIdProducto(txtProductos.Text), txtCantidad.Text))
            {
                varInventario.pushStack(inventario.getIdEntrada());
                if (varInventario.countStack() > 1)
                {
                    for (byte i = 0; i <= varInventario.countStack(); i++)
                    {
                        MessageBox.Show("Compra: " + varInventario.IdCompra + " Entrada: " + varInventario.peekStack() + " ");
                        inventario.enlazarEntradasCompras(varInventario.peekStack(), varInventario.IdCompra);
                        varInventario.popStack();
                    }
                }
                else
                {
                    MessageBox.Show("Compra: " + varInventario.IdCompra + " Entrada: " +varInventario.peekStack()+ " ");
                    inventario.enlazarEntradasCompras(varInventario.peekStack(), varInventario.IdCompra);
                }
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inventario.regEntrada(inventario.getIdProducto(txtProductos.Text), txtCantidad.Text))
            {
                MessageBox.Show("Entrada registrada"); 
                varInventario.pushStack(inventario.getIdEntrada());
            }
            txtCantidad.Text = ""; 
            txtProductos.Text = "";
        }

        private void EntradaProducto_Load(object sender, EventArgs e)
        {

        }
    
    }
}
