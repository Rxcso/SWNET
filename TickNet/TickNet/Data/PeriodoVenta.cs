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
    
    public partial class PeriodoVenta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PeriodoVenta()
        {
            this.Precio_Eventos = new HashSet<Precio_Eventos>();
        }
    
        public string codPeriodo { get; set; }
        public Nullable<int> codEvento { get; set; }
        public Nullable<System.DateTime> fechaIni { get; set; }
        public Nullable<System.DateTime> fechaFin { get; set; }
    
        public virtual Eventos Eventos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Precio_Eventos> Precio_Eventos { get; set; }
    }
}
