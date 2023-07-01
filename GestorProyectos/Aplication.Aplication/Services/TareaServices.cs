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
    public class TareaServices
    {
        readonly ITareaRepository tareas;

        public TareaServices()
        {
            tareas = new TareaRepository();
        }

        public IEnumerable<Tarea> ListarTarea()
        {
            return tareas.GetAll();
        }

        public void InsertarTarea(Tarea nueva_tarea)
        {
            tareas.Add(nueva_tarea);
        }

        public void ModificarTarea(Tarea nuevo_tarea)
        {
            tareas.Modify(nuevo_tarea);
        }

        public void EliminarTarea(int id)
        {
            tareas.Delete(id);
        }
    }
}
