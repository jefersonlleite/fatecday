using Fatec.eComm.Domain.Models.CategoryModel;
using Fatec.eComm.Infrastructure.Data;
using Fatec.eComm.Infrastructure.Repository;

namespace Fatec.eComm.Infrastructure.Repositories
{
    public class CategoryRepository : RepositoryBase<Category, Guid>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDataContext applicationDataContext) : base(applicationDataContext)
        {
        }


    }
}
