using SistemaVentasP2.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVentasP2.DAO;

namespace SistemaVentasP2.VISTA
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
            Carga();
            clear();
        }
        void clear()
        {
            txtIdCliente.Clear();
            txtNombreCliente.Clear();
            txtDireccionCliente.Clear();
            txtDuiCliente.Clear();
        }

        void Carga()
        {

            dataGridView1.Rows.Clear();
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                var Lista = db.tb_cliente.ToList();

                foreach (var iteracion in Lista)
                {
               dataGridView1.Rows.Add(iteracion.iDCliente, iteracion.nombreCliente, iteracion.direccionCliente,iteracion.duiCliente);
                }
            }

        }

        private void btnAgregarClientes_Click(object sender, EventArgs e)
        {
              ClsDCliente clsDUserList = new ClsDCliente();
            tb_cliente userList = new tb_cliente();
            userList.nombreCliente= txtNombreCliente.Text;
            userList.direccionCliente = txtDireccionCliente.Text;
            userList.duiCliente = txtDuiCliente.Text;

            clsDUserList.SaveDatosUser(userList);

            Carga();
            clear();
        }

        private void btnRemoveClientes_Click(object sender, EventArgs e)
        {
            ClsDCliente user = new ClsDCliente();
            user.deleteUser(Convert.ToInt32(txtIdCliente.Text));

            Carga();
            clear();
        }

        private void btnUpdateClientes_Click(object sender, EventArgs e)
        {
            ClsDCliente clsDUserList = new ClsDCliente();

            tb_cliente userList = new tb_cliente();
            userList.iDCliente = Convert.ToInt32(txtIdCliente.Text);
            userList.nombreCliente = txtNombreCliente.Text;
            userList.direccionCliente = txtDireccionCliente.Text;
            userList.duiCliente = txtDuiCliente.Text;
            clsDUserList.updateUser(userList);

            Carga();
            clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String idCliente = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            String nombreCliente = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            String DireccionCliente = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            String dui = dataGridView1.CurrentRow.Cells[3].Value.ToString();


            txtIdCliente.Text = idCliente;
            txtNombreCliente.Text = nombreCliente;
            txtDireccionCliente.Text = DireccionCliente;
            txtDuiCliente.Text = dui;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
