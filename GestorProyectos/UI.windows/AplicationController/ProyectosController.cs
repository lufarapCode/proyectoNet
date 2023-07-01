using Aplication.Aplication.Services;
using Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.windows.ViewModel;

namespace UI.windows.AplicationController
{
    public class ProyectosController
    {
        // El controlador (EmpleadoController) lo que hace es transformar la entidad y convertir en
        // la entidad view model y a su vez  va insertar o consumir el servicio.

        private ProyectoServices servicesProyecto;

        public ProyectosController()
        {
            servicesProyecto = new ProyectoServices();
        }

        public bool InsertarEmpleado(ProyectoVistaModelo nuevoProyectoViewModel)
        {
            Proyecto nuevoProyecto = new Proyecto();
            try
            {
                nuevoProyecto.nombreProyecto = nuevoProyectoViewModel.NombreProyecto;
                nuevoProyecto.descripcionProyecto = nuevoProyectoViewModel.DescripcionProyecto;
                nuevoProyecto.fechaInicioProyecto = nuevoProyectoViewModel.FechaInicioProyecto;
                nuevoProyecto.FechaFinProyecto = nuevoProyectoViewModel.FechaFinProyecto;
                nuevoProyecto.estadoProyecto = nuevoProyectoViewModel.EstadoProyecto;
                //nuevoEmpleado.id_empleado = nuevoEmpleadoViewModel.Id_empleado;
                servicesProyecto.insertarProyectos(nuevoProyecto);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ingresar proyecto" + ex.Message);
            }
        }

        public bool ActualizarProyecto(ProyectoVistaModelo nuevoProyectoViewModel)
        {
            Proyecto nuevoProyecto = new Proyecto();
            try
            {
                nuevoProyecto.nombreProyecto = nuevoProyectoViewModel.NombreProyecto;
                nuevoProyecto.descripcionProyecto = nuevoProyectoViewModel.DescripcionProyecto;
                nuevoProyecto.fechaInicioProyecto = nuevoProyectoViewModel.FechaInicioProyecto;
                nuevoProyecto.FechaFinProyecto = nuevoProyectoViewModel.FechaFinProyecto;
                nuevoProyecto.estadoProyecto = nuevoProyectoViewModel.EstadoProyecto;
                nuevoProyecto.idProyecto = nuevoProyectoViewModel.IdProyecto;
                servicesProyecto.actualizarProyectos(nuevoProyecto);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar empleado" + ex.Message);
            }
        }

        public IEnumerable<ProyectoVistaModelo> GetProyecto()
        {

            var ProyectoList = servicesProyecto.GetProyecto();
            List<ProyectoVistaModelo> resultadoViewModel = new List<ProyectoVistaModelo>();

            try
            {
                foreach (Proyecto item in ProyectoList)
                {
                    resultadoViewModel.Add(new ProyectoVistaModelo
                    {
                        IdProyecto = item.idProyecto,
                        NombreProyecto = item.nombreProyecto,
                        DescripcionProyecto = item.descripcionProyecto,
                        FechaInicioProyecto = item.fechaInicioProyecto,
                        FechaFinProyecto = item.FechaFinProyecto,
                        EstadoProyecto = item.estadoProyecto

                    });

                }
                return resultadoViewModel;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar proyecto" + ex.Message);

            }

        }
    }
}
