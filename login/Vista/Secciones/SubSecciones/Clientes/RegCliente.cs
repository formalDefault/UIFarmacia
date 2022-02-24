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
        Model.Usuarios validarEmail = new Model.Usuarios();

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
            if(textName.Text == "" || textTel.Text == "" || textDireccion.Text == "" || textEmail.Text == "")
            {
                MessageBox.Show("Por favor llene todo los campos");
            }
            else
            {
                if (validarEmail.FormatoEmail(textEmail.Text))
                {
                    if (clientes.regCliente(textName.Text, textTel.Text, textDireccion.Text, textEmail.Text))
                    {
                        MessageBox.Show("Cliente registrado correctamente");
                        Caja.Carrito.Instance.recargarCbClientes();
                        Clientes.Instance.refreshTable();
                        this.Hide(); 
                    }
                } 
                else
                {
                    MessageBox.Show("Introduzca un email valido");
                }
            }  
        }

        private void textTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            } 
        }
    }
}
