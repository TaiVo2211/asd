using System;
using System.Collections.Generic;

namespace Avaya.Domain.Models
{
    public partial class ProductDetails
    {
        public int Id { get; set; }
        public int? BrandId { get; set; }
        public string Name { get; set; }
        public int? Amount { get; set; }
        public decimal? Price { get; set; }
        public string Detail { get; set; }
        public int? UserCreate { get; set; }
        public DateTimeOffset? DateCreate { get; set; }
        public int? UserModified { get; set; }
        public DateTimeOffset? DateModified { get; set; }
        public int? IsActive { get; set; }
        public string ImgName { get; set; }
    }
}
