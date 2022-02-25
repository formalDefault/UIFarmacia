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

        //singleton
        private static Clientes instancia = null;

        public static Clientes Instance
        {
            get
            {
                if (instancia == null) instancia = new Clientes();
                return instancia;
            }
        }   

        protected Clientes()
        {      
            InitializeComponent();
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.DataSource = funciones.TablaDatos("SELECT nombre as Cliente, direccion as Direccion, email as Correo FROM clientes");  
        }
        //fin Singleton

        public void refreshTable () { dataGridView1.DataSource = funciones.TablaDatos("SELECT nombre as Cliente, direccion as Direccion, email as Correo FROM clientes"); }
        
        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            detalleClientes details = new detalleClientes();
            details.Show();
        } 
    }
}
  