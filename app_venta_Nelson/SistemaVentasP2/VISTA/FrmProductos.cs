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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
            Carga();
            clear();
        }
        void clear()
        {
            txtidProducto.Clear();
            txtProducto.Clear();
            txtPrecioProducto.Clear();
            txtEstadoProducto.Clear();
        }

        void Carga()
        {

            dataGridView1.Rows.Clear();
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                var Lista = db.tb_producto.ToList();

                foreach (var iteracion in Lista)
                {
                    dataGridView1.Rows.Add(iteracion.idProducto, iteracion.nombreProducto, iteracion.precioProducto,iteracion.estadoProducto);
                }
            }

        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            ClsDProducto clsDUserList = new ClsDProducto();
            tb_producto userList = new tb_producto();
            userList.nombreProducto = txtProducto.Text;
            userList.precioProducto = txtPrecioProducto.Text;
            userList.estadoProducto = txtEstadoProducto.Text;

            clsDUserList.SaveDatosUser(userList);

            Carga();
            clear();
        }

        private void btnRemoveProducto_Click(object sender, EventArgs e)
        {
            ClsDProducto user = new ClsDProducto();
            user.deleteUser(Convert.ToInt32(txtidProducto.Text));

            Carga();
            clear();
        }

        private void btnUpdateProducto_Click(object sender, EventArgs e)
        {
            ClsDProducto clsDUserList = new ClsDProducto();

            tb_producto userList = new tb_producto();
            userList.idProducto = Convert.ToInt32(txtidProducto.Text);
            userList.nombreProducto = txtProducto.Text;
            userList.precioProducto = txtPrecioProducto.Text;
            userList.estadoProducto = txtEstadoProducto.Text;
            clsDUserList.updateUser(userList);

            Carga();
            clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            String idProducto = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            String nombreProducto = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            String PrecioProducto = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            String EstadoProducto = dataGridView1.CurrentRow.Cells[3].Value.ToString();


            txtidProducto.Text = idProducto;
            txtProducto.Text = nombreProducto;
            txtPrecioProducto.Text = PrecioProducto;
            txtEstadoProducto.Text = EstadoProducto;


        }
    }
}
