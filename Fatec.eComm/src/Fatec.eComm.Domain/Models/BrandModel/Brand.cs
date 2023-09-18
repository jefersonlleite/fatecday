using Fatec.eComm.Domain.Models.ProductModel;

namespace Fatec.eComm.Domain.Models.BrandModel
{
    public class Brand
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public List<Product> Products{ get; set; }
    }
}
