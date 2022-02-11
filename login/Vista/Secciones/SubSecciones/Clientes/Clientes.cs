using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login.Vista.Secciones.SubSecciones.Clientes
{
    public partial class Clientes : Form
    {
        Model.funcGenerales funciones = new Model.funcGenerales();
        public Clientes()
        {
            InitializeComponent();
            dataGridView1.DataSource = funciones.TablaDatos("SELECT * FROM clientes");
        }
    }
}
