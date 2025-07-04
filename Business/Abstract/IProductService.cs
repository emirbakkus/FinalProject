﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetBuyUnitPrice(decimal min, decimal max);    
        IDataResult<List<ProductDetailDto>> GetProductDetails(); // Ürün detaylarını listeleme metodu
        IDataResult<Product> GetById(int ProductId);
        IResult Add(Product product);
        IResult Update(Product product);
        IResult AddTransactionalTest(Product product); //Transactional Test metodu

        //Restful servislerdeki gibi HTTP metodları ile isimlendirme yapıldı.

    }

}
