﻿using Northwind.Business.Abstract;
using Northwind.Entities.Concrete;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
using Northwind.Business.ValidationRules.FluentValidation;
using FluentValidation;

namespace Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            ProductValidator productValidator = new ProductValidator();
            var result = productValidator.Validate(product);
            if (result.Errors.Count>0)
            {
                throw new ValidationException(result.Errors);
            }
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
            }
            catch 
            {

                throw new Exception("Silme Gerçekleşemedi");
            }

        }

        public List<Product> GetAll()
        {

            return _productDal.GetAll();
        }

        public List<Product> GetProductByName(string productName)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryId);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
