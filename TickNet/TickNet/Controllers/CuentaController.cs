using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TickNet.Data;
using TickNet.Models;

namespace TickNet.Controllers
{
    public class CuentaController : Controller
    {
        // GET: Cuenta
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult crearusuario()
        {
            return View();
        }

        public ActionResult micuenta()
        {
            return View();
        }

        [HttpPost]
        public ActionResult nuevacuenta(CuentaUsuario modelo)
        {
            new Cuentas().creaCuenta(modelo);
            ViewData["mensaje"] = "cuenta creada";
            return View("crearusuario");
        }

        [HttpPost]
        public ActionResult Login(TickNet.Data.CuentaUsuario user)
        {
            if (ModelState.IsValid)
            {
                if (new TickNet.Data.CuentaDAO().IsValid(user.correo, user.contrasena))
                {
                    return RedirectToAction("micuenta", "Cuenta");
                }
                else
                {
                    ModelState.AddModelError("", "Login data is incorrect!");
                }
            }
            return View(user);
        }

    }
}