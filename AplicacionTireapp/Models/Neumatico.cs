//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AplicacionTireapp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Neumatico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Neumatico()
        {
            this.Camion_neumaticos = new HashSet<Camion_neumaticos>();
            this.Lectura = new HashSet<Lectura>();
        }
    
        public int NeumaticoID { get; set; }
        public Nullable<int> tipo_neumatico_id { get; set; }
        public Nullable<int> empresa_id { get; set; }
        public string tag { get; set; }
        public string dol { get; set; }
        public string observacion { get; set; }
        public Nullable<int> cant_reencauche { get; set; }
        public string estado { get; set; }
        public string usureg { get; set; }
        public Nullable<System.DateTime> fecreg { get; set; }
        public string usumod { get; set; }
        public Nullable<System.DateTime> fecmod { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Camion_neumaticos> Camion_neumaticos { get; set; }
        public virtual Empresa Empresa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lectura> Lectura { get; set; }
        public virtual Tipo_neumatico Tipo_neumatico { get; set; }
    }
}
