using Abp.AutoMapper;
using prototipo.caliset.Clients.Dto;
using prototipo.caliset.Models.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace prototipo.caliset.Operations.Dto
{
    [AutoMapFrom(typeof(Operation))]
    public class CreateOperationInput
    {
        [Required]
        public DateTime Date { get; set; }

        public string Commodity { get; set; }
        public string Destiny { get; set; }

        public DateTime CreationTime { get; set; }

        public ClientDto Client { get; set; }
    }
}
