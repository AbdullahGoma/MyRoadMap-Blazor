using Assignment.Models;
using Microsoft.AspNetCore.Components;

namespace Assignment.Components
{
    public partial class ProductDetails
    {
        [Parameter]
        public int ID { set; get; }
        public Product Product { set; get; } = new Product();
        protected override void OnInitialized()
        {
            Product = productRepository.GetProductById(ID);
            base.OnInitialized();
        }
        protected override void OnParametersSet()
        {
            Product = productRepository.GetProductById(ID);
            base.OnParametersSet();
        }
        public List<Product> GetProducts() => productRepository.GetProducts();
    }
}
