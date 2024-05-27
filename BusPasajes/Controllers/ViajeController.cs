using BusPasajes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusPasajes.Controllers
{
    public class ViajeController : Controller
    {
        // GET: Viaje
        public ActionResult Index()
        {
            List<ViajeCLS> lstviaje = null;
            using (var bd = new BDPasajeEntities())
            {
                lstviaje = (from viaje in bd.Viaje
                            join lugarorigen in bd.Lugar
                            on viaje.IIDLUGARORIGEN equals lugarorigen.IIDLUGAR
                            join lugardestino in bd.Lugar
                            on viaje.IIDLUGARDESTINO equals lugardestino.IIDLUGAR
                            join bus in bd.Bus
                            on viaje.IIDBUS equals bus.IIDBUS
                            //where viaje.BHABILITADO == 1
                            select new ViajeCLS
                            {
                                iidviaje = viaje.IIDVIAJE,
                                nombrebus = bus.PLACA,
                                nombrelugarorigen = lugarorigen.NOMBRE,
                                nombrelugardestino = lugardestino.NOMBRE
                            }).ToList();
            }
            return View(lstviaje);
        }
    }
}