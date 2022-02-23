using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TesodevOrder.EntityLayer.Concrete.Mappers.DtoModelMappers;


namespace TesodevOrder.CoreLayer.Concrete.MapperConfiguration
{
    public class ObjectMapperConfiguration
    {
        private static readonly Lazy<IMapper> lazy = new Lazy<IMapper>(() =>
        {
            var configuration = new AutoMapper.MapperConfiguration(configuration =>
            {
                configuration.AddProfile<MappingProfile>();
            });
            return configuration.CreateMapper();
        });

        public static readonly IMapper Mapper = lazy.Value;
    }
}
