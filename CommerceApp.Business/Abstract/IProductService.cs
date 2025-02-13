﻿using CommerceApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceApp.Business.Abstract
{
    public interface IProductService
    {
        Product GetById(int id);
        Product GetProductDetails(string url);
        List<Product> GetAll();
        List<Product> GetproductByCategory(string categoryName, int page,int pageSize);
        void Create(Product entity);
        void Delete(Product entity);
        void Update(Product entity);
        int getCountByCategory(string category);
        List<Product> GetHomePageProducts();
        List<Product> GetSearchResult(string searchString);
        Product GetByIdWithCategories(int productId);
        void Update(Product entity, int[] categoryIds);


    }
}
