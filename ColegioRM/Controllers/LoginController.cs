using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ColegioRM.ModelsE;

//namespace ColegioRM.Controllers
//{
//        public class LoginController : Controller
//        {
//            // GET: Login
//            public ActionResult Index()
//            {
//                return View();
//            }

//            //
//            [HttpPost]
//            public ActionResult Autherize(ModelsE.Usuario UsuariosModel)


//            {
//                using (ColegioRMEntities1 db = new ColegioRMEntities1())
//                {
//                    var usuariosDetails = db.Usuario.Where(x => x.codUsuario == UsuariosModel.codUsuario && x.contrasena == UsuariosModel.contrasena).FirstOrDefault();
//                    if (usuariosDetails == null)
//                    {
//                        UsuariosModel.LoginErrorMessage = "Usuario y/o contraseña incorrecta.";
//                        return View("Index", UsuariosModel);
//                    }
//                    else
//                    {
//                        Session["idUsuarios"] = usuariosDetails.idUsuario;
//                        Session["username"] = usuariosDetails.codUsuario;
//                        Session["apPaterno"] = usuariosDetails.apPaterno;
//                        Session["apMaterno"] = usuariosDetails.apMaterno;
//                        Session["nombres"] = usuariosDetails.nombres;
//                        return RedirectToAction("Index", "Home");
//                    }
//                }

//            }

//            public ActionResult LogOut()
//            {
//                int userId = (int)Session["idUsuarios"];
//                Session.Abandon();
//                return RedirectToAction("Index", "Login");
//            }


//        }
//    }
