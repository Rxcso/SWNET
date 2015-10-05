using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TickNet.Data
{
    public class CuentaDAO
    {
        public string ImprimeCustomer(CuentaUsuario c)
        {
            string cust = c.usuario + "   " + c.nombre + "  " + c.apellido + "   " + c.codDoc;
            return cust;
        }

        public List<CuentaUsuario> GetCustomer(string correo)
        {
            var contexto = new modelEntities();
            if (correo.Equals(""))
            {
                return contexto.CuentaUsuario.AsNoTracking().ToList();
            }
            else
            {
                return contexto.CuentaUsuario.AsNoTracking().Where(c => c.correo == correo).ToList();
            }
        }

        public bool IsValid(string _correo, string _password)
        {
            List<TickNet.Data.CuentaUsuario> cu = new TickNet.Data.CuentaDAO().GetCustomer(_correo);
            
            if (cu.Count > 0)
            {
                if (cu[0].contrasena.Equals(_password))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
    }
}