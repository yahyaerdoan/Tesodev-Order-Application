using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesodevOrder.CoreLayer.Concrete.Entities;
using TesodevOrder.InterfaceLayer.Abstract.IGenericService;

namespace TesodevOrder.WebApiLayer.Controllers.GenericController.cs
{
    [Route("api/[controller]s")]
    [ApiController]
    public class GenericController<TInterface, T, TDto> : ControllerBase where TInterface : IGenericService<T, TDto> where T : Entity where TDto : Dto
    {
        private readonly TInterface _service;
        public GenericController(TInterface service)
        {
            _service = service;
        }
    }
}
