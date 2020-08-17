using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Maya.Project
{
    public class ProjectCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProjectCoreSharedModule).GetAssembly());
        }
    }
}