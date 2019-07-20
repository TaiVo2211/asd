using System;
using System.Collections.Generic;

namespace Avaya.Domain.Models
{
    public partial class Cart
    {
        public int Id { get; set; }
        public int? Status { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public DateTimeOffset? CompletedDate { get; set; }
        public int? UserId { get; set; }
    }
}
