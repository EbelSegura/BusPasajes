using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BusPasajes.Models
{
    public class EmpleadoCLS
    {
        [Display(Name = "# de Empleado")]
        public int iidempleado { get; set; }

        
        [Required]
        [Display(Name = "Nombre")]
        [StringLength(100, ErrorMessage = "Longitud maxima de 100")]
        public string nombre { get; set; }

        [Required]
        [Display(Name = "Apellido Paterno")]
        [StringLength(200, ErrorMessage = "Longitud maxima de 200")]
        public string appaterno { get; set; }

        [Required]
        [Display(Name = "Apellido Materno")]
        [StringLength(200, ErrorMessage = "Longitud maxima de 200")]
        public string apmaterno { get; set; }

        [Required]
        [Display(Name = "Fecha De Contrato")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime fechacontrato { get; set; }

        /*[Display(Name = "Sueldo")]
        public decimal sueldo { get; set; }*/

        [Required]
        [Display(Name = "Tipo Usuario")]
        public int iidtipousuario { get; set; }

        [Required]
        [Display(Name = "Tipo Contrato")]
        public int iidtipocontrato { get; set; }

        [Required]
        [Display(Name = "Sexo")]
        public int iidsexo { get; set; }


        public int bhabilitado { get; set; }

        //PROPIEDADES ADICIONALES
        [Display(Name = "Tipo Contrato")]
        public string nombretipocontrato { get; set; }

        [Display(Name = "Tipo Usuario")]
        public string nombretipousuario { get; set; }



    }
}