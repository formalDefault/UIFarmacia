using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using login.Model.caja;

namespace login.Vista.Secciones.SubSecciones.Caja
{
    public partial class Terminal : Form
    {
        Model.funcGenerales funciones = new Model.funcGenerales();  

        public Terminal()
        {
            InitializeComponent();
            dataGridView1.DataSource = funciones.TablaDatos("SELECT * FROM productos"); 
        }

        private void button3_Click(object sender, EventArgs e)
        { 
        } 
    }
}
