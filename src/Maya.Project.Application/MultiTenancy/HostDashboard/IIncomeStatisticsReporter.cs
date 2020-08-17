﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Maya.Project.MultiTenancy.HostDashboard.Dto;

namespace Maya.Project.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}