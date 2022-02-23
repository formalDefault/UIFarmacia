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
    public partial class RegCliente : Form
    {
        Model.clientes.clientes clientes = new Model.clientes.clientes();  

        public RegCliente()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (clientes.regCliente(textName.Text, textTel.Text, textDireccion.Text, textEmail.Text))
            {
                MessageBox.Show("Cliente registrado correctamente");
                Caja.Carrito.Instance.recargarCbClientes();
                Caja.Carrito.Instance.NuevoCliente = textName.Text;
                Caja.Carrito.Instance.setNuevoCliente();
                this.Hide();
            }
        }
    }
}
