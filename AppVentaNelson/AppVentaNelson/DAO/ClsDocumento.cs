using AppVentaNelson.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVentaNelson.DAO
{
    class ClsDocumento
    {
        public void Insertar(String nombre)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_documento documento = new tb_documento();
                documento.nombreDocumento = nombre;


                db.tb_documento.Add(documento);
                db.SaveChanges();

            }

        }
        public void Eliminar(int id)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_documento documento = new tb_documento();
                int eliminar = Convert.ToInt32(id);
                documento = db.tb_documento.Find(eliminar);
                db.tb_documento.Remove(documento);
                db.SaveChanges();


            }

        }
        public void Actulizar(tb_documento documento)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    int update = documento.iDDocumento;
                    tb_documento agregardocumento = db.tb_documento.Where(x => x.iDDocumento == update).FirstOrDefault();
                    agregardocumento.nombreDocumento = documento.nombreDocumento;


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
}
