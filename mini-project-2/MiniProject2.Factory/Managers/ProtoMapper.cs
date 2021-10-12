using System;
using AutoMapper;

namespace MiniProject2.Factory.Managers
{
    public class ProtoMapper<T, E>
    {
        public static E Map(T source)
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<T, E>();
            });
            IMapper iMapper = config.CreateMapper();
            return iMapper.Map<T, E>(source);
        }
    }
}