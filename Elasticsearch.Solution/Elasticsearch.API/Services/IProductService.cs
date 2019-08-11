using Elasticsearch.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Elasticsearch.API.Services
{
    public interface IProductService
    {
        Task SaveProduct(Product product);
        Task<List<Product>> GetProducts();
    }
}