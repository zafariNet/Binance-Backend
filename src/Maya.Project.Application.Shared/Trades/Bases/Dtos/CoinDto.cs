using Abp.Application.Services.Dto;
using Maya.Project.Dto;

namespace Maya.Project.Trades.Bases.Dtos
{
    public class CoinDto:EntityDto<int>
    {
        public string Name { get; protected set; }
        public string Symbol { get; protected set; }
        public bool IsActive { get; protected set; }
    }

    public class CoinRequestDto : PagedAndSortedInputDto
    {
        public string Name { get; protected set; }
        public string Symbol { get; protected set; }
        public bool IsActive { get; protected set; }
    }
}
