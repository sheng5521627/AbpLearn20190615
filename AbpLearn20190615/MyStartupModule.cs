using System.Reflection;
using Abp.Auditing;
using Abp.Dependency;
using Abp.Modules;
using Abp.Runtime.Session;

namespace AbpLearn20190615
{
    public class MyStartupModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;
            IocManager.Register<IAuditingStore,MyAuditingStore>(DependencyLifeStyle.Singleton);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }

        public override void PostInitialize()
        {
        }

        public override void Shutdown()
        {
        }
    }
}
