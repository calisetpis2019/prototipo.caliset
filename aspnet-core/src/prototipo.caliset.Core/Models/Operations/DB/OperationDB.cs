using System;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;

namespace prototipo.caliset.Models.Operations
{
    [Table("Operations")]
    public class OperationDB : FullAuditedEntity<long>
    {
        protected OperationDB() { }

        [DataType(DataType.Date)]
        [Required]
        public DateTime Date { get; set; }

        public string Commodity { get; set; }
        public string Destiny { get; set; }

    }
}