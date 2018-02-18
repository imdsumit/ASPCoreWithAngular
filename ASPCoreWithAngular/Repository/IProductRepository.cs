using System;
using System.Collections.Generic;
using ASPCoreWithAngular.Models;

namespace ASPCoreWithAngular.Repository
{
    public interface IProductRepository
    {
        void Add(Product product);
        void Delete(Guid id);
        Product Get(Guid id);
        IEnumerable<Product> List();
        void Update(Product product);
    }
}