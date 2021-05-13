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
    public partial class FrmDocumento : Form
    {
        public FrmDocumento()
        {
            InitializeComponent();
            ActualizarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsDocumento documento = new ClsDocumento();
            documento.Insertar(txtNombre.Text);
            ActualizarDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClsDocumento documento = new ClsDocumento();
            documento.Eliminar(Convert.ToInt32(txtId.Text));
            ActualizarDatos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClsDocumento ClaseDocumento = new ClsDocumento();
            tb_documento TablaDocumento = new tb_documento();

            TablaDocumento.iDDocumento = Convert.ToInt32(txtId.Text);
            TablaDocumento.nombreDocumento = txtNombre.Text;

            ClaseDocumento.Actulizar(TablaDocumento);
             ActualizarDatos();
        }
        void ActualizarDatos()
        {
            dataGridView1.Rows.Clear();
            using (sistema_ventasEntities db = new sistema_ventasEntities())

            {

                foreach (var iteracion in db.tb_documento.ToList())
                {
                    dataGridView1.Rows.Add(iteracion.iDDocumento, iteracion.nombreDocumento);
                }
            }

        }

        private void FrmDocumento_Load(object sender, EventArgs e)
        {

        }
    }
}
