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
                            where marca.BHABILITADO == 1
                            select new MarcaCLS
                            {
                                iidmarca = marca.IIDMARCA,
                                nombre = marca.NOMBRE,
                                descripcion = marca.descripcion
                            }).ToList();
            }
            return View(lstmarca);
        }

        public ActionResult Agregar()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Agregar(MarcaCLS oMarcaCLS)
        {
            if (!ModelState.IsValid)
            {
                return View(oMarcaCLS);
            }
            else
            {
                using (var bd = new BDPasajeEntities())
                {
                    Marca oMarca = new Marca();
                    oMarca.NOMBRE = oMarcaCLS.nombre;
                    oMarca.descripcion = oMarcaCLS.descripcion;
                    oMarca.BHABILITADO = 1;
                    bd.Marca.Add(oMarca);
                    bd.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }
    }
}