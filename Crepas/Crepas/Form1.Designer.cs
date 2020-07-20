namespace Crepas
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.combo_productos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_tipo = new System.Windows.Forms.ComboBox();
            this.Pedidos = new System.Windows.Forms.ListBox();
            this.Direccion = new System.Windows.Forms.Label();
            this.txt_dic = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.l_total = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_cant = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.pedidosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
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
            // combo_productos
            // 
            this.combo_productos.FormattingEnabled = true;
            this.combo_productos.Location = new System.Drawing.Point(76, 216);
            this.combo_productos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combo_productos.Name = "combo_productos";
            this.combo_productos.Size = new System.Drawing.Size(223, 24);
            this.combo_productos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 189);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "PRODUCTO";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 290);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 263);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "CLIENTE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(403, 261);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "TIPO DE PEDIDO";
            // 
            // combo_tipo
            // 
            this.combo_tipo.FormattingEnabled = true;
            this.combo_tipo.Items.AddRange(new object[] {
            "Local",
            "Domicilio"});
            this.combo_tipo.Location = new System.Drawing.Point(403, 288);
            this.combo_tipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combo_tipo.Name = "combo_tipo";
            this.combo_tipo.Size = new System.Drawing.Size(160, 24);
            this.combo_tipo.TabIndex = 6;
            this.combo_tipo.SelectionChangeCommitted += new System.EventHandler(this.combo_tipo_SelectionChangeCommitted);
            // 
            // Pedidos
            // 
            this.Pedidos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pedidos.FormattingEnabled = true;
            this.Pedidos.ItemHeight = 23;
            this.Pedidos.Location = new System.Drawing.Point(660, 53);
            this.Pedidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pedidos.Name = "Pedidos";
            this.Pedidos.ScrollAlwaysVisible = true;
            this.Pedidos.Size = new System.Drawing.Size(372, 303);
            this.Pedidos.TabIndex = 7;
            this.Pedidos.SelectedIndexChanged += new System.EventHandler(this.Pedidos_SelectedIndexChanged);
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Direccion.Location = new System.Drawing.Point(260, 320);
            this.Direccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(122, 23);
            this.Direccion.TabIndex = 8;
            this.Direccion.Text = "DIRECCIÓN";
            // 
            // txt_dic
            // 
            this.txt_dic.Location = new System.Drawing.Point(76, 347);
            this.txt_dic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_dic.Name = "txt_dic";
            this.txt_dic.Size = new System.Drawing.Size(487, 22);
            this.txt_dic.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 390);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "TOTAL:";
            // 
            // l_total
            // 
            this.l_total.AutoSize = true;
            this.l_total.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_total.Location = new System.Drawing.Point(151, 360);
            this.l_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_total.Name = "l_total";
            this.l_total.Size = new System.Drawing.Size(0, 27);
            this.l_total.TabIndex = 11;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(427, 389);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(100, 28);
            this.btn_guardar.TabIndex = 12;
            this.btn_guardar.Text = "Aceptar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(432, 191);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "CANTIDAD";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(697, 385);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(100, 28);
            this.btn_agregar.TabIndex = 15;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // txt_cant
            // 
            this.txt_cant.Location = new System.Drawing.Point(450, 218);
            this.txt_cant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cant.MaxLength = 100;
            this.txt_cant.Name = "txt_cant";
            this.txt_cant.Size = new System.Drawing.Size(77, 22);
            this.txt_cant.TabIndex = 16;
            this.txt_cant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cant_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("CHICKEN Pie Height", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(238, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 37);
            this.label6.TabIndex = 17;
            this.label6.Text = "Toma de pedido";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Intimacy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(572, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "¡Hola!, Recuerda registrar todos los productos que ordene el cliente";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(143, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(463, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(889, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 21;
            this.button1.Text = "Eiminar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 438);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_cant);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.l_total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_dic);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.Pedidos);
            this.Controls.Add(this.combo_tipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_productos);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ComboBox combo_productos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_tipo;
        private System.Windows.Forms.ListBox Pedidos;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.TextBox txt_dic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label l_total;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txt_cant;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}

