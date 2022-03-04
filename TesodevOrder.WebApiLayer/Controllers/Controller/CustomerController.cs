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
    public class CustomerController : GenericController<ICustomerService, Customer, DtoCustomer>
    {
        public CustomerController(ICustomerService service) : base(service)
        {
        }
    }
}
