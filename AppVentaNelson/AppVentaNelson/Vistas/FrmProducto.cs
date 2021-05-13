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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
            ActualirDatos();
        }
        void ActualirDatos()
        {
            dataGridView1.Rows.Clear();
            using (sistema_ventasEntities db = new sistema_ventasEntities())

            {
                var lista = db.tb_producto.ToList();
                foreach (var iteracion in lista)
                {
                    dataGridView1.Rows.Add(iteracion.idProducto, iteracion.nombreProducto, iteracion.precioProducto, iteracion.estadoProducto);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsProducto producto = new ClsProducto();

            producto.Insertar(txtNombre.Text, txtPrecio.Text, txtEstado.Text);
            ActualirDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClsProducto producto = new ClsProducto();
            producto.Eliminar(Convert.ToInt32(txtId.Text));
            ActualirDatos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClsProducto ClaseProducto = new ClsProducto();
            tb_producto Producto = new tb_producto();
            try
            {
                Producto.idProducto = Convert.ToInt32(txtId.Text);
                Producto.nombreProducto = txtNombre.Text;
                Producto.precioProducto = txtPrecio.Text;
                Producto.estadoProducto = txtEstado.Text;

                ClaseProducto.Actulizar(Producto);

                ActualirDatos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
