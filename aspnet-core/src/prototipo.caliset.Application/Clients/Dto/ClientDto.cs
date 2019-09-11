using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using prototipo.caliset.Models.Clients;
using System;
using System.Collections.Generic;
using System.Text;

namespace prototipo.caliset.Clients.Dto
{
    [AutoMapFrom(typeof(Client))]
    public class ClientDto : EntityDto<long>
    {
        public string Name { get; set; }
    }
}
