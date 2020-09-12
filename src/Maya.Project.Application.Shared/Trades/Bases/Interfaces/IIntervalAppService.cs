using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Maya.Project.Trades.Bases.Dtos;

namespace Maya.Project.Trades.Bases.Interfaces
{
    public interface IIntervalAppService:IApplicationService
    {
        List<IntervalDto> GetIntervals();
    }
}
