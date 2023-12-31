﻿using Business.Abstracts;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;

        }
        public async Task<Paginate<Product>> GetListAsync()
        {
            var result = await _productDal.GetListAsync();
            return result;
        }

        public async Task Add(Product product)
        {
            await _productDal.AddAsync(product);

        }
    }
}
