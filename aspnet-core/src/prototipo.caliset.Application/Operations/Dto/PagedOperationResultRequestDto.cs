using Abp.Application.Services.Dto;
using System;

namespace prototipo.caliset.Operations.Dto
{
    //custom PagedResultRequestDto
    public class PagedOperationResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}
