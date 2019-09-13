using System;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;
using prototipo.caliset.Models.Clients;
using System.Collections.Generic;
using prototipo.caliset.Models.Comments;

namespace prototipo.caliset.Models.Operations
{
    [Table("Operations")]
    public class Operation : FullAuditedEntity
    {
        protected Operation() { }

        [DataType(DataType.Date)]
        [Required]
        public DateTime Date { get; set; }
        public string Commodity { get; set; }
        public string Destiny { get; set; }
        [Required]
        public  Client Client { get; set; }
        public  IEnumerable<Comment> Comments { get; set; }

    }
}