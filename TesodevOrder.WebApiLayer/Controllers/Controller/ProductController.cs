using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesodevOrder.EntityLayer.Concrete.DtoModels;
using TesodevOrder.EntityLayer.Concrete.Models;
using TesodevOrder.InterfaceLayer.Abstract.IModelService;
using TesodevOrder.WebApiLayer.Controllers.GenericController.cs;

namespace TesodevOrder.WebApiLayer.Controllers.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : GenericController<IProductService, Product, DtoProduct>
    {
        private readonly IProductService _productService;
        public ProductController(IProductService service, IProductService productService) : base(service)
        {
            _productService = productService;
        }
    }
}
