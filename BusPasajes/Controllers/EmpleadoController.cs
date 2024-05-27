using BusPasajes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusPasajes.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Index()
        {
            List<EmpleadoCLS> lstempleado = null;
            using (var bd = new BDPasajeEntities())
            {
                lstempleado = (from empleado in bd.Empleado 
                               join TipoUsuario in bd.TipoUsuario
                               on empleado.IIDTIPOUSUARIO equals TipoUsuario.IIDTIPOUSUARIO
                               join TipoContrato in bd.TipoContrato
                               on empleado.IIDTIPOCONTRATO equals TipoContrato.IIDTIPOCONTRATO
                              where empleado.BHABILITADO == 1
                              select new EmpleadoCLS
                              {
                                  iidempleado = empleado.IIDEMPLEADO,
                                  nombre = empleado.NOMBRE,
                                  appaterno = empleado.APPATERNO,
                                  apmaterno = empleado.APMATERNO,
                                  nombretipousuario = TipoUsuario.NOMBRE,
                                  nombretipocontrato = TipoContrato.NOMBRE
                              }).ToList();
            }
            return View(lstempleado);
        }
    }
}