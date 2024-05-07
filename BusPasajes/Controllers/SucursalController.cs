using BusPasajes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusPasajes.Controllers
{
    public class SucursalController : Controller
    {
        // GET: Sucursal
        public ActionResult Index()
        {
            List<SucursalCLS> lstsucursal = null;
            using (var bd = new BDPasajeEntities())
            {
                lstsucursal = (from sucursal in bd.Sucursal
                               where sucursal.BHABILITADO == 1
                              select new SucursalCLS
                              {
                                  iidsucursal = sucursal.IIDSUCURSAL,
                                  nombre = sucursal.NOMBRE,
                                  direccion = sucursal.DIRECCION,
                                  telefono = sucursal.TELEFONO,
                                  email = sucursal.EMAIL
                              }).ToList();
            }
            return View(lstsucursal);
        }

        public ActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Agregar(SucursalCLS oSucursalCLS)
        {
            if (!ModelState.IsValid)
            {
                return View (oSucursalCLS);
            }
            else
            {
                using (var bd = new BDPasajeEntities())
                {
                    Sucursal oSucursal = new Sucursal();
                    oSucursal.NOMBRE = oSucursalCLS.nombre;
                    oSucursal.DIRECCION = oSucursalCLS.direccion;
                    oSucursal.TELEFONO = oSucursalCLS.telefono;
                    oSucursal.EMAIL = oSucursalCLS.email;
                    oSucursal.FECHAAPERTURA = oSucursalCLS.fechaapertura;
                    oSucursal.BHABILITADO = 1;
                    bd.Sucursal.Add(oSucursal);
                    bd.SaveChanges();
                }
            }
            return RedirectToAction("Index"); 
        }
    }
}