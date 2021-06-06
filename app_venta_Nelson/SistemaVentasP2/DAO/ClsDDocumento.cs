using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVentasP2.MODEL;
namespace SistemaVentasP2.DAO
{
    class ClsDDocumento
    {


        public List<tb_documento> cargarDocumento()

        {
            List<tb_documento> Lista = new List<tb_documento>();

            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                Lista = db.tb_documento.ToList();


            }

            return Lista;
        }


        public void SaveDatosUser(tb_documento user)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {

                    tb_documento userList = new tb_documento();

                    userList.nombreDocumento = user.nombreDocumento;
                   


                    db.tb_documento.Add(userList);
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
                    tb_documento userList = db.tb_documento.Where(x => x.iDDocumento == eliminar).Select(x => x).FirstOrDefault();


                    db.tb_documento.Remove(userList);
                    db.SaveChanges();


                }
            }
            catch (Exception ex)
            {

            }
        }

        public void updateUser(tb_documento user)
        {
            try
            {


                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {

                    int update = Convert.ToInt32(user.iDDocumento);
                    tb_documento userList = db.tb_documento.Where(x => x.iDDocumento == update).Select(x => x).FirstOrDefault();

                    userList.nombreDocumento = user.nombreDocumento;
                 
                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {

            }
        }


    }
}
