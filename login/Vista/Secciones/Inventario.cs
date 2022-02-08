using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login.Vista.Secciones
{
    public partial class Inventario : Form
    {

        public Inventario()
        {
            InitializeComponent(); 
            mostrarContenido(new SubSecciones.Inventario.stock()); 
            subMenu_inventario.ForeColor = Color.Black;
            subMenu_inventario.BackColor = Color.White;

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

        public void colors()
        {
            subMenu_inventario.BackColor = Color.Transparent;
            subMenu_devoluciones.BackColor = Color.Transparent; 
            subMenu_addProducto.BackColor = Color.Transparent; 

            subMenu_inventario.ForeColor = Color.White;
            subMenu_devoluciones.ForeColor = Color.White; 
            subMenu_addProducto.ForeColor = Color.White; 
        }

        private void subMenu_inventario_Click(object sender, EventArgs e)
        {
            colors();  
            mostrarContenido(new SubSecciones.Inventario.stock());
            subMenu_inventario.ForeColor = Color.Black;
            subMenu_inventario.BackColor = Color.White;

        }

        private void subMenu_devoluciones_Click(object sender, EventArgs e)
        {
            colors();
            subMenu_devoluciones.ForeColor = Color.Black;
            subMenu_devoluciones.BackColor = Color.White;
        }

        private void subMenu_addProducto_Click(object sender, EventArgs e)
        { 
            SubSecciones.Inventario.RegistarProducto form = new SubSecciones.Inventario.RegistarProducto();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            mostrarContenido(new SubSecciones.Inventario.stock());
        }
    }
}
