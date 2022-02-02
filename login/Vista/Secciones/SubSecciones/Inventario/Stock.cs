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
    public partial class stock : Form
    {
        Model.inventario.inventario inventario = new Model.inventario.inventario();
        public stock()
        {
            InitializeComponent();
            dataGridView1.DataSource = inventario.TablaProductoInventarios();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        { 
            Inventario.AgregarEntrada agregarEntrada = new Inventario.AgregarEntrada();
            agregarEntrada.Show();
        }
    }
}
