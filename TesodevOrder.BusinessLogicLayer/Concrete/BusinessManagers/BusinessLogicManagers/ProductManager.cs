﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesodevOrder.BusinesLogicLayer.Concrete.BusinessManagers.GenericBusinessLogics;
using TesodevOrder.EntityLayer.Concrete.DtoModels;
using TesodevOrder.EntityLayer.Concrete.Models;
using TesodevOrder.InterfaceLayer.Abstract.IModelService;

namespace TesodevOrder.BusinessLogicLayer.Concrete.BusinessManagers.BusinessLogicManagers
{
    public class ProductManager : GenericBusinessLogicManager<Product, DtoProduct>, IProductService
    {
        private readonly IProductService _productService;
        public ProductManager(IServiceProvider service, IProductService productService) : base(service)
        {
            _productService = productService;
        }
    }
}
