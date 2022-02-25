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
    public partial class stock : Form
    { 
        Model.funcGenerales funciones = new Model.funcGenerales();
        int idP = 0;
        
        //patron singleton  
        private static stock instancia = null;

        public static stock Instance
        {
            get
            {
                if (instancia == null) instancia = new stock();
                return instancia;
            }
        }

        protected stock()
        {
            InitializeComponent();
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false; 
            btnDetalles.Visible = false;
            loadTable();
        }
        //fin singleton

        public void loadTable()
        {
            dataGridView1.DataSource = funciones.TablaDatos("SELECT " +
                                                             "p.id, p.`codigo`, p.`nombre` AS producto, p.`descripcion`, p.`costo`, p.`retail`, p.`mayoreo`, p.`categoria`, " +
                                                             "IF(e.cant_entradas IS NULL, 0, e.cant_entradas) - IF(s.cant_salidas IS NULL, 0, s.cant_salidas) AS Existencias " +
                                                             "FROM productos AS p " +
                                                             "LEFT JOIN(SELECT idProducto, SUM(cantidad) AS cant_entradas FROM entradas GROUP BY idProducto) AS e ON e.idProducto = p.id " +
                                                             "LEFT JOIN(SELECT idProducto, SUM(cantidad) AS cant_salidas FROM salidas GROUP BY idProducto) AS s ON s.idProducto = p.id");

            dataGridView1.Columns["id"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        { 
            AgregarEntrada agregarEntrada = new AgregarEntrada();
            agregarEntrada.Show();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            DetalleProducto detalleProducto = new DetalleProducto(idP); 
            detalleProducto.Show();
        }

        //Obtiene el id de la fila selecciona en la tabla
        public static string GetValorCelda(DataGridView dgv, int num)
        {
            string valor = dgv.Rows[dgv.CurrentRow.Index].Cells[num].Value.ToString();

            return valor;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            idP = Int32.Parse(GetValorCelda(dataGridView1, 0));
            btnDetalles.Visible = true;
        }
    }
}
