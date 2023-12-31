﻿using Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Model.Abstractions
{
    public interface IEmpleado : IBaseRepository<empleado>
    {
        // select * from empleado where estado =1;
        IEnumerable<empleado> ListarEmpleadosActivos();

    }
}
