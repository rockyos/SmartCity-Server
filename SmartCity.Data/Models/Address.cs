using System;
using System.Collections;
using System.Collections.Generic;

namespace SmartCity.Data.Models
{
    public class Address
    : BaseEntity
    {
        public Guid PollingPlaceId { get; set; }
        public virtual PollingPlace PollingPlace { get; set; }
        
        public virtual ICollection<AppUser> Users { get; set; }
    }
}