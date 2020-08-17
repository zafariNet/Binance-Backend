using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Maya.Project
{
    [DependsOn(typeof(ProjectCoreSharedModule))]
    public class ProjectApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProjectApplicationSharedModule).GetAssembly());
        }
    }
}