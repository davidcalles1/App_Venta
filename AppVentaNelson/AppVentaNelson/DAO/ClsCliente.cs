using AppVentaNelson.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVentaNelson.DAO
{
    class ClsCliente
    {
        public void Insertar(String nombre, String direccion, String dui)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_cliente tabla = new tb_cliente();
               tabla.nombreCliente = nombre;
                tabla.direccionCliente = direccion;
                tabla.duiCliente = dui;

                db.tb_cliente.Add(tabla);
                db.SaveChanges();

            }

        }
        public void Eliminar(int id)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_cliente r = new tb_cliente();
                int eliminar = Convert.ToInt32(id);
                r = db.tb_cliente.Find(eliminar);
                db.tb_cliente.Remove(r);
                db.SaveChanges();


            }

        }
        public void Actulizar(tb_cliente cliente)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    int update = cliente.iDCliente;
                    tb_cliente agregarCliente = db.tb_cliente.Where(x => x.iDCliente == update).FirstOrDefault();
                    agregarCliente.nombreCliente = cliente.nombreCliente;
                    agregarCliente.direccionCliente = cliente.direccionCliente;
                    agregarCliente.duiCliente = cliente.duiCliente;

                    db.SaveChanges();
                    MessageBox.Show("Actualizados");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

    }
}
