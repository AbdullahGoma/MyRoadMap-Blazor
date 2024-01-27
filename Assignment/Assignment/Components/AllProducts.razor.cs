using Assignment.Models;

namespace Assignment.Components
{
    public partial class AllProducts
    {
        public List<Product> Products { set; get; } = new List<Product>();
        protected override void OnInitialized()
        {
            Products = productRepository.GetProducts();
            base.OnInitialized();
        }
    }
}
