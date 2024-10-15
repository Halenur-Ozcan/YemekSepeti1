using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<TEntity>
        where TEntity : class, new()
    {
        void Add(TEntity entity);
        void Delete(TEntity entity);
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null);
        void Update(TEntity entity);
    }
}

