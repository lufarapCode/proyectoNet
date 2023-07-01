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
    public class EmpleadoServices
    {
        // solo editar, averiguar readnly, nombre de la carpeta Abstractions
        readonly IEmpleado empleadoRepository;

        // constructor: crear los objetos en momoeria, accede a los repositorios
        public EmpleadoServices()
        {
            // nombre de la carpeta repository
            empleadoRepository = new EmpleadoRepository();
        }
        // cabera_alquiler nombre de la entitie
        public IEnumerable<empleado> GetEmpleado()
        {
            return empleadoRepository.GetAll();
        }

        public IEnumerable<empleado> ListarEmpleado()
        {
            return empleadoRepository.GetAll();
        }

        public void InsertarEmpleado(empleado nuevoEmpleado)
        {
            empleadoRepository.Add(nuevoEmpleado);
        }

        public void ActualizarEmpleado(empleado nuevoEmpleado)
        {
            empleadoRepository.Modify(nuevoEmpleado);
        }

        public void EliminarEmpleado(int id)
        {
            empleadoRepository.Delete(id);
        }


        public IEnumerable<empleado> ListarEmpleadoActivo()
        {
            return empleadoRepository.ListarEmpleadosActivos();
        }


    }

   
}
