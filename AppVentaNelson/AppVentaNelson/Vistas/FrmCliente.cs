using AppVentaNelson.DAO;
using AppVentaNelson.MODEL;
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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
            ActualizarDatos();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            ClsCliente cliente = new ClsCliente();

            cliente.Insertar(txtNombreCliente.Text, txtDireccionCliente.Text, txtDuiCliente.Text);
            ActualizarDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClsCliente cliente = new ClsCliente();
            cliente.Eliminar(Convert.ToInt32(txtId.Text));
            ActualizarDatos();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ClsCliente Clasecliente = new ClsCliente();
            tb_cliente Tablacliente = new tb_cliente();
            try
            {
                Tablacliente.iDCliente = Convert.ToInt32(txtId.Text);
                Tablacliente.nombreCliente = txtNombreCliente.Text;
                Tablacliente.direccionCliente = txtDireccionCliente.Text;
                Tablacliente.duiCliente = txtDuiCliente.Text;

                Clasecliente.Actulizar(Tablacliente);


                ActualizarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }
        void ActualizarDatos()
        {
            dataGridView1.Rows.Clear();
            using (sistema_ventasEntities db = new sistema_ventasEntities())

            {
                
                foreach (var iteracion in db.tb_cliente.ToList())
                {
                    dataGridView1.Rows.Add(iteracion.iDCliente, iteracion.nombreCliente, iteracion.direccionCliente, iteracion.duiCliente);
                }
            }

        }
    }
    
}
