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
    
    public partial class Usuario_Perfil
    {
        public int usuarioper_ID { get; set; }
        public Nullable<int> Usuario_ID { get; set; }
        public Nullable<int> Perfil_ID { get; set; }
        public Nullable<int> Empresa_ID { get; set; }
        public string Estado { get; set; }
        public string usureg { get; set; }
        public System.DateTime fecreg { get; set; }
        public string usumod { get; set; }
        public Nullable<System.DateTime> fecmod { get; set; }
    
        public virtual Empresa Empresa { get; set; }
        public virtual Perfil Perfil { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
