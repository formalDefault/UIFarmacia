namespace login.Vista.Secciones.SubSecciones.Caja
{
    public partial class Terminal : Form
    {
        Model.funcGenerales funciones = new Model.funcGenerales(); 
        static int idProducto = 0;
        
        private static Terminal instancia = null;

        public static Terminal Instance
        {
            get
            {
                if (instancia == null) instancia = new Terminal();
                return instancia;
            }
        }

        protected Terminal()
        {
            InitializeComponent();
            dataGridView1.DataSource = funciones.TablaDatos("SELECT * FROM productos"); 
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if(idProducto != 0)
            {
                if (Model.caja.PilaProducts.Push(idProducto)) MessageBox.Show("Producto agregado al carrito de compras");

                //Model.caja.PilaProducts.PushCantidad(1);
                MessageBox.Show("Cantidad del producto "+idProducto+" agregado");
            }
            else
            {
                MessageBox.Show("Elige un producto primero");
            }
        }

        //Obtiene el id de la fila selecciona en la tabla
        public static string GetValorCelda(DataGridView dgv, int num)
        { 
            string valor = dgv.Rows[dgv.CurrentRow.Index].Cells[num].Value.ToString();

            return valor;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            idProducto = Int16.Parse(GetValorCelda(dataGridView1, 0));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string asd = string.Join(", ", Model.caja.PilaProducts.seeStack());
            MessageBox.Show(asd);
        }
    }
}
