﻿using Northwind.Entities.Concrete;
using Northwind.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Northwind.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : IProductDal
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }



        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }



        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            List<Product> product = new List<Product>{
            new Product
            {
                ProductId =1,CategoryId=1, ProductName="Laptop",QuantityPerUnit="1 in a box",UnitPrice=3000,UnitsInStock = 11
            }
            };
            return product;
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
