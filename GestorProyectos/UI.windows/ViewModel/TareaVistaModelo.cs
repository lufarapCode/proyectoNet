using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.windows.ViewModel
{
    public class TareaVistaModelo
    {
        public int IdTarea { get; set; }
        public string TituloTarea { get; set; }
        public string DescripcionTarea { get; set; }
        public System.DateTime FechaVencimientoTarea { get; set; }
        public string PrioridadTarea { get; set; }
        public string EstadoTarea { get; set; }
        public int IdProyecto { get; set; }
    }
}
