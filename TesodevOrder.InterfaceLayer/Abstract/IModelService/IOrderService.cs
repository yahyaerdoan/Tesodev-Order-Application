using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesodevOrder.EntityLayer.Concrete.DtoModels;
using TesodevOrder.EntityLayer.Concrete.Models;
using TesodevOrder.InterfaceLayer.Abstract.IGenericService;

namespace TesodevOrder.InterfaceLayer.Abstract.IModelService
{
    public interface IOrderService : IGenericService<Order, DtoOrder>
    {
    }
}
