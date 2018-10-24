using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MPAPhoneProject.Authorization.Roles;
using MPAPhoneProject.Authorization.Users;
using MPAPhoneProject.MultiTenancy;

namespace MPAPhoneProject.EntityFrameworkCore
{
    public class MPAPhoneProjectDbContext : AbpZeroDbContext<Tenant, Role, User, MPAPhoneProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MPAPhoneProjectDbContext(DbContextOptions<MPAPhoneProjectDbContext> options)
            : base(options)
        {
        }
    }
}
