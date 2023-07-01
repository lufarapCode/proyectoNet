using Dominio.Model.Abstractions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess.Repository
{
    public class BaseRepository<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : class
    {
        public void Add(TEntity entity)
        {
            try
            {
                // creo variable local
                using (var context = new gestorProyectosEntities())
                {
                    context.Set<TEntity>().Add(entity); // Add hace el insert en la base
                    context.SaveChanges(); // guarda en la base
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al ingresar registros:" + ex.Message, ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                // creo variable local
                using (var context = new gestorProyectosEntities())
                {
                    // buscasr si hay el dato para elminarolo
                    var entity = context.Set<TEntity>().Find(id);

                    context.Set<TEntity>().Remove(entity);
                    context.SaveChanges(); // guarda las modificaciones
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al borrar registros:" + ex.Message, ex);
            }
        }
                
        public TEntity Get(int id)
        {
            try
            {
                // creo variable local
                using (var context = new gestorProyectosEntities())
                {
                    // buscasr si hay el dato para elminarolo
                    return context.Set<TEntity>().Find(id);
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al listar registros:" + ex.Message, ex);
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            try
            {
                // creo variable local
                using (var context = new gestorProyectosEntities())
                {
                    // listar todos los datos
                    return context.Set<TEntity>().ToList();

                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al ingresar registros:" + ex.Message, ex);
            }
        }

        public void Modify(TEntity entity)
        {
            try
            {
                // creo variable local
                using (var context = new gestorProyectosEntities())
                {
                    // la tabla que venga es para modificacion
                    context.Entry(entity).State = EntityState.Modified;
                    context.SaveChanges(); // guarda las modificaciones
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al modificar registros:" + ex.Message, ex);
            }
        }

        public interface IDisponsable
        {
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
