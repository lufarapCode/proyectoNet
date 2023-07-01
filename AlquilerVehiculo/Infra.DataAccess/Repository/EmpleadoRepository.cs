using Dominio.Model.Abstractions;
using Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess.Repository
{
    public class EmpleadoRepository : BaseRepository<empleado>, IEmpleado
    {
        public IEnumerable<empleado> ListarEmpleadosActivos()
        {
            try
            {   // conexion a la base de datos
                using (var context = new AlquilerVehiculosEntities())
                {

                    var resultEmpleados = from emp in context.empleado // origen de la informacion   BD.Tabla
                                 where emp.estado == 1 // filtro a los datos
                                 select emp; // seleccion
                    return resultEmpleados.ToList();
                }

            }
            catch(Exception ex)
            {
                throw new Exception("Error al listar empleados (Repository)" + ex.Message);

            }

        }
    }
}
