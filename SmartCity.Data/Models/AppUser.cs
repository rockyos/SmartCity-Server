using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SmartCity.Data.Models
{
    public class AppUser
        : BaseEntity 
    {
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        
        public Guid PollingPlaceId { get; set; }
        public virtual PollingPlace PollingPlace { get; set; }

        public ICollection<IssueUser> IssueUser { get; set; }
    }
}