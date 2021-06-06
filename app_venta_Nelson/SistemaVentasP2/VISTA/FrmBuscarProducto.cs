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
    public partial class FrmBuscarProducto : Form
    {
        public FrmBuscarProducto()
        {
            InitializeComponent();
            cargarProductos();
        }

        void cargarProductos()
        {

            var Lista = new ClsDProducto();
            dataGridView1.Rows.Clear();


            foreach (var listarDatos in Lista.cargarProductoFiltro(txtBuscarProducto.Text))
            {


                dataGridView1.Rows.Add(listarDatos.idProducto, listarDatos.nombreProducto, listarDatos.precioProducto);

            }
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            cargarProductos();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        void enviar()
        {

            String id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            String nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            String precio = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            //FrmVentas ventas = new FrmVentas();
            //ventas.txtCodigoProducto.Text = id;
            //ventas.txtNombreProducto.Text = nombre;
            //ventas.txtPrecioProducto.Text = precio;
            //ventas.Show();

            FrmMenu.ventas.txtCodigoProducto.Text = id;
            FrmMenu.ventas.txtNombreProducto.Text = nombre;
            FrmMenu.ventas.txtPrecioProducto.Text = precio;
            FrmMenu.ventas.txtCantidad.Focus();
            this.Close();
        }

        private void FrmBuscarProducto_Load(object sender, EventArgs e)
        {
            cargarProductos();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            enviar();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) {
                enviar();

            }
        }
    }
}
