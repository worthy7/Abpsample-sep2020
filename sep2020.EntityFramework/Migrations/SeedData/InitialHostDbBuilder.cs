using sep2020.EntityFramework;
using EntityFramework.DynamicFilters;

namespace sep2020.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly sep2020DbContext _context;

        public InitialHostDbBuilder(sep2020DbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
