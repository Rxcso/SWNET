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
    
    public partial class Promociones
    {
        public string fechaIni { get; set; }
        public string fechaFin { get; set; }
        public string descuento { get; set; }
        public string descripcion { get; set; }
        public string cantAdq { get; set; }
        public string cantComp { get; set; }
        public string modoPago { get; set; }
        public int codigo { get; set; }
        public string codBanco { get; set; }
        public string codTipoTarjeta { get; set; }
    
        public virtual Banco Banco { get; set; }
        public virtual TipoTarjeta TipoTarjeta { get; set; }
    }
}
