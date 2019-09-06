using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using prototipo.caliset.Models.Operations;

namespace prototipo.caliset.Operations.Dto
{
    [AutoMapFrom(typeof(Operation))]
    public class OperationDto : EntityDto<long>
    {
        [Required]
        public DateTime Date { get; set; }

        public string Commodity { get; set; }

        public string Destiny { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
