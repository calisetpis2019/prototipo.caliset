using System.Threading.Tasks;
using Abp.Application.Services;
using prototipo.caliset.Sessions.Dto;

namespace prototipo.caliset.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
