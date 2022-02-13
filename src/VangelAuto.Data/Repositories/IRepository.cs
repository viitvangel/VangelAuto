namespace VangelAuto.Data.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using VangelAuto.Data.Models;

    public interface IRepository<TEntity>
        where TEntity : IDbEntity
    { 
        IEnumerable<TEntity> All();

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}