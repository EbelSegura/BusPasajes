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

        List<SelectListItem> listasexo;
        private void llenarsexo()
        {
            using (var bd = new BDPasajeEntities())
            {
                listasexo = (from sexo in bd.Sexo
                             where sexo.BHABILITADO == 1
                             select new SelectListItem
                             {
                                 Text = sexo.NOMBRE,
                                 Value = sexo.IIDSEXO.ToString()
                             }).ToList();
                listasexo.Insert(0, new SelectListItem { Text = "--Seleccione--", Value = "" });
            }
        }

        public ActionResult Agregar()
        {
            llenarsexo();
            ViewBag.lista = listasexo;
            return View();
        }

        [HttpPost]
        public ActionResult Agregar(ClienteCLS oClienteCLS)
        {
            if (!ModelState.IsValid)
            {
                llenarsexo();
                ViewBag.lista = listasexo;
                return View(oClienteCLS);
            }
            else
            {
                using (var bd = new BDPasajeEntities())
                {
                    Cliente oCliente = new Cliente();
                    oCliente.NOMBRE = oClienteCLS.nombre;
                    oCliente.APPATERNO = oClienteCLS.appaterno;
                    oCliente.APMATERNO = oClienteCLS.apmaterno;
                    oCliente.EMAIL = oClienteCLS.email;
                    oCliente.DIRECCION = oClienteCLS.direccion;
                    oCliente.IIDSEXO = oClienteCLS.iidsexo;
                    oCliente.TELEFONOFIJO = oClienteCLS.telefonofijo;
                    oCliente.TELEFONOCELULAR = oClienteCLS.telefonocelular;
                    oCliente.BHABILITADO = 1;
                    bd.Cliente.Add(oCliente);
                    bd.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }
    }
}