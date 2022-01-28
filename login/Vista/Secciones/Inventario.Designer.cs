namespace login.Vista.Secciones
{
    partial class Inventario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.subMenu_devoluciones = new System.Windows.Forms.Button();
            this.subMenu_inventario = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.subMenu_devoluciones);
            this.panel1.Controls.Add(this.subMenu_inventario);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1455, 38);
            this.panel1.TabIndex = 6;
            // 
            // subMenu_devoluciones
            // 
            this.subMenu_devoluciones.BackColor = System.Drawing.Color.Transparent;
            this.subMenu_devoluciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subMenu_devoluciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(67)))));
            this.subMenu_devoluciones.FlatAppearance.BorderSize = 0;
            this.subMenu_devoluciones.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.subMenu_devoluciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.subMenu_devoluciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.subMenu_devoluciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subMenu_devoluciones.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subMenu_devoluciones.ForeColor = System.Drawing.Color.White;
            this.subMenu_devoluciones.Location = new System.Drawing.Point(129, 0);
            this.subMenu_devoluciones.Name = "subMenu_devoluciones";
            this.subMenu_devoluciones.Size = new System.Drawing.Size(132, 38);
            this.subMenu_devoluciones.TabIndex = 11;
            this.subMenu_devoluciones.Text = "Devoluciones";
            this.subMenu_devoluciones.UseVisualStyleBackColor = false;
            this.subMenu_devoluciones.Click += new System.EventHandler(this.subMenu_devoluciones_Click);
            // 
            // subMenu_inventario
            // 
            this.subMenu_inventario.BackColor = System.Drawing.Color.Transparent;
            this.subMenu_inventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subMenu_inventario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.subMenu_inventario.FlatAppearance.BorderSize = 0;
            this.subMenu_inventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.subMenu_inventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.subMenu_inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subMenu_inventario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subMenu_inventario.ForeColor = System.Drawing.Color.White;
            this.subMenu_inventario.Location = new System.Drawing.Point(0, 0);
            this.subMenu_inventario.Name = "subMenu_inventario";
            this.subMenu_inventario.Size = new System.Drawing.Size(129, 38);
            this.subMenu_inventario.TabIndex = 10;
            this.subMenu_inventario.Text = "Inventario";
            this.subMenu_inventario.UseVisualStyleBackColor = false;
            this.subMenu_inventario.Click += new System.EventHandler(this.subMenu_inventario_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Location = new System.Drawing.Point(-2, 35);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1439, 696);
            this.panelContainer.TabIndex = 7;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1437, 729);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panelContainer;
        private Button subMenu_devoluciones;
        private Button subMenu_inventario;
    }
}