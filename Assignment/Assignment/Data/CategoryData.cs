using Assignment.Models;

namespace Assignment.Data
{
    public class CategoryData
    {
        List<Category> Categories { get; set; } = new List<Category>();
        public CategoryData()
        {
            Categories.Add(new Category { ID = 1, Name = "Category1" });
            Categories.Add(new Category { ID = 2, Name = "Category2" });
            Categories.Add(new Category { ID = 3, Name = "Category3" });
        }
        public List<Category> GetCategories()
        {
            return Categories;
        }
    }
}
