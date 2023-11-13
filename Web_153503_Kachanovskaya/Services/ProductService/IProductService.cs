using Web_153503_Kachanovskaya.Domain.Entities;
using Web_153503_Kachanovskaya.Domain.Models;

namespace Web_153503_Kachanovskaya.Services.ProductService
{
    public interface IProductService
    {
        //Получение списка всех объектов
        public Task<ResponseData<ListModel<Product>>> GetProductListAsync(string? categoryNormalizedName, int pageNum = 1);
        /// <summary>
        /// Поиск объекта по ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Найденный объект или null, если объект не найден</returns>
        public Task<ResponseData<Product>> GetProductByIdAsync (int id);

        //Обновление объекта
        public Task UpdateProductAsync(int id, Product product, IFormFile? formFile);

        //Удаление объекта
        public Task DeleteProductAsync(int id);

        /// <summary>
        /// Создание объекта
        /// </summary>
        /// <param name="product"></param>
        /// <param name="formFile"></param>
        /// <returns>Созданный объект</returns>
        public Task<ResponseData<Product>> CreateProductAsync(Product product, IFormFile?
            formFile);
    }
}
