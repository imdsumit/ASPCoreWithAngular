using ASPCoreWithAngular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreWithAngular.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductCatalogContext dBContext;

        public ProductRepository(ProductCatalogContext productCatalogContext)
        {
            this.dBContext = productCatalogContext;
        }

        public Product Get(Guid id)
        {
            return dBContext.Products.SingleOrDefault(product => product.Id == id);
        }

        public IEnumerable<Product> List()
        {
            return dBContext.Products.AsEnumerable();
        }

        public void Add(Product product)
        {
            dBContext.Products.Add(product);
            dBContext.SaveChanges();
        }

        public void Update(Product product)
        {
            dBContext.Products.Update(product);
            dBContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var product = this.Get(id);
            dBContext.Products.Remove(product);
            dBContext.SaveChanges();
        }
    }
}
