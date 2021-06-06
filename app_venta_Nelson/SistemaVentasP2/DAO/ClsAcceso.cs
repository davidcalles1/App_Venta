using SistemaVentasP2.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasP2.DAO
{
    class ClsAcceso
    {

        public int acceso(string usuario, string Password)
        {
            int variabledeacceso = 0;
            using (sistema_ventasEntities bd = new sistema_ventasEntities())
            {

                var consulta = from user in bd.tb_usuario
                               where user.email == usuario && user.contrasena == Password
                               select user;

                if (consulta.Count() > 0)
                {
                    variabledeacceso = 1;
                }
            }

            return variabledeacceso;
        }

    }
}
