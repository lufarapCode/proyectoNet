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
    public class AsignacionServices
    {
        readonly IAsignacionRepository asignaciones;
        AsignacionServices()
        {
            asignaciones = new AsignacionRepository();
        }
        public IEnumerable<Asignacion> GetAsignacion()
        {
            return asignaciones.GetAll();
        }

        public void insertarAsignaciones(Asignacion nuevo_Asignacion)
        {
            asignaciones.Add(nuevo_Asignacion);
        }

        public void actualizarAsignaciones(Asignacion nuevo_Asignacion)
        {
            asignaciones.Modify(nuevo_Asignacion);
        }

        public void eliminarAsignaciones(int id)
        {
            asignaciones.Delete(id);
        }
    }
}
