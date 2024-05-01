using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BusPasajes.Models
{
    public class ClienteCLS
    {
        [Display(Name = "# de Cliente")]
        public int iidcliente { get; set; }

        [Display(Name = "Nombre Cliente")]
        public string nombre { get; set; }

        [Display(Name = "Apellid Paterno")]
        public string appaterno { get; set; }

        [Display(Name = "Apellido Materno")]
        public string apmaterno { get; set; }


        public string email { get; set; }


        public string direccion { get; set; }


        public int iidsexo { get; set; }

        [Display(Name = "Telefono Fijo")]
        public string telefonofijo { get; set; }


        public string telefonocelular { get; set; }


        public string bhabilitado { get; set; }
    }
}