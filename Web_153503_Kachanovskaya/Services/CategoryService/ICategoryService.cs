using Web_153503_Kachanovskaya.Domain.Models;
using Web_153503_Kachanovskaya.Domain.Entities;

namespace Web_153503_Kachanovskaya.Services.CategoryService
{
    public interface ICategoryService
    {
        public Task<ResponseData<List<Category>>> GetCategoryListAsync();
    }
}
