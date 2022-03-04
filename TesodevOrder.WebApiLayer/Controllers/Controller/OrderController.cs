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
    public class OrderController : GenericController<IOrderService, Order, DtoOrder>
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService service, IOrderService orderService) : base(service)
        {
            _orderService = orderService;
        }
    }
}
