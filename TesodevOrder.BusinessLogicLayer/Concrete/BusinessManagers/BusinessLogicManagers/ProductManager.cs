using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesodevOrder.BusinesLogicLayer.Concrete.BusinessManagers.GenericBusinessLogics;
using TesodevOrder.DataAccessLayer.Abstract.IRepository;
using TesodevOrder.EntityLayer.Concrete.DtoModels;
using TesodevOrder.EntityLayer.Concrete.Models;
using TesodevOrder.InterfaceLayer.Abstract.IModelService;

namespace TesodevOrder.BusinessLogicLayer.Concrete.BusinessManagers.BusinessLogicManagers
{
    public class ProductManager : GenericBusinessLogicManager<Product, DtoProduct>, IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductManager(IServiceProvider service, IProductRepository productRepository) : base(service)
        {
            _productRepository = productRepository;
        }
    }
}
