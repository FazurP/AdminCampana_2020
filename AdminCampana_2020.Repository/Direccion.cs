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
    
    public partial class Direccion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Direccion()
        {
            this.Movilizado = new HashSet<Movilizado>();
        }
    
        public int id { get; set; }
        public string strCalle { get; set; }
        public string strNumeroInterior { get; set; }
        public string strNumeroExterior { get; set; }
        public Nullable<int> idColonia { get; set; }
        public string strObservacion { get; set; }
    
        public virtual Colonia Colonia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Movilizado> Movilizado { get; set; }
    }
}
