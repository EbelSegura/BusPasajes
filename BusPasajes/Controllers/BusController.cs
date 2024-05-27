using BusPasajes.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusPasajes.Controllers
{
    public class BusController : Controller
    {
        // GET: Bus
        public ActionResult Index()
        {
            List<BusCLS> lstbus = null;
            using (var bd = new BDPasajeEntities())
            {
                lstbus = (from bus in bd.Bus
                          join sucursal in bd.Sucursal
                          on bus.IIDSUCURSAL equals sucursal.IIDSUCURSAL
                          join TipoBus in bd.TipoBus
                          on bus.IIDSUCURSAL equals TipoBus.IIDTIPOBUS
                          where bus.BHABILITADO == 1
                          join modelo in bd.Modelo
                          on bus.IIDMODELO equals modelo.IIDMODELO
                          where bus.BHABILITADO == 1
                          select new BusCLS
                          {
                              iidbus = bus.IIDBUS,
                              nombresucursal = sucursal.NOMBRE,
                              nombretipobus = TipoBus.NOMBRE,
                              placa = bus.PLACA,
                              nombremodelo = modelo.NOMBRE
                          }).ToList();
            }
            return View(lstbus);
        }
    }
}