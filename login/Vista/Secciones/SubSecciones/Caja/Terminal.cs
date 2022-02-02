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
        ventas ventas = new ventas();   

        public Terminal()
        {
            InitializeComponent();
            dataGridView1.DataSource = ventas.TablaProductos(); 
        }

        private void button3_Click(object sender, EventArgs e)
        { 
        } 
    }
}
