using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BusPasajes.Models
{
    public class ViajeCLS
    {
        [Display(Name = "# de Viaje")]
        public int iidviaje { get; set; }

        [Required]
        [Display(Name = "Lugar De Origen")]
        public int iidlugarorigen { get; set; }

        [Required]
        [Display(Name = "Lugar Destino")]
        public int iidlugaresdestino { get; set; }

        [Required]
        [Display(Name = "Precio")]
        public decimal precio { get; set; }

        [Required]
        [Display(Name = "Fecha Viaje")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime fechaviaje { get; set; }

        [Required]
        [Display(Name = "Bus")]
        public int iidbus { get; set; }

        [Required]
        [Display(Name = "Numero Asiento Disponible")]
        public int numeroasientosdisponibles { get; set; }


        //public int bhabilitado { get; set; }

        //PROPIEDADES ADICIONALES
        [Display(Name = "Lugar De Origen")]
        public string nombrelugarorigen { get; set; }

        [Display(Name = "Lugar De Destino")]
        public string nombrelugardestino { get; set; }

        [Display(Name = "Nombre Bus")]
        public string nombrebus { get; set; }
    }
}