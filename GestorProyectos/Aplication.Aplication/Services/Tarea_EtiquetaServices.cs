using Dominio.Model.Abstractions;
using Dominio.Model.Entities;
using Infra.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Aplication.Services
{
    public class Tarea_EtiquetaServices
    {
        readonly ITarea_EtiquetaRepsitory tarea_etiquetas;

        public Tarea_EtiquetaServices()
        {
            tarea_etiquetas = new Tarea_EtiquetaRepsitory();
        }

        public IEnumerable<Tarea_Etiqueta> ListarTarea_Etiqueta()
        {
            return tarea_etiquetas.GetAll();
        }

        public void InsertarTarea_Etiqueta(Tarea_Etiqueta nueva_tarea)
        {
            tarea_etiquetas.Add(nueva_tarea);
        }

        public void ModificarTarea_Etiqueta(Tarea_Etiqueta nuevo_tarea)
        {
            tarea_etiquetas.Modify(nuevo_tarea);
        }

        public void EliminarTarea_Etiqueta(int id)
        {
            tarea_etiquetas.Delete(id);
        }
    }
}
