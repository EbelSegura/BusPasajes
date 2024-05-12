using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusPasajes.Models
{
    public class ClienteCLS
    {
        [Display(Name = "# de Cliente")]
        public int iidcliente { get; set; }

        [Required]
        [Display(Name = "Nombre Cliente")]
        [StringLength(100, ErrorMessage = "Longitud maxima es de 100")]
        public string nombre { get; set; }

        [Required]
        [Display(Name = "Apellido Paterno")]
        [StringLength(150, ErrorMessage = "Longitud maxima es de 150")]
        public string appaterno { get; set; }

        [Required]
        [Display(Name = "Apellido Materno")]
        [StringLength(150, ErrorMessage = "Longitud maxima es de 150")]
        public string apmaterno { get; set; }

        [Required]
        [Display(Name = "Correo Elctronico")]
        [StringLength(200, ErrorMessage = "Longitud maxima es de 200")]
        [EmailAddress(ErrorMessage = "Ingrese un email valido")]
        public string email { get; set; }

        [Required]
        [Display(Name = "Domicilio")]
        [StringLength(200, ErrorMessage = "Longitud maxima es de 200")]
        public string direccion { get; set; }

        [Required]
        [Display(Name = "Sexo")]
        public int iidsexo { get; set; }

        [Required]
        [Display(Name = "Telefono Fijo")]
        [StringLength(10, ErrorMessage = "Longitud maxima es de 10")]
        public string telefonofijo { get; set; }

        [Required]
        [Display(Name = "Telefono Celular")]
        [StringLength(10, ErrorMessage = "Longitud maxima es de 10")]
        public string telefonocelular { get; set; }


        public string bhabilitado { get; set; }
    }
}