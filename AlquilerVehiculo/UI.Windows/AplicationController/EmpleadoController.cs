using Aplication.Aplication.Services;
using Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Windows.ViewModel;

namespace UI.Windows.AplicationController
{
    public class EmpleadoController
    {

        // El controlador (EmpleadoController) lo que hace es transformar la entidad y convertir en
        // la entidad view model y a su vez  va insertar o consumir el servicio.

        private EmpleadoServices servicesEmpleado;
        public EmpleadoController()
        {
            servicesEmpleado = new EmpleadoServices();
        }
        // a este 
        public bool InsertarEmpleado(EmpleadoViewModel nuevoEmpleadoViewModel)
        {
            empleado nuevoEmpleado = new empleado();
            try
            {
                nuevoEmpleado.nombre = nuevoEmpleadoViewModel.Nombre;
                nuevoEmpleado.apellido = nuevoEmpleadoViewModel.Apellido;
                nuevoEmpleado.direccion = nuevoEmpleadoViewModel.Direccion;
                nuevoEmpleado.telefono = nuevoEmpleadoViewModel.Telefono;
                nuevoEmpleado.estado = nuevoEmpleadoViewModel.Estado;
                //nuevoEmpleado.id_empleado = nuevoEmpleadoViewModel.Id_empleado;
                servicesEmpleado.InsertarEmpleado(nuevoEmpleado);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ingresar empleado" + ex.Message);
            }
        }

        public bool ActualizarEmpleado(EmpleadoViewModel nuevoEmpleadoViewModel)
        {
            empleado nuevoEmpleado = new empleado();
            try
            {
                nuevoEmpleado.id_empleado = nuevoEmpleadoViewModel.Id_empleado;
                nuevoEmpleado.nombre = nuevoEmpleadoViewModel.Nombre;
                nuevoEmpleado.apellido = nuevoEmpleadoViewModel.Apellido;
                nuevoEmpleado.direccion = nuevoEmpleadoViewModel.Direccion;
                nuevoEmpleado.telefono = nuevoEmpleadoViewModel.Telefono;
                nuevoEmpleado.estado = nuevoEmpleadoViewModel.Estado;
                servicesEmpleado.ActualizarEmpleado(nuevoEmpleado);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar empleado" + ex.Message);
            }
        }

        public IEnumerable<EmpleadoViewModel> GetEmpleado()
        {

            var empleadoList = servicesEmpleado.GetEmpleado();
            List<EmpleadoViewModel> resultadoViewModel = new List<EmpleadoViewModel>();

            try
            {
                foreach (empleado item in empleadoList)
                {
                    resultadoViewModel.Add(new EmpleadoViewModel
                    {
                        Id_empleado = item.id_empleado,
                        Nombre = item.nombre,
                        Apellido = item.apellido,
                        Direccion = item.direccion,
                        Telefono = item.telefono,
                        Estado = item.estado

                    });

                }
                return resultadoViewModel;

            }catch (Exception ex)
            {
                throw new Exception("Error al actualizar empleado" + ex.Message);

            }
            
        }


    }
}
