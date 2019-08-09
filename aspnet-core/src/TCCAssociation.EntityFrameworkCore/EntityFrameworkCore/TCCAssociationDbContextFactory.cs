using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using TCCAssociation.Configuration;
using TCCAssociation.Web;

namespace TCCAssociation.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class TCCAssociationDbContextFactory : IDesignTimeDbContextFactory<TCCAssociationDbContext>
    {
        public TCCAssociationDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TCCAssociationDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            TCCAssociationDbContextConfigurer.Configure(builder, configuration.GetConnectionString(TCCAssociationConsts.ConnectionStringName));

            return new TCCAssociationDbContext(builder.Options);
        }
    }
}
