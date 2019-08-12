using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TCCAssociation.Authorization.Roles;
using TCCAssociation.Authorization.Users;
using TCCAssociation.MultiTenancy;
using TCCAssociation.Models;

namespace TCCAssociation.EntityFrameworkCore
{
    public class TCCAssociationDbContext : AbpZeroDbContext<Tenant, Role, User, TCCAssociationDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Association> Associations { get; set; }
        
        public TCCAssociationDbContext(DbContextOptions<TCCAssociationDbContext> options)
            : base(options)
        {
        }
    }
}
