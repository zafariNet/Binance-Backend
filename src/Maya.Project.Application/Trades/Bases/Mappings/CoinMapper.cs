using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Maya.Project.Trades.Bases.Dtos;

namespace Maya.Project.Trades.Bases.Mappings
{
    public class CoinMapper
    {
        public static void CreateMap(IMapperConfigurationExpression mapper)
        {
            mapper.CreateMap<Coin, CoinDto>().ReverseMap();
        }
    }
}
