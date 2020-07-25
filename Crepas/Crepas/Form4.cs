using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crepas
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Direccion_Click(object sender, EventArgs e)
        {

        }
        //MUENU STRIP esta opción del botón secundario Opciones--->agregarcliente
        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 nForm4 = new Form4();
            nForm4.TopLevel = true;
            nForm4.Show();
            this.Hide();
        }
    }
}
