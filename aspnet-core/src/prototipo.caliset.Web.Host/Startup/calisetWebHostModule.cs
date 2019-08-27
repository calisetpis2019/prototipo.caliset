using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using prototipo.caliset.Configuration;

namespace prototipo.caliset.Web.Host.Startup
{
    [DependsOn(
       typeof(calisetWebCoreModule))]
    public class calisetWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public calisetWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(calisetWebHostModule).GetAssembly());
        }
    }
}
