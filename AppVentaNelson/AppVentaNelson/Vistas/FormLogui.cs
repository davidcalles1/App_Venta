using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVentaNelson.Vistas
{
    public partial class FormLogui : Form
    {
        public FormLogui()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            ClsAcceso acceso = new ClsAcceso();
            int valor = acceso.Acceso(txtUsuario.Text, txtPaswork.Text);

            if (valor == 1)
            {
                MessageBox.Show("Inicio de sesion valido", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmMenu frm = new FrmMenu();
                frm.lblCorreo.Text = txtUsuario.Text;
                frm.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Tu correo o clave son incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
