//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdminCampana_2020.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class Auditoria
    {
        public int id { get; set; }
        public Nullable<int> idMovilizado { get; set; }
        public Nullable<int> idUsuario { get; set; }
        public string hora { get; set; }
        public string fecha { get; set; }
        public string operacion { get; set; }
        public string modulo { get; set; }
    }
}
