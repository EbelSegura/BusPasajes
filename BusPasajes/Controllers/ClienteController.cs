using BusPasajes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusPasajes.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            List<ClienteCLS> lstcliente = null;
            using (var bd = new BDPasajeEntities())
            {
                lstcliente = (from cliente in bd.Cliente
                              where cliente.BHABILITADO == 1
                              select new ClienteCLS
                              {
                                  iidcliente = cliente.IIDCLIENTE,
                                  nombre = cliente.NOMBRE,
                                  appaterno = cliente.APPATERNO,
                                  apmaterno = cliente.APMATERNO,
                                  telefonofijo = cliente.TELEFONOFIJO
                              }).ToList();
            }
            return View(lstcliente);
        }
    }
}