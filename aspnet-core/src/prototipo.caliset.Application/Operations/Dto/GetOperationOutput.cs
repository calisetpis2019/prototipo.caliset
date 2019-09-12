using prototipo.caliset.Clients.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace prototipo.caliset.Operations.Dto
{
    public class GetOperationOutput
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Commodity { get; set; }
        public string Destiny { get; set; }
        public int ClientId { get; set; }
    }
}
