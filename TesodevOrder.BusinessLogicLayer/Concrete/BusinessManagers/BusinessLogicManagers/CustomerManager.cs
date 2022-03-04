using System;
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
    public class CustomerManager : GenericBusinessLogicManager<Customer, DtoCustomer>,ICustomerService
    {
        private readonly ICustomerService _customerService;
        public CustomerManager(IServiceProvider service, ICustomerService customerService) : base(service)
        {
            _customerService = customerService;
        }
    }
}
