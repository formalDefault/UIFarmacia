namespace login.Vista.Secciones.SubSecciones.Inventario
{
    partial class AgregarEntrada
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textProveedor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(384, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Agregar nueva entrada";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(41, 278);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 3);
            this.panel3.TabIndex = 47;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(41, 210);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 3);
            this.panel2.TabIndex = 46;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(16)))), ((int)(((byte)(255)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(260, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 39);
            this.button1.TabIndex = 44;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textTotal
            // 
            this.textTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(67)))));
            this.textTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTotal.ForeColor = System.Drawing.Color.White;
            this.textTotal.Location = new System.Drawing.Point(41, 255);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(323, 16);
            this.textTotal.TabIndex = 34;
            // 
            // textDescripcion
            // 
            this.textDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(67)))));
            this.textDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDescripcion.ForeColor = System.Drawing.Color.White;
            this.textDescripcion.Location = new System.Drawing.Point(41, 188);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(323, 16);
            this.textDescripcion.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(41, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Total de la compra:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(41, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Descripcion (opcional)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Proveedor:";
            // 
            // textProveedor
            // 
            this.textProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textProveedor.BackColor = System.Drawing.Color.White;
            this.textProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textProveedor.DropDownWidth = 300;
            this.textProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textProveedor.ForeColor = System.Drawing.Color.Black;
            this.textProveedor.FormattingEnabled = true;
            this.textProveedor.ItemHeight = 15;
            this.textProveedor.Location = new System.Drawing.Point(41, 127);
            this.textProveedor.Name = "textProveedor";
            this.textProveedor.Size = new System.Drawing.Size(323, 23);
            this.textProveedor.TabIndex = 48;
            // 
            // AgregarEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(418, 393);
            this.Controls.Add(this.textProveedor);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.textDescripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarEntrada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label1;
        private Panel panel3;
        private Panel panel2;
        private Button button1;
        private TextBox textTotal;
        private TextBox textDescripcion;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox textProveedor;
    }
}