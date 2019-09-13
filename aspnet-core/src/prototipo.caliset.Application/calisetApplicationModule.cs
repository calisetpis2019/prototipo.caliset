using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using prototipo.caliset.Authorization;
using prototipo.caliset.Clients.Dto;
using prototipo.caliset.Comments.Dto;
using prototipo.caliset.Models.Clients;
using prototipo.caliset.Models.Comments;
using prototipo.caliset.Models.Operations;
using prototipo.caliset.Operations.Dto;

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
            Configuration.Modules.AbpAutoMapper().Configurators.Add(mapper =>
            {
                mapper.CreateMap<CreateOperationInput, Operation>().ReverseMap();
                mapper.CreateMap<GetOperationInput, Operation>().ReverseMap();
                mapper.CreateMap<GetOperationOutput, Operation>().ReverseMap();
                mapper.CreateMap<UpdateOperationInput, Operation>().ReverseMap();

                mapper.CreateMap<GetCommentOutput, Comment>().ReverseMap();
                mapper.CreateMap<GetCommentInput, Comment>().ReverseMap();

                mapper.CreateMap<CreateClientInput, Client>().ReverseMap();
                mapper.CreateMap<GetClientInput, Client>().ReverseMap();
                mapper.CreateMap<GetClientOutput, Client>().ReverseMap();
                mapper.CreateMap<ClientDto, Client>().ReverseMap();
                mapper.CreateMap<UpdateClientInput, Client>().ReverseMap();
            });

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
