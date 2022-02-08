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
        Model.funcGenerales funciones = new Model.funcGenerales();  
        AgregarEntrada agregarEntrada = new AgregarEntrada();

        public stock()
        {
            InitializeComponent();
            dataGridView1.DataSource = funciones.TablaDatos("SELECT p.id, p.`codigo`, p.`nombre`, p.`descripcion`, p.`costo`, p.`retail`, p.`mayoreo`, p.`categoria`, p.`periodoDevolucion_dias` as devolucion, SUM(e.cantidad) AS stock FROM productos AS p LEFT JOIN entradas AS e ON e.`idProducto` = p.`id` GROUP BY p.`id` ");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        { 
            agregarEntrada.Show();
        }
    }
}
