using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login.Vista.secciones
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            mostrarContenido(new Vista.Secciones.SubSecciones.Clientes.Clientes());
            subMenu_clientes.ForeColor = Color.Black;
            subMenu_clientes.BackColor = Color.White;
        }

        public void colors()
        {
            subMenu_clientes.BackColor = Color.Transparent;

            subMenu_clientes.ForeColor = Color.White;
        }

        public void mostrarContenido(object contenido)
        {
            if (this.panelContainer.Controls.Count > 0)
                this.panelContainer.Controls.RemoveAt(0);
            Form fh = contenido as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(fh);
            this.panelContainer.Tag = fh;
            fh.Show();
        }

        private void subMenu_clientes_Click(object sender, EventArgs e)
        {
            colors();
            mostrarContenido(new Vista.Secciones.SubSecciones.Clientes.Clientes());
            subMenu_clientes.ForeColor = Color.Black;
            subMenu_clientes.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void subMenu_regCliente_Click(object sender, EventArgs e)
        {
            Secciones.SubSecciones.Clientes.RegCliente form = new Secciones.SubSecciones.Clientes.RegCliente();
            form.Show();
        }
    }
}
