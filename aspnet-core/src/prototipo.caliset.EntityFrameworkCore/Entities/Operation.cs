using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace prototipo.caliset.EntityFrameworkCore.Entities
{
    public class Operation
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime Date { get; set; }

        public string Commodity { get; set; }
        public string Destiny { get; set; }
    }
}