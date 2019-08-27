using Abp.Application.Services.Dto;

namespace prototipo.caliset.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

