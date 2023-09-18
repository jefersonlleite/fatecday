using Fatec.eComm.Domain.Core.Data;
using Fatec.eComm.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Fatec.eComm.Infrastructure.Repository
{
    public class RepositoryBase<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : class
    {
        #region OLD - REPOSITORY BASE
        //TODO: REPOSITORY BASE - FIRST CLASS
        /*
        private readonly ApplicationDataContext _applicationDataContext;
        public RepositoryBase(ApplicationDataContext applicationDataContext) 
        {
            _applicationDataContext = applicationDataContext;
        }

        public void Add(CategoryViewModel category)
        {
            var cat = new Category
            {
                Id = Guid.NewGuid(),
                Description = category.Description,
                IsActive = category.IsActive,
            };
            _applicationDataContext.Categories.Add(cat);
        }
        */
        #endregion

        protected readonly ApplicationDataContext _applicationDataContext;
        protected readonly DbSet<TEntity> _entity;
        public virtual IUnitOfWork UnitOfWork => _applicationDataContext;

        public RepositoryBase(ApplicationDataContext applicationDataContext)
        {
            _applicationDataContext = applicationDataContext;
            _entity= _applicationDataContext.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _entity.Add(entity);
        }

        public async Task<IQueryable<TEntity>> GetAll()
        {
            return _entity;
        }

        public TEntity GetById(TKey id)
        {
            return _entity.Find(id);
        }

        public void Update(TEntity entity)
        {
            _entity.Update(entity);
        }

        public void Dispose()
        {
            _applicationDataContext.Dispose();
        }

        public async Task<int> SaveChangesAsync()
        {
            var result = await _applicationDataContext.SaveChangesAsync().ConfigureAwait(false);
            return result;
        }

      
    }
}
