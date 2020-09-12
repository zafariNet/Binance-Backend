using AutoMapper;
using Maya.Project.Trades.Bases.Dtos;

namespace Maya.Project.Trades.Bases.Mappings
{
    public class IntervalMapper
    {
    

        public static void CreateMap(IMapperConfigurationExpression mapper)
        {
            mapper.CreateMap<Interval, IntervalDto>().ReverseMap();
        }
    }
}
