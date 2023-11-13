using Web_153503_Kachanovskaya.Domain.Entities;
using Web_153503_Kachanovskaya.Domain.Models;
using Web_153503_Kachanovskaya.Services.CategoryService;

namespace Web_153503_Kachanovskaya.Services.ProductService
{
    public class MemoryProductService : IProductService
    {
        List<Product> _products;
        List<Category> _categories;

        public MemoryProductService(ICategoryService categoryService)
        {
            _categories = categoryService.GetCategoryListAsync().Result.Data;
            SetupData();
        }

        private void SetupData()
        {
            _products = new List<Product>
            {
                new Product { Id = 1, Name = "Букет алых роз", Description = "Алые розы, 9 штук", 
                    Price = 105, CategoryId = _categories.Find(c => c.NormalizedName.Equals("bouquet")).Id,
                    ImgPath = "Images/roses.jpg" 
                },

                new Product { Id = 2, Name = "Букет из экзотической протеи", Description = "Протея в количестве 3 (трех) штук",
                    Price = 90, CategoryId = _categories.Find(c => c.NormalizedName.Equals("bouquet")).Id,
                    ImgPath = "Images/proteya.jpg"
                }
            };
        }
        public Task<ResponseData<Product>> CreateProductAsync(Product product, IFormFile? formFile)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseData<Product>> GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseData<ListModel<Product>>> GetProductListAsync(string? categoryNormalizedName, int pageNum = 1)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductAsync(int id, Product product, IFormFile? formFile)
        {
            throw new NotImplementedException();
        }
    }
}
