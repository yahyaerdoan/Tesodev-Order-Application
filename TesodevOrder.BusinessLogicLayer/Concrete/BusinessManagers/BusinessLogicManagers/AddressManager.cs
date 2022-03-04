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
    public class AddressManager : GenericBusinessLogicManager<Address, DtoAddress>, IAddressService
    {
        private readonly IAddressRepository _addressRepository;
        public AddressManager(IServiceProvider service, IAddressRepository addressRepository) : base(service)
        {
            _addressRepository = addressRepository;
        }
    }
}
