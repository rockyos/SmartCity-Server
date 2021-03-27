using System;

namespace SmartCity.Data.Models
{
    public class UserDocument
    {
        public Guid UserId { get; set; }
        public virtual AppUser User { get; set; }
        
        public Guid PollingPlaceId { get; set; }
        public virtual PollingPlace PollingPlace { get; set; }
    }
}