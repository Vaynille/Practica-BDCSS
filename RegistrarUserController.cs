using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class RegistrarUserController : Controller
    {
        //
        // GET: /RegistrarUser/
        public ActionResult ViewRegistrarUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ViewRegistrarUser(UsuarioModel usuario)
        {
            DbConnection conn = new DbConnection();
            conn.CrearUsuario(usuario);
            ViewBag.message = "Correctamente";
            return View();
           
           // return RedirectToAction("ViewMain", "Main");
        }


          [HttpGet]
        public JsonResult BuscarCorreo(string email)
        {
            var db = new DbConnection();

            var usuario = db.BuscarPorEmail(email);
            return Json(new { Existe = usuario != null, Mensaje = "Ejecucion exitosa" }, JsonRequestBehavior.AllowGet);
   
        }


        }
}