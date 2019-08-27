using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using prototipo.caliset.Configuration;
using prototipo.caliset.Web;

namespace prototipo.caliset.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class calisetDbContextFactory : IDesignTimeDbContextFactory<calisetDbContext>
    {
        public calisetDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<calisetDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            calisetDbContextConfigurer.Configure(builder, configuration.GetConnectionString(calisetConsts.ConnectionStringName));

            return new calisetDbContext(builder.Options);
        }
    }
}
