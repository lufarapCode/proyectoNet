using Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Model.Abstractions
{
    public interface IClienteRepository : IBaseRepository<cliente>
    {
        // en caso que se requira la busqueda por CI
        // metodo propio de Cliente
        cliente BuscarClineteCI(string numeroCI);
    }
}
