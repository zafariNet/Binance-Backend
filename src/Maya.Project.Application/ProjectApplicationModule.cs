using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Maya.Project.Authorization;

namespace Maya.Project
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(ProjectApplicationSharedModule),
        typeof(ProjectCoreModule)
        )]
    public class ProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProjectApplicationModule).GetAssembly());
        }
    }
}