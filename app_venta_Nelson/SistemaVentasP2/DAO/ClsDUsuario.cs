using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVentasP2.MODEL;
namespace SistemaVentasP2.DAO
{
   
        class ClsDUsuario
        {

        public List<tb_usuario> cargarDatoUserList()

        {
            List<tb_usuario> Lista;

            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                Lista = db.tb_usuario.ToList();


            }

            return Lista;
        }


        public void SaveDatosUser(tb_usuario user)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {

                    tb_usuario userList = new tb_usuario();

                    userList.email = user.email;
                    userList.contrasena = user.contrasena;
                   

                    db.tb_usuario.Add(userList);
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
                    tb_usuario userList = db.tb_usuario.Where(x => x.iDUsuario == eliminar).Select(x => x).FirstOrDefault();

                 
                    db.tb_usuario.Remove(userList);
                    db.SaveChanges();

                   
                }
            }
            catch (Exception ex)
            {
            
            }
        }

        public void updateUser(tb_usuario user)
        {
            try
            {


                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {

                    int update = Convert.ToInt32(user.iDUsuario);
                    tb_usuario userList = db.tb_usuario.Where(x => x.iDUsuario == update).Select(x => x).FirstOrDefault();

                    userList.email = user.email;
                    userList.contrasena = user.contrasena;
                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {

            }
        }
    }

}