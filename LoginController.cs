using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        public ActionResult ViewLogin()
        {
            return View();
        }

    [HttpPost]
        public ActionResult ViewLogin(LoginViewModel login)
        {
            var validar = LoginManager.Login(login.user, login.password);

            if (validar != null)
            {/*accion, contrlador*/
                Request.RequestContext.HttpContext.Session.Add("user", validar);
                return RedirectToAction("ViewInSistema", "InSistema");
            }
            else
            {
                ViewBag.Message = "Usuario o contraseña incorrectos";
                return View("ViewLogin");
            }
        }

	}
}