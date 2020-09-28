using System.Linq;
using sep2020.EntityFramework;
using sep2020.MultiTenancy;

namespace sep2020.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly sep2020DbContext _context;

        public DefaultTenantCreator(sep2020DbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
