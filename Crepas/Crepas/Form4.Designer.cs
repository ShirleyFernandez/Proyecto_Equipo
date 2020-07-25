namespace Crepas
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.l_total = new System.Windows.Forms.Label();
            this.txt_dic = new System.Windows.Forms.TextBox();
            this.Direccion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosCocinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro del Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Los clientes los registramos en este apartado :D";
            // 
            // l_total
            // 
            this.l_total.AutoSize = true;
            this.l_total.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_total.Location = new System.Drawing.Point(218, 261);
            this.l_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_total.Name = "l_total";
            this.l_total.Size = new System.Drawing.Size(0, 27);
            this.l_total.TabIndex = 31;
            // 
            // txt_dic
            // 
            this.txt_dic.Location = new System.Drawing.Point(41, 331);
            this.txt_dic.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dic.Name = "txt_dic";
            this.txt_dic.Size = new System.Drawing.Size(701, 22);
            this.txt_dic.TabIndex = 30;
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Direccion.Location = new System.Drawing.Point(36, 285);
            this.Direccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(131, 25);
            this.Direccion.TabIndex = 29;
            this.Direccion.Text = "DIRECCION";
            this.Direccion.Click += new System.EventHandler(this.Direccion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "NOMBRE CLIENTE";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_cliente
            // 
            this.txt_cliente.Location = new System.Drawing.Point(41, 235);
            this.txt_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(701, 22);
            this.txt_cliente.TabIndex = 25;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(426, 205);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(11, 17);
            this.lbl_total.TabIndex = 32;
            this.lbl_total.Text = "\'";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Cornsilk;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.pedidosCocinaToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.inicioToolStripMenuItem.Text = "Incio";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.pedidosToolStripMenuItem.Text = "Cuentas";
            // 
            // pedidosCocinaToolStripMenuItem
            // 
            this.pedidosCocinaToolStripMenuItem.Name = "pedidosCocinaToolStripMenuItem";
            this.pedidosCocinaToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.pedidosCocinaToolStripMenuItem.Text = "Pedidos Cocina";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.agregarClienteToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // agregarClienteToolStripMenuItem
            // 
            this.agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            this.agregarClienteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.agregarClienteToolStripMenuItem.Text = "Agregar Cliente";
            this.agregarClienteToolStripMenuItem.Click += new System.EventHandler(this.agregarClienteToolStripMenuItem_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(599, 379);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(143, 28);
            this.btn_guardar.TabIndex = 34;
            this.btn_guardar.Text = "Agregar Cliente";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.l_total);
            this.Controls.Add(this.txt_dic);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_cliente);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label l_total;
        private System.Windows.Forms.TextBox txt_dic;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosCocinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarClienteToolStripMenuItem;
        private System.Windows.Forms.Button btn_guardar;
    }
}