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
    
    public partial class CuentaUsuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CuentaUsuario()
        {
            this.Comentarios = new HashSet<Comentarios>();
            this.RegaloxCliente = new HashSet<RegaloxCliente>();
        }
    
        public string usuario { get; set; }
        public string tipoUsuario { get; set; }
        public string correo { get; set; }
        public string contrasena { get; set; }
        public string estado { get; set; }
        public Nullable<int> tipoDoc { get; set; }
        public string codDoc { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string telMovil { get; set; }
        public string sexo { get; set; }
        public Nullable<System.DateTime> fechaNac { get; set; }
        public Nullable<int> puntos { get; set; }
        public int codPerfil { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comentarios> Comentarios { get; set; }
        public virtual Perfiles Perfiles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegaloxCliente> RegaloxCliente { get; set; }
    }
}