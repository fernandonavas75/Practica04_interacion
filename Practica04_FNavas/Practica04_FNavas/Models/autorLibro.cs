//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practica04_FNavas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class autorLibro
    {
        public int idLibro { get; set; }
        public int idAutor { get; set; }
        public System.DateTime FechaPublicacion { get; set; }
        public Nullable<int> idEditorial { get; set; }
    
        public virtual autor autor { get; set; }
        public virtual editorial editorial { get; set; }
        public virtual libro libro { get; set; }
    }
}
