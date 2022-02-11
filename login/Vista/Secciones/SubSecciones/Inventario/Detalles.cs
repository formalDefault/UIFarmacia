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
    public partial class Detalles : Form
    {
        Model.funcGenerales funciones = new Model.funcGenerales();
        public Detalles()
        {
            InitializeComponent();
            dataGridView1.DataSource = funciones.TablaDatos("SELECT e.*, c.`descripcion` AS descripcion, c.`id` AS compra FROM entradas AS e LEFT JOIN compras_entradas AS ce ON e.`id` = ce.`idEntrada` LEFT JOIN compras AS c ON c.`id` = ce.`idCompra` ");
        }
    }
}
