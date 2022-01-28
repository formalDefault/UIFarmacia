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
    public partial class Caja : Form
    {
        public Caja()
        {
            InitializeComponent();
            subMenu_terminal.BackColor = Color.White;
            subMenu_terminal.ForeColor = Color.Black;
            mostrarContenido(new SubSecciones.Caja.Terminal());
        }

        //Pintar colores dinamicamente al hacer click en los 
        public void colors()
        {
            //Hacer botones transparentes
            subMenu_arqueo.BackColor = Color.Transparent; 
            subMenu_corte.BackColor = Color.Transparent; 
            subMenu_facturacion.BackColor = Color.Transparent; 
            subMenu_gasto.BackColor = Color.Transparent; 
            subMenu_presupuesto.BackColor = Color.Transparent; 
            subMenu_terminal.BackColor = Color.Transparent;
            subMenu_carrito.BackColor = Color.Transparent;
           
            //pintar color de las letras
            subMenu_arqueo.ForeColor = Color.White; 
            subMenu_corte.ForeColor = Color.White; 
            subMenu_facturacion.ForeColor = Color.White; 
            subMenu_gasto.ForeColor = Color.White; 
            subMenu_presupuesto.ForeColor = Color.White; 
            subMenu_terminal.ForeColor = Color.White;  
            subMenu_carrito.ForeColor = Color.White;
        }

        //Mostrar contenido en el panel container
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

        private void subMenu_terminal_Click(object sender, EventArgs e)
        {
            colors();
            subMenu_terminal.BackColor = Color.White;
            subMenu_terminal.ForeColor = Color.Black;
            mostrarContenido(new SubSecciones.Caja.Terminal()); 
        }

        private void subMenu_corte_Click(object sender, EventArgs e)
        {
            colors();
            subMenu_corte.BackColor = Color.White;
            subMenu_corte.ForeColor = Color.Black;
            mostrarContenido(new SubSecciones.Caja.Corte());
        }
         
        private void subMenu_carrito_Click(object sender, EventArgs e)
        {
            colors();
            subMenu_carrito.BackColor = Color.White;
            subMenu_carrito.ForeColor = Color.Black;
            mostrarContenido(new SubSecciones.Caja.Carrito());
        }
    }
}
