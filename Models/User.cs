using System;
using System.Collections.Generic;

namespace CoditasPortal.Models
{
    public partial class User
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public int LockOutStatus { get; set; }

        public virtual UserBiometric UserBiometric { get; set; }
    }
}
