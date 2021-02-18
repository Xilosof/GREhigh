using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace GREhigh.Infrastructure.Interfaces {

    public interface IRepository { }
    public interface IRepository<TEntity> : IRepository {
        public IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");
        public TEntity GetByID(object id);
        public void Insert(TEntity entity);
        public void Insert(IEnumerable<TEntity> entityList);
        public void Delete(object id);
        public void Delete(TEntity entityToDelete);
        public void Update(TEntity entityToUpdate);
    }
}
