using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.windows.ViewModel
{
   public class AsignacionVistoModelo
    {
        public int IdAsignacion { get; set; }
        public int IdDesarrollador { get; set; }
        public int IdTarea { get; set; }
        public System.DateTime FechaAsignacion { get; set; }
        public string EstadoAsignacion { get; set; }
    }
}
