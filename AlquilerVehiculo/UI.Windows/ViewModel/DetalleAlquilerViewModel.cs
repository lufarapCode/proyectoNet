using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows.ViewModel
{
    class DetalleAlquilerViewModel
    {
        public int Id_detalle_alquiler { get; set; }
        public Nullable<int> Id_vehiculo { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public byte[] Observacion { get; set; }
        public Nullable<int> Estado { get; set; }
        public Nullable<int> Id_cabAlquiler { get; set; }
    }
}
