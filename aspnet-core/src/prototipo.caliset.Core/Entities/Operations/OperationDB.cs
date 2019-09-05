using System;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Operations
{
    [Table("Operations")]
    public class OperationDB : FullAuditedEntity
    {
        protected OperationDB() { }
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime Date { get; set; }

        public string Commodity { get; set; }
        public string Destiny { get; set; }

    }
}