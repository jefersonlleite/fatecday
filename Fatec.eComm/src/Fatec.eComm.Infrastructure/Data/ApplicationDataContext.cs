using Fatec.eComm.Domain.Core.Data;
using Fatec.eComm.Domain.Models.BrandModel;
using Fatec.eComm.Domain.Models.CategoryModel;
using Fatec.eComm.Domain.Models.ProductModel;
using Microsoft.EntityFrameworkCore;

namespace Fatec.eComm.Infrastructure.Data
{
    public class ApplicationDataContext : DbContext, IUnitOfWork
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get;set; }
        public DbSet<Brand> Brands { get; set; }

    }
}
