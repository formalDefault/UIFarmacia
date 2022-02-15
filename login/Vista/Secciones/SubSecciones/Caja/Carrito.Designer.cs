namespace login.Vista.Secciones.SubSecciones.Caja
{
    partial class Carrito
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carrito));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCliente = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelAdvertencia = new System.Windows.Forms.Label();
            this.cobrar_btn = new System.Windows.Forms.Button();
            this.quitarProducto_Btn = new System.Windows.Forms.Button();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.agregar_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelCliente.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.labelTotal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(740, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 249);
            this.panel1.TabIndex = 0;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.Location = new System.Drawing.Point(252, 202);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(125, 19);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "Venta por mayoreo";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Location = new System.Drawing.Point(76, 202);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(129, 19);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Venta por menudeo";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotal.Location = new System.Drawing.Point(188, 90);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(62, 30);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "$0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(164, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total";
            // 
            // panelCliente
            // 
            this.panelCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCliente.BackgroundImage")));
            this.panelCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelCliente.Controls.Add(this.label5);
            this.panelCliente.Controls.Add(this.label6);
            this.panelCliente.Controls.Add(this.label4);
            this.panelCliente.Controls.Add(this.panel4);
            this.panelCliente.Controls.Add(this.textBox1);
            this.panelCliente.Controls.Add(this.label3);
            this.panelCliente.Location = new System.Drawing.Point(740, 291);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Size = new System.Drawing.Size(441, 323);
            this.panelCliente.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(211, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Registra un nuevo cliente.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(66, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "¿No aparece el cliente?,";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(76, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre del cliente:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(67)))));
            this.panel4.Location = new System.Drawing.Point(76, 166);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(282, 2);
            this.panel4.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(76, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 16);
            this.textBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(152, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 44);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cliente";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.labelAdvertencia);
            this.panel3.Location = new System.Drawing.Point(168, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(524, 521);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.Location = new System.Drawing.Point(104, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 2, 2, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 45;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(320, 475);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // labelAdvertencia
            // 
            this.labelAdvertencia.AutoSize = true;
            this.labelAdvertencia.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAdvertencia.Location = new System.Drawing.Point(104, 226);
            this.labelAdvertencia.Name = "labelAdvertencia";
            this.labelAdvertencia.Size = new System.Drawing.Size(331, 23);
            this.labelAdvertencia.TabIndex = 42;
            this.labelAdvertencia.Text = "No se ha agregado ningun producto ";
            // 
            // cobrar_btn
            // 
            this.cobrar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cobrar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cobrar_btn.FlatAppearance.BorderSize = 0;
            this.cobrar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cobrar_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cobrar_btn.ForeColor = System.Drawing.Color.White;
            this.cobrar_btn.Location = new System.Drawing.Point(1042, 635);
            this.cobrar_btn.Name = "cobrar_btn";
            this.cobrar_btn.Size = new System.Drawing.Size(125, 33);
            this.cobrar_btn.TabIndex = 3;
            this.cobrar_btn.Text = "Cobrar";
            this.cobrar_btn.UseVisualStyleBackColor = false;
            this.cobrar_btn.Click += new System.EventHandler(this.cobrar_btn_Click);
            // 
            // quitarProducto_Btn
            // 
            this.quitarProducto_Btn.BackColor = System.Drawing.Color.DarkOrange;
            this.quitarProducto_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitarProducto_Btn.FlatAppearance.BorderSize = 0;
            this.quitarProducto_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitarProducto_Btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quitarProducto_Btn.ForeColor = System.Drawing.Color.White;
            this.quitarProducto_Btn.Location = new System.Drawing.Point(177, 635);
            this.quitarProducto_Btn.Name = "quitarProducto_Btn";
            this.quitarProducto_Btn.Size = new System.Drawing.Size(170, 33);
            this.quitarProducto_Btn.TabIndex = 4;
            this.quitarProducto_Btn.Text = "Quitar producto";
            this.quitarProducto_Btn.UseCompatibleTextRendering = true;
            this.quitarProducto_Btn.UseVisualStyleBackColor = false;
            this.quitarProducto_Btn.Click += new System.EventHandler(this.quitarProducto_Btn_Click);
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.BackColor = System.Drawing.Color.DarkRed;
            this.cancelar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelar_btn.FlatAppearance.BorderSize = 0;
            this.cancelar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelar_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelar_btn.ForeColor = System.Drawing.Color.White;
            this.cancelar_btn.Location = new System.Drawing.Point(627, 635);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(170, 33);
            this.cancelar_btn.TabIndex = 5;
            this.cancelar_btn.Text = "Cancelar venta";
            this.cancelar_btn.UseCompatibleTextRendering = true;
            this.cancelar_btn.UseVisualStyleBackColor = false;
            this.cancelar_btn.Click += new System.EventHandler(this.cancelar_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Location = new System.Drawing.Point(176, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 3);
            this.panel2.TabIndex = 6;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigo.Location = new System.Drawing.Point(176, 55);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(386, 18);
            this.txtCodigo.TabIndex = 7;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // agregar_btn
            // 
            this.agregar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.agregar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregar_btn.FlatAppearance.BorderSize = 0;
            this.agregar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregar_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.agregar_btn.ForeColor = System.Drawing.Color.White;
            this.agregar_btn.Location = new System.Drawing.Point(568, 48);
            this.agregar_btn.Name = "agregar_btn";
            this.agregar_btn.Size = new System.Drawing.Size(111, 28);
            this.agregar_btn.TabIndex = 8;
            this.agregar_btn.Text = "Agregar ";
            this.agregar_btn.UseCompatibleTextRendering = true;
            this.agregar_btn.UseVisualStyleBackColor = false;
            this.agregar_btn.Click += new System.EventHandler(this.agregar_btn_Click);
            // 
            // Carrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1428, 690);
            this.Controls.Add(this.agregar_btn);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.quitarProducto_Btn);
            this.Controls.Add(this.cobrar_btn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelCliente);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Carrito";
            this.Text = "Carrito";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCliente.ResumeLayout(false);
            this.panelCliente.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panelCliente;
        private Panel panel3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label labelTotal;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label4;
        private Panel panel4;
        private TextBox textBox1;
        private Label label3;
        private Button cobrar_btn;
        private Button quitarProducto_Btn;
        private DataGridView dataGridView1;
        private Label labelAdvertencia;
        private Button cancelar_btn;
        private Panel panel2;
        private TextBox txtCodigo;
        private Button agregar_btn;
    }
}