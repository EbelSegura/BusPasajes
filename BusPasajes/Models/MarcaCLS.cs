using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BusPasajes.Models
{
    public class MarcaCLS
    {
        [Display(Name = "# de Marca")]
        public int iidmarca { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "la longitd maxima es de 100")]
        [Display(Name = "Nombre Marca")]
        public string nombre { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "la longitd maxima es de 200")]
        [Display(Name = "descripción")]
        public string descripcion { get; set; }

        public int bhabilitado { get; set; }
    }
}