using System;
using System.Collections.Generic;

namespace CoditasPortal.Models
{
    public partial class UserBiometric
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }

        public virtual User IdNavigation { get; set; }
    }
}
