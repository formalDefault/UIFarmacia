namespace login.Vista.secciones
{
    partial class Clientes
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
            this.subMenu_regCliente = new System.Windows.Forms.Button();
            this.subMenu_clientes = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.subMenu_regCliente);
            this.panel1.Controls.Add(this.subMenu_clientes);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1443, 38);
            this.panel1.TabIndex = 2;
            // 
            // subMenu_regCliente
            // 
            this.subMenu_regCliente.BackColor = System.Drawing.Color.Transparent;
            this.subMenu_regCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subMenu_regCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.subMenu_regCliente.FlatAppearance.BorderSize = 0;
            this.subMenu_regCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.subMenu_regCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.subMenu_regCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subMenu_regCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subMenu_regCliente.ForeColor = System.Drawing.Color.White;
            this.subMenu_regCliente.Location = new System.Drawing.Point(119, 0);
            this.subMenu_regCliente.Name = "subMenu_regCliente";
            this.subMenu_regCliente.Size = new System.Drawing.Size(145, 38);
            this.subMenu_regCliente.TabIndex = 12;
            this.subMenu_regCliente.Text = "Registrar cliente";
            this.subMenu_regCliente.UseVisualStyleBackColor = false;
            this.subMenu_regCliente.Click += new System.EventHandler(this.subMenu_regCliente_Click);
            // 
            // subMenu_clientes
            // 
            this.subMenu_clientes.BackColor = System.Drawing.Color.Transparent;
            this.subMenu_clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subMenu_clientes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.subMenu_clientes.FlatAppearance.BorderSize = 0;
            this.subMenu_clientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.subMenu_clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.subMenu_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subMenu_clientes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subMenu_clientes.ForeColor = System.Drawing.Color.White;
            this.subMenu_clientes.Location = new System.Drawing.Point(3, 0);
            this.subMenu_clientes.Name = "subMenu_clientes";
            this.subMenu_clientes.Size = new System.Drawing.Size(118, 38);
            this.subMenu_clientes.TabIndex = 11;
            this.subMenu_clientes.Text = "Clientes";
            this.subMenu_clientes.UseVisualStyleBackColor = false;
            this.subMenu_clientes.Click += new System.EventHandler(this.subMenu_clientes_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Location = new System.Drawing.Point(-5, 35);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1443, 695);
            this.panelContainer.TabIndex = 3;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(1437, 729);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Panel panelContainer;
        private Button subMenu_clientes;
        private Button subMenu_regCliente;
    }
}