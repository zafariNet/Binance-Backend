using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Maya.Project.Startup
{
    [DependsOn(typeof(ProjectCoreModule))]
    public class ProjectGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProjectGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}