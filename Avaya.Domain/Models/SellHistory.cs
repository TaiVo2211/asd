using System;
using System.Collections.Generic;

namespace Avaya.Domain.Models
{
    public partial class SellHistory
    {
        public int Id { get; set; }
        public int? CartId { get; set; }
        public DateTimeOffset? Date { get; set; }
    }
}
