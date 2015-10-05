using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TickNet.Data
{
    public class Cuentas
    {
        modelEntities contexto = new modelEntities();

        public void creaCuenta(CuentaUsuario cuenta)
        {
            try
            {
                contexto.CuentaUsuario.Add(cuenta);
                contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

        }
    }
}