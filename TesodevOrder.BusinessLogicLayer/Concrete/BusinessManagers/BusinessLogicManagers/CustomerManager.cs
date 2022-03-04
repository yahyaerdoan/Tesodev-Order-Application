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
    public class CustomerManager : GenericBusinessLogicManager<Customer, DtoCustomer>,ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerManager(IServiceProvider service, ICustomerRepository customerRepository) : base(service)
        {
            _customerRepository = customerRepository;
        }
    }
}
