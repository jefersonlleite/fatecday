using Fatec.eComm.Domain.Models.ProductModel;

namespace Fatec.eComm.Domain.Models.CategoryModel

{
    public class Category
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public List<Product> Products { get; set; }
    }
}
