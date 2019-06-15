using System;
using Abp.Auditing;
using Abp.Dependency;

namespace AbpLearn20190615
{
    public interface IAuditingTest
    {
        void Auditing();
    }
    [Audited]
    public class AuditingTest : IAuditingTest, ITransientDependency
    {
        public void Auditing()
        {
            Console.WriteLine("Auditing");
        }
    }
}
