using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using sep2020.EntityFramework;

namespace sep2020.Migrator
{
    [DependsOn(typeof(sep2020DataModule))]
    public class sep2020MigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<sep2020DbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}