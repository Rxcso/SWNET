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
    
    public partial class ZonaEvento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ZonaEvento()
        {
            this.Asientos = new HashSet<Asientos>();
            this.Precio_Eventos = new HashSet<Precio_Eventos>();
        }
    
        public string codZona { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string piso { get; set; }
        public string aforo { get; set; }
        public int codLocal { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asientos> Asientos { get; set; }
        public virtual Locales Locales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Precio_Eventos> Precio_Eventos { get; set; }
    }
}
