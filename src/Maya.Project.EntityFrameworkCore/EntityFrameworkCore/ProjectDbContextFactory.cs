using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Maya.Project.Configuration;
using Maya.Project.Web;

namespace Maya.Project.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ProjectDbContextFactory : IDesignTimeDbContextFactory<ProjectDbContext>
    {
        public ProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ProjectDbContext>();
            var configuration = AppConfigurations.Get(
                WebContentDirectoryFinder.CalculateContentRootFolder(),
                addUserSecrets: true
            );

            ProjectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ProjectConsts.ConnectionStringName));

            return new ProjectDbContext(builder.Options);
        }
    }
}