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
    public class ClienteServices
    {
        readonly IClienteRepository clienteRepository;

        public ClienteServices()
        {
            clienteRepository = new ClienteRepository();
        }

        public IEnumerable<cliente> GetClientes()
        {
            return clienteRepository.GetAll();
        }


    }



}
