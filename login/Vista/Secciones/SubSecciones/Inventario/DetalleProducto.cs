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
        int idProducto = 0;
        stock tabla = stock.Instance;

        public DetalleProducto(int id)
        {
            InitializeComponent();
            enableEdit(false);
            idProducto = id;
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
            txtCosto.Text = list[5];
        }

        public void enableEdit(bool state)
        {
            txtCod.Enabled = state;
            txtName.Enabled = state;
            txtCategoria.Enabled = state;
            txtMenudeo.Enabled = state;
            txtMayoreo.Enabled = state;
            txtCosto.Enabled = state;

            btnCancel.Visible = state;
            btnEdit.Visible = !state;
            btnDelete.Visible = state;
            btnSave.Visible = state;

            txtCod.BackColor = Color.White;
            txtName.BackColor = Color.White;
            txtCategoria.BackColor = Color.White;
            txtMenudeo.BackColor = Color.White;
            txtMayoreo.BackColor = Color.White;
            txtCosto.BackColor = Color.White;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea guardar los cambios?", "Guardar cambios", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (inventario.updateProduct(idProducto, Int32.Parse(txtCod.Text), txtName.Text,txtCategoria.Text, float.Parse(txtMenudeo.Text), float.Parse(txtMayoreo.Text), float.Parse(txtCosto.Text)))
                { 
                    enableEdit(false);
                    tabla.loadTable();
                }
            }
                
        }

        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtMayoreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtMenudeo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //logica para borrar producto de manera logica y que no se muestre en el stock
        }
    }
}
