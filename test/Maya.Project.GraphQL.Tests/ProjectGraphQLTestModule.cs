using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Maya.Project.Configure;
using Maya.Project.Startup;
using Maya.Project.Test.Base;

namespace Maya.Project.GraphQL.Tests
{
    [DependsOn(
        typeof(ProjectGraphQLModule),
        typeof(ProjectTestBaseModule))]
    public class ProjectGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProjectGraphQLTestModule).GetAssembly());
        }
    }
}