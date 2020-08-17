﻿using Abp.Application.Services.Dto;

namespace Maya.Project.DynamicEntityParameters.Dto
{
    public class EntityDynamicParameterDto : EntityDto
    {
        public string EntityFullName { get; set; }

        public string DynamicParameterName { get; set; }

        public int DynamicParameterId { get; set; }

        public int? TenantId { get; set; }
    }
}
