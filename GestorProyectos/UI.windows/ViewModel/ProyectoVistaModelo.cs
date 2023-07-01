using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.windows.ViewModel
{
    public class ProyectoVistaModelo
    {
        public int IdProyecto { get; set; }
        public string NombreProyecto { get; set; }
        public string DescripcionProyecto { get; set; }
        public System.DateTime FechaInicioProyecto { get; set; }
        public System.DateTime FechaFinProyecto { get; set; }
        public string EstadoProyecto { get; set; }
    }
}
