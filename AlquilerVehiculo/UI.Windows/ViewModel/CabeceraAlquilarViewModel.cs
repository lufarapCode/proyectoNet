using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows.ViewModel
{
    public class CabeceraAlquilarViewModel
    {
        public int id_CabAlquiler { get; set; }
        public Nullable<int> Id_empleado { get; set; }
        public Nullable<int> Id_cliente { get; set; }
        public Nullable<System.DateTime> Fecha_registro { get; set; }
        public Nullable<System.DateTime> Fecha_inicio { get; set; }
        public Nullable<System.DateTime> Fecha_entrega { get; set; }
        public string Observacion { get; set; }
        public Nullable<int> Estado { get; set; }
    }
}
