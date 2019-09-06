using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using prototipo.caliset.Authorization;

namespace prototipo.caliset
{
    [DependsOn(
        typeof(calisetCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class calisetApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<calisetAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(calisetApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
