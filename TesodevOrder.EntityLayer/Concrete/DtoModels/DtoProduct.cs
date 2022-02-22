using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesodevOrder.CoreLayer.Concrete.Entities;

namespace TesodevOrder.EntityLayer.Concrete.DtoModels
{
    public class DtoProduct : Dto
    {
        public Guid Id { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
    }
}
