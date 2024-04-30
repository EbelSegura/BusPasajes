using BusPasajes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Web;
using System.Web.Mvc;

namespace BusPasajes.Controllers
{
    public class MarcaController : Controller
    {
        // GET: Marca
        public ActionResult Index()
        {
            List<MarcaCLS> lstmarca = null;
            using (var bd = new BDPasajeEntities())
            {
                lstmarca = (from marca in bd.Marca
                            select new MarcaCLS
                            {
                                iidmarca = marca.IIDMARCA,
                                nombre = marca.NOMBRE,
                                descripcion = marca.DESCRIPCION
                            }).ToList();
            }
            return View(lstmarca);
        }
    }
}