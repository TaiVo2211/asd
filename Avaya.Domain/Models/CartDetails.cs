using System;
using System.Collections.Generic;

namespace Avaya.Domain.Models
{
    public partial class CartDetails
    {
        public int Id { get; set; }
        public int? CartId { get; set; }
        public int? ProductDetailsId { get; set; }
        public int? Amount { get; set; }
        public int? IsActive { get; set; }
    }
}
