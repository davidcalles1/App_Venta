using AppVentaNelson.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVentaNelson.DAO
{
    class ClsProducto
    {

        public void Insertar(String nombre, String precio, String estado)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_producto Producto = new tb_producto();
                Producto.nombreProducto = nombre;
                Producto.precioProducto = precio;
                Producto.estadoProducto = estado;

                db.tb_producto.Add(Producto);
                db.SaveChanges();

            }

        }
        public void Eliminar(int id)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_producto producto = new tb_producto();
                int eliminar = Convert.ToInt32(id);
                producto = db.tb_producto.Find(eliminar);
                db.tb_producto.Remove(producto);
                db.SaveChanges();


            }

        }
        public void Actulizar(tb_producto producto)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    int update = producto.idProducto;
                    tb_producto aproducto = db.tb_producto.Where(x => x.idProducto == update).FirstOrDefault();
                    aproducto.nombreProducto = producto.nombreProducto;
                    aproducto.precioProducto = producto.precioProducto;
                    aproducto.estadoProducto = producto.estadoProducto;

                    db.SaveChanges();
                    MessageBox.Show("Actualizados ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }




    }
}
