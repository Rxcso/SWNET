//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TickNet.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Locales
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Locales()
        {
            this.Eventos = new HashSet<Eventos>();
            this.ZonaEvento = new HashSet<ZonaEvento>();
        }
    
        public string aforo { get; set; }
        public string ubicacion { get; set; }
        public string descripcion { get; set; }
        public int codLocal { get; set; }
        public int idProvincia { get; set; }
        public string idRegion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Eventos> Eventos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZonaEvento> ZonaEvento { get; set; }
        public virtual Region Region { get; set; }
    }
}
