using System;
using Abp;
using Abp.Auditing;

namespace AbpLearn20190615
{
    class Program
    {
        static void Main(string[] args)
        {
            var bootstrapper = AbpBootstrapper.Create<MyStartupModule>(options =>
            {
                
            });
            bootstrapper.Initialize();
            var iocManager = bootstrapper.IocManager;
            var auditingTest = iocManager.Resolve<IAuditingTest>();
            auditingTest.Auditing();

            Console.WriteLine(iocManager.IsRegistered<IAuditingConfiguration>());
            Console.ReadLine();
        }
    }
}
