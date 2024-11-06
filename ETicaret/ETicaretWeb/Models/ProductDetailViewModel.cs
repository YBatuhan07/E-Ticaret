using ETicaretCore.Entities;

namespace ETicaretWeb.Models
{
    public class ProductDetailViewModel
    {
        public Product? Product { get; set; }
        public IEnumerable<Product> RelatedProducts { get; set; }
    }
}
