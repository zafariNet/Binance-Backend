using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.Linq.Extensions;
using AutoMapper;
using Maya.Project.Trades.Bases.Dtos;
using Maya.Project.Trades.Bases.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Maya.Project.Trades.Bases.Services
{
    public class CoinAppService: ProjectAppServiceBase, ICoinAppService
    {
        private readonly IRepository<Coin> _coinRepository;

        public CoinAppService(IRepository<Coin> coinRepository)
        {
            _coinRepository = coinRepository;
        }

        public async Task<PagedResultDto<CoinDto>> GetCoins(CoinRequestDto request)
        {
            var query = CreateCoinQuer(request);

            var count = await query.CountAsync();
            var list=  query
                        .OrderBy(request.Sorting)
                        .PageBy(request)
                        .ToListAsync();

            var result = ObjectMapper.Map<List<CoinDto>>(query);
      
            return new  PagedResultDto<CoinDto>(
                count,
                result
            );

        }

        public async Task<List<CoinDto>> GetCoinsForCombo()
        {
            var query =await _coinRepository.GetAllListAsync();
            var result = ObjectMapper.Map<List<CoinDto>>(query);

            return result;
        }

        #region Private Members

        private IQueryable<Coin> CreateCoinQuer(CoinRequestDto request)
        {
            var query = _coinRepository.GetAll()
                .WhereIf(request.Name.IsNullOrEmpty(), c => c.Name.Contains(request.Name))
                .WhereIf(request.Symbol.IsNullOrEmpty(), x => x.Symbol == request.Symbol)
                .WhereIf(request.IsActive, x => x.IsActive);
            return query;
        }
        #endregion
    }
}
