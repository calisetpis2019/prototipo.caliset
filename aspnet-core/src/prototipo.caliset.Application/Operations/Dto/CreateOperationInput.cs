using System;
using System.Collections.Generic;
using System.Text;

namespace prototipo.caliset.Operations.Dto
{
    public class CreateOperationInput
    {
        public DateTime Date { get; set; }

        public string Commodity { get; set; }
        public string Destiny { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
