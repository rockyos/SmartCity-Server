using System;
using System.Collections.Generic;

namespace SmartCity.Data.Models
{
    public class PollingPlace
        : BaseEntity 
    {
        public Guid VotingPlaceId { get; set; }

        public virtual ICollection<AppUser> Users { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
    }
}