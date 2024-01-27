using Assignment.Data;
using Assignment.Models;

namespace Assignment.Repository
{
    public class CategoryRepository
    {
        CategoryData CategoryData;
        public CategoryRepository()
        {
            CategoryData = new CategoryData();
        }
        public List<Category> GetCategories()
        {
            return CategoryData.GetCategories();
        }
        public Category GetCategory(int id)
        {
            return CategoryData.GetCategories().FirstOrDefault(x => x.ID == id);
        }
    }
}
