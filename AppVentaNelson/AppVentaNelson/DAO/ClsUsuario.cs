using AppVentaNelson.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVentaNelson.DAO
{
    class ClsUsuario
    {
        public void Insertar(String email, String contraseña)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_usuario tabla = new tb_usuario();
                tabla.email = email;
                tabla.contrasena = contraseña;


                db.tb_usuario.Add(tabla);
                db.SaveChanges();

            }

        }
        public void Eliminar(int id)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_usuario b = new tb_usuario();
                int eliminar = Convert.ToInt32(id);
                b = db.tb_usuario.Find(eliminar);
                db.tb_usuario.Remove(b);
                db.SaveChanges();


            }

        }
        public void Actualizar(tb_usuario cliente)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    int update = cliente.iDUsuario;
                    tb_usuario modificarCliente = db.tb_usuario.Where(x => x.iDUsuario == update).FirstOrDefault();
                    modificarCliente.email = cliente.email;
                    modificarCliente.contrasena = cliente.contrasena;


                    db.SaveChanges();
                    MessageBox.Show("SE ACTUALIZO DE FORMA CORECTA");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }


}


