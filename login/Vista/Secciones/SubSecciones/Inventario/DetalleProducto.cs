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
    public partial class DetalleProducto : Form
    { 
        Model.inventario.inventario inventario = new Model.inventario.inventario(); 

        public DetalleProducto(int id)
        {
            InitializeComponent();
            enableEdit(false);
            loadData(id);
        }
          
        public void loadData(int id)
        {
            List<string> list = inventario.detalles(id);
            txtCod.Text = list[0];
            txtName.Text = list[1];
            txtCategoria.Text = list[2];
            txtMenudeo.Text = list[3];
            txtMayoreo.Text = list[4];
        }

        public void enableEdit(bool state)
        {
            txtCod.Enabled = state;
            txtName.Enabled = state;
            txtCategoria.Enabled = state;
            txtMenudeo.Enabled = state;
            txtMayoreo.Enabled = state;

            btnCancel.Visible = state;
            btnEdit.Visible = !state;
            btnDelete.Visible = state;
            btnSave.Visible = state;

            txtCod.BackColor = Color.White;
            txtName.BackColor = Color.White;
            txtCategoria.BackColor = Color.White;
            txtMenudeo.BackColor = Color.White;
            txtMayoreo.BackColor = Color.White;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            enableEdit(true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            enableEdit(false);
        }
    }
}
