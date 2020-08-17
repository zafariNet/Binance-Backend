using Abp.Auditing;
using Maya.Project.Configuration.Dto;

namespace Maya.Project.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}