//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dominio.Model.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Asignacion
    {
        public int idAsignacion { get; set; }
        public int idDesarrollador { get; set; }
        public int idTarea { get; set; }
        public System.DateTime fechaAsignacion { get; set; }
        public string estadoAsignacion { get; set; }
    
        public virtual Desarrollador Desarrollador { get; set; }
        public virtual Tarea Tarea { get; set; }
    }
}