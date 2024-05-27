using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BusPasajes.Models
{
    public class BusCLS
    {
        [Display(Name = "# de Bus")]
        public int iidbus { get; set; }

        [Required]
        [Display(Name = "Nombre Sucursal")]
        public int iidsucursal { get; set; }

        [Required]
        [Display(Name = "Tipo Bus")]
        public int iidtipobus { get; set; }

        [Required]
        [Display(Name = "Placa")]   
        [StringLength(100, ErrorMessage = "Longitud maxima 100")]
        public string placa { get; set; }

        [Required]
        [Display(Name = "Fecha Compra")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime fechacompra { get; set; }

        [Required]
        [Display(Name = "Nombre Modelo")]
        public int iidmodelo { get; set; }

        [Required]
        [Display(Name = "Numero Filas")]
        public int numerofilas { get; set; }

        [Required]
        [Display(Name = "Numero Columnas")]
        public int numerocolumnas { get; set; }


        public int bhabilitado { get; set; }

        [Required]
        [Display(Name = "Descripción")]
        [StringLength(200, ErrorMessage = "Longitud maxima 200")]
        public string descripcion { get; set; }

        [Display(Name = "Observacion")]
        [StringLength(200, ErrorMessage = "Longitud maxima 200")]
        public string observacion { get; set; }

        [Required]
        [Display(Name = "# de Marca")]
        public int iidmarca { get; set; }


        //Propiedades adicionales
        [Display(Name = "Nombre Sucursal")]
        public string nombresucursal { get; set; }

        [Display(Name = "Nombre Tipo Bus")]
        public string nombretipobus { get; set; }

        [Display(Name = "Nombre Modelo")]
        public string nombremodelo { get; set; }

    }
}