using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TesodevOrder.EntityLayer.Concrete.DtoModels;
using TesodevOrder.EntityLayer.Concrete.Models;

namespace TesodevOrder.EntityLayer.Concrete.DtoModelMappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Address, DtoAddress>().ReverseMap();
            CreateMap<Customer, DtoCustomer>().ReverseMap();
            CreateMap<Order, DtoOrder>().ReverseMap();
            CreateMap<Product, DtoProduct>().ReverseMap();
        }
    }
}
