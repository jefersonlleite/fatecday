using Fatec.eComm.Domain.Models.BrandModel;
using Fatec.eComm.Domain.Models.CategoryModel;
namespace Fatec.eComm.Domain.Models.ProductModel
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; } 
        public Guid BrandId { get; set; }
        public virtual Brand Brand { get; set; }
    }
}
