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
    public class TareaController
    {
        private TareaServices servicesTarea;

        public TareaController()
        {
            servicesTarea = new TareaServices();
        }

        public bool InsertarTarea(TareaVistaModelo nuevoTareaViewModel)
        {
            Tarea nuevaTarea = new Tarea();
            try
            {
                nuevaTarea.tituloTarea = nuevoTareaViewModel.TituloTarea;
                nuevaTarea.descripcionTarea = nuevoTareaViewModel.DescripcionTarea;
                nuevaTarea.fechaVencimientoTarea = nuevoTareaViewModel.FechaVencimientoTarea;
                nuevaTarea.prioridadTarea = nuevoTareaViewModel.PrioridadTarea;
                nuevaTarea.estadoTarea = nuevoTareaViewModel.EstadoTarea;
                nuevaTarea.IdProyecto = nuevoTareaViewModel.IdProyecto;
                servicesTarea.InsertarTarea(nuevaTarea);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ingresar Tarea" + ex.Message);
            }
        }

        public bool ActualizarTarea(TareaVistaModelo nuevoTareaViewModel)
        {
            Tarea nuevaTarea = new Tarea();
            try
            {
                nuevaTarea.tituloTarea = nuevoTareaViewModel.TituloTarea;
                nuevaTarea.descripcionTarea = nuevoTareaViewModel.DescripcionTarea;
                nuevaTarea.fechaVencimientoTarea = nuevoTareaViewModel.FechaVencimientoTarea;
                nuevaTarea.prioridadTarea = nuevoTareaViewModel.PrioridadTarea;
                nuevaTarea.estadoTarea = nuevoTareaViewModel.EstadoTarea;
                nuevaTarea.IdProyecto = nuevoTareaViewModel.IdProyecto;
                nuevaTarea.idTarea = nuevoTareaViewModel.IdTarea;

                servicesTarea.InsertarTarea(nuevaTarea);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar Tarea" + ex.Message);
            }
        }

        public IEnumerable<TareaVistaModelo> GetTarea()
        {

            var TareaList = servicesTarea.ListarTarea();
            List<TareaVistaModelo> resultadoViewModel = new List<TareaVistaModelo>();

            try
            {
                foreach (Tarea item in TareaList)
                {
                    resultadoViewModel.Add(new TareaVistaModelo
                    {
                        IdTarea = item.idTarea,
                        TituloTarea = item.tituloTarea,
                        DescripcionTarea = item.descripcionTarea,
                        FechaVencimientoTarea = item.fechaVencimientoTarea,
                        PrioridadTarea = item.prioridadTarea,
                        EstadoTarea = item.estadoTarea,
                        IdProyecto = item.IdProyecto

                    });

                }
                return resultadoViewModel;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar Tarea" + ex.Message);

            }

        }
    }
}
