using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using AutoMapper;
using Maya.Project.Trades.Bases.Dtos;
using Maya.Project.Trades.Bases.Interfaces;

namespace Maya.Project.Trades.Bases.Services
{
    public class IntervalAppService:ApplicationService,IIntervalAppService
    {
        private readonly IRepository<Interval> _intervalRepository;
        private readonly IMapper _mapper;
        public IntervalAppService(IRepository<Interval> intervalRepository)
        {
            _intervalRepository = intervalRepository;
        }
        public List<IntervalDto> GetIntervals()
        {
            var lists = _intervalRepository.GetAllList();
            var result = ObjectMapper.Map<List<IntervalDto>>(lists);
            return  result;
        }
    }
}
