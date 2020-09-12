using Abp.Application.Services.Dto;

namespace Maya.Project.Trades.Bases.Dtos
{
    public class IntervalDto:EntityDto<int>
    {
        public string Name { get; protected set; }
        public string Symbol { get; protected set; }
        public bool IsActive { get; protected set; }
    }
}
