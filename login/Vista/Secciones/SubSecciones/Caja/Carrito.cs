using System.ComponentModel;

namespace login.Vista.Secciones.SubSecciones.Caja
{
    public partial class Carrito : Form
    {
        Model.funcGenerales funciones = new Model.funcGenerales();
        Model.caja.ventas ventas = new Model.caja.ventas();
        static int idProduct = 0;
        float costoTotal = 0;
          
        //patron singleton  
        private static Carrito instancia = null;

        public static Carrito Instance
        {
            get
            {
                if (instancia == null) instancia = new Carrito(); 
                return instancia;
            }
        }

        protected Carrito()
        {
            InitializeComponent();
            dataGridView2.Columns["id"].Visible = false;
            string ids = string.Join(", ", Model.caja.PilaProducts.seeStack());
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false; 
            recargarCbClientes();
            if (ids.Equals(""))
            {
                limpiar();
            }
            else
            {
                dataGridView1.DataSource = funciones.TablaDatos("SELECT id, nombre as Producto, retail as Precio FROM productos WHERE id IN ( " + ids + " )");
                labelTotal.Text = "$" + funciones.GetCampo("productos", "SUM(retail) as total", "id IN(" + ids + ")") + " MXN";
            }

            if (radioButton1.Checked) panelCliente.Visible = false;
        }
        //Vista.Secciones.SubSecciones.Caja.Carrito.Instance (Manera para devolver o iniciar la esta clase desde otra) 
        //fin del patron singleton

        //funcion para los atajos de teclado 
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            txtCodigo.Focus();
        }

        public void recargarCbClientes()
        {
            comboBoxCliente.Items.Clear();
            funciones.comboBox(comboBoxCliente, "SELECT nombre FROM clientes", "nombre");
        }

        //Obtiene el id de la fila selecciona en la tabla
        public static string GetValorCelda(DataGridView dgv, int num)
        {
            string valor = dgv.Rows[dgv.CurrentRow.Index].Cells[num].Value.ToString(); 
            return valor;
        }

        //botones para mostrar y ocultar la seleccion de clientes
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panelCliente.Visible = false;
        }
        
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panelCliente.Visible = true;
        }

        //quitar el producto de la tabla
        private void quitarProducto_Btn_Click(object sender, EventArgs e)
        {
            Model.caja.PilaProducts.popStack(idProduct);
            string ids = string.Join(", ", Model.caja.PilaProducts.seeStack()); 
            if (ids.Equals(""))
            {
                limpiar();
            }
            else
            {
                Model.caja.PilaProducts.Push(idProduct);

                dataGridView1.DataSource = funciones.TablaDatos("SELECT id, nombre as Producto, retail as Precio FROM productos WHERE id IN ( " + ids + " )");
                labelTotal.Text = "$" + funciones.GetCampo("productos", "SUM(retail) as total", "id IN(" + ids + ")") + " MXN";

                int iterador = 0;
                foreach (var id in Model.caja.PilaProducts.seeStack())
                {
                    int filaId = Int16.Parse(dataGridView2.Rows[iterador].Cells["id"].Value.ToString());
                    if (filaId == idProduct)
                    {
                        string cant = dataGridView2.Rows[iterador].Cells[0].Value.ToString();
                        float MultiplicacionCantidad = float.Parse(funciones.GetCampo("productos", "retail * " + cant + " ", "id = " + idProduct + " "));
                        costoTotal -= MultiplicacionCantidad;
                        labelTotal.Text = "$" + costoTotal + " MXN";

                        dataGridView2.Rows.RemoveAt(iterador);
                        Model.caja.PilaProducts.popStack(idProduct);
                        break;
                    }
                    ++iterador;
                }
            }
        }

        //seleccionar fila de la tabla
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            idProduct = Int16.Parse(GetValorCelda(dataGridView1, 0));
        }

        //limpia la pila y restablece la ventana
        public void limpiar()
        {
            foreach (var i in Model.caja.PilaProducts.seeStack())
            {
                Model.caja.PilaProducts.popStack(i);
            }
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            labelTotal.Text = "$0.00";
            dataGridView2.Rows.Clear();
            cobrar_btn.Visible = false;
            quitarProducto_Btn.Visible = false;
            cancelar_btn.Visible = false;
            comboBoxCliente.Text = "";
            radioButton1.Checked = true;
            costoTotal = 0;
        }

        //proceso para cobrar (registra la venta, las salidas y despues las enlaza)
        private void cobrar_btn_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (ventas.RegVenta(costoTotal))
                {
                    int i = 0;
                    foreach (var id in Model.caja.PilaProducts.seeStack())
                    {
                        int cantidad = Int16.Parse(dataGridView2.Rows[i].Cells[0].Value.ToString());
                        int idProducto = Int16.Parse(dataGridView2.Rows[i].Cells[1].Value.ToString());
                        ventas.regSalidas(idProducto, cantidad, float.Parse(funciones.GetCampo("productos", "retail * " + cantidad + " as total ", "id = " + idProducto + "")));
                        ++i;
                    }
                    ventas.enlazarSalidasVentas();
                    limpiar();
                    MessageBox.Show("Venta finalizada con exito");
                }
            }
            else
            { 
                if(comboBoxCliente.Text != "")
                {
                    if (ventas.RegVenta(funciones.GetId("clientes", "nombre = '" + comboBoxCliente.Text + "'"), costoTotal))
                    {
                        int i = 0;
                        foreach (var id in Model.caja.PilaProducts.seeStack())
                        {
                            int cantidad = Int16.Parse(dataGridView2.Rows[i].Cells[0].Value.ToString());
                            int idProducto = Int16.Parse(dataGridView2.Rows[i].Cells[1].Value.ToString());
                            ventas.regSalidas(idProducto, cantidad, float.Parse(funciones.GetCampo("productos", "retail * " + cantidad + " as total ", "id = " + idProducto + "")));
                            ++i;
                        }
                        ventas.enlazarSalidasVentas();
                        limpiar();
                        MessageBox.Show("Venta finalizada con exito");
                    } 
                }
                else
                {
                    MessageBox.Show("No se a seleccionado ningun cliente");
                }
                
            }
            
        }

        //cancelar compra
        private void cancelar_btn_Click(object sender, EventArgs e)
        { 
            if(MessageBox.Show("¿Esta seguro de cancelar la venta?", "Cancelar venta actual", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                limpiar();
            }
        }

        //boton para agregar producto
        private void agregar_btn_Click(object sender, EventArgs e)
        {
            agregarProducto();
        }

        //boton para registrar nuevo cliente
        private void label5_Click(object sender, EventArgs e)
        {
            Clientes.RegCliente regClientes = new Clientes.RegCliente();
            if (MessageBox.Show("Desea registrar un nuevo cliente?", "Registrar cliente", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                regClientes.Show();
            }
        }

        //funcion para agregar un producto al carrito
        private void agregarProducto()
        {
            int idIngresado = 0; 
            if(funciones.GetCampo("productos", "id", "codigo = " + Int64.Parse(txtCodigo.Text) + " ") != "")
            {
                idIngresado = Int32.Parse(funciones.GetCampo("productos", "id", "codigo = " + int.Parse(txtCodigo.Text) + " "));

                if (Model.caja.PilaProducts.Push(idIngresado))
                {
                    string ids = string.Join(", ", Model.caja.PilaProducts.seeStack());
                    txtCodigo.Text = "";
                    dataGridView1.Visible = true;
                    cobrar_btn.Visible = true;
                    dataGridView1.DataSource = funciones.TablaDatos("SELECT id, nombre as Producto, retail as Precio FROM productos WHERE id IN (" + ids + ") ");

                    costoTotal += float.Parse(funciones.GetCampo("productos", "retail", "id = " + idIngresado + ""));

                    labelTotal.Text = "$" + costoTotal + " MXN";

                    dataGridView2.Rows.Add("1", idIngresado);

                    //Ordena los datos mostrados en la tabla de menor a mayor //quitar comentario
                    dataGridView2.Sort(this.dataGridView2.Columns["id"], ListSortDirection.Ascending);

                    dataGridView2.Visible = true;

                    quitarProducto_Btn.Visible = true;
                    cancelar_btn.Visible = true; 
                }
                else
                {
                    int i = 0;
                    dataGridView1.Visible = true;
                    cobrar_btn.Visible = true;

                    foreach (var id in Model.caja.PilaProducts.seeStack())
                    {
                        int filaId = Int16.Parse(dataGridView2.Rows[i].Cells[1].Value.ToString());
                        if (filaId == idIngresado)
                        {
                            string cant = dataGridView2.Rows[i].Cells[0].Value.ToString();
                            int cantidad = Int16.Parse(cant) + 1;
                            dataGridView2.Rows[i].Cells[0].Value = cantidad;
                            float MultiplicacionCantidad = float.Parse(funciones.GetCampo("productos", "retail", "id = " + idIngresado + " "));
                            costoTotal += MultiplicacionCantidad;
                            labelTotal.Text = "$" + costoTotal + " MXN";
                            txtCodigo.Text = "";
                            break;
                        }
                        ++i;
                    }
                    dataGridView2.Visible = true;
                }
            }
            else
            { 
                MessageBox.Show("El producto no existe en el inventario");
                txtCodigo.Text = "";
            } 
        }

        //agregar un producto al presionar enter
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if(txtCodigo.Text != "")
                {
                    agregarProducto();
                }
                else
                {
                    MessageBox.Show("El producto no existe en el inventario");
                }
            }
        }



        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
         
        private void comboBoxCliente_Click(object sender, EventArgs e)
        {
            comboBoxCliente.DroppedDown = true;
        }
    }
}
