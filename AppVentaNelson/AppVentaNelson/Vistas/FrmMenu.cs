using AppVentaNelson.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVentaNelson
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            cliente.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmProducto producto = new FrmProducto();
            producto.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmUsuario usuario = new FrmUsuario();
            usuario.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmDocumento documeto = new FrmDocumento();
            documeto.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
