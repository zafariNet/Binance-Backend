using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Maya.Project.Trades.Bases.Dtos;

namespace Maya.Project.Trades.Bases.Interfaces
{
    public interface ICoinAppService:IApplicationService
    {
        Task<PagedResultDto<CoinDto>> GetCoins(CoinRequestDto request);
        Task<List<CoinDto>> GetCoinsForCombo();
    }
}
