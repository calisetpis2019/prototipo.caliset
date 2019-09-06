using System;
using System.Collections.Generic;
using System.Text;

namespace prototipo.caliset.Operations.Dto
{
    public class UpdateOperationInput
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public string Commodity { get; set; }
        public string Destiny { get; set; }
    }
}
