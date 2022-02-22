using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesodevOrder.CoreLayer.Concrete.Entities;

namespace TesodevOrder.EntityLayer.Concrete.DtoModels
{
    public class DtoAddress : Dto
    {
        public Guid Id { get; set; }
        public string AddressLine { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int CityCode { get; set; }
    }
}
