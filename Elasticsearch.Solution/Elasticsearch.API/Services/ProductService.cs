using Elasticsearch.API.Models;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elasticsearch.API.Services
{
    public class ProductService : IProductService
    {
        private IElasticClient _elasticClient;

        public ProductService(IElasticClient es) {
            _elasticClient = es;
        }

        public async Task<List<Product>> GetProducts()
        {
            var result = await _elasticClient.SearchAsync<Product>();

            return result.Documents.ToList();
        }

        public async Task SaveProduct(Product product)
        {
            var result = await _elasticClient.IndexDocumentAsync(product);
            
        }
    }
}
