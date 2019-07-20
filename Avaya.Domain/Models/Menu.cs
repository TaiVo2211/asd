using System;
using System.Collections.Generic;

namespace Avaya.Domain.Models
{
    public partial class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public int? DisplayOrder { get; set; }
    }
}
