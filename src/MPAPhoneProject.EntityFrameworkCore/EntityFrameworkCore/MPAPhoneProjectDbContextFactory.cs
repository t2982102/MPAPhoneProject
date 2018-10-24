using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MPAPhoneProject.Configuration;
using MPAPhoneProject.Web;

namespace MPAPhoneProject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MPAPhoneProjectDbContextFactory : IDesignTimeDbContextFactory<MPAPhoneProjectDbContext>
    {
        public MPAPhoneProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MPAPhoneProjectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MPAPhoneProjectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MPAPhoneProjectConsts.ConnectionStringName));

            return new MPAPhoneProjectDbContext(builder.Options);
        }
    }
}
