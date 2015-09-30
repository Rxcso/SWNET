using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TickNet.Models;

namespace TickNet.Controllers
{
    public class ClientController : Controller
    {
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }
        
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Register(ClientViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index","Home");
            }
            return View(model);
        }

        public ActionResult Register2()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Register2(FormCollection collection)
        {
            String correo = collection["correo"];
            return View();
        }
    }
}