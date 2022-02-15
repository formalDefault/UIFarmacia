using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login.Vista.Secciones.SubSecciones.Caja
{
    public partial class Carrito : Form
    {
        Model.funcGenerales funciones = new Model.funcGenerales();
        Model.caja.ventas ventas = new Model.caja.ventas();
        static int idProduct = 0;

        public Carrito()
        { 
            InitializeComponent();
            string ids = string.Join(", ", Model.caja.PilaProducts.seeStack());
            if(ids.Equals(""))
            {
                dataGridView1.Visible = false; 
                cobrar_btn.Visible = false; 
            }
            else
            { 
                dataGridView1.DataSource = funciones.TablaDatos("SELECT id, nombre, retail as precio FROM productos WHERE id IN ( " + ids + " )");
                labelTotal.Text = "$"+funciones.GetCampo("productos", "SUM(retail) as total", "id IN(" + ids + ")")+" MXN"; 
            }
            
            if (radioButton1.Checked) panelCliente.Visible = false;
        }

        //Obtiene el id de la fila selecciona en la tabla
        public static string GetValorCelda(DataGridView dgv, int num)
        { 
            string valor = dgv.Rows[dgv.CurrentRow.Index].Cells[num].Value.ToString();

            return valor;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panelCliente.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panelCliente.Visible=true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void quitarProducto_Btn_Click(object sender, EventArgs e)
        {
            Model.caja.PilaProducts.popStack(idProduct);
            string ids = string.Join(", ", Model.caja.PilaProducts.seeStack());
            if (ids.Equals(""))
            {
                dataGridView1.Visible = false; 
                labelTotal.Text = "$0.00";
                cobrar_btn.Visible = false;
            }
            else
            {
                dataGridView1.DataSource = funciones.TablaDatos("SELECT id, nombre, retail as precio FROM productos WHERE id IN ( " + ids + " )");
                labelTotal.Text = "$" + funciones.GetCampo("productos", "SUM(retail) as total", "id IN(" + ids + ")") + " MXN";
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            idProduct = Int16.Parse(GetValorCelda(dataGridView1, 1)); 
        }

        //limpia la pila y restablece la ventana
        private void limpiar()
        {
            foreach (var i in Model.caja.PilaProducts.seeStack())
            {
                Model.caja.PilaProducts.popStack(i);
            }
            dataGridView1.Visible = false;
            labelTotal.Text = "$0.00"; 
            cobrar_btn.Visible = false;
        }

        private void cobrar_btn_Click(object sender, EventArgs e)
        {
            string ids = string.Join(", ", Model.caja.PilaProducts.seeStack());
            float total = Int16.Parse(funciones.GetCampo("productos", "SUM(retail) as total", "id IN(" + ids + ")"));

            if (ventas.RegVenta(total))
            {
                limpiar();
                MessageBox.Show("Venta finalizada con exito");
            }
        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esta seguro de cancelar la compra?", "Cancelar compra", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                limpiar();
            }
            
        }

        private void agregar_btn_Click(object sender, EventArgs e)
        {
            Model.caja.PilaProducts.Push(Int32.Parse(funciones.GetCampo("productos", "id", "codigo =" + txtCodigo.Text + " ")));

            string ids = string.Join(", ", Model.caja.PilaProducts.seeStack());
            if (ids.Equals(""))
            {
                dataGridView1.Visible = false;
                labelTotal.Text = "$0.00";
                cobrar_btn.Visible = false;
            }
            else
            {
                txtCodigo.Text = "";
                dataGridView1.Visible = true;
                cobrar_btn.Visible = true;
                dataGridView1.DataSource = funciones.TablaDatos("SELECT id, nombre, retail as precio FROM productos WHERE id IN ( " + ids + " )");
                labelTotal.Text = "$" + funciones.GetCampo("productos", "SUM(retail) as total", "id IN(" + ids + ")") + " MXN";
            }
        }
    }
}
