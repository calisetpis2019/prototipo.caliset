using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using prototipo.caliset.Roles.Dto;
using prototipo.caliset.Users.Dto;

namespace prototipo.caliset.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
