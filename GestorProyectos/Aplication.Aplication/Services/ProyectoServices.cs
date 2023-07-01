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
    public class ProyectoServices
    {
        readonly IProyectoRepository proyectos;

        public ProyectoServices()
        {
            proyectos = new ProyectoRepository();
        }
        public IEnumerable<Proyecto> GetProyecto()
        {
            return proyectos.GetAll();
        }

        public void insertarProyectos(Proyecto nuevo_proyecto)
        {
            proyectos.Add(nuevo_proyecto);
        }

        public void actualizarProyectos(Proyecto nuevo_proyecto)
        {
            proyectos.Modify(nuevo_proyecto);
        }

        public void eliminarProyectos(int id)
        {
            proyectos.Delete(id);
        }
    }
}
