using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows.ViewModel
{
    public class VehiculoViewModel
    {
        public int Id_vehiculo { get; set; }
        public string Placa { get; set; }
        public string Chasis { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public Nullable<int> Anio { get; set; }
        public Nullable<int> Estado { get; set; }
    }
}
