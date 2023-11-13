using Web_153503_Kachanovskaya.Domain.Entities;
using Web_153503_Kachanovskaya.Domain.Models;

namespace Web_153503_Kachanovskaya.Services.CategoryService
{
    public class MemoryCategoryService : ICategoryService
    {
        public Task<ResponseData<List<Category>>> GetCategoryListAsync()
        {
            var categories = new List<Category>()
            {
                new Category() { Id = 1, Name = "Букеты", NormalizedName = "bouquet"},
                new Category() { Id = 2, Name = "Комнатные растения", NormalizedName = "houseplants"}
            };

            var result = new ResponseData<List<Category>>();
            result.Data = categories;
            return Task.FromResult(result);
        }      
    }
}
