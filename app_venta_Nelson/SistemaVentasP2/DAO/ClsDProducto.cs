using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVentasP2.MODEL;

namespace SistemaVentasP2.DAO
{
    class ClsDProducto
    {


        public List<tb_producto> cargarProductoFiltro(string filtro)

        {
            List<tb_producto> tb_Productos = new List<tb_producto>();

            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_Productos = (from listadoProductos in db.tb_producto
                         where listadoProductos.nombreProducto.Contains(filtro)
                         select listadoProductos).ToList();
                //Lista = db.tb_producto.ToList();
            }

            return tb_Productos;
        }


        public List<tb_producto> BuscarProductos(int codigo)

        {
            List<tb_producto> tb_Productos = new List<tb_producto>();

            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_Productos = (from listadoProductos in db.tb_producto
                         where listadoProductos.idProducto == codigo
                         select listadoProductos).ToList();
                //Lista = db.tb_producto.ToList();
            }

            return tb_Productos;
        }


        public void SaveDatosUser(tb_producto user)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {

                    tb_producto userList = new tb_producto();

                    userList.nombreProducto = user.nombreProducto;
                    userList.precioProducto = user.precioProducto;
                    userList.estadoProducto = user.estadoProducto;

                    db.tb_producto.Add(userList);
                    db.SaveChanges();



                }

            }
            catch (Exception ex)
            {

            }
        }

        public void deleteUser(int ID)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    int eliminar = Convert.ToInt32(ID);
                    tb_producto userList = db.tb_producto.Where(x => x.idProducto == eliminar).Select(x => x).FirstOrDefault();


                    db.tb_producto.Remove(userList);
                    db.SaveChanges();


                }
            }
            catch (Exception ex)
            {

            }
        }

        public void updateUser(tb_producto user)
        {
            try
            {


                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {

                    int update = Convert.ToInt32(user.idProducto);
                    tb_producto userList = db.tb_producto.Where(x => x.idProducto == update).Select(x => x).FirstOrDefault();

                    userList.nombreProducto = user.nombreProducto;
                    userList.precioProducto = user.precioProducto;
                    userList.estadoProducto = user.estadoProducto;
                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {

            }
        }

    }
}
