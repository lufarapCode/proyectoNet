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
    
    public partial class detalle_alquiler
    {
        public int id_detalle_alquiler { get; set; }
        public Nullable<int> id_vehiculo { get; set; }
        public Nullable<int> cantidad { get; set; }
        public byte[] observacion { get; set; }
        public Nullable<int> estado { get; set; }
        public Nullable<int> id_cabAlquiler { get; set; }
    
        public virtual cabecera_alquiler cabecera_alquiler { get; set; }
        public virtual vehiculo vehiculo { get; set; }
    }
}
