using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Maya.Project.Editions.Dto;

namespace Maya.Project.MultiTenancy.Dto
{
    public class GetTenantFeaturesEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}