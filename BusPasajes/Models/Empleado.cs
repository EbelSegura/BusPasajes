//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusPasajes.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empleado
    {
        public int IIDEMPLEADO { get; set; }
        public string NOMBRE { get; set; }
        public string APPATERNO { get; set; }
        public string APMATERNO { get; set; }
        public Nullable<System.DateTime> FECHACONTRATO { get; set; }
        public Nullable<decimal> SUELDO { get; set; }
        public Nullable<int> IIDTIPOUSUARIO { get; set; }
        public Nullable<int> IIDTIPOCONTRATO { get; set; }
        public Nullable<int> IIDSEXO { get; set; }
        public Nullable<int> BHABILITADO { get; set; }
        public Nullable<int> bTieneUsuario { get; set; }
        public string TIPOUSUARIO { get; set; }
    
        public virtual Sexo Sexo { get; set; }
        public virtual TipoUsuario TipoUsuario1 { get; set; }
        public virtual TipoContrato TipoContrato { get; set; }
        public virtual TIPOUSUARIOREGISTRO TIPOUSUARIOREGISTRO { get; set; }
    }
}
