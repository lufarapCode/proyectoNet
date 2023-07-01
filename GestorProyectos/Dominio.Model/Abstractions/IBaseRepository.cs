using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Model.Abstractions
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        // insertar
        void Add(TEntity entity);

        // eliminar
        void Delete(int id);

        //void Delete(TEntity entity) en teoria funciona ;

        // actualizar
        void Modify(TEntity entity);

        // select * from
        IEnumerable<TEntity> GetAll();

        // Buscar por id
        TEntity Get(int id);
    }
}
