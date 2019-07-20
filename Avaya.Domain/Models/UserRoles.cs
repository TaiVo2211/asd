using System;
using System.Collections.Generic;

namespace Avaya.Domain.Models
{
    public partial class UserRoles
    {
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public int? UserId { get; set; }
    }
}
