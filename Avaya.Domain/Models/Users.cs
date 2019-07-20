using System;
using System.Collections.Generic;

namespace Avaya.Domain.Models
{
    public partial class Users
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Email { get; set; }
        public string ImgUrl { get; set; }
        public string Address { get; set; }
    }
}
