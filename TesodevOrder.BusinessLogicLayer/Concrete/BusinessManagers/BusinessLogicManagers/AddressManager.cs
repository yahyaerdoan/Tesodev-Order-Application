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
    public class AddressManager : GenericBusinessLogicManager<Address, DtoAddress>, IAddressService
    {
        private readonly IAddressService _addressService;
        public AddressManager(IServiceProvider service, IAddressService addressService) : base(service)
        {
            _addressService = addressService;
        }
    }
}
