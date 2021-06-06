using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVentasP2.DAO;
using SistemaVentasP2.MODEL;

namespace SistemaVentasP2.DAO
{
    class ClsDCliente
    {

        public List<tb_cliente> cargarComboCliente()

        {
            List<tb_cliente> Lista;

            List<tb_cliente> tb_Cliente = new List<tb_cliente>();

            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                Lista = db.tb_cliente.ToList();


            }

            return Lista;
        }


        public void SaveDatosUser(tb_cliente user)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {

                    tb_cliente userList = new tb_cliente();

                    userList.nombreCliente = user.nombreCliente;
                    userList.direccionCliente = user.direccionCliente;
                    userList.duiCliente = user.duiCliente;

                    db.tb_cliente.Add(userList);
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
                    tb_cliente userList = db.tb_cliente.Where(x => x.iDCliente == eliminar).Select(x => x).FirstOrDefault();


                    db.tb_cliente.Remove(userList);
                    db.SaveChanges();


                }
            }
            catch (Exception ex)
            {

            }
        }

        public void updateUser(tb_cliente user)
        {
            try
            {


                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {

                    int update = Convert.ToInt32(user.iDCliente);
                    tb_cliente userList = db.tb_cliente.Where(x => x.iDCliente == update).Select(x => x).FirstOrDefault();

                    
                    userList.nombreCliente = user.nombreCliente;
                    userList.direccionCliente = user.direccionCliente;
                    userList.duiCliente = user.duiCliente;
                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}
