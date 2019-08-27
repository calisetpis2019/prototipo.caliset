using Abp.Application.Services;
using Abp.Application.Services.Dto;
using prototipo.caliset.MultiTenancy.Dto;

namespace prototipo.caliset.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

