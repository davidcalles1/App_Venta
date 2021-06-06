using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVentasP2.MODEL;
using SistemaVentasP2.DAO;

namespace SistemaVentasP2.VISTA
{
    public partial class FrmAgregarUsuarios : Form
    {
        public FrmAgregarUsuarios()
        {
            InitializeComponent();
            Carga();
            clear();
        }

        void clear()
        {

            txtIdUsuarios.Clear();
            txtEmail.Clear();
            txtPass.Clear();
           
        }

        void Carga()
        {

            dataGridView1.Rows.Clear();
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                var Lista = db.tb_usuario.ToList();

                foreach (var iteracion in Lista)
                {
                    dataGridView1.Rows.Add(iteracion.iDUsuario,iteracion.email,iteracion.contrasena);
                }
            }

        }

        private void btnAgregarUsuarios_Click(object sender, EventArgs e)
        {
            ClsDUsuario clsDUserList = new ClsDUsuario();
            tb_usuario userList = new tb_usuario();
            userList.email= txtEmail.Text;
            userList.contrasena = txtPass.Text;
            
            clsDUserList.SaveDatosUser(userList);

            Carga();
            clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ClsDUsuario user = new ClsDUsuario();
            user.deleteUser(Convert.ToInt32(txtIdUsuarios.Text));

            Carga();
            clear();
        }

        private void btnUpdateUsuario_Click(object sender, EventArgs e)
        {
            ClsDUsuario clsDUserList = new ClsDUsuario();

            tb_usuario userList = new tb_usuario();
            userList.iDUsuario= Convert.ToInt32(txtIdUsuarios.Text);
            userList.email = txtEmail.Text;
            userList.contrasena = txtPass.Text;
          
            clsDUserList.updateUser(userList);

            Carga();
            clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String Id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            String email = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            String pass = dataGridView1.CurrentRow.Cells[2].Value.ToString();


            txtIdUsuarios.Text = Id;
            txtEmail.Text = email;
            txtPass.Text = pass;

        }

        private void txtIdUsuarios_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
