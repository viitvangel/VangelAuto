using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VangelAuto.Data.Models;

namespace VangelAuto.Data.Repositories
{
    public class GenericInMemoryRepository<T> : IRepository<T>
         where T : IDbEntity
    {
        private readonly ICollection<T> list;

        public GenericInMemoryRepository()
        {
            list = new List<T>();
        }

        public void Add(T entity)
        {
            var entityFromDb = list.FirstOrDefault(e => e.Id == entity.Id);

            if (entityFromDb is not null)
            {
                return;
            }

            list.Add(entity);
        }

        public IEnumerable<T> All()
        {
            return list;
        }

        public void Delete(T entity)
        {
            list.Remove(entity);
        }

        public void Update(T entity)
        {
            var entityFromDb = list.FirstOrDefault(e => e.Id == entity.Id);
            list.Remove(entityFromDb);
            list.Add(entity);
        }
    }
}
