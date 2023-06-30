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
    public class CabeceraAlquilerServices
    {
        // solo editar, averiguar readnly, nombre de la carpeta Abstractions
        readonly ICabeceraAlquiler cabeceraAlquiler;

        // constructor: crear los objetos en momoeria, accede a los repositorios
        public CabeceraAlquilerServices()
        {   
            // nombre de la carpeta repository
            cabeceraAlquiler = new CabeceraAlquiler();
        }
        // cabera_alquiler nombre de la entitie
        public IEnumerable<cabecera_alquiler> GetCabeceraAlquiler()
        {
            return cabeceraAlquiler.GetAll();
        }

        

        public void InsertarCabeceraAlquiler(cabecera_alquiler nuevocabecera_Alquiler)
        {
            cabeceraAlquiler.Modify(nuevocabecera_Alquiler);
        }

        public void ActualizarCabeceraAlquiler(cabecera_alquiler nuevocabecera_Alquiler)
        {
            cabeceraAlquiler.Add(nuevocabecera_Alquiler);
        }

        public void EliminarCabeceraAlquiler(int id)
        {
            cabeceraAlquiler.Delete(id);
        }

    }
}
