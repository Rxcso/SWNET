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
    
    public partial class Funcion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Funcion()
        {
            this.AsientosXFuncion = new HashSet<AsientosXFuncion>();
            this.VentasXFuncion = new HashSet<VentasXFuncion>();
        }
    
        public string codFuncion { get; set; }
        public string horaIni { get; set; }
        public string horaFin { get; set; }
        public string fecha { get; set; }
        public int codEvento { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AsientosXFuncion> AsientosXFuncion { get; set; }
        public virtual Eventos Eventos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VentasXFuncion> VentasXFuncion { get; set; }
    }
}
