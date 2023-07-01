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
    public class DesarrolladorServices
    {
        readonly IDesarrolladorRepository desarrolladores;
        DesarrolladorServices()
        {
            desarrolladores = new DesarrolladorRepository();
        }
        public IEnumerable<Desarrollador> GetDesarrollador()
        {
            return desarrolladores.GetAll();
        }

        public void insertarDesarrolladores(Desarrollador nuevo_Desarrollador)
        {
            desarrolladores.Add(nuevo_Desarrollador);
        }

        public void actualizarDesarrolladores(Desarrollador nuevo_Desarrollador)
        {
            desarrolladores.Modify(nuevo_Desarrollador);
        }

        public void eliminarDesarrolladores(int id)
        {
            desarrolladores.Delete(id);
        }

    }
}
