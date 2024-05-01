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
    }
}