using login.Vista.secciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
            pintarBotones();
            Vista.Variables var = new Vista.Variables();
            labelUser.Text = var.User;
            SCaja.BackColor = Color.Tomato;
            mostrarContenido(new Vista.Secciones.Caja());
        } 

        private void pintarBotones()
        {
            SCaja.BackColor = Color.Transparent;
            SClientes.BackColor = Color.Transparent;
            SPedidos.BackColor = Color.Transparent;
            SInventario.BackColor = Color.Transparent;
            SProveedores.BackColor = Color.Transparent;
        }

        private void reloj_Tick(object sender, EventArgs e)
        {
            labelReloj.Text = DateTime.Now.ToLongTimeString();
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void flowLayoutPanel2_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void flowLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void mostrarContenido(object contenido)
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

        //botones del menu
        private void btnMenu_caja_Click(object sender, EventArgs e) 
        {
            pintarBotones();
            SCaja.BackColor = Color.Tomato;
            mostrarContenido(new Vista.Secciones.Caja());
        }

        private void btnMenu_clientes_Click(object sender, EventArgs e)
        {
            mostrarContenido(new Clientes());
            pintarBotones();
            SClientes.BackColor = Color.Tomato;   
        }

        private void btnMenu_pedidos_Click(object sender, EventArgs e)
        {
            pintarBotones();
            SPedidos.BackColor = Color.Tomato;
            mostrarContenido(new Vista.Secciones.Pedidos());
        }

        private void btnMenu_inventario_Click(object sender, EventArgs e)
        {
            pintarBotones();
            SInventario.BackColor = Color.Tomato;
            mostrarContenido(new Vista.Secciones.Inventario()); 
        }

        private void btnMenu_proveedores_Click(object sender, EventArgs e)
        {
            pintarBotones();
            SProveedores.BackColor = Color.Tomato;
            mostrarContenido(new Vista.Secciones.Proveedores());

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        int m, mx, my;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void panel4_Click(object sender, EventArgs e)
        { 
            SingUp singUp = new SingUp();
            singUp.Show();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
    }  
}
