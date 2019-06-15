using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Auditing;
using Abp.Json;

namespace AbpLearn20190615
{
    public class MyAuditingStore : IAuditingStore
    {
        public Task SaveAsync(AuditInfo auditInfo)
        {
            Console.WriteLine(auditInfo.ToJsonString());
            return Task.CompletedTask;
        }
    }
}
