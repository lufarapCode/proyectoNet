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
    internal class EtiquetaServices
    {
        readonly IEtiquetaRepository etiquetas;
        EtiquetaServices()
        {
            etiquetas = new EtiquetaRepository();
        }
        public IEnumerable<Etiqueta> GetEtiqueta()
        {
            return etiquetas.GetAll();
        }

        public void insertarEtiquetas(Etiqueta nuevo_Etiqueta)
        {
            etiquetas.Add(nuevo_Etiqueta);
        }

        public void actualizarEtiquetas(Etiqueta nuevo_Etiqueta)
        {
            etiquetas.Modify(nuevo_Etiqueta);
        }

        public void eliminarEtiquetas(int id)
        {
            etiquetas.Delete(id);
        }
    }
}
