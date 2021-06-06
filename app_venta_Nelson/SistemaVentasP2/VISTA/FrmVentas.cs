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
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
          
        }
        void ultimocorrelativodeventa(){


            ClsDVenta consultarultinaventa = new ClsDVenta();


            var consultarultimaventa = new ClsDVenta();
            int lista = 0;
            foreach (var list in consultarultimaventa.UltimaVenta())
            {

                lista = list.iDVenta;



            }
            lista++;
            txtUltimaVenta.Text = lista.ToString();


        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
         

            
            {
                ultimocorrelativodeventa();
                ClsDCliente clsDClientes = new ClsDCliente();



                    comboBox2.DataSource = clsDClientes.cargarComboCliente();
                    comboBox2.DisplayMember = "nombreCliente";
                    comboBox2.ValueMember = "iDCliente";


                ClsDDocumento clsDDocumento = new ClsDDocumento();

                    comboBox1.DataSource = clsDDocumento.cargarDocumento();
                    comboBox1.DisplayMember = "nombreDocumento";
                    comboBox1.ValueMember = "iDDocumento";
               
            }
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscarProducto buscar = new FrmBuscarProducto();
            buscar.Show();
            //btnAgregar.PerformClick();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string precio = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            //FrmMenu.FrmVenta.TxtId.Text = id;
            //FrmMenu.FrmVenta.TxtNombreProducto.Text = nombre;
            //FrmMenu.frmVenta.TxtCantidad.Text = precio;

            this.Close();

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            try{
                Double precio, cantidad, total;
            cantidad = Convert.ToDouble(txtCantidad.Text);
            precio = Convert.ToDouble(txtPrecioProducto.Text);

            total = precio * cantidad;

            txtTotal.Text = total.ToString();

            }
            catch(Exception ex){
                if (txtCantidad.Text.Equals("")){
                    txtCantidad.Text = "1";
                    txtCantidad.SelectAll();


                }


            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtCodigoProducto.Text,txtNombreProducto.Text,txtPrecioProducto.Text,txtCantidad.Text,txtTotal.Text);

            Double suma = 0;  /*variable de acarreo*/

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                String datosaoperartotal = dataGridView1.Rows[i].Cells[4].Value.ToString();

                Double DatosConvertidos = Convert.ToDouble(datosaoperartotal);

                suma += DatosConvertidos;

                txtTotalFinal.Text = suma.ToString();

                txtCodigoProducto.Clear();
                txtNombreProducto.Clear();
                txtPrecioProducto.Clear();
                txtCantidad.Text = "";
                txtTotal.Text = "";

            }




        }

        private void txtBuscarProductos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)


                if (txtBuscarProductos.Text.Equals(""))
                {
                    e.Handled = true;

                    btnAgregar.PerformClick();

                }
                else
                {

                    {
                        e.Handled = true;
                        ClsDProducto prod = new ClsDProducto();
                        var busqueda = prod.BuscarProductos(Convert.ToInt32(txtBuscarProductos.Text));

                        foreach (var iteracion in busqueda)
                        {
                            txtCodigoProducto.Text = iteracion.idProducto.ToString();
                            txtNombreProducto.Text = iteracion.nombreProducto;
                            txtPrecioProducto.Text = iteracion.precioProducto.ToString();
                            txtCantidad.Text = "i";
                            txtCantidad.Focus();
                            txtBuscarProductos.Text = "";
                        }


                    }
                }


        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {


                //btnAgregar.PerformClick();
                e.Handled = true;
                txtBuscarProductos.Focus();


            }
        }

        private void btnGuardarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                ClsDVenta ventas = new ClsDVenta();
                tb_venta venta = new tb_venta();
                venta.iDDocumento = Convert.ToInt32(comboBox1.SelectedValue.ToString());
                venta.iDCliente = Convert.ToInt32(comboBox2.SelectedValue.ToString());
                venta.iDUsuario = 1;
                venta.totalVenta = Convert.ToDecimal(txtTotalFinal.Text);
                venta.fecha = Convert.ToDateTime(dtpFecha.Text);
                ventas.save(venta);

                ClsDDetalle detalle = new ClsDDetalle();
                tb_detalleVenta tbDetalle = new tb_detalleVenta();

                foreach (DataGridViewRow dtgv in dataGridView1.Rows)
                {


                    tbDetalle.idVenta = Convert.ToInt32(txtUltimaVenta.Text); ;
                    tbDetalle.idProducto = Convert.ToInt32(dtgv.Cells[0].Value.ToString());
                    tbDetalle.cantidad = Convert.ToInt32(dtgv.Cells[3].Value.ToString());
                    tbDetalle.precio = Convert.ToDecimal(dtgv.Cells[2].Value.ToString());
                    tbDetalle.total = Convert.ToDecimal(dtgv.Cells[4].Value.ToString());
                    detalle.guardardetalleventa(tbDetalle);


                }

                ultimocorrelativodeventa();
                dataGridView1.Rows.Clear();
                txtTotalFinal.Text = "";

                MessageBox.Show("Guardado");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}

