//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SRP_proyecto.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_vehiculo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_vehiculo()
        {
            this.tb_parqueo = new HashSet<tb_parqueo>();
        }
    
        public int IdVehiculo { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public Nullable<int> Modelo { get; set; }
        public string Placa { get; set; }
        public Nullable<int> IdCliente { get; set; }
    
        public virtual tb_cliente tb_cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_parqueo> tb_parqueo { get; set; }
    }
}