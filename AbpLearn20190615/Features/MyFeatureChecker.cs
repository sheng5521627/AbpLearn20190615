using System.Threading.Tasks;
using Abp.Application.Features;

namespace AbpLearn20190615.Features
{
    public class MyFeatureChecker : IFeatureChecker
    {
        private readonly IFeatureManager _featureManager;

        public MyFeatureChecker(IFeatureManager featureManager)
        {
            _featureManager = featureManager;
        }

        public Task<string> GetValueAsync(string name)
        {
           var feature = _featureManager.Get(name);
           return Task.FromResult(feature?.DefaultValue);
        }

        public Task<string> GetValueAsync(int tenantId, string name)
        {
            var feature = _featureManager.Get(name);
            return Task.FromResult(feature?.DefaultValue);
        }

        public Task<bool> IsEnabledAsync(string featureName)
        {
            return Task.FromResult(true);
        }

        public Task<bool> IsEnabledAsync(int tenantId, string featureName)
        {
            return Task.FromResult(true);
        }
    }
}
