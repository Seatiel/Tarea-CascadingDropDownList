using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TareaDeCiudades.Models;

namespace TareaDeCiudades.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProvinciaList()
        {
            IQueryable provincias = Provincias.GetProvincias();

            if (HttpContext.Request.IsAjaxRequest())
            {
                return Json(new SelectList(
                                provincias,
                                "ProvinciaId",
                                "NombreProvincia"), JsonRequestBehavior.AllowGet
                                );
            }
            return View(provincias);
        }

        public ActionResult CiudadList(int provinciaId)
        {
            IQueryable ciudades = Ciudades.GetCiudades().Where(c => c.ProvinciaId == provinciaId);

            if (HttpContext.Request.IsAjaxRequest())
            {
                return Json(new SelectList(
                                ciudades,
                                "CiudadesId",
                                "NombreCiudad"), JsonRequestBehavior.AllowGet
                                );
            }
            return View(ciudades);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}