﻿using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Abstract
{
    public interface IProductService
    {
        void Add(Product product);
        void Delete(Product product);
        List<Product> GetAll();
        List<Product> GetProductByName(string productName);
        List<Product> GetProductsByCategory(int categoryId);
        void Update(Product product);
    }
}
