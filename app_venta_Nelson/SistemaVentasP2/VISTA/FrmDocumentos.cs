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
    public partial class FrmDocumentos : Form
    {
        public FrmDocumentos()
        {
            InitializeComponent();
            Carga();
            clear();
        }
        void clear()
        {
            txtIdDocumento.Clear();
            txtDocumento.Clear();
            
        }

        void Carga()
        {

            dataGridView1.Rows.Clear();
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                var Lista = db.tb_documento.ToList();

                foreach (var iteracion in Lista)
                {
                    dataGridView1.Rows.Add(iteracion.iDDocumento, iteracion.nombreDocumento);
                }
            }

        }

        private void btnAgregarDocumento_Click(object sender, EventArgs e)
        {
            ClsDDocumento clsDUserList = new ClsDDocumento();
            tb_documento userList = new tb_documento();
            userList.nombreDocumento = txtDocumento.Text;
           

            clsDUserList.SaveDatosUser(userList);

            Carga();
            clear();
        }

        private void btnRemoveDocumento_Click(object sender, EventArgs e)
        {
            ClsDDocumento user = new ClsDDocumento();
            user.deleteUser(Convert.ToInt32(txtIdDocumento.Text));

            Carga();
            clear();
        }

        private void btnUpdateDocumento_Click(object sender, EventArgs e)
        {
            ClsDDocumento clsDUserList = new ClsDDocumento();

            tb_documento userList = new tb_documento();
            userList.iDDocumento = Convert.ToInt32(txtIdDocumento.Text);
            userList.nombreDocumento = txtDocumento.Text;
         
            clsDUserList.updateUser(userList);

            Carga();
            clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String idDocumento = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            String nombreDocumento = dataGridView1.CurrentRow.Cells[1].Value.ToString();
           


            txtIdDocumento.Text = idDocumento;
            txtDocumento.Text = nombreDocumento;
           
        }
    }
}
