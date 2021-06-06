using SistemaVentasP2.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentasP2.VISTA
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        FrmVentas ventas = new FrmVentas();
       
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            ClsAcceso acce = new ClsAcceso();
            int valor = acce.acceso(txtEmail.Text, txtPassword.Text);


            if (valor == 1)
            {
                MessageBox.Show("Bienvenido");

                FrmMenu menu = new FrmMenu();
                //ventas.MdiParent = this;
                menu.Show();
            }
            else
            {

               

                MessageBox.Show(" Email o contraseña incorrecto");
            }

        }
       

    }
}
