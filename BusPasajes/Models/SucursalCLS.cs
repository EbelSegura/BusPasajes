using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace BusPasajes.Models
{
    public class SucursalCLS
    {
        [Display(Name = "# de Sucursal")]
        public int iidsucursal { get; set; }

        [Required]
        [Display(Name = "Nombre Sucursal")]
        [StringLength(100, ErrorMessage = "Longitud maxima de 100")]
        public string nombre { get; set; }

        [Required]
        [Display(Name = "Direccion")]
        [StringLength(200, ErrorMessage = "Longitud maxima de 200")]
        public string direccion { get ; set; }

        [Required]
        [Display(Name = "Telefono Sucursal")]
        [StringLength(10, ErrorMessage = "Longitud maxima de 10")]
        public string telefono { get; set; }

        [Required]
        [Display(Name = "Email Sucursal")]
        [EmailAddress(ErrorMessage = "Ingrese un email valido")]
        [StringLength(100, ErrorMessage = "Longitud maxima de 100")]
        public string email { get; set; }

        [Required]
        [Display(Name = "Fecha Apertura")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",ApplyFormatInEditMode = true)]
        public DateTime fechaapertura { get; set; }


        public int bhabilitado { get; set; }
    }
}