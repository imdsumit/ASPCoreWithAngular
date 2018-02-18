using ASPCoreWithAngular.Models;
using ASPCoreWithAngular.Repository;
using System.Collections.Generic;

namespace ASPCoreWithAngular.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public void AddProduct(Product product)
        {
            this.productRepository.Add(product);
        }

        public IEnumerable<Product> ListProducts()
        {
            var products = this.productRepository.List();
            return products;
        }
    }
}
