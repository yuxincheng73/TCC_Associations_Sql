using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TCCAssociation.Authorization.Roles;
using TCCAssociation.Authorization.Users;
using TCCAssociation.MultiTenancy;

namespace TCCAssociation.EntityFrameworkCore
{
    public class TCCAssociationDbContext : AbpZeroDbContext<Tenant, Role, User, TCCAssociationDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public TCCAssociationDbContext(DbContextOptions<TCCAssociationDbContext> options)
            : base(options)
        {
        }
    }
}
