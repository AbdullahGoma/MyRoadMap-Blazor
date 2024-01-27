using Assignment.Data;
using Assignment.Models;

namespace Assignment.Repository
{
    public class ProductRepository
    {
        ProductData productData;
        public ProductRepository()
        {
            productData = new ProductData();
        }
        public List<Product> GetProducts()
        {
            return productData.GetProducts();   
        }

        public Product GetProductById(int id)
        {
            return productData.GetProducts().FirstOrDefault(x => x.ID == id);
        }

    }
}
