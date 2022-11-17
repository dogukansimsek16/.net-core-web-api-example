using MyApi.Models.Base;
using MyApi.Repository.Base;
using System.Linq.Expressions;

namespace MyApi.Service.Base
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : Vehicle
    {
         

        private GenericRepository<TEntity> repo;
        public BaseService()
        {
            repo = new();
        }
        public DataResult<TEntity> Delete(int id)
        {
            return repo.Delete(id);
        }

        public DataResult<TEntity> GetList(Expression<Func<TEntity, bool>> filter)
        {
            return repo.GetList(filter);
        }

        public DataResult<TEntity> GetSingle(Expression<Func<TEntity, bool>> filter)
        {
            return repo.GetSingle(filter);
        }

        public DataResult<TEntity> Update(TEntity entity)
        {
            return repo.Update(entity);
        }
    }
}
