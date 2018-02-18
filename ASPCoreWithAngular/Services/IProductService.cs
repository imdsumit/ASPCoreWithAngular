using System.Collections.Generic;
using ASPCoreWithAngular.Models;

namespace ASPCoreWithAngular.Services
{
    public interface IProductService
    {
        void AddProduct(Product product);
        IEnumerable<Product> ListProducts();
    }
}