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
    public partial class RegistarProducto : Form
    {
        public RegistarProducto()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model.inventario.inventario inventario = new Model.inventario.inventario();
            if (inventario.registrarProducto(textCodigo.Text, textName.Text, textDescripcion.Text, textCosto.Text, textRetail.Text, 
                                             textMayoreo.Text, textCategoria.Text, textDevolucion.Text))
            {
                this.Hide();
            }
        }
    }
}
